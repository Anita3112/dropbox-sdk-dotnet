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
    /// <para>Activated a hold.</para>
    /// </summary>
    public class LegalHoldsActivateAHoldDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<LegalHoldsActivateAHoldDetails> Encoder = new LegalHoldsActivateAHoldDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<LegalHoldsActivateAHoldDetails> Decoder = new LegalHoldsActivateAHoldDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="LegalHoldsActivateAHoldDetails"
        /// /> class.</para>
        /// </summary>
        /// <param name="legalHoldId">Hold ID.</param>
        /// <param name="name">Hold name.</param>
        /// <param name="startDate">Hold start date.</param>
        /// <param name="endDate">Hold end date.</param>
        public LegalHoldsActivateAHoldDetails(string legalHoldId,
                                              string name,
                                              sys.DateTime startDate,
                                              sys.DateTime? endDate = null)
        {
            if (legalHoldId == null)
            {
                throw new sys.ArgumentNullException("legalHoldId");
            }

            if (name == null)
            {
                throw new sys.ArgumentNullException("name");
            }

            this.LegalHoldId = legalHoldId;
            this.Name = name;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="LegalHoldsActivateAHoldDetails"
        /// /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public LegalHoldsActivateAHoldDetails()
        {
        }

        /// <summary>
        /// <para>Hold ID.</para>
        /// </summary>
        public string LegalHoldId { get; protected set; }

        /// <summary>
        /// <para>Hold name.</para>
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// <para>Hold start date.</para>
        /// </summary>
        public sys.DateTime StartDate { get; protected set; }

        /// <summary>
        /// <para>Hold end date.</para>
        /// </summary>
        public sys.DateTime? EndDate { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="LegalHoldsActivateAHoldDetails" />.</para>
        /// </summary>
        private class LegalHoldsActivateAHoldDetailsEncoder : enc.StructEncoder<LegalHoldsActivateAHoldDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(LegalHoldsActivateAHoldDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("legal_hold_id", value.LegalHoldId, writer, enc.StringEncoder.Instance);
                WriteProperty("name", value.Name, writer, enc.StringEncoder.Instance);
                WriteProperty("start_date", value.StartDate, writer, enc.DateTimeEncoder.Instance);
                if (value.EndDate != null)
                {
                    WriteProperty("end_date", value.EndDate.Value, writer, enc.DateTimeEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="LegalHoldsActivateAHoldDetails" />.</para>
        /// </summary>
        private class LegalHoldsActivateAHoldDetailsDecoder : enc.StructDecoder<LegalHoldsActivateAHoldDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="LegalHoldsActivateAHoldDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override LegalHoldsActivateAHoldDetails Create()
            {
                return new LegalHoldsActivateAHoldDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(LegalHoldsActivateAHoldDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "legal_hold_id":
                        value.LegalHoldId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "name":
                        value.Name = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "start_date":
                        value.StartDate = enc.DateTimeDecoder.Instance.Decode(reader);
                        break;
                    case "end_date":
                        value.EndDate = enc.DateTimeDecoder.Instance.Decode(reader);
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
