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
    /// <para>The information about a group. Groups is a way to manage a list of users  who
    /// need same access permission to the shared folder.</para>
    /// </summary>
    /// <seealso cref="GroupMembershipInfo" />
    /// <seealso cref="GroupSummary" />
    public class GroupInfo : Team.GroupSummary
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<GroupInfo> Encoder = new GroupInfoEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<GroupInfo> Decoder = new GroupInfoDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GroupInfo" /> class.</para>
        /// </summary>
        /// <param name="groupName">The group name</param>
        /// <param name="groupId">The group id</param>
        /// <param name="memberCount">The number of members in the group.</param>
        /// <param name="sameTeam">If the group is owned by the current user's team.</param>
        /// <param name="groupExternalId">External ID of group. This is an arbitrary ID that an
        /// admin can attach to a group.</param>
        public GroupInfo(string groupName,
                         string groupId,
                         uint memberCount,
                         bool sameTeam,
                         string groupExternalId = null)
            : base(groupName, groupId, memberCount, groupExternalId)
        {
            this.SameTeam = sameTeam;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GroupInfo" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public GroupInfo()
        {
        }

        /// <summary>
        /// <para>If the group is owned by the current user's team.</para>
        /// </summary>
        public bool SameTeam { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="GroupInfo" />.</para>
        /// </summary>
        private class GroupInfoEncoder : enc.StructEncoder<GroupInfo>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(GroupInfo value, enc.IJsonWriter writer)
            {
                WriteProperty("group_name", value.GroupName, writer, enc.StringEncoder.Instance);
                WriteProperty("group_id", value.GroupId, writer, enc.StringEncoder.Instance);
                WriteProperty("member_count", value.MemberCount, writer, enc.UInt32Encoder.Instance);
                WriteProperty("same_team", value.SameTeam, writer, enc.BooleanEncoder.Instance);
                if (value.GroupExternalId != null)
                {
                    WriteProperty("group_external_id", value.GroupExternalId, writer, enc.StringEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="GroupInfo" />.</para>
        /// </summary>
        private class GroupInfoDecoder : enc.StructDecoder<GroupInfo>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="GroupInfo" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override GroupInfo Create()
            {
                return new GroupInfo();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(GroupInfo value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "group_name":
                        value.GroupName = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "group_id":
                        value.GroupId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "member_count":
                        value.MemberCount = enc.UInt32Decoder.Instance.Decode(reader);
                        break;
                    case "same_team":
                        value.SameTeam = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    case "group_external_id":
                        value.GroupExternalId = enc.StringDecoder.Instance.Decode(reader);
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
