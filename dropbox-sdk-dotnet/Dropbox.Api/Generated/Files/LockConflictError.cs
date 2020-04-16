// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The lock conflict error object</para>
    /// </summary>
    public class LockConflictError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<LockConflictError> Encoder = new LockConflictErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<LockConflictError> Decoder = new LockConflictErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="LockConflictError" />
        /// class.</para>
        /// </summary>
        /// <param name="lock">The lock that caused the conflict.</param>
        public LockConflictError(FileLock @lock)
        {
            if (@lock == null)
            {
                throw new sys.ArgumentNullException("@lock");
            }

            this.Lock = @lock;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="LockConflictError" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public LockConflictError()
        {
        }

        /// <summary>
        /// <para>The lock that caused the conflict.</para>
        /// </summary>
        public FileLock Lock { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="LockConflictError" />.</para>
        /// </summary>
        private class LockConflictErrorEncoder : enc.StructEncoder<LockConflictError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(LockConflictError value, enc.IJsonWriter writer)
            {
                WriteProperty("lock", value.Lock, writer, global::Dropbox.Api.Files.FileLock.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="LockConflictError" />.</para>
        /// </summary>
        private class LockConflictErrorDecoder : enc.StructDecoder<LockConflictError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="LockConflictError" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override LockConflictError Create()
            {
                return new LockConflictError();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(LockConflictError value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "lock":
                        value.Lock = global::Dropbox.Api.Files.FileLock.Decoder.Decode(reader);
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
