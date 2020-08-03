

namespace VehStatus.DefPositionOffset
{
    /// <summary>
    /// Represents schema type 'Position-LL-32B' (SEQUENCE)
    /// </summary>
    [System.Serializable]
    public partial class PositionLL32B : Oss.Asn1.BaseType
    {
        /// <summary>Field 'lon'</summary>
        public long Lon { get; set; }
        /// <summary>Field 'lat'</summary>
        public long Lat { get; set; }

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
            PositionLL32B that = right as PositionLL32B;
            if (Lon != that.Lon)
                return false;
            if (Lat != that.Lat)
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
            hash ^= Lon.GetHashCode();
            hash ^= Lat.GetHashCode();
            return hash;
        }

        /// <summary>
        /// Returns the name of the ASN.1 schema type represented by this class.
        /// </summary>
        /// <returns>the string containing the name of the ASN.1 schema type.</returns>
        public override string GetAsn1TypeName()
        {
            return "Position-LL-32B";
        }

        /// <summary>
        /// Asserts the validity of this object`s ASN.1 data.
        /// </summary>
        /// <exception cref="Oss.Asn1.Asn1InvalidDataException">Thrown if the instance contains invalid data.</exception>
        public override void Validate()
        {
            try {
                try {
                    if (this.Lon < -32768)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    if (this.Lon > 32767)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Lon", "long", "lon", "OffsetLL-B16", false); throw;
                }
                try {
                    if (this.Lat < -32768)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    if (this.Lat > 32767)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Lat", "long", "lat", "OffsetLL-B16", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "PositionLL32B", null, "Position-LL-32B", false); throw;
            }
        }

        /// <summary>
        /// Creates the deep copy of this object.
        /// </summary>
        /// <returns>A new object that is a deep copy of this instance.</returns>
        public override object Copy()
        {
            PositionLL32B obj0 = new PositionLL32B();
            {
                obj0.Lon = this.Lon;
            }
            {
                obj0.Lat = this.Lat;
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
                    prt.Write("lon ");
                    prt.Write(this.Lon);
                }
                {
                    prt.WriteLine(",");
                    prt.Write("lat ");
                    prt.Write(this.Lat);
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
                try {
                    if (enc.BitCount(this.Lon - -32768) > 16 || this.Lon < -32768)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.Lon);
                    enc.EncodeConstrainedLongInteger((long)(this.Lon - (-32768)), 16);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Lon", "long", "lon", "OffsetLL-B16", false); throw;
                }
                try {
                    if (enc.BitCount(this.Lat - -32768) > 16 || this.Lat < -32768)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.Lat);
                    enc.EncodeConstrainedLongInteger((long)(this.Lat - (-32768)), 16);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Lat", "long", "lat", "OffsetLL-B16", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "PositionLL32B", null, "Position-LL-32B", false); throw;
            }
        }

        protected override void DecodePer(Oss.Asn1.Internal.PerDecoder dec)
        {
            try {
                try {
                    this.Lon = dec.DecodeConstrainedLongInteger(16, -32768);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Lon", "long", "lon", "OffsetLL-B16", false); throw;
                }
                try {
                    this.Lat = dec.DecodeConstrainedLongInteger(16, -32768);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Lat", "long", "lat", "OffsetLL-B16", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "PositionLL32B", null, "Position-LL-32B", false); throw;
            }
        }
    }
}
