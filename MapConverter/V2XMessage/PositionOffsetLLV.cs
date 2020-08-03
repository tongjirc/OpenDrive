
namespace VehStatus.DefPositionOffset
{
    /// <summary>
    /// Represents schema type 'PositionOffsetLLV' (SEQUENCE)
    /// </summary>
    [System.Serializable]
    public partial class PositionOffsetLLV : Oss.Asn1.BaseType
    {
        /// <summary>Field 'offsetLL'</summary>
        public PositionOffsetLL OffsetLL { get; set; }
        /// <summary>Field 'offsetV'</summary>
        public VerticalOffset OffsetV { get; set; }

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="right">The object to compare with this object. </param>
        /// <returns>true if the specified object is equal to the current object; otherwise, false.</returns>
        public override bool Equals(object right)
        {
            if (right == null)
                return false;
            if (object.ReferenceEquals(this, right))
                return true;
            if (this.GetType() != right.GetType())
                return false;
            PositionOffsetLLV that = right as PositionOffsetLLV;
            if (OffsetLL != null) {
                if (!OffsetLL.Equals(that.OffsetLL))
                    return false;
            } else if (that.OffsetLL != null)
                return false;
            if (OffsetV != null) {
                if (!OffsetV.Equals(that.OffsetV))
                    return false;
            } else if (that.OffsetV != null)
                return false;
            return true;
        }

        /// <summary>
        /// Serves as a hash function for a particular type.
        /// </summary>
        /// <returns>A hash code for the current object.</returns>
        public override int GetHashCode()
        {
            int hash = GetType().GetHashCode();
            if (OffsetLL != null)
                hash ^= OffsetLL.GetHashCode();
            if (OffsetV != null)
                hash ^= OffsetV.GetHashCode();
            return hash;
        }

        /// <summary>
        /// Returns the name of the ASN.1 schema type represented by this class.
        /// </summary>
        /// <returns>the string containing the name of the ASN.1 schema type.</returns>
        public override string GetAsn1TypeName()
        {
            return "PositionOffsetLLV";
        }

        /// <summary>
        /// Asserts the validity of this object`s ASN.1 data.
        /// </summary>
        /// <exception cref="Oss.Asn1.Asn1InvalidDataException">Thrown if the instance contains invalid data.</exception>
        public override void Validate()
        {
            try {
                try {
                    if (this.OffsetLL == null)
                        throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._null_component_element);
                    this.OffsetLL.Validate();
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "OffsetLL", "PositionOffsetLL", "offsetLL", "PositionOffsetLL", false); throw;
                }
                try {
                    if (this.OffsetV != null) {
                        this.OffsetV.Validate();
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "OffsetV", "VerticalOffset", "offsetV", "VerticalOffset", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "PositionOffsetLLV", null, "PositionOffsetLLV", false); throw;
            }
        }

        /// <summary>
        /// Creates the deep copy of this object.
        /// </summary>
        /// <returns>A new object that is a deep copy of this instance.</returns>
        public override object Copy()
        {
            PositionOffsetLLV obj0 = new PositionOffsetLLV();
            {
                obj0.OffsetLL = Oss.Asn1.Internal.CopyUtil.CopyType(this.OffsetLL);
            }
            {
                obj0.OffsetV = Oss.Asn1.Internal.CopyUtil.CopyType(this.OffsetV);
            }
            return obj0;
        }

        protected override void PrintAsn1ValueNotation(Oss.Asn1.Internal.ValueNotationHelper prt)
        {
            try
            {
                prt.BeginConstructedValue();
                {
                    PositionOffsetLL data1 = this.OffsetLL;

                    prt.WriteLine();
                    prt.Write("offsetLL ");
                    if (data1 == null)
                        prt.Write("<<<NULL>>>");
                    else {
                        prt.PrintContent(data1);
                    }
                }
                {
                    VerticalOffset data1 = this.OffsetV;

                    if (data1 != null) {
                        prt.WriteLine(",");
                        prt.Write("offsetV ");
                        prt.PrintContent(data1);
                    }
                }
                prt.EndConstructedValue();
            }
            catch (System.Exception)
            {
                prt.ResetIndent();
                throw;
            }
        }

        protected override void EncodePer(Oss.Asn1.Internal.PerEncoder enc)
        {
            try {
                byte[] optMask0 = new byte[1];

                if (this.OffsetV != null)
                    optMask0[0] |= (byte)(0x80 >> 0);
                enc.Output.WriteBits(optMask0, 0, 1);
                try {
                    enc.EncodeType(this.OffsetLL);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "OffsetLL", "PositionOffsetLL", "offsetLL", "PositionOffsetLL", false); throw;
                }
                try {
                    VerticalOffset data1 = this.OffsetV;

                    if (data1 != null)
                    {
                        enc.EncodeType(data1);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "OffsetV", "VerticalOffset", "offsetV", "VerticalOffset", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "PositionOffsetLLV", null, "PositionOffsetLLV", false); throw;
            }
        }

        protected override void DecodePer(Oss.Asn1.Internal.PerDecoder dec)
        {
            try {
                byte[] optMask0 = new byte[1];

                dec.Input.ReadBits(optMask0, 1);
                try {
                    PositionOffsetLL data1 = new PositionOffsetLL();

                    dec.DecodeType(data1);
                    this.OffsetLL = data1;
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "OffsetLL", "PositionOffsetLL", "offsetLL", "PositionOffsetLL", false); throw;
                }
                if ((optMask0[0] & (0x80 >> 0)) != 0)
                {
                    try {
                        VerticalOffset data1 = new VerticalOffset();

                        dec.DecodeType(data1);
                        this.OffsetV = data1;
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "OffsetV", "VerticalOffset", "offsetV", "VerticalOffset", false); throw;
                    }
                }
                else
                {
                    this.OffsetV = null;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "PositionOffsetLLV", null, "PositionOffsetLLV", false); throw;
            }
        }
    }
}
