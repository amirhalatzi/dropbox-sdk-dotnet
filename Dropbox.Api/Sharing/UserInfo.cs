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
    /// <para>Basic information about a user. Use <see
    /// cref="Dropbox.Api.Sharing.Routes.SharingRoutes.Users.getAccountAsync" /> and <see
    /// cref="Dropbox.Api.Sharing.Routes.SharingRoutes.Users.getAccountBatchAsync" />` to
    /// obtain more detailed information.</para>
    /// </summary>
    /// <seealso cref="UserMembershipInfo" />
    public class UserInfo
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<UserInfo> Encoder = new UserInfoEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<UserInfo> Decoder = new UserInfoDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UserInfo" /> class.</para>
        /// </summary>
        /// <param name="accountId">The account ID of the user.</param>
        /// <param name="sameTeam">If the user is in the same team as current user.</param>
        /// <param name="teamMemberId">The team member ID of the shared folder member. Only
        /// present if <paramref name="sameTeam" /> is true.</param>
        public UserInfo(string accountId,
                        bool sameTeam,
                        string teamMemberId = null)
        {
            if (accountId == null)
            {
                throw new sys.ArgumentNullException("accountId");
            }
            else if (accountId.Length < 40 || accountId.Length > 40)
            {
                throw new sys.ArgumentOutOfRangeException("accountId");
            }

            this.AccountId = accountId;
            this.SameTeam = sameTeam;
            this.TeamMemberId = teamMemberId;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UserInfo" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public UserInfo()
        {
        }

        /// <summary>
        /// <para>The account ID of the user.</para>
        /// </summary>
        public string AccountId { get; protected set; }

        /// <summary>
        /// <para>If the user is in the same team as current user.</para>
        /// </summary>
        public bool SameTeam { get; protected set; }

        /// <summary>
        /// <para>The team member ID of the shared folder member. Only present if <see
        /// cref="SameTeam" /> is true.</para>
        /// </summary>
        public string TeamMemberId { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="UserInfo" />.</para>
        /// </summary>
        private class UserInfoEncoder : enc.StructEncoder<UserInfo>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(UserInfo value, enc.IJsonWriter writer)
            {
                WriteProperty("account_id", value.AccountId, writer, enc.StringEncoder.Instance);
                WriteProperty("same_team", value.SameTeam, writer, enc.BooleanEncoder.Instance);
                if (value.TeamMemberId != null)
                {
                    WriteProperty("team_member_id", value.TeamMemberId, writer, enc.StringEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="UserInfo" />.</para>
        /// </summary>
        private class UserInfoDecoder : enc.StructDecoder<UserInfo>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="UserInfo" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override UserInfo Create()
            {
                return new UserInfo();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(UserInfo value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "account_id":
                        value.AccountId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "same_team":
                        value.SameTeam = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    case "team_member_id":
                        value.TeamMemberId = enc.StringDecoder.Instance.Decode(reader);
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
