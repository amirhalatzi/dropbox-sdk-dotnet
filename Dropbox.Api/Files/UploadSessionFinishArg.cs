// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>The upload session finish arg object</para>
    /// </summary>
    public class UploadSessionFinishArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<UploadSessionFinishArg> Encoder = new UploadSessionFinishArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<UploadSessionFinishArg> Decoder = new UploadSessionFinishArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UploadSessionFinishArg" />
        /// class.</para>
        /// </summary>
        /// <param name="cursor">Contains the upload session ID and the offset.</param>
        /// <param name="commit">Contains the path and other optional modifiers for the
        /// commit.</param>
        public UploadSessionFinishArg(UploadSessionCursor cursor,
                                      CommitInfo commit)
        {
            if (cursor == null)
            {
                throw new sys.ArgumentNullException("cursor");
            }

            if (commit == null)
            {
                throw new sys.ArgumentNullException("commit");
            }

            this.Cursor = cursor;
            this.Commit = commit;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UploadSessionFinishArg" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public UploadSessionFinishArg()
        {
        }

        /// <summary>
        /// <para>Contains the upload session ID and the offset.</para>
        /// </summary>
        public UploadSessionCursor Cursor { get; protected set; }

        /// <summary>
        /// <para>Contains the path and other optional modifiers for the commit.</para>
        /// </summary>
        public CommitInfo Commit { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="UploadSessionFinishArg" />.</para>
        /// </summary>
        private class UploadSessionFinishArgEncoder : enc.StructEncoder<UploadSessionFinishArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(UploadSessionFinishArg value, enc.IJsonWriter writer)
            {
                WriteProperty("cursor", value.Cursor, writer, UploadSessionCursor.Encoder);
                WriteProperty("commit", value.Commit, writer, CommitInfo.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="UploadSessionFinishArg" />.</para>
        /// </summary>
        private class UploadSessionFinishArgDecoder : enc.StructDecoder<UploadSessionFinishArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="UploadSessionFinishArg"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override UploadSessionFinishArg Create()
            {
                return new UploadSessionFinishArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(UploadSessionFinishArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "cursor":
                        value.Cursor = UploadSessionCursor.Decoder.Decode(reader);
                        break;
                    case "commit":
                        value.Commit = CommitInfo.Decoder.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
