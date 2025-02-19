namespace SimpleTest
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System.Windows;

    using Dropbox.Api;
    using Dropbox.Api.Files;
    using System.Threading;

    partial class Program
    {
        // Add an ApiKey (from https://www.dropbox.com/developers/apps) here
        // private const string ApiKey = "XXXXXXXXXXXXXXX";

        private DropboxClient client;

        [STAThread]
        static int Main(string[] args)
        {
            var instance = new Program();

            var task = Task.Run((Func<Task<int>>)instance.Run);

            task.Wait();

            return task.Result;
        }

        private async Task<int> Run()
        {
            InitializeCertPinning();

            var accessToken = await this.GetAccessToken();
            if (string.IsNullOrEmpty(accessToken))
            {
                return 1;
            }

            // Specify socket level timeout which decides maximum waiting time when on bytes are
            // received by the socket.
            var httpClient = new HttpClient(new WebRequestHandler { ReadWriteTimeout = 10 * 1000 })
            {
                // Specify request level timeout which decides maximum time taht can be spent on
                // download/upload files.
                Timeout = TimeSpan.FromMinutes(20)
            };

            this.client = new DropboxClient(accessToken, userAgent: "SimpleTestApp", httpClient: httpClient);

            try
            {
                await GetCurrentAccount();

                var path = "/DotNetApi/Help";
                var list = await ListFolder(path);

                var firstFile = list.Entries.FirstOrDefault(i => i.IsFile);
                if (firstFile != null)
                {
                    await Download(path, firstFile.AsFile);
                }

                await Upload(path, "Test.txt", "This is a text file");

                await ChunkUpload(path, "Binary");
            }
            catch (HttpException e)
            {
                Console.WriteLine("Exception reported from RPC layer");
                Console.WriteLine("    Status code: {0}", e.StatusCode);
                Console.WriteLine("    Message    : {0}", e.Message);
                if (e.RequestUri != null)
                {
                    Console.WriteLine("    Request uri: {0}", e.RequestUri);
                }
            }

            return 0;
        }

        /// <summary>
        /// Initializes ssl certificate pinning.
        /// </summary>
        private void InitializeCertPinning()
        {
            ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) =>
            {
                var root = chain.ChainElements[chain.ChainElements.Count - 1];
                var publicKey = root.Certificate.GetPublicKeyString();

                return DropboxCertHelper.IsKnownRootCertPublicKey(publicKey);
            };
        }

        /// <summary>
        /// Gets the dropbox access token.
        /// <para>
        /// This fetches the access token from the applications settings, if it is not found there
        /// (or if the user chooses to reset the settings) then the UI in <see cref="LoginForm"/> is
        /// displayed to authorize the user.
        /// </para>
        /// </summary>
        /// <returns>A valid access token or null.</returns>
        private async Task<string> GetAccessToken()
        {
            Console.Write("Reset settings (Y/N) ");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Settings.Default.Reset();
            }
            Console.WriteLine();

            var accessToken = Settings.Default.AccessToken;

            if (string.IsNullOrEmpty(accessToken))
            {
                Console.WriteLine("Waiting for credentials.");
                var completion = new TaskCompletionSource<Tuple<string, string>>();

                var thread = new Thread(() =>
                    {
                        try
                        {
                            var app = new Application();
                            var login = new LoginForm(ApiKey);
                            app.Run(login);
                            if (login.Result)
                            {
                                completion.TrySetResult(Tuple.Create(login.AccessToken, login.Uid));
                            }
                            else
                            {
                                completion.TrySetCanceled();
                            }
                        }
                        catch(Exception e)
                        {
                            completion.TrySetException(e);
                        }
                    });
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();

                try
                {
                    var result = await completion.Task;
                    Console.WriteLine("and back...");

                    accessToken = result.Item1;
                    var uid = result.Item2;
                    Console.WriteLine("Uid: {0}", uid);

                    Settings.Default.AccessToken = accessToken;
                    Settings.Default.Uid = uid;

                    Settings.Default.Save();
                }
                catch (Exception e)
                {
                    e = e.InnerException ?? e;
                    Console.WriteLine("Error: {0}", e.Message);
                    return null;
                }
            }

            return accessToken;
        }

        /// <summary>
        /// Gets information about the currently authorized account.
        /// <para>
        /// This demonstrates calling a simple rpc style api from the Users namespace.
        /// </para>
        /// </summary>
        /// <returns>An asynchronous task.</returns>
        private async Task GetCurrentAccount()
        {
            var full = await this.client.Users.GetCurrentAccountAsync();

            Console.WriteLine("Account id    : {0}", full.AccountId);
            Console.WriteLine("Country       : {0}", full.Country);
            Console.WriteLine("Email         : {0}", full.Email);
            Console.WriteLine("Is paired     : {0}", full.IsPaired ? "Yes" : "No");
            Console.WriteLine("Locale        : {0}", full.Locale);
            Console.WriteLine("Name");
            Console.WriteLine("  Display  : {0}", full.Name.DisplayName);
            Console.WriteLine("  Familiar : {0}", full.Name.FamiliarName);
            Console.WriteLine("  Given    : {0}", full.Name.GivenName);
            Console.WriteLine("  Surname  : {0}", full.Name.Surname);
            Console.WriteLine("Referral link : {0}", full.ReferralLink);

            if (full.Team != null)
            {
                Console.WriteLine("Team");
                Console.WriteLine("  Id   : {0}", full.Team.Id);
                Console.WriteLine("  Name : {0}", full.Team.Name);
            }
            else
            {
                Console.WriteLine("Team - None");
            }
        }

        /// <summary>
        /// Lists the items within a folder.
        /// </summary>
        /// <remarks>This is a demonstrates calling an rpc style api in the Files namespace.</remarks>
        /// <param name="path">The path to list.</param>
        /// <returns>The result from the ListFolderAsync call.</returns>
        private async Task<ListFolderResult> ListFolder(string path)
        {
            Console.WriteLine("--- Files ---");
            var list = await this.client.Files.ListFolderAsync(path);

            // show folders then files
            foreach (var item in list.Entries.Where(i => i.IsFolder))
            {
                Console.WriteLine("D  {0}/", item.Name);
            }

            foreach (var item in list.Entries.Where(i => i.IsFile))
            {
                var file = item.AsFile;

                Console.WriteLine("F{0,8} {1}",
                    file.Size,
                    item.Name);
            }

            if (list.HasMore)
            {
                Console.WriteLine("   ...");
            }
            return list;
        }

        /// <summary>
        /// Downloads a file.
        /// </summary>
        /// <remarks>This demonstrates calling a download style api in the Files namespace.</remarks>
        /// <param name="folder">The folder path in which the file should be found.</param>
        /// <param name="file">The file to download within <paramref name="folder"/>.</param>
        /// <returns></returns>
        private async Task Download(string folder, FileMetadata file)
        {
            Console.WriteLine("Download file...");

            using (var response = await this.client.Files.DownloadAsync(folder + "/" + file.Name))
            {
                Console.WriteLine("Downloaded {0} Rev {1}", response.Response.Name, response.Response.Rev);
                Console.WriteLine("------------------------------");
                Console.WriteLine(await response.GetContentAsStringAsync());
                Console.WriteLine("------------------------------");
            }
        }

        /// <summary>
        /// Uploads given content to a file in Dropbox.
        /// </summary>
        /// <param name="folder">The folder to upload the file.</param>
        /// <param name="fileName">The name of the file.</param>
        /// <param name="fileContent">The file content.</param>
        /// <returns></returns>
        private async Task Upload(string folder, string fileName, string fileContent)
        {
            Console.WriteLine("Upload file...");

            using (var stream = new MemoryStream(System.Text.UTF8Encoding.UTF8.GetBytes(fileContent)))
            {
                var response = await this.client.Files.UploadAsync(folder + "/" + fileName, WriteMode.Overwrite.Instance, body: stream);

                Console.WriteLine("Uploaded Id {0} Rev {1}", response.Id, response.Rev);
            }
        }

        /// <summary>
        /// Uploads a big file in chunk. The is very helpful for uploading large file in slow network condition
        /// and also enable capability to track upload progerss.
        /// </summary>
        /// <param name="folder">The folder to upload the file.</param>
        /// <param name="fileName">The name of the file.</param>
        /// <returns></returns>
        private async Task ChunkUpload(string folder, string fileName)
        {
            Console.WriteLine("Chunk upload file...");
            // Chunk size is 128KB.
            const int chunkSize = 128 * 1024;

            // Create a random file of 1MB in size.
            var fileContent = new byte[1024 * 1024];        
            new Random().NextBytes(fileContent);

            using (var stream = new MemoryStream(fileContent))
            {
                int numChunks = (int)Math.Ceiling((double)stream.Length / chunkSize);

                byte[] buffer = new byte[chunkSize];
                string sessionId = null;

                for (var idx = 0; idx < numChunks; idx++)
                {
                    Console.WriteLine("Start uploading chunk {0}", idx);
                    var byteRead = stream.Read(buffer, 0, chunkSize);

                    using (MemoryStream memStream = new MemoryStream(buffer, 0, byteRead))
                    {
                        if (idx == 0)
                        {
                            var result = await this.client.Files.UploadSessionStartAsync(memStream);
                            sessionId = result.SessionId;
                        }

                        else
                        {
                            UploadSessionCursor cursor = new UploadSessionCursor(sessionId, (ulong)(chunkSize * idx));

                            if (idx == numChunks - 1)
                            {
                                await this.client.Files.UploadSessionFinishAsync(cursor, new CommitInfo(folder + "/" + fileName), memStream);
                            }

                            else
                            {
                                await this.client.Files.UploadSessionAppendAsync(cursor, memStream);
                            }
                        }
                    }
                }
            }

        }
    }
}
