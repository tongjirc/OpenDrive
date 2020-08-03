

namespace VehStatus.SPATIntersectionState
{
    /// <summary>
    /// Represents schema type 'PhaseState' (SEQUENCE)
    /// </summary>
    [System.Serializable]
    public partial class PhaseState : Oss.Asn1.BaseType
    {
        /// <summary>Field 'light'</summary>
        public LightState Light { get; set; }
        /// <summary>Field 'timing'</summary>
        public TimeChangeDetails Timing { get; set; }

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
            PhaseState that = right as PhaseState;
            if (Light != that.Light)
                return false;
            if (Timing != null) {
                if (!Timing.Equals(that.Timing))
                    return false;
            } else if (that.Timing != null)
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
            hash ^= Light.GetHashCode();
            if (Timing != null)
                hash ^= Timing.GetHashCode();
            return hash;
        }

        /// <summary>
        /// Returns the name of the ASN.1 schema type represented by this class.
        /// </summary>
        /// <returns>the string containing the name of the ASN.1 schema type.</returns>
        public override string GetAsn1TypeName()
        {
            return "PhaseState";
        }

        /// <summary>
        /// Asserts the validity of this object`s ASN.1 data.
        /// </summary>
        /// <exception cref="Oss.Asn1.Asn1InvalidDataException">Thrown if the instance contains invalid data.</exception>
        public override void Validate()
        {
            try {
                try {
                    switch (this.Light)
                    {
                        case LightState.Unavailable:
                        case LightState.Dark:
                        case LightState.StopThenProceed:
                        case LightState.StopAndRemain:
                        case LightState.PreMovement:
                        case LightState.PermissiveMovementAllowed:
                        case LightState.ProtectedMovementAllowed:
                        case LightState.IntersectionClearance:
                        case LightState.CautionConflictingTraffic:
                            break;
                        default:
                            throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._not_enumerated);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Light", "LightState", "light", "LightState", false); throw;
                }
                try {
                    if (this.Timing != null) {
                        this.Timing.Validate();
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Timing", "TimeChangeDetails", "timing", "TimeChangeDetails", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "PhaseState", null, "PhaseState", false); throw;
            }
        }

        /// <summary>
        /// Creates the deep copy of this object.
        /// </summary>
        /// <returns>A new object that is a deep copy of this instance.</returns>
        public override object Copy()
        {
            PhaseState obj0 = new PhaseState();
            {
                obj0.Light = this.Light;
            }
            {
                obj0.Timing = Oss.Asn1.Internal.CopyUtil.CopyType(this.Timing);
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
                    prt.Write("light ");
                    switch (this.Light) {
                    case LightState.Unavailable:
                        prt.Write("unavailable");
                        break;
                    case LightState.Dark:
                        prt.Write("dark");
                        break;
                    case LightState.StopThenProceed:
                        prt.Write("stop-Then-Proceed");
                        break;
                    case LightState.StopAndRemain:
                        prt.Write("stop-And-Remain");
                        break;
                    case LightState.PreMovement:
                        prt.Write("pre-Movement");
                        break;
                    case LightState.PermissiveMovementAllowed:
                        prt.Write("permissive-Movement-Allowed");
                        break;
                    case LightState.ProtectedMovementAllowed:
                        prt.Write("protected-Movement-Allowed");
                        break;
                    case LightState.IntersectionClearance:
                        prt.Write("intersection-clearance");
                        break;
                    case LightState.CautionConflictingTraffic:
                        prt.Write("caution-Conflicting-Traffic");
                        break;
                    default:
                        prt.Write((int)this.Light);
                        break;
                    }
                }
                {
                    TimeChangeDetails data1 = this.Timing;

                    if (data1 != null) {
                        prt.WriteLine(",");
                        prt.Write("timing ");
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
                bool extPresent0 = false;
                byte[] optMask0 = new byte[1];

                enc.Output.WriteBool(extPresent0);
                if (this.Timing != null)
                    optMask0[0] |= (byte)(0x80 >> 0);
                enc.Output.WriteBits(optMask0, 0, 1);
                try {
                    enc.EncodeEnum((int)this.Light, _InternalMetadata.PerCodecMetaData.SortedEnum16);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Light", "LightState", "light", "LightState", false); throw;
                }
                try {
                    TimeChangeDetails data1 = this.Timing;

                    if (data1 != null)
                    {
                        enc.EncodeType(data1);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Timing", "TimeChangeDetails", "timing", "TimeChangeDetails", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "PhaseState", null, "PhaseState", false); throw;
            }
        }

        protected override void DecodePer(Oss.Asn1.Internal.PerDecoder dec)
        {
            try {
                bool extPresent0 = dec.Input.ReadBool();
                byte[] optMask0 = new byte[1];

                dec.Input.ReadBits(optMask0, 1);
                try {
                    this.Light = (LightState)dec.DecodeEnum(_InternalMetadata.PerCodecMetaData.SortedEnum16);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Light", "LightState", "light", "LightState", false); throw;
                }
                if ((optMask0[0] & (0x80 >> 0)) != 0)
                {
                    try {
                        TimeChangeDetails data1 = new TimeChangeDetails();

                        dec.DecodeType(data1);
                        this.Timing = data1;
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "Timing", "TimeChangeDetails", "timing", "TimeChangeDetails", false); throw;
                    }
                }
                else
                {
                    this.Timing = null;
                }
                if (extPresent0)
                {
                    int extMaskLen0 = 0;
                    byte[] extMask0 = dec.DecodeExtPreamble(out extMaskLen0);

                    dec.SkipUnknownExtensions(extMask0, extMaskLen0, 0);
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "PhaseState", null, "PhaseState", false); throw;
            }
        }
    }
}
