

namespace VehStatus.VehSafetyExt
{
    /// <summary>
    /// Represents schema type 'FullPositionVector' (SEQUENCE)
    /// </summary>
    [System.Serializable]
    public partial class FullPositionVector : Oss.Asn1.BaseType
    {
        /// <summary>Field 'utcTime'</summary>
        public DefTime.DDateTime UtcTime { get; set; }
        /// <summary>Field 'pos'</summary>
        public DefPosition.Position3D Pos { get; set; }
        /// <summary>Field 'heading'</summary>
        public int? Heading { get; set; }
        /// <summary>Field 'transmission'</summary>
        public VehStatusModule.TransmissionState? Transmission { get; set; }
        /// <summary>Field 'speed'</summary>
        public int? Speed { get; set; }
        /// <summary>Field 'posAccuracy'</summary>
        public DefPosition.PositionConfidenceSet PosAccuracy { get; set; }
        /// <summary>Field 'timeConfidence'</summary>
        public DefTime.TimeConfidence? TimeConfidence { get; set; }
        /// <summary>Field 'posConfidence'</summary>
        public DefPosition.PositionConfidenceSet PosConfidence { get; set; }
        /// <summary>Field 'motionCfd'</summary>
        public DefMotion.MotionConfidenceSet MotionCfd { get; set; }

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
            FullPositionVector that = right as FullPositionVector;
            if (UtcTime != null) {
                if (!UtcTime.Equals(that.UtcTime))
                    return false;
            } else if (that.UtcTime != null)
                return false;
            if (Pos != null) {
                if (!Pos.Equals(that.Pos))
                    return false;
            } else if (that.Pos != null)
                return false;
            if (Heading != null) {
                if (Heading != that.Heading)
                    return false;
            } else if (that.Heading != null)
                return false;
            if (Transmission != null) {
                if (Transmission != that.Transmission)
                    return false;
            } else if (that.Transmission != null)
                return false;
            if (Speed != null) {
                if (Speed != that.Speed)
                    return false;
            } else if (that.Speed != null)
                return false;
            if (PosAccuracy != null) {
                if (!PosAccuracy.Equals(that.PosAccuracy))
                    return false;
            } else if (that.PosAccuracy != null)
                return false;
            if (TimeConfidence != null) {
                if (TimeConfidence != that.TimeConfidence)
                    return false;
            } else if (that.TimeConfidence != null)
                return false;
            if (PosConfidence != null) {
                if (!PosConfidence.Equals(that.PosConfidence))
                    return false;
            } else if (that.PosConfidence != null)
                return false;
            if (MotionCfd != null) {
                if (!MotionCfd.Equals(that.MotionCfd))
                    return false;
            } else if (that.MotionCfd != null)
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
            if (UtcTime != null)
                hash ^= UtcTime.GetHashCode();
            if (Pos != null)
                hash ^= Pos.GetHashCode();
            if (Heading != null)
                hash ^= Heading.GetHashCode();
            if (Transmission != null)
                hash ^= Transmission.GetHashCode();
            if (Speed != null)
                hash ^= Speed.GetHashCode();
            if (PosAccuracy != null)
                hash ^= PosAccuracy.GetHashCode();
            if (TimeConfidence != null)
                hash ^= TimeConfidence.GetHashCode();
            if (PosConfidence != null)
                hash ^= PosConfidence.GetHashCode();
            if (MotionCfd != null)
                hash ^= MotionCfd.GetHashCode();
            return hash;
        }

        /// <summary>
        /// Returns the name of the ASN.1 schema type represented by this class.
        /// </summary>
        /// <returns>the string containing the name of the ASN.1 schema type.</returns>
        public override string GetAsn1TypeName()
        {
            return "FullPositionVector";
        }

