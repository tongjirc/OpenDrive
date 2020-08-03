
namespace VehStatus.VehSafetyExt
{
    /// <summary>
    /// Represents schema type 'PathPrediction' (SEQUENCE)
    /// </summary>
    [System.Serializable]
    public partial class PathPrediction : Oss.Asn1.BaseType
    {
        /// <summary>Field 'radiusOfCurve'</summary>
        public long RadiusOfCurve { get; set; }
        /// <summary>Field 'confidence'</summary>
        public int Confidence { get; set; }

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
            PathPrediction that = right as PathPrediction;
            if (RadiusOfCurve != that.RadiusOfCurve)
                return false;
            if (Confidence != that.Confidence)
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
            hash ^= RadiusOfCurve.GetHashCode();
            hash ^= Confidence.GetHashCode();
            return hash;
        }

        /// <summary>
        /// Returns the name of the ASN.1 schema type represented by this class.
        /// </summary>
        /// <returns>the string containing the name of the ASN.1 schema type.</returns>
        public override string GetAsn1TypeName()
        {
            return "PathPrediction";
        }

        /// <summary>
        /// Asserts the validity of this object`s ASN.1 data.
        /// </summary>
        /// <exception cref="Oss.Asn1.Asn1InvalidDataException">Thrown if the instance contains invalid data.</exception>
        public override void Validate()
        {
            try {
                try {
                    if (this.RadiusOfCurve < -32767)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    if (this.RadiusOfCurve > 32767)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "RadiusOfCurve", "long", "radiusOfCurve", "RadiusOfCurvature", false); throw;
                }
                try {
                    if (this.Confidence < 0)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    if (this.Confidence > 200)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Confidence", "int", "confidence", "Confidence", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "PathPrediction", null, "PathPrediction", false); throw;
            }
        }

        /// <summary>
        /// Creates the deep copy of this object.
        /// </summary>
        /// <returns>A new object that is a deep copy of this instance.</returns>
        public override object Copy()
        {
            PathPrediction obj0 = new PathPrediction();
            {
                obj0.RadiusOfCurve = this.RadiusOfCurve;
            }
            {
                obj0.Confidence = this.Confidence;
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
                    prt.Write("radiusOfCurve ");
                    prt.Write(this.RadiusOfCurve);
                }
                {
                    prt.WriteLine(",");
                    prt.Write("confidence ");
                    prt.Write(this.Confidence);
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
                    if (enc.BitCount(this.RadiusOfCurve - -32767) > 16 || this.RadiusOfCurve < -32767)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.RadiusOfCurve);
                    enc.EncodeConstrainedLongInteger((long)(this.RadiusOfCurve - (-32767)), 16);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "RadiusOfCurve", "long", "radiusOfCurve", "RadiusOfCurvature", false); throw;
                }
                try {
                    if (enc.BitCount(this.Confidence - 0) > 8 || this.Confidence < 0)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.Confidence);
                    enc.Output.Write8BitInt((this.Confidence - (0)));
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Confidence", "int", "confidence", "Confidence", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "PathPrediction", null, "PathPrediction", false); throw;
            }
        }

        protected override void DecodePer(Oss.Asn1.Internal.PerDecoder dec)
        {
            try {
                bool extPresent0 = dec.Input.ReadBool();

                try {
                    this.RadiusOfCurve = dec.DecodeConstrainedLongInteger(16, -32767);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "RadiusOfCurve", "long", "radiusOfCurve", "RadiusOfCurvature", false); throw;
                }
                try {
                    this.Confidence = 0 + dec.Input.Read8BitInt();
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Confidence", "int", "confidence", "Confidence", false); throw;
                }
                if (extPresent0)
                {
                    int extMaskLen0 = 0;
                    byte[] extMask0 = dec.DecodeExtPreamble(out extMaskLen0);

                    dec.SkipUnknownExtensions(extMask0, extMaskLen0, 0);
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "PathPrediction", null, "PathPrediction", false); throw;
            }
        }
    }
}
