/*************************************************************/
/* Copyright (C) 2020 OSS Nokalva, Inc.  All rights reserved.*/
/*************************************************************/

/* THIS FILE IS PROPRIETARY MATERIAL OF OSS NOKALVA, INC.
 * AND MAY BE USED ONLY BY DIRECT LICENSEES OF OSS NOKALVA, INC.
 * THIS FILE MAY NOT BE DISTRIBUTED.
 * THIS COPYRIGHT STATEMENT MAY NOT BE REMOVED. */

/* Generated for: tongji (Trial), License 80149Z 80149Z. */
/* Abstract syntax: VehStatus */
/* Created: Thu Jan 16 15:47:39 2020 */
/* ASN.1/C# Compiler version: 4.7 */
/* ASN.1 compiler options and file names specified:
 * -uper -root -noSampleCode -messageFormat msvc -allow universaltags
*/


namespace VehStatus.DefPosition
{
    /// <summary>
    /// Represents schema type 'Position3D' (SEQUENCE)
    /// </summary>
    [System.Serializable]
    public partial class Position3D : Oss.Asn1.BaseType
    {
        /// <summary>Field 'lat'</summary>
        public long Lat { get; set; }
        /// <summary>Field 'long'</summary>
        public long Long { get; set; }
        /// <summary>Field 'elevation'</summary>
        public long? Elevation { get; set; }

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
            Position3D that = right as Position3D;
            if (Lat != that.Lat)
                return false;
            if (Long != that.Long)
                return false;
            if (Elevation != null) {
                if (Elevation != that.Elevation)
                    return false;
            } else if (that.Elevation != null)
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
            hash ^= Lat.GetHashCode();
            hash ^= Long.GetHashCode();
            if (Elevation != null)
                hash ^= Elevation.GetHashCode();
            return hash;
        }

        /// <summary>
        /// Returns the name of the ASN.1 schema type represented by this class.
        /// </summary>
        /// <returns>the string containing the name of the ASN.1 schema type.</returns>
        public override string GetAsn1TypeName()
        {
            return "Position3D";
        }

        /// <summary>
        /// Asserts the validity of this object`s ASN.1 data.
        /// </summary>
        /// <exception cref="Oss.Asn1.Asn1InvalidDataException">Thrown if the instance contains invalid data.</exception>
        public override void Validate()
        {
            try {
                try {
                    if (this.Lat < -900000000)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    if (this.Lat > 900000001)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Lat", "long", "lat", "Latitude", false); throw;
                }
                try {
                    if (this.Long < -1799999999)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    if (this.Long > 1800000001)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Long", "long", "long", "Longitude", false); throw;
                }
                try {
                    if (this.Elevation != null) {
                        if (this.Elevation.Value < -4096)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                        if (this.Elevation.Value > 61439)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Elevation.Value", "long", "elevation", "Elevation", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "Position3D", null, "Position3D", false); throw;
            }
        }

        /// <summary>
        /// Creates the deep copy of this object.
        /// </summary>
        /// <returns>A new object that is a deep copy of this instance.</returns>
        public override object Copy()
        {
            Position3D obj0 = new Position3D();
            {
                obj0.Lat = this.Lat;
            }
            {
                obj0.Long = this.Long;
            }
            {
                obj0.Elevation = this.Elevation;
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
                    prt.Write("lat ");
                    prt.Write(this.Lat);
                }
                {
                    prt.WriteLine(",");
                    prt.Write("long ");
                    prt.Write(this.Long);
                }
                {
                    long? data1 = this.Elevation;

                    if (data1 != null) {
                        prt.WriteLine(",");
                        prt.Write("elevation ");
                        prt.Write(data1.Value);
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

                if (this.Elevation != null)
                    optMask0[0] |= (byte)(0x80 >> 0);
                enc.Output.WriteBits(optMask0, 0, 1);
                try {
                    if (enc.BitCount(this.Lat - -900000000) > 31 || this.Lat < -900000000)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.Lat);
                    enc.EncodeConstrainedLongInteger((long)(this.Lat - (-900000000)), 31);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Lat", "long", "lat", "Latitude", false); throw;
                }
                try {
                    if (enc.BitCount(this.Long - -1799999999) > 32 || this.Long < -1799999999)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.Long);
                    enc.EncodeConstrainedLongInteger((long)(this.Long - (-1799999999)), 32);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Long", "long", "long", "Longitude", false); throw;
                }
                try {
                    if (this.Elevation != null)
                    {
                        if (enc.BitCount(this.Elevation.Value - -4096) > 16 || this.Elevation.Value < -4096)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.Elevation.Value);
                        enc.EncodeConstrainedLongInteger((long)(this.Elevation.Value - (-4096)), 16);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Elevation.Value", "long", "elevation", "Elevation", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "Position3D", null, "Position3D", false); throw;
            }
        }

        protected override void DecodePer(Oss.Asn1.Internal.PerDecoder dec)
        {
            try {
                byte[] optMask0 = new byte[1];

                dec.Input.ReadBits(optMask0, 1);
                try {
                    this.Lat = dec.DecodeConstrainedLongInteger(31, -900000000);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Lat", "long", "lat", "Latitude", false); throw;
                }
                try {
                    this.Long = dec.DecodeConstrainedLongInteger(32, -1799999999);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Long", "long", "long", "Longitude", false); throw;
                }
                if ((optMask0[0] & (0x80 >> 0)) != 0)
                {
                    try {
                        this.Elevation = dec.DecodeConstrainedLongInteger(16, -4096);
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "Elevation", "long", "elevation", "Elevation", false); throw;
                    }
                }
                else
                {
                    this.Elevation = null;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "Position3D", null, "Position3D", false); throw;
            }
        }
    }
}