        /// <summary>
        /// Asserts the validity of this object`s ASN.1 data.
        /// </summary>
        /// <exception cref="Oss.Asn1.Asn1InvalidDataException">Thrown if the instance contains invalid data.</exception>
        public override void Validate()
        {
            try {
                try {
                    if (this.UtcTime != null) {
                        this.UtcTime.Validate();
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "UtcTime", "DefTime.DDateTime", "utcTime", "DDateTime", false); throw;
                }
                try {
                    if (this.Pos == null)
                        throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._null_component_element);
                    this.Pos.Validate();
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Pos", "DefPosition.Position3D", "pos", "Position3D", false); throw;
                }
                try {
                    if (this.Heading != null) {
                        if (this.Heading.Value < 0)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                        if (this.Heading.Value > 28800)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Heading.Value", "int", "heading", "Heading", false); throw;
                }
                try {
                    if (this.Transmission != null) {
                        switch (this.Transmission.Value)
                        {
                            case VehStatusModule.TransmissionState.Neutral:
                            case VehStatusModule.TransmissionState.Park:
                            case VehStatusModule.TransmissionState.ForwardGears:
                            case VehStatusModule.TransmissionState.ReverseGears:
                            case VehStatusModule.TransmissionState.Reserved1:
                            case VehStatusModule.TransmissionState.Reserved2:
                            case VehStatusModule.TransmissionState.Reserved3:
                            case VehStatusModule.TransmissionState.Unavailable:
                                break;
                            default:
                                throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._not_enumerated);
                        }
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Transmission.Value", "VehStatusModule.TransmissionState", "transmission", "TransmissionState", false); throw;
                }
                try {
                    if (this.Speed != null) {
                        if (this.Speed.Value < 0)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                        if (this.Speed.Value > 8191)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Speed.Value", "int", "speed", "Speed", false); throw;
                }
                try {
                    if (this.PosAccuracy != null) {
                        this.PosAccuracy.Validate();
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "PosAccuracy", "DefPosition.PositionConfidenceSet", "posAccuracy", "PositionConfidenceSet", false); throw;
                }
                try {
                    if (this.TimeConfidence != null) {
                        switch (this.TimeConfidence.Value)
                        {
                            case DefTime.TimeConfidence.Unavailable:
                            case DefTime.TimeConfidence.Time100000:
                            case DefTime.TimeConfidence.Time050000:
                            case DefTime.TimeConfidence.Time020000:
                            case DefTime.TimeConfidence.Time010000:
                            case DefTime.TimeConfidence.Time002000:
                            case DefTime.TimeConfidence.Time001000:
                            case DefTime.TimeConfidence.Time000500:
                            case DefTime.TimeConfidence.Time000200:
                            case DefTime.TimeConfidence.Time000100:
                            case DefTime.TimeConfidence.Time000050:
                            case DefTime.TimeConfidence.Time000020:
                            case DefTime.TimeConfidence.Time000010:
                            case DefTime.TimeConfidence.Time000005:
                            case DefTime.TimeConfidence.Time000002:
                            case DefTime.TimeConfidence.Time000001:
                            case DefTime.TimeConfidence.Time0000005:
                            case DefTime.TimeConfidence.Time0000002:
                            case DefTime.TimeConfidence.Time0000001:
                            case DefTime.TimeConfidence.Time00000005:
                            case DefTime.TimeConfidence.Time00000002:
                            case DefTime.TimeConfidence.Time00000001:
                            case DefTime.TimeConfidence.Time000000005:
                            case DefTime.TimeConfidence.Time000000002:
                            case DefTime.TimeConfidence.Time000000001:
                            case DefTime.TimeConfidence.Time0000000005:
                            case DefTime.TimeConfidence.Time0000000002:
                            case DefTime.TimeConfidence.Time0000000001:
                            case DefTime.TimeConfidence.Time00000000005:
                            case DefTime.TimeConfidence.Time00000000002:
                            case DefTime.TimeConfidence.Time00000000001:
                            case DefTime.TimeConfidence.Time000000000005:
                            case DefTime.TimeConfidence.Time000000000002:
                            case DefTime.TimeConfidence.Time000000000001:
                            case DefTime.TimeConfidence.Time0000000000005:
                            case DefTime.TimeConfidence.Time0000000000002:
                            case DefTime.TimeConfidence.Time0000000000001:
                            case DefTime.TimeConfidence.Time00000000000005:
                            case DefTime.TimeConfidence.Time00000000000002:
                            case DefTime.TimeConfidence.Time00000000000001:
                                break;
                            default:
                                throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._not_enumerated);
                        }
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "TimeConfidence.Value", "DefTime.TimeConfidence", "timeConfidence", "TimeConfidence", false); throw;
                }
                try {
                    if (this.PosConfidence != null) {
                        this.PosConfidence.Validate();
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "PosConfidence", "DefPosition.PositionConfidenceSet", "posConfidence", "PositionConfidenceSet", false); throw;
                }
                try {
                    if (this.MotionCfd != null) {
                        this.MotionCfd.Validate();
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "MotionCfd", "DefMotion.MotionConfidenceSet", "motionCfd", "MotionConfidenceSet", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "FullPositionVector", null, "FullPositionVector", false); throw;
            }
        }

        /// <summary>
        /// Creates the deep copy of this object.
        /// </summary>
        /// <returns>A new object that is a deep copy of this instance.</returns>
        public override object Copy()
        {
            FullPositionVector obj0 = new FullPositionVector();
            {
                obj0.UtcTime = Oss.Asn1.Internal.CopyUtil.CopyType(this.UtcTime);
            }
            {
                obj0.Pos = Oss.Asn1.Internal.CopyUtil.CopyType(this.Pos);
            }
            {
                obj0.Heading = this.Heading;
            }
            {
                obj0.Transmission = this.Transmission;
            }
            {
                obj0.Speed = this.Speed;
            }
            {
                obj0.PosAccuracy = Oss.Asn1.Internal.CopyUtil.CopyType(this.PosAccuracy);
            }
            {
                obj0.TimeConfidence = this.TimeConfidence;
            }
            {
                obj0.PosConfidence = Oss.Asn1.Internal.CopyUtil.CopyType(this.PosConfidence);
            }
            {
                obj0.MotionCfd = Oss.Asn1.Internal.CopyUtil.CopyType(this.MotionCfd);
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
                    DefTime.DDateTime data1 = this.UtcTime;

                    if (data1 != null) {
                        prt.WriteLine();
                        first0 = false;
                        prt.Write("utcTime ");
                        prt.PrintContent(data1);
                    }
                }
                {
                    prt.WriteLine(first0 ? "" : ",");
                    prt.Write("pos ");
                    if (this.Pos == null)
                        prt.Write("<<<NULL>>>");
                    else {
                        prt.PrintContent(this.Pos);
                    }
                }
                {
                    int? data1 = this.Heading;

                    if (data1 != null) {
                        prt.WriteLine(",");
                        prt.Write("heading ");
                        prt.Write(data1.Value);
                    }
                }
                {
                    VehStatusModule.TransmissionState? data1 = this.Transmission;

                    if (data1 != null) {
                        prt.WriteLine(",");
                        prt.Write("transmission ");
                        switch (data1.Value) {
                        case VehStatusModule.TransmissionState.Neutral:
                            prt.Write("neutral");
                            break;
                        case VehStatusModule.TransmissionState.Park:
                            prt.Write("park");
                            break;
                        case VehStatusModule.TransmissionState.ForwardGears:
                            prt.Write("forwardGears");
                            break;
                        case VehStatusModule.TransmissionState.ReverseGears:
                            prt.Write("reverseGears");
                            break;
                        case VehStatusModule.TransmissionState.Reserved1:
                            prt.Write("reserved1");
                            break;
                        case VehStatusModule.TransmissionState.Reserved2:
                            prt.Write("reserved2");
                            break;
                        case VehStatusModule.TransmissionState.Reserved3:
                            prt.Write("reserved3");
                            break;
                        case VehStatusModule.TransmissionState.Unavailable:
                            prt.Write("unavailable");
                            break;
                        default:
                            prt.Write((int)data1.Value);
                            break;
                        }
                    }
                }
                {
                    int? data1 = this.Speed;

                    if (data1 != null) {
                        prt.WriteLine(",");
                        prt.Write("speed ");
                        prt.Write(data1.Value);
                    }
                }
                {
                    DefPosition.PositionConfidenceSet data1 = this.PosAccuracy;

                    if (data1 != null) {
                        prt.WriteLine(",");
                        prt.Write("posAccuracy ");
                        prt.PrintContent(data1);
                    }
                }
                {
                    DefTime.TimeConfidence? data1 = this.TimeConfidence;

                    if (data1 != null) {
                        prt.WriteLine(",");
                        prt.Write("timeConfidence ");
                        switch (data1.Value) {
                        case DefTime.TimeConfidence.Unavailable:
                            prt.Write("unavailable");
                            break;
                        case DefTime.TimeConfidence.Time100000:
                            prt.Write("time-100-000");
                            break;
                        case DefTime.TimeConfidence.Time050000:
                            prt.Write("time-050-000");
                            break;
                        case DefTime.TimeConfidence.Time020000:
                            prt.Write("time-020-000");
                            break;
                        case DefTime.TimeConfidence.Time010000:
                            prt.Write("time-010-000");
                            break;
                        case DefTime.TimeConfidence.Time002000:
                            prt.Write("time-002-000");
                            break;
                        case DefTime.TimeConfidence.Time001000:
                            prt.Write("time-001-000");
                            break;
                        case DefTime.TimeConfidence.Time000500:
                            prt.Write("time-000-500");
                            break;
                        case DefTime.TimeConfidence.Time000200:
                            prt.Write("time-000-200");
                            break;
                        case DefTime.TimeConfidence.Time000100:
                            prt.Write("time-000-100");
                            break;
                        case DefTime.TimeConfidence.Time000050:
                            prt.Write("time-000-050");
                            break;
                        case DefTime.TimeConfidence.Time000020:
                            prt.Write("time-000-020");
                            break;
                        case DefTime.TimeConfidence.Time000010:
                            prt.Write("time-000-010");
                            break;
                        case DefTime.TimeConfidence.Time000005:
                            prt.Write("time-000-005");
                            break;
                        case DefTime.TimeConfidence.Time000002:
                            prt.Write("time-000-002");
                            break;
                        case DefTime.TimeConfidence.Time000001:
                            prt.Write("time-000-001");
                            break;
                        case DefTime.TimeConfidence.Time0000005:
                            prt.Write("time-000-000-5");
                            break;
                        case DefTime.TimeConfidence.Time0000002:
                            prt.Write("time-000-000-2");
                            break;
                        case DefTime.TimeConfidence.Time0000001:
                            prt.Write("time-000-000-1");
                            break;
                        case DefTime.TimeConfidence.Time00000005:
                            prt.Write("time-000-000-05");
                            break;
                        case DefTime.TimeConfidence.Time00000002:
                            prt.Write("time-000-000-02");
                            break;
                        case DefTime.TimeConfidence.Time00000001:
                            prt.Write("time-000-000-01");
                            break;
                        case DefTime.TimeConfidence.Time000000005:
                            prt.Write("time-000-000-005");
                            break;
                        case DefTime.TimeConfidence.Time000000002:
                            prt.Write("time-000-000-002");
                            break;
                        case DefTime.TimeConfidence.Time000000001:
                            prt.Write("time-000-000-001");
                            break;
                        case DefTime.TimeConfidence.Time0000000005:
                            prt.Write("time-000-000-000-5");
                            break;
                        case DefTime.TimeConfidence.Time0000000002:
                            prt.Write("time-000-000-000-2");
                            break;
                        case DefTime.TimeConfidence.Time0000000001:
                            prt.Write("time-000-000-000-1");
                            break;
                        case DefTime.TimeConfidence.Time00000000005:
                            prt.Write("time-000-000-000-05");
                            break;
                        case DefTime.TimeConfidence.Time00000000002:
                            prt.Write("time-000-000-000-02");
                            break;
                        case DefTime.TimeConfidence.Time00000000001:
                            prt.Write("time-000-000-000-01");
                            break;
                        case DefTime.TimeConfidence.Time000000000005:
                            prt.Write("time-000-000-000-005");
                            break;
                        case DefTime.TimeConfidence.Time000000000002:
                            prt.Write("time-000-000-000-002");
                            break;
                        case DefTime.TimeConfidence.Time000000000001:
                            prt.Write("time-000-000-000-001");
                            break;
                        case DefTime.TimeConfidence.Time0000000000005:
                            prt.Write("time-000-000-000-000-5");
                            break;
                        case DefTime.TimeConfidence.Time0000000000002:
                            prt.Write("time-000-000-000-000-2");
                            break;
                        case DefTime.TimeConfidence.Time0000000000001:
                            prt.Write("time-000-000-000-000-1");
                            break;
                        case DefTime.TimeConfidence.Time00000000000005:
                            prt.Write("time-000-000-000-000-05");
                            break;
                        case DefTime.TimeConfidence.Time00000000000002:
                            prt.Write("time-000-000-000-000-02");
                            break;
                        case DefTime.TimeConfidence.Time00000000000001:
                            prt.Write("time-000-000-000-000-01");
                            break;
                        default:
                            prt.Write((int)data1.Value);
                            break;
                        }
                    }
                }
                {
                    DefPosition.PositionConfidenceSet data1 = this.PosConfidence;

                    if (data1 != null) {
                        prt.WriteLine(",");
                        prt.Write("posConfidence ");
                        prt.PrintContent(data1);
                    }
                }
                {
                    DefMotion.MotionConfidenceSet data1 = this.MotionCfd;

                    if (data1 != null) {
                        prt.WriteLine(",");
                        prt.Write("motionCfd ");
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
                if (this.UtcTime != null)
                    optMask0[0] |= (byte)(0x80 >> 0);
                if (this.Heading != null)
                    optMask0[0] |= (byte)(0x80 >> 1);
                if (this.Transmission != null)
                    optMask0[0] |= (byte)(0x80 >> 2);
                if (this.Speed != null)
                    optMask0[0] |= (byte)(0x80 >> 3);
                if (this.PosAccuracy != null)
                    optMask0[0] |= (byte)(0x80 >> 4);
                if (this.TimeConfidence != null)
                    optMask0[0] |= (byte)(0x80 >> 5);
                if (this.PosConfidence != null)
                    optMask0[0] |= (byte)(0x80 >> 6);
                if (this.MotionCfd != null)
                    optMask0[0] |= (byte)(0x80 >> 7);
                enc.Output.WriteBits(optMask0, 0, 8);
                try {
                    DefTime.DDateTime data1 = this.UtcTime;

                    if (data1 != null)
                    {
                        enc.EncodeType(data1);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "UtcTime", "DefTime.DDateTime", "utcTime", "DDateTime", false); throw;
                }
                try {
                    enc.EncodeType(this.Pos);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Pos", "DefPosition.Position3D", "pos", "Position3D", false); throw;
                }
                try {
                    if (this.Heading != null)
                    {
                        if (enc.BitCount(this.Heading.Value - 0) > 15 || this.Heading.Value < 0)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.Heading.Value);
                        enc.EncodeConstrainedInteger((this.Heading.Value - (0)), 15);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Heading.Value", "int", "heading", "Heading", false); throw;
                }
                try {
                    if (this.Transmission != null)
                    {
                        enc.EncodeEnum((int)this.Transmission.Value, _InternalMetadata.PerCodecMetaData.SortedEnum2);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Transmission.Value", "VehStatusModule.TransmissionState", "transmission", "TransmissionState", false); throw;
                }
                try {
                    if (this.Speed != null)
                    {
                        if (enc.BitCount(this.Speed.Value - 0) > 13 || this.Speed.Value < 0)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.Speed.Value);
                        enc.EncodeConstrainedInteger((this.Speed.Value - (0)), 13);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Speed.Value", "int", "speed", "Speed", false); throw;
                }
                try {
                    if (this.PosAccuracy != null)
                    {
                        enc.EncodeType(this.PosAccuracy);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "PosAccuracy", "DefPosition.PositionConfidenceSet", "posAccuracy", "PositionConfidenceSet", false); throw;
                }
                try {
                    if (this.TimeConfidence != null)
                    {
                        enc.EncodeEnum((int)this.TimeConfidence.Value, _InternalMetadata.PerCodecMetaData.SortedEnum12);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "TimeConfidence.Value", "DefTime.TimeConfidence", "timeConfidence", "TimeConfidence", false); throw;
                }
                try {
                    if (this.PosConfidence != null)
                    {
                        enc.EncodeType(this.PosConfidence);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "PosConfidence", "DefPosition.PositionConfidenceSet", "posConfidence", "PositionConfidenceSet", false); throw;
                }
                try {
                    if (this.MotionCfd != null)
                    {
                        enc.EncodeType(this.MotionCfd);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "MotionCfd", "DefMotion.MotionConfidenceSet", "motionCfd", "MotionConfidenceSet", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "FullPositionVector", null, "FullPositionVector", false); throw;
            }
        }

        protected override void DecodePer(Oss.Asn1.Internal.PerDecoder dec)
        {
            try {
                bool extPresent0 = dec.Input.ReadBool();
                byte[] optMask0 = new byte[1];

                dec.Input.ReadBits(optMask0, 8);
                if ((optMask0[0] & (0x80 >> 0)) != 0)
                {
                    try {
                        DefTime.DDateTime data1 = new DefTime.DDateTime();

                        dec.DecodeType(data1);
                        this.UtcTime = data1;
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "UtcTime", "DefTime.DDateTime", "utcTime", "DDateTime", false); throw;
                    }
                }
                else
                {
                    this.UtcTime = null;
                }
                try {
                    DefPosition.Position3D data1 = new DefPosition.Position3D();

                    dec.DecodeType(data1);
                    this.Pos = data1;
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Pos", "DefPosition.Position3D", "pos", "Position3D", false); throw;
                }
                if ((optMask0[0] & (0x80 >> 1)) != 0)
                {
                    try {
                        this.Heading = dec.DecodeConstrainedInteger(15, 0);
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "Heading", "int", "heading", "Heading", false); throw;
                    }
                }
                else
                {
                    this.Heading = null;
                }
                if ((optMask0[0] & (0x80 >> 2)) != 0)
                {
                    try {
                        this.Transmission = (VehStatusModule.TransmissionState)dec.DecodeEnum(_InternalMetadata.PerCodecMetaData.SortedEnum2);
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "Transmission", "VehStatusModule.TransmissionState", "transmission", "TransmissionState", false); throw;
                    }
                }
                else
                {
                    this.Transmission = null;
                }
                if ((optMask0[0] & (0x80 >> 3)) != 0)
                {
                    try {
                        this.Speed = dec.DecodeConstrainedInteger(13, 0);
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "Speed", "int", "speed", "Speed", false); throw;
                    }
                }
                else
                {
                    this.Speed = null;
                }
                if ((optMask0[0] & (0x80 >> 4)) != 0)
                {
                    try {
                        DefPosition.PositionConfidenceSet data1 = new DefPosition.PositionConfidenceSet();

                        dec.DecodeType(data1);
                        this.PosAccuracy = data1;
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "PosAccuracy", "DefPosition.PositionConfidenceSet", "posAccuracy", "PositionConfidenceSet", false); throw;
                    }
                }
                else
                {
                    this.PosAccuracy = null;
                }
                if ((optMask0[0] & (0x80 >> 5)) != 0)
                {
                    try {
                        this.TimeConfidence = (DefTime.TimeConfidence)dec.DecodeEnum(_InternalMetadata.PerCodecMetaData.SortedEnum12);
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "TimeConfidence", "DefTime.TimeConfidence", "timeConfidence", "TimeConfidence", false); throw;
                    }
                }
                else
                {
                    this.TimeConfidence = null;
                }
                if ((optMask0[0] & (0x80 >> 6)) != 0)
                {
                    try {
                        DefPosition.PositionConfidenceSet data1 = new DefPosition.PositionConfidenceSet();

                        dec.DecodeType(data1);
                        this.PosConfidence = data1;
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "PosConfidence", "DefPosition.PositionConfidenceSet", "posConfidence", "PositionConfidenceSet", false); throw;
                    }
                }
                else
                {
                    this.PosConfidence = null;
                }
                if ((optMask0[0] & (0x80 >> 7)) != 0)
                {
                    try {
                        DefMotion.MotionConfidenceSet data1 = new DefMotion.MotionConfidenceSet();

                        dec.DecodeType(data1);
                        this.MotionCfd = data1;
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "MotionCfd", "DefMotion.MotionConfidenceSet", "motionCfd", "MotionConfidenceSet", false); throw;
                    }
                }
                else
                {
                    this.MotionCfd = null;
                }
                if (extPresent0)
                {
                    int extMaskLen0 = 0;
                    byte[] extMask0 = dec.DecodeExtPreamble(out extMaskLen0);

                    dec.SkipUnknownExtensions(extMask0, extMaskLen0, 0);
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "FullPositionVector", null, "FullPositionVector", false); throw;
            }
        }
    }
}
