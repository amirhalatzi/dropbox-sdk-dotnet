// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Sharing
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>The add member selector error object</para>
    /// </summary>
    public class AddMemberSelectorError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<AddMemberSelectorError> Encoder = new AddMemberSelectorErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<AddMemberSelectorError> Decoder = new AddMemberSelectorErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="AddMemberSelectorError" />
        /// class.</para>
        /// </summary>
        public AddMemberSelectorError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is InvalidDropboxId</para>
        /// </summary>
        public bool IsInvalidDropboxId
        {
            get
            {
                return this is InvalidDropboxId;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a InvalidDropboxId, or <c>null</c>.</para>
        /// </summary>
        public InvalidDropboxId AsInvalidDropboxId
        {
            get
            {
                return this as InvalidDropboxId;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is InvalidEmail</para>
        /// </summary>
        public bool IsInvalidEmail
        {
            get
            {
                return this is InvalidEmail;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a InvalidEmail, or <c>null</c>.</para>
        /// </summary>
        public InvalidEmail AsInvalidEmail
        {
            get
            {
                return this as InvalidEmail;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is UnverifiedDropboxId</para>
        /// </summary>
        public bool IsUnverifiedDropboxId
        {
            get
            {
                return this is UnverifiedDropboxId;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a UnverifiedDropboxId, or <c>null</c>.</para>
        /// </summary>
        public UnverifiedDropboxId AsUnverifiedDropboxId
        {
            get
            {
                return this as UnverifiedDropboxId;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is GroupDeleted</para>
        /// </summary>
        public bool IsGroupDeleted
        {
            get
            {
                return this is GroupDeleted;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a GroupDeleted, or <c>null</c>.</para>
        /// </summary>
        public GroupDeleted AsGroupDeleted
        {
            get
            {
                return this as GroupDeleted;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is GroupNotOnTeam</para>
        /// </summary>
        public bool IsGroupNotOnTeam
        {
            get
            {
                return this is GroupNotOnTeam;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a GroupNotOnTeam, or <c>null</c>.</para>
        /// </summary>
        public GroupNotOnTeam AsGroupNotOnTeam
        {
            get
            {
                return this as GroupNotOnTeam;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="AddMemberSelectorError" />.</para>
        /// </summary>
        private class AddMemberSelectorErrorEncoder : enc.StructEncoder<AddMemberSelectorError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(AddMemberSelectorError value, enc.IJsonWriter writer)
            {
                if (value is InvalidDropboxId)
                {
                    WriteProperty(".tag", "invalid_dropbox_id", writer, enc.StringEncoder.Instance);
                    InvalidDropboxId.Encoder.EncodeFields((InvalidDropboxId)value, writer);
                    return;
                }
                if (value is InvalidEmail)
                {
                    WriteProperty(".tag", "invalid_email", writer, enc.StringEncoder.Instance);
                    InvalidEmail.Encoder.EncodeFields((InvalidEmail)value, writer);
                    return;
                }
                if (value is UnverifiedDropboxId)
                {
                    WriteProperty(".tag", "unverified_dropbox_id", writer, enc.StringEncoder.Instance);
                    UnverifiedDropboxId.Encoder.EncodeFields((UnverifiedDropboxId)value, writer);
                    return;
                }
                if (value is GroupDeleted)
                {
                    WriteProperty(".tag", "group_deleted", writer, enc.StringEncoder.Instance);
                    GroupDeleted.Encoder.EncodeFields((GroupDeleted)value, writer);
                    return;
                }
                if (value is GroupNotOnTeam)
                {
                    WriteProperty(".tag", "group_not_on_team", writer, enc.StringEncoder.Instance);
                    GroupNotOnTeam.Encoder.EncodeFields((GroupNotOnTeam)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="AddMemberSelectorError" />.</para>
        /// </summary>
        private class AddMemberSelectorErrorDecoder : enc.UnionDecoder<AddMemberSelectorError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="AddMemberSelectorError"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override AddMemberSelectorError Create()
            {
                return new AddMemberSelectorError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override AddMemberSelectorError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "invalid_dropbox_id":
                        return InvalidDropboxId.Decoder.DecodeFields(reader);
                    case "invalid_email":
                        return InvalidEmail.Decoder.DecodeFields(reader);
                    case "unverified_dropbox_id":
                        return UnverifiedDropboxId.Decoder.DecodeFields(reader);
                    case "group_deleted":
                        return GroupDeleted.Decoder.DecodeFields(reader);
                    case "group_not_on_team":
                        return GroupNotOnTeam.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The value is the ID that could not be identified.</para>
        /// </summary>
        public sealed class InvalidDropboxId : AddMemberSelectorError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<InvalidDropboxId> Encoder = new InvalidDropboxIdEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<InvalidDropboxId> Decoder = new InvalidDropboxIdDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="InvalidDropboxId" />
            /// class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public InvalidDropboxId(string value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="InvalidDropboxId" />
            /// class.</para>
            /// </summary>
            private InvalidDropboxId()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public string Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="InvalidDropboxId" />.</para>
            /// </summary>
            private class InvalidDropboxIdEncoder : enc.StructEncoder<InvalidDropboxId>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(InvalidDropboxId value, enc.IJsonWriter writer)
                {
                    WriteProperty("invalid_dropbox_id", value.Value, writer, enc.StringEncoder.Instance);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="InvalidDropboxId" />.</para>
            /// </summary>
            private class InvalidDropboxIdDecoder : enc.StructDecoder<InvalidDropboxId>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="InvalidDropboxId" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override InvalidDropboxId Create()
                {
                    return new InvalidDropboxId();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(InvalidDropboxId value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "invalid_dropbox_id":
                            value.Value = enc.StringDecoder.Instance.Decode(reader);
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The value is the e-email address that is malformed.</para>
        /// </summary>
        public sealed class InvalidEmail : AddMemberSelectorError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<InvalidEmail> Encoder = new InvalidEmailEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<InvalidEmail> Decoder = new InvalidEmailDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="InvalidEmail" />
            /// class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public InvalidEmail(string value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="InvalidEmail" />
            /// class.</para>
            /// </summary>
            private InvalidEmail()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public string Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="InvalidEmail" />.</para>
            /// </summary>
            private class InvalidEmailEncoder : enc.StructEncoder<InvalidEmail>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(InvalidEmail value, enc.IJsonWriter writer)
                {
                    WriteProperty("invalid_email", value.Value, writer, enc.StringEncoder.Instance);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="InvalidEmail" />.</para>
            /// </summary>
            private class InvalidEmailDecoder : enc.StructDecoder<InvalidEmail>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="InvalidEmail" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override InvalidEmail Create()
                {
                    return new InvalidEmail();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(InvalidEmail value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "invalid_email":
                            value.Value = enc.StringDecoder.Instance.Decode(reader);
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The value is the ID of the Dropbox user with an unverified e-mail address.
        /// Invite unverified users by e-mail address instead of by their Dropbox ID.</para>
        /// </summary>
        public sealed class UnverifiedDropboxId : AddMemberSelectorError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<UnverifiedDropboxId> Encoder = new UnverifiedDropboxIdEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<UnverifiedDropboxId> Decoder = new UnverifiedDropboxIdDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="UnverifiedDropboxId" />
            /// class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public UnverifiedDropboxId(string value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="UnverifiedDropboxId" />
            /// class.</para>
            /// </summary>
            private UnverifiedDropboxId()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public string Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="UnverifiedDropboxId" />.</para>
            /// </summary>
            private class UnverifiedDropboxIdEncoder : enc.StructEncoder<UnverifiedDropboxId>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(UnverifiedDropboxId value, enc.IJsonWriter writer)
                {
                    WriteProperty("unverified_dropbox_id", value.Value, writer, enc.StringEncoder.Instance);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="UnverifiedDropboxId" />.</para>
            /// </summary>
            private class UnverifiedDropboxIdDecoder : enc.StructDecoder<UnverifiedDropboxId>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="UnverifiedDropboxId"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override UnverifiedDropboxId Create()
                {
                    return new UnverifiedDropboxId();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(UnverifiedDropboxId value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "unverified_dropbox_id":
                            value.Value = enc.StringDecoder.Instance.Decode(reader);
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>At least one of the specified groups in <see
        /// cref="AddFolderMemberArg.Members" /> is deleted.</para>
        /// </summary>
        public sealed class GroupDeleted : AddMemberSelectorError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<GroupDeleted> Encoder = new GroupDeletedEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<GroupDeleted> Decoder = new GroupDeletedDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="GroupDeleted" />
            /// class.</para>
            /// </summary>
            private GroupDeleted()
            {
            }

            /// <summary>
            /// <para>A singleton instance of GroupDeleted</para>
            /// </summary>
            public static readonly GroupDeleted Instance = new GroupDeleted();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="GroupDeleted" />.</para>
            /// </summary>
            private class GroupDeletedEncoder : enc.StructEncoder<GroupDeleted>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(GroupDeleted value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="GroupDeleted" />.</para>
            /// </summary>
            private class GroupDeletedDecoder : enc.StructDecoder<GroupDeleted>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="GroupDeleted" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override GroupDeleted Create()
                {
                    return new GroupDeleted();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override GroupDeleted DecodeFields(enc.IJsonReader reader)
                {
                    return GroupDeleted.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>Sharing to a group that is not on the current account's team.</para>
        /// </summary>
        public sealed class GroupNotOnTeam : AddMemberSelectorError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<GroupNotOnTeam> Encoder = new GroupNotOnTeamEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<GroupNotOnTeam> Decoder = new GroupNotOnTeamDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="GroupNotOnTeam" />
            /// class.</para>
            /// </summary>
            private GroupNotOnTeam()
            {
            }

            /// <summary>
            /// <para>A singleton instance of GroupNotOnTeam</para>
            /// </summary>
            public static readonly GroupNotOnTeam Instance = new GroupNotOnTeam();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="GroupNotOnTeam" />.</para>
            /// </summary>
            private class GroupNotOnTeamEncoder : enc.StructEncoder<GroupNotOnTeam>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(GroupNotOnTeam value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="GroupNotOnTeam" />.</para>
            /// </summary>
            private class GroupNotOnTeamDecoder : enc.StructDecoder<GroupNotOnTeam>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="GroupNotOnTeam" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override GroupNotOnTeam Create()
                {
                    return new GroupNotOnTeam();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override GroupNotOnTeam DecodeFields(enc.IJsonReader reader)
                {
                    return GroupNotOnTeam.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : AddMemberSelectorError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return new Other();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override Other DecodeFields(enc.IJsonReader reader)
                {
                    return Other.Instance;
                }
            }

            #endregion
        }
    }
}
