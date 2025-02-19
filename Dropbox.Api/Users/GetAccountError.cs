// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Users
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>The get account error object</para>
    /// </summary>
    public class GetAccountError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<GetAccountError> Encoder = new GetAccountErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<GetAccountError> Decoder = new GetAccountErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GetAccountError" />
        /// class.</para>
        /// </summary>
        public GetAccountError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is NoAccount</para>
        /// </summary>
        public bool IsNoAccount
        {
            get
            {
                return this is NoAccount;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a NoAccount, or <c>null</c>.</para>
        /// </summary>
        public NoAccount AsNoAccount
        {
            get
            {
                return this as NoAccount;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Unknown</para>
        /// </summary>
        public bool IsUnknown
        {
            get
            {
                return this is Unknown;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Unknown, or <c>null</c>.</para>
        /// </summary>
        public Unknown AsUnknown
        {
            get
            {
                return this as Unknown;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="GetAccountError" />.</para>
        /// </summary>
        private class GetAccountErrorEncoder : enc.StructEncoder<GetAccountError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(GetAccountError value, enc.IJsonWriter writer)
            {
                if (value is NoAccount)
                {
                    WriteProperty(".tag", "no_account", writer, enc.StringEncoder.Instance);
                    NoAccount.Encoder.EncodeFields((NoAccount)value, writer);
                    return;
                }
                if (value is Unknown)
                {
                    WriteProperty(".tag", "unknown", writer, enc.StringEncoder.Instance);
                    Unknown.Encoder.EncodeFields((Unknown)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="GetAccountError" />.</para>
        /// </summary>
        private class GetAccountErrorDecoder : enc.UnionDecoder<GetAccountError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="GetAccountError" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override GetAccountError Create()
            {
                return new GetAccountError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override GetAccountError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "no_account":
                        return NoAccount.Decoder.DecodeFields(reader);
                    default:
                        return Unknown.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The specified <see cref="GetAccountArg.AccountId" /> does not exist.</para>
        /// </summary>
        public sealed class NoAccount : GetAccountError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<NoAccount> Encoder = new NoAccountEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<NoAccount> Decoder = new NoAccountDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="NoAccount" /> class.</para>
            /// </summary>
            private NoAccount()
            {
            }

            /// <summary>
            /// <para>A singleton instance of NoAccount</para>
            /// </summary>
            public static readonly NoAccount Instance = new NoAccount();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="NoAccount" />.</para>
            /// </summary>
            private class NoAccountEncoder : enc.StructEncoder<NoAccount>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(NoAccount value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="NoAccount" />.</para>
            /// </summary>
            private class NoAccountDecoder : enc.StructDecoder<NoAccount>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="NoAccount" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override NoAccount Create()
                {
                    return new NoAccount();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override NoAccount DecodeFields(enc.IJsonReader reader)
                {
                    return NoAccount.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The unknown object</para>
        /// </summary>
        public sealed class Unknown : GetAccountError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Unknown> Encoder = new UnknownEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Unknown> Decoder = new UnknownDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Unknown" /> class.</para>
            /// </summary>
            private Unknown()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Unknown</para>
            /// </summary>
            public static readonly Unknown Instance = new Unknown();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Unknown" />.</para>
            /// </summary>
            private class UnknownEncoder : enc.StructEncoder<Unknown>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Unknown value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Unknown" />.</para>
            /// </summary>
            private class UnknownDecoder : enc.StructDecoder<Unknown>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Unknown" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Unknown Create()
                {
                    return new Unknown();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override Unknown DecodeFields(enc.IJsonReader reader)
                {
                    return Unknown.Instance;
                }
            }

            #endregion
        }
    }
}
