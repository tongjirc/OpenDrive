

namespace VehStatus.DefPositionOffset
{
    /// <summary>
    /// Represents schema type 'Position-LL-28B' (SEQUENCE)
    /// </summary>
    [System.Serializable]
    public partial class PositionLL28B : Oss.Asn1.BaseType
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
            PositionLL28B that = right as PositionLL28B;
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
            return "Position-LL-28B";
        }

        /// <summary>
        /// Asserts the validity of this object`s ASN.1 data.
        /// </summary>
        /// <exception cref="Oss.Asn1.Asn1InvalidDataException">Thrown if the instance contains invalid data.</exception>
        public override void Validate()
        {
            try {
                try {
                    if (this.Lon < -8192)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    if (this.Lon > 8191)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Lon", "long", "lon", "OffsetLL-B14", false); throw;
                }
                try {
                    if (this.Lat < -8192)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    if (this.Lat > 8191)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Lat", "long", "lat", "OffsetLL-B14", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "PositionLL28B", null, "Position-LL-28B", false); throw;
            }
        }

        /// <summary>
        /// Creates the deep copy of this object.
        /// </summary>
        /// <returns>A new object that is a deep copy of this instance.</returns>
        public override object Copy()
        {
            PositionLL28B obj0 = new PositionLL28B();
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
                    if (enc.BitCount(this.Lon - -8192) > 14 || this.Lon < -8192)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.Lon);
                    enc.EncodeConstrainedLongInteger((long)(this.Lon - (-8192)), 14);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Lon", "long", "lon", "OffsetLL-B14", false); throw;
                }
                try {
                    if (enc.BitCount(this.Lat - -8192) > 14 || this.Lat < -8192)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.Lat);
                    enc.EncodeConstrainedLongInteger((long)(this.Lat - (-8192)), 14);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Lat", "long", "lat", "OffsetLL-B14", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "PositionLL28B", null, "Position-LL-28B", false); throw;
            }
        }

        protected override void DecodePer(Oss.Asn1.Internal.PerDecoder dec)
        {
            try {
                try {
                    this.Lon = dec.DecodeConstrainedLongInteger(14, -8192);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Lon", "long", "lon", "OffsetLL-B14", false); throw;
                }
                try {
                    this.Lat = dec.DecodeConstrainedLongInteger(14, -8192);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Lat", "long", "lat", "OffsetLL-B14", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "PositionLL28B", null, "Position-LL-28B", false); throw;
            }
        }
    }
}
