// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Paper
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The list users cursor error object</para>
    /// </summary>
    public class ListUsersCursorError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<ListUsersCursorError> Encoder = new ListUsersCursorErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<ListUsersCursorError> Decoder = new ListUsersCursorErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ListUsersCursorError" />
        /// class.</para>
        /// </summary>
        public ListUsersCursorError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is DocNotFound</para>
        /// </summary>
        public bool IsDocNotFound
        {
            get
            {
                return this is DocNotFound;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a DocNotFound, or <c>null</c>.</para>
        /// </summary>
        public DocNotFound AsDocNotFound
        {
            get
            {
                return this as DocNotFound;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is CursorError</para>
        /// </summary>
        public bool IsCursorError
        {
            get
            {
                return this is CursorError;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a CursorError, or <c>null</c>.</para>
        /// </summary>
        public CursorError AsCursorError
        {
            get
            {
                return this as CursorError;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is
        /// InsufficientPermissions</para>
        /// </summary>
        public bool IsInsufficientPermissions
        {
            get
            {
                return this is InsufficientPermissions;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a InsufficientPermissions, or <c>null</c>.</para>
        /// </summary>
        public InsufficientPermissions AsInsufficientPermissions
        {
            get
            {
                return this as InsufficientPermissions;
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
        /// <para>Encoder for  <see cref="ListUsersCursorError" />.</para>
        /// </summary>
        private class ListUsersCursorErrorEncoder : enc.StructEncoder<ListUsersCursorError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(ListUsersCursorError value, enc.IJsonWriter writer)
            {
                if (value is DocNotFound)
                {
                    WriteProperty(".tag", "doc_not_found", writer, enc.StringEncoder.Instance);
                    DocNotFound.Encoder.EncodeFields((DocNotFound)value, writer);
                    return;
                }
                if (value is CursorError)
                {
                    WriteProperty(".tag", "cursor_error", writer, enc.StringEncoder.Instance);
                    CursorError.Encoder.EncodeFields((CursorError)value, writer);
                    return;
                }
                if (value is InsufficientPermissions)
                {
                    WriteProperty(".tag", "insufficient_permissions", writer, enc.StringEncoder.Instance);
                    InsufficientPermissions.Encoder.EncodeFields((InsufficientPermissions)value, writer);
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
        /// <para>Decoder for  <see cref="ListUsersCursorError" />.</para>
        /// </summary>
        private class ListUsersCursorErrorDecoder : enc.UnionDecoder<ListUsersCursorError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="ListUsersCursorError" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override ListUsersCursorError Create()
            {
                return new ListUsersCursorError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override ListUsersCursorError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "doc_not_found":
                        return DocNotFound.Decoder.DecodeFields(reader);
                    case "cursor_error":
                        return CursorError.Decoder.DecodeFields(reader);
                    case "insufficient_permissions":
                        return InsufficientPermissions.Decoder.DecodeFields(reader);
                    case "other":
                        return Other.Decoder.DecodeFields(reader);
                    default:
                        throw new sys.InvalidOperationException();
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The required doc was not found.</para>
        /// </summary>
        public sealed class DocNotFound : ListUsersCursorError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<DocNotFound> Encoder = new DocNotFoundEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<DocNotFound> Decoder = new DocNotFoundDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="DocNotFound" />
            /// class.</para>
            /// </summary>
            private DocNotFound()
            {
            }

            /// <summary>
            /// <para>A singleton instance of DocNotFound</para>
            /// </summary>
            public static readonly DocNotFound Instance = new DocNotFound();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="DocNotFound" />.</para>
            /// </summary>
            private class DocNotFoundEncoder : enc.StructEncoder<DocNotFound>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(DocNotFound value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="DocNotFound" />.</para>
            /// </summary>
            private class DocNotFoundDecoder : enc.StructDecoder<DocNotFound>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="DocNotFound" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override DocNotFound Create()
                {
                    return DocNotFound.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The cursor error object</para>
        /// </summary>
        public sealed class CursorError : ListUsersCursorError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<CursorError> Encoder = new CursorErrorEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<CursorError> Decoder = new CursorErrorDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="CursorError" />
            /// class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public CursorError(PaperApiCursorError value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="CursorError" />
            /// class.</para>
            /// </summary>
            private CursorError()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public PaperApiCursorError Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="CursorError" />.</para>
            /// </summary>
            private class CursorErrorEncoder : enc.StructEncoder<CursorError>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(CursorError value, enc.IJsonWriter writer)
                {
                    WriteProperty("cursor_error", value.Value, writer, global::Dropbox.Api.Paper.PaperApiCursorError.Encoder);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="CursorError" />.</para>
            /// </summary>
            private class CursorErrorDecoder : enc.StructDecoder<CursorError>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="CursorError" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override CursorError Create()
                {
                    return new CursorError();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(CursorError value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "cursor_error":
                            value.Value = global::Dropbox.Api.Paper.PaperApiCursorError.Decoder.Decode(reader);
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
        /// <para>Your account does not have permissions to perform this action. This may be
        /// due to it only having access to Paper as files in the Dropbox filesystem. For more
        /// information, refer to the <a
        /// href="https://www.dropbox.com/lp/developers/reference/paper-migration-guide">Paper
        /// Migration Guide</a>.</para>
        /// </summary>
        public sealed class InsufficientPermissions : ListUsersCursorError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<InsufficientPermissions> Encoder = new InsufficientPermissionsEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<InsufficientPermissions> Decoder = new InsufficientPermissionsDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="InsufficientPermissions" />
            /// class.</para>
            /// </summary>
            private InsufficientPermissions()
            {
            }

            /// <summary>
            /// <para>A singleton instance of InsufficientPermissions</para>
            /// </summary>
            public static readonly InsufficientPermissions Instance = new InsufficientPermissions();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="InsufficientPermissions" />.</para>
            /// </summary>
            private class InsufficientPermissionsEncoder : enc.StructEncoder<InsufficientPermissions>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(InsufficientPermissions value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="InsufficientPermissions" />.</para>
            /// </summary>
            private class InsufficientPermissionsDecoder : enc.StructDecoder<InsufficientPermissions>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="InsufficientPermissions"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override InsufficientPermissions Create()
                {
                    return InsufficientPermissions.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : ListUsersCursorError
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
                    return Other.Instance;
                }

            }

            #endregion
        }
    }
}
