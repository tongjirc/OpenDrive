
namespace VehStatus.MapPoint
{
    /// <summary>
    /// Represents schema type 'RoadPoint' (SEQUENCE)
    /// </summary>
    [System.Serializable]
    public partial class RoadPoint : Oss.Asn1.BaseType
    {
        /// <summary>Field 'posOffset'</summary>
        public DefPositionOffset.PositionOffsetLLV PosOffset { get; set; }

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
            RoadPoint that = right as RoadPoint;
            if (PosOffset != null) {
                if (!PosOffset.Equals(that.PosOffset))
                    return false;
            } else if (that.PosOffset != null)
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
            if (PosOffset != null)
                hash ^= PosOffset.GetHashCode();
            return hash;
        }

        /// <summary>
        /// Returns the name of the ASN.1 schema type represented by this class.
        /// </summary>
        /// <returns>the string containing the name of the ASN.1 schema type.</returns>
        public override string GetAsn1TypeName()
        {
            return "RoadPoint";
        }

        /// <summary>
        /// Asserts the validity of this object`s ASN.1 data.
        /// </summary>
        /// <exception cref="Oss.Asn1.Asn1InvalidDataException">Thrown if the instance contains invalid data.</exception>
        public override void Validate()
        {
            try {
                try {
                    if (this.PosOffset == null)
                        throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._null_component_element);
                    this.PosOffset.Validate();
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "PosOffset", "DefPositionOffset.PositionOffsetLLV", "posOffset", "PositionOffsetLLV", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "RoadPoint", null, "RoadPoint", false); throw;
            }
        }

        /// <summary>
        /// Creates the deep copy of this object.
        /// </summary>
        /// <returns>A new object that is a deep copy of this instance.</returns>
        public override object Copy()
        {
            RoadPoint obj0 = new RoadPoint();
            {
                obj0.PosOffset = Oss.Asn1.Internal.CopyUtil.CopyType(this.PosOffset);
            }
            return obj0;
        }

        protected override void PrintAsn1ValueNotation(Oss.Asn1.Internal.ValueNotationHelper prt)
        {
            try
            {
                prt.BeginConstructedValue();
                {
                    prt.WriteLine();
                    prt.Write("posOffset ");
                    if (this.PosOffset == null)
                        prt.Write("<<<NULL>>>");
                    else {
                        prt.PrintContent(this.PosOffset);
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
                bool extPresent0 = false;

                enc.Output.WriteBool(extPresent0);
                try {
                    enc.EncodeType(this.PosOffset);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "PosOffset", "DefPositionOffset.PositionOffsetLLV", "posOffset", "PositionOffsetLLV", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "RoadPoint", null, "RoadPoint", false); throw;
            }
        }

        protected override void DecodePer(Oss.Asn1.Internal.PerDecoder dec)
        {
            try {
                bool extPresent0 = dec.Input.ReadBool();

                try {
                    DefPositionOffset.PositionOffsetLLV data1 = new DefPositionOffset.PositionOffsetLLV();

                    dec.DecodeType(data1);
                    this.PosOffset = data1;
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "PosOffset", "DefPositionOffset.PositionOffsetLLV", "posOffset", "PositionOffsetLLV", false); throw;
                }
                if (extPresent0)
                {
                    int extMaskLen0 = 0;
                    byte[] extMask0 = dec.DecodeExtPreamble(out extMaskLen0);

                    dec.SkipUnknownExtensions(extMask0, extMaskLen0, 0);
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "RoadPoint", null, "RoadPoint", false); throw;
            }
        }
    }
}
