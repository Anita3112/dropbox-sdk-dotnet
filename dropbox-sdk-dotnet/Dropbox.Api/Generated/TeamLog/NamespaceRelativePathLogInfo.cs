// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Namespace relative path details.</para>
    /// </summary>
    /// <seealso cref="PathLogInfo" />
    public class NamespaceRelativePathLogInfo
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<NamespaceRelativePathLogInfo> Encoder = new NamespaceRelativePathLogInfoEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<NamespaceRelativePathLogInfo> Decoder = new NamespaceRelativePathLogInfoDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="NamespaceRelativePathLogInfo" />
        /// class.</para>
        /// </summary>
        /// <param name="nsId">Namespace ID. Might be missing due to historical data
        /// gap.</param>
        /// <param name="relativePath">A path relative to the specified namespace ID. Might be
        /// missing due to historical data gap.</param>
        /// <param name="isSharedNamespace">True if the namespace is shared. Might be missing
        /// due to historical data gap.</param>
        public NamespaceRelativePathLogInfo(string nsId = null,
                                            string relativePath = null,
                                            bool? isSharedNamespace = null)
        {
            this.NsId = nsId;
            this.RelativePath = relativePath;
            this.IsSharedNamespace = isSharedNamespace;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="NamespaceRelativePathLogInfo" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public NamespaceRelativePathLogInfo()
        {
        }

        /// <summary>
        /// <para>Namespace ID. Might be missing due to historical data gap.</para>
        /// </summary>
        public string NsId { get; protected set; }

        /// <summary>
        /// <para>A path relative to the specified namespace ID. Might be missing due to
        /// historical data gap.</para>
        /// </summary>
        public string RelativePath { get; protected set; }

        /// <summary>
        /// <para>True if the namespace is shared. Might be missing due to historical data
        /// gap.</para>
        /// </summary>
        public bool? IsSharedNamespace { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="NamespaceRelativePathLogInfo" />.</para>
        /// </summary>
        private class NamespaceRelativePathLogInfoEncoder : enc.StructEncoder<NamespaceRelativePathLogInfo>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(NamespaceRelativePathLogInfo value, enc.IJsonWriter writer)
            {
                if (value.NsId != null)
                {
                    WriteProperty("ns_id", value.NsId, writer, enc.StringEncoder.Instance);
                }
                if (value.RelativePath != null)
                {
                    WriteProperty("relative_path", value.RelativePath, writer, enc.StringEncoder.Instance);
                }
                if (value.IsSharedNamespace != null)
                {
                    WriteProperty("is_shared_namespace", value.IsSharedNamespace.Value, writer, enc.BooleanEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="NamespaceRelativePathLogInfo" />.</para>
        /// </summary>
        private class NamespaceRelativePathLogInfoDecoder : enc.StructDecoder<NamespaceRelativePathLogInfo>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="NamespaceRelativePathLogInfo"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override NamespaceRelativePathLogInfo Create()
            {
                return new NamespaceRelativePathLogInfo();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(NamespaceRelativePathLogInfo value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "ns_id":
                        value.NsId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "relative_path":
                        value.RelativePath = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "is_shared_namespace":
                        value.IsSharedNamespace = enc.BooleanDecoder.Instance.Decode(reader);
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
