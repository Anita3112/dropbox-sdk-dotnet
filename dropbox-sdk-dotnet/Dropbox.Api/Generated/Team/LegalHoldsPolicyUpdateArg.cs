// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Team
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The legal holds policy update arg object</para>
    /// </summary>
    public class LegalHoldsPolicyUpdateArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<LegalHoldsPolicyUpdateArg> Encoder = new LegalHoldsPolicyUpdateArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<LegalHoldsPolicyUpdateArg> Decoder = new LegalHoldsPolicyUpdateArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="LegalHoldsPolicyUpdateArg" />
        /// class.</para>
        /// </summary>
        /// <param name="id">The legal hold Id.</param>
        /// <param name="members">List of team members to apply the policy on.</param>
        /// <param name="name">Policy new name.</param>
        /// <param name="description">Policy new description.</param>
        public LegalHoldsPolicyUpdateArg(string id,
                                         col.IEnumerable<string> members,
                                         string name = null,
                                         string description = null)
        {
            if (id == null)
            {
                throw new sys.ArgumentNullException("id");
            }
            if (!re.Regex.IsMatch(id, @"\A(?:^pid_dbhid:.+)\z"))
            {
                throw new sys.ArgumentOutOfRangeException("id", @"Value should match pattern '\A(?:^pid_dbhid:.+)\z'");
            }

            var membersList = enc.Util.ToList(members);

            if (members == null)
            {
                throw new sys.ArgumentNullException("members");
            }

            if (name != null)
            {
                if (name.Length > 140)
                {
                    throw new sys.ArgumentOutOfRangeException("name", "Length should be at most 140");
                }
            }

            if (description != null)
            {
                if (description.Length > 501)
                {
                    throw new sys.ArgumentOutOfRangeException("description", "Length should be at most 501");
                }
            }

            this.Id = id;
            this.Members = membersList;
            this.Name = name;
            this.Description = description;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="LegalHoldsPolicyUpdateArg" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public LegalHoldsPolicyUpdateArg()
        {
        }

        /// <summary>
        /// <para>The legal hold Id.</para>
        /// </summary>
        public string Id { get; protected set; }

        /// <summary>
        /// <para>List of team members to apply the policy on.</para>
        /// </summary>
        public col.IList<string> Members { get; protected set; }

        /// <summary>
        /// <para>Policy new name.</para>
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// <para>Policy new description.</para>
        /// </summary>
        public string Description { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="LegalHoldsPolicyUpdateArg" />.</para>
        /// </summary>
        private class LegalHoldsPolicyUpdateArgEncoder : enc.StructEncoder<LegalHoldsPolicyUpdateArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(LegalHoldsPolicyUpdateArg value, enc.IJsonWriter writer)
            {
                WriteProperty("id", value.Id, writer, enc.StringEncoder.Instance);
                WriteListProperty("members", value.Members, writer, enc.StringEncoder.Instance);
                if (value.Name != null)
                {
                    WriteProperty("name", value.Name, writer, enc.StringEncoder.Instance);
                }
                if (value.Description != null)
                {
                    WriteProperty("description", value.Description, writer, enc.StringEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="LegalHoldsPolicyUpdateArg" />.</para>
        /// </summary>
        private class LegalHoldsPolicyUpdateArgDecoder : enc.StructDecoder<LegalHoldsPolicyUpdateArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="LegalHoldsPolicyUpdateArg"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override LegalHoldsPolicyUpdateArg Create()
            {
                return new LegalHoldsPolicyUpdateArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(LegalHoldsPolicyUpdateArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "id":
                        value.Id = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "members":
                        value.Members = ReadList<string>(reader, enc.StringDecoder.Instance);
                        break;
                    case "name":
                        value.Name = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "description":
                        value.Description = enc.StringDecoder.Instance.Decode(reader);
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
