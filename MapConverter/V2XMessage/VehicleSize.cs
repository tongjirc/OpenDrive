namespace VehStatus.VehSize
{
    /// <summary>
    /// Represents schema type 'VehicleSize' (SEQUENCE)
    /// </summary>
    [System.Serializable]
    public partial class VehicleSize : Oss.Asn1.BaseType
    {
        /// <summary>Field 'width'</summary>
        public int Width { get; set; }
        /// <summary>Field 'length'</summary>
        public int Length { get; set; }
        /// <summary>Field 'height'</summary>
        public int? Height { get; set; }

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
            VehicleSize that = right as VehicleSize;
            if (Width != that.Width)
                return false;
            if (Length != that.Length)
                return false;
            if (Height != null) {
                if (Height != that.Height)
                    return false;
            } else if (that.Height != null)
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
            hash ^= Width.GetHashCode();
            hash ^= Length.GetHashCode();
            if (Height != null)
                hash ^= Height.GetHashCode();
            return hash;
        }

        /// <summary>
        /// Returns the name of the ASN.1 schema type represented by this class.
        /// </summary>
        /// <returns>the string containing the name of the ASN.1 schema type.</returns>
        public override string GetAsn1TypeName()
        {
            return "VehicleSize";
        }

        /// <summary>
        /// Asserts the validity of this object`s ASN.1 data.
        /// </summary>
        /// <exception cref="Oss.Asn1.Asn1InvalidDataException">Thrown if the instance contains invalid data.</exception>
        public override void Validate()
        {
            try {
                try {
                    if (this.Width < 0)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    if (this.Width > 1023)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Width", "int", "width", "VehicleWidth", false); throw;
                }
                try {
                    if (this.Length < 0)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    if (this.Length > 4095)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Length", "int", "length", "VehicleLength", false); throw;
                }
                try {
                    if (this.Height != null) {
                        if (this.Height.Value < 0)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                        if (this.Height.Value > 127)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Height.Value", "int", "height", "VehicleHeight", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "VehicleSize", null, "VehicleSize", false); throw;
            }
        }

        /// <summary>
        /// Creates the deep copy of this object.
        /// </summary>
        /// <returns>A new object that is a deep copy of this instance.</returns>
        public override object Copy()
        {
            VehicleSize obj0 = new VehicleSize();
            {
                obj0.Width = this.Width;
            }
            {
                obj0.Length = this.Length;
            }
            {
                obj0.Height = this.Height;
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
                    prt.Write("width ");
                    prt.Write(this.Width);
                }
                {
                    prt.WriteLine(",");
                    prt.Write("length ");
                    prt.Write(this.Length);
                }
                {
                    int? data1 = this.Height;

                    if (data1 != null) {
                        prt.WriteLine(",");
                        prt.Write("height ");
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

                if (this.Height != null)
                    optMask0[0] |= (byte)(0x80 >> 0);
                enc.Output.WriteBits(optMask0, 0, 1);
                try {
                    if (enc.BitCount(this.Width - 0) > 10 || this.Width < 0)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.Width);
                    enc.EncodeConstrainedInteger((this.Width - (0)), 10);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Width", "int", "width", "VehicleWidth", false); throw;
                }
                try {
                    if (enc.BitCount(this.Length - 0) > 12 || this.Length < 0)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.Length);
                    enc.EncodeConstrainedInteger((this.Length - (0)), 12);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Length", "int", "length", "VehicleLength", false); throw;
                }
                try {
                    if (this.Height != null)
                    {
                        if (enc.BitCount(this.Height.Value - 0) > 7 || this.Height.Value < 0)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.Height.Value);
                        enc.Output.Write7BitInt((this.Height.Value - (0)));
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Height.Value", "int", "height", "VehicleHeight", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "VehicleSize", null, "VehicleSize", false); throw;
            }
        }

        protected override void DecodePer(Oss.Asn1.Internal.PerDecoder dec)
        {
            try {
                byte[] optMask0 = new byte[1];

                dec.Input.ReadBits(optMask0, 1);
                try {
                    this.Width = dec.DecodeConstrainedInteger(10, 0);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Width", "int", "width", "VehicleWidth", false); throw;
                }
                try {
                    this.Length = dec.DecodeConstrainedInteger(12, 0);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Length", "int", "length", "VehicleLength", false); throw;
                }
                if ((optMask0[0] & (0x80 >> 0)) != 0)
                {
                    try {
                        this.Height = 0 + dec.Input.Read7BitInt();
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "Height", "int", "height", "VehicleHeight", false); throw;
                    }
                }
                else
                {
                    this.Height = null;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "VehicleSize", null, "VehicleSize", false); throw;
            }
        }
    }
}
