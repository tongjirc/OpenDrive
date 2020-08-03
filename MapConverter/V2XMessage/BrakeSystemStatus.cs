

namespace VehStatus.VehBrake
{
    /// <summary>
    /// Represents schema type 'BrakeSystemStatus' (SEQUENCE)
    /// </summary>
    [System.Serializable]
    public partial class BrakeSystemStatus : Oss.Asn1.BaseType
    {
        /// <summary>Field 'brakePadel'</summary>
        public BrakePedalStatus? BrakePadel { get; set; }
        /// <summary>Field 'wheelBrakes'</summary>
        public Oss.Asn1.BitStringWithNamedBits WheelBrakes { get; set; }
        /// <summary>Field 'traction'</summary>
        public TractionControlStatus? Traction { get; set; }
        /// <summary>Field 'abs'</summary>
        public AntiLockBrakeStatus? Abs { get; set; }
        /// <summary>Field 'scs'</summary>
        public StabilityControlStatus? Scs { get; set; }
        /// <summary>Field 'brakeBoost'</summary>
        public BrakeBoostApplied? BrakeBoost { get; set; }
        /// <summary>Field 'auxBrakes'</summary>
        public AuxiliaryBrakeStatus? AuxBrakes { get; set; }

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
            BrakeSystemStatus that = right as BrakeSystemStatus;
            if (BrakePadel != null) {
                if (BrakePadel != that.BrakePadel)
                    return false;
            } else if (that.BrakePadel != null)
                return false;
            if (WheelBrakes != null) {
                if (!WheelBrakes.Equals(that.WheelBrakes))
                    return false;
            } else if (that.WheelBrakes != null)
                return false;
            if (Traction != null) {
                if (Traction != that.Traction)
                    return false;
            } else if (that.Traction != null)
                return false;
            if (Abs != null) {
                if (Abs != that.Abs)
                    return false;
            } else if (that.Abs != null)
                return false;
            if (Scs != null) {
                if (Scs != that.Scs)
                    return false;
            } else if (that.Scs != null)
                return false;
            if (BrakeBoost != null) {
                if (BrakeBoost != that.BrakeBoost)
                    return false;
            } else if (that.BrakeBoost != null)
                return false;
            if (AuxBrakes != null) {
                if (AuxBrakes != that.AuxBrakes)
                    return false;
            } else if (that.AuxBrakes != null)
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
            if (BrakePadel != null)
                hash ^= BrakePadel.GetHashCode();
            if (WheelBrakes != null)
                hash ^= WheelBrakes.GetHashCode();
            if (Traction != null)
                hash ^= Traction.GetHashCode();
            if (Abs != null)
                hash ^= Abs.GetHashCode();
            if (Scs != null)
                hash ^= Scs.GetHashCode();
            if (BrakeBoost != null)
                hash ^= BrakeBoost.GetHashCode();
            if (AuxBrakes != null)
                hash ^= AuxBrakes.GetHashCode();
            return hash;
        }

        /// <summary>
        /// Returns the name of the ASN.1 schema type represented by this class.
        /// </summary>
        /// <returns>the string containing the name of the ASN.1 schema type.</returns>
        public override string GetAsn1TypeName()
        {
            return "BrakeSystemStatus";
        }

        /// <summary>
        /// Asserts the validity of this object`s ASN.1 data.
        /// </summary>
        /// <exception cref="Oss.Asn1.Asn1InvalidDataException">Thrown if the instance contains invalid data.</exception>
        public override void Validate()
        {
            try {
                try {
                    if (this.BrakePadel != null) {
                        switch (this.BrakePadel.Value)
                        {
                            case BrakePedalStatus.Unavailable:
                            case BrakePedalStatus.Off:
                            case BrakePedalStatus.On:
                                break;
                            default:
                                throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._not_enumerated);
                        }
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "BrakePadel.Value", "BrakePedalStatus", "brakePadel", "BrakePedalStatus", false); throw;
                }
                try {
                    if (this.WheelBrakes != null) {
                        if (this.WheelBrakes.Count != 5)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "WheelBrakes", "Oss.Asn1.BitStringWithNamedBits", "wheelBrakes", "BrakeAppliedStatus", false); throw;
                }
                try {
                    if (this.Traction != null) {
                        switch (this.Traction.Value)
                        {
                            case TractionControlStatus.Unavailable:
                            case TractionControlStatus.Off:
                            case TractionControlStatus.On:
                            case TractionControlStatus.Engaged:
                                break;
                            default:
                                throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._not_enumerated);
                        }
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Traction.Value", "TractionControlStatus", "traction", "TractionControlStatus", false); throw;
                }
                try {
                    if (this.Abs != null) {
                        switch (this.Abs.Value)
                        {
                            case AntiLockBrakeStatus.Unavailable:
                            case AntiLockBrakeStatus.Off:
                            case AntiLockBrakeStatus.On:
                            case AntiLockBrakeStatus.Engaged:
                                break;
                            default:
                                throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._not_enumerated);
                        }
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Abs.Value", "AntiLockBrakeStatus", "abs", "AntiLockBrakeStatus", false); throw;
                }
                try {
                    if (this.Scs != null) {
                        switch (this.Scs.Value)
                        {
                            case StabilityControlStatus.Unavailable:
                            case StabilityControlStatus.Off:
                            case StabilityControlStatus.On:
                            case StabilityControlStatus.Engaged:
                                break;
                            default:
                                throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._not_enumerated);
                        }
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Scs.Value", "StabilityControlStatus", "scs", "StabilityControlStatus", false); throw;
                }
                try {
                    if (this.BrakeBoost != null) {
                        switch (this.BrakeBoost.Value)
                        {
                            case BrakeBoostApplied.Unavailable:
                            case BrakeBoostApplied.Off:
                            case BrakeBoostApplied.On:
                                break;
                            default:
                                throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._not_enumerated);
                        }
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "BrakeBoost.Value", "BrakeBoostApplied", "brakeBoost", "BrakeBoostApplied", false); throw;
                }
                try {
                    if (this.AuxBrakes != null) {
                        switch (this.AuxBrakes.Value)
                        {
                            case AuxiliaryBrakeStatus.Unavailable:
                            case AuxiliaryBrakeStatus.Off:
                            case AuxiliaryBrakeStatus.On:
                            case AuxiliaryBrakeStatus.Reserved:
                                break;
                            default:
                                throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._not_enumerated);
                        }
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "AuxBrakes.Value", "AuxiliaryBrakeStatus", "auxBrakes", "AuxiliaryBrakeStatus", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "BrakeSystemStatus", null, "BrakeSystemStatus", false); throw;
            }
        }

        /// <summary>
        /// Creates the deep copy of this object.
        /// </summary>
        /// <returns>A new object that is a deep copy of this instance.</returns>
        public override object Copy()
        {
            BrakeSystemStatus obj0 = new BrakeSystemStatus();
            {
                obj0.BrakePadel = this.BrakePadel;
            }
            {
                obj0.WheelBrakes = Oss.Asn1.Internal.CopyUtil.CopyBitString(this.WheelBrakes);
            }
            {
                obj0.Traction = this.Traction;
            }
            {
                obj0.Abs = this.Abs;
            }
            {
                obj0.Scs = this.Scs;
            }
            {
                obj0.BrakeBoost = this.BrakeBoost;
            }
            {
                obj0.AuxBrakes = this.AuxBrakes;
            }
            return obj0;
        }

        protected override void PrintAsn1ValueNotation(Oss.Asn1.Internal.ValueNotationHelper prt)
        {
            try
            {
                bool first0 = true;

                prt.BeginConstructedValue();
                {
                    BrakePedalStatus? data1 = this.BrakePadel;

                    if (data1 != null) {
                        prt.WriteLine();
                        first0 = false;
                        prt.Write("brakePadel ");
                        switch (data1.Value) {
                        case BrakePedalStatus.Unavailable:
                            prt.Write("unavailable");
                            break;
                        case BrakePedalStatus.Off:
                            prt.Write("off");
                            break;
                        case BrakePedalStatus.On:
                            prt.Write("on");
                            break;
                        default:
                            prt.Write((int)data1.Value);
                            break;
                        }
                    }
                }
                {
                    Oss.Asn1.BitStringWithNamedBits data1 = this.WheelBrakes;

                    if (data1 != null) {
                        prt.WriteLine(first0 ? "" : ",");
                        first0 = false;
                        prt.Write("wheelBrakes ");
                        prt.PrintBitString(data1, 
                            delegate(int index)
                            {
                                switch (index)
                                {
                                    case (int)0: return "unavailable";
                                    case (int)1: return "leftFront";
                                    case (int)2: return "leftRear";
                                    case (int)3: return "rightFront";
                                    case (int)4: return "rightRear";
                                }
                                return null;
                            }
                        );
                    }
                }
                {
                    TractionControlStatus? data1 = this.Traction;

                    if (data1 != null) {
                        prt.WriteLine(first0 ? "" : ",");
                        first0 = false;
                        prt.Write("traction ");
                        switch (data1.Value) {
                        case TractionControlStatus.Unavailable:
                            prt.Write("unavailable");
                            break;
                        case TractionControlStatus.Off:
                            prt.Write("off");
                            break;
                        case TractionControlStatus.On:
                            prt.Write("on");
                            break;
                        case TractionControlStatus.Engaged:
                            prt.Write("engaged");
                            break;
                        default:
                            prt.Write((int)data1.Value);
                            break;
                        }
                    }
                }
                {
                    AntiLockBrakeStatus? data1 = this.Abs;

                    if (data1 != null) {
                        prt.WriteLine(first0 ? "" : ",");
                        first0 = false;
                        prt.Write("abs ");
                        switch (data1.Value) {
                        case AntiLockBrakeStatus.Unavailable:
                            prt.Write("unavailable");
                            break;
                        case AntiLockBrakeStatus.Off:
                            prt.Write("off");
                            break;
                        case AntiLockBrakeStatus.On:
                            prt.Write("on");
                            break;
                        case AntiLockBrakeStatus.Engaged:
                            prt.Write("engaged");
                            break;
                        default:
                            prt.Write((int)data1.Value);
                            break;
                        }
                    }
                }
                {
                    StabilityControlStatus? data1 = this.Scs;

                    if (data1 != null) {
                        prt.WriteLine(first0 ? "" : ",");
                        first0 = false;
                        prt.Write("scs ");
                        switch (data1.Value) {
                        case StabilityControlStatus.Unavailable:
                            prt.Write("unavailable");
                            break;
                        case StabilityControlStatus.Off:
                            prt.Write("off");
                            break;
                        case StabilityControlStatus.On:
                            prt.Write("on");
                            break;
                        case StabilityControlStatus.Engaged:
                            prt.Write("engaged");
                            break;
                        default:
                            prt.Write((int)data1.Value);
                            break;
                        }
                    }
                }
                {
                    BrakeBoostApplied? data1 = this.BrakeBoost;

                    if (data1 != null) {
                        prt.WriteLine(first0 ? "" : ",");
                        first0 = false;
                        prt.Write("brakeBoost ");
                        switch (data1.Value) {
                        case BrakeBoostApplied.Unavailable:
                            prt.Write("unavailable");
                            break;
                        case BrakeBoostApplied.Off:
                            prt.Write("off");
                            break;
                        case BrakeBoostApplied.On:
                            prt.Write("on");
                            break;
                        default:
                            prt.Write((int)data1.Value);
                            break;
                        }
                    }
                }
                {
                    AuxiliaryBrakeStatus? data1 = this.AuxBrakes;

                    if (data1 != null) {
                        prt.WriteLine(first0 ? "" : ",");
                        first0 = false;
                        prt.Write("auxBrakes ");
                        switch (data1.Value) {
                        case AuxiliaryBrakeStatus.Unavailable:
                            prt.Write("unavailable");
                            break;
                        case AuxiliaryBrakeStatus.Off:
                            prt.Write("off");
                            break;
                        case AuxiliaryBrakeStatus.On:
                            prt.Write("on");
                            break;
                        case AuxiliaryBrakeStatus.Reserved:
                            prt.Write("reserved");
                            break;
                        default:
                            prt.Write((int)data1.Value);
                            break;
                        }
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

                if (this.BrakePadel != null)
                    optMask0[0] |= (byte)(0x80 >> 0);
                if (this.WheelBrakes != null)
                    optMask0[0] |= (byte)(0x80 >> 1);
                if (this.Traction != null)
                    optMask0[0] |= (byte)(0x80 >> 2);
                if (this.Abs != null)
                    optMask0[0] |= (byte)(0x80 >> 3);
                if (this.Scs != null)
                    optMask0[0] |= (byte)(0x80 >> 4);
                if (this.BrakeBoost != null)
                    optMask0[0] |= (byte)(0x80 >> 5);
                if (this.AuxBrakes != null)
                    optMask0[0] |= (byte)(0x80 >> 6);
                enc.Output.WriteBits(optMask0, 0, 7);
                try {
                    if (this.BrakePadel != null)
                    {
                        enc.EncodeEnum((int)this.BrakePadel.Value, _InternalMetadata.PerCodecMetaData.SortedEnum6);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "BrakePadel.Value", "BrakePedalStatus", "brakePadel", "BrakePedalStatus", false); throw;
                }
                try {
                    if (this.WheelBrakes != null)
                    {
                        int length1 = Oss.Asn1.Internal.MiscUtil.SearchGreaterOrEqual(_InternalMetadata.BerCodecMetaData.Ranges1, this.WheelBrakes.LastOneBitPos() + 1);
                        enc.EncodeBitStringWithNamedBits(this.WheelBrakes, length1, 5);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "WheelBrakes", "Oss.Asn1.BitStringWithNamedBits", "wheelBrakes", "BrakeAppliedStatus", false); throw;
                }
                try {
                    if (this.Traction != null)
                    {
                        enc.EncodeEnum((int)this.Traction.Value, _InternalMetadata.PerCodecMetaData.SortedEnum7);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Traction.Value", "TractionControlStatus", "traction", "TractionControlStatus", false); throw;
                }
                try {
                    if (this.Abs != null)
                    {
                        enc.EncodeEnum((int)this.Abs.Value, _InternalMetadata.PerCodecMetaData.SortedEnum8);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Abs.Value", "AntiLockBrakeStatus", "abs", "AntiLockBrakeStatus", false); throw;
                }
                try {
                    if (this.Scs != null)
                    {
                        enc.EncodeEnum((int)this.Scs.Value, _InternalMetadata.PerCodecMetaData.SortedEnum9);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Scs.Value", "StabilityControlStatus", "scs", "StabilityControlStatus", false); throw;
                }
                try {
                    if (this.BrakeBoost != null)
                    {
                        enc.EncodeEnum((int)this.BrakeBoost.Value, _InternalMetadata.PerCodecMetaData.SortedEnum10);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "BrakeBoost.Value", "BrakeBoostApplied", "brakeBoost", "BrakeBoostApplied", false); throw;
                }
                try {
                    if (this.AuxBrakes != null)
                    {
                        enc.EncodeEnum((int)this.AuxBrakes.Value, _InternalMetadata.PerCodecMetaData.SortedEnum11);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "AuxBrakes.Value", "AuxiliaryBrakeStatus", "auxBrakes", "AuxiliaryBrakeStatus", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "BrakeSystemStatus", null, "BrakeSystemStatus", false); throw;
            }
        }

        protected override void DecodePer(Oss.Asn1.Internal.PerDecoder dec)
        {
            try {
                byte[] optMask0 = new byte[1];

                dec.Input.ReadBits(optMask0, 7);
                if ((optMask0[0] & (0x80 >> 0)) != 0)
                {
                    try {
                        this.BrakePadel = (BrakePedalStatus)dec.DecodeEnum(_InternalMetadata.PerCodecMetaData.SortedEnum6);
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "BrakePadel", "BrakePedalStatus", "brakePadel", "BrakePedalStatus", false); throw;
                    }
                }
                else
                {
                    this.BrakePadel = null;
                }
                if ((optMask0[0] & (0x80 >> 1)) != 0)
                {
                    try {
                        this.WheelBrakes = dec.DecodeBitStringWithNamedBits(5, _InternalMetadata.BerCodecMetaData.Ranges1);
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "WheelBrakes", "Oss.Asn1.BitStringWithNamedBits", "wheelBrakes", "BrakeAppliedStatus", false); throw;
                    }
                }
                else
                {
                    this.WheelBrakes = null;
                }
                if ((optMask0[0] & (0x80 >> 2)) != 0)
                {
                    try {
                        this.Traction = (TractionControlStatus)dec.DecodeEnum(_InternalMetadata.PerCodecMetaData.SortedEnum7);
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "Traction", "TractionControlStatus", "traction", "TractionControlStatus", false); throw;
                    }
                }
                else
                {
                    this.Traction = null;
                }
                if ((optMask0[0] & (0x80 >> 3)) != 0)
                {
                    try {
                        this.Abs = (AntiLockBrakeStatus)dec.DecodeEnum(_InternalMetadata.PerCodecMetaData.SortedEnum8);
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "Abs", "AntiLockBrakeStatus", "abs", "AntiLockBrakeStatus", false); throw;
                    }
                }
                else
                {
                    this.Abs = null;
                }
                if ((optMask0[0] & (0x80 >> 4)) != 0)
                {
                    try {
                        this.Scs = (StabilityControlStatus)dec.DecodeEnum(_InternalMetadata.PerCodecMetaData.SortedEnum9);
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "Scs", "StabilityControlStatus", "scs", "StabilityControlStatus", false); throw;
                    }
                }
                else
                {
                    this.Scs = null;
                }
                if ((optMask0[0] & (0x80 >> 5)) != 0)
                {
                    try {
                        this.BrakeBoost = (BrakeBoostApplied)dec.DecodeEnum(_InternalMetadata.PerCodecMetaData.SortedEnum10);
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "BrakeBoost", "BrakeBoostApplied", "brakeBoost", "BrakeBoostApplied", false); throw;
                    }
                }
                else
                {
                    this.BrakeBoost = null;
                }
                if ((optMask0[0] & (0x80 >> 6)) != 0)
                {
                    try {
                        this.AuxBrakes = (AuxiliaryBrakeStatus)dec.DecodeEnum(_InternalMetadata.PerCodecMetaData.SortedEnum11);
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "AuxBrakes", "AuxiliaryBrakeStatus", "auxBrakes", "AuxiliaryBrakeStatus", false); throw;
                    }
                }
                else
                {
                    this.AuxBrakes = null;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "BrakeSystemStatus", null, "BrakeSystemStatus", false); throw;
            }
        }
    }
}
