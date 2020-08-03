
namespace VehStatus.SPATIntersectionState
{
    /// <summary>
    /// Represents schema type 'IntersectionState' (SEQUENCE)
    /// </summary>
    [System.Serializable]
    public partial class IntersectionState : Oss.Asn1.BaseType
    {
        /// <summary>Field 'intersectionId'</summary>
        public MapNode.NodeReferenceID IntersectionId { get; set; }
        /// <summary>Field 'status'</summary>
        public Oss.Asn1.BitStringWithNamedBits Status { get; set; }
        /// <summary>Field 'moy'</summary>
        public int? Moy { get; set; }
        /// <summary>Field 'timeStamp'</summary>
        public int? TimeStamp { get; set; }
        /// <summary>Field 'phases'</summary>
        public PhaseList Phases { get; set; }

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
            IntersectionState that = right as IntersectionState;
            if (IntersectionId != null) {
                if (!IntersectionId.Equals(that.IntersectionId))
                    return false;
            } else if (that.IntersectionId != null)
                return false;
            if (Status != null) {
                if (!Status.Equals(that.Status))
                    return false;
            } else if (that.Status != null)
                return false;
            if (Moy != null) {
                if (Moy != that.Moy)
                    return false;
            } else if (that.Moy != null)
                return false;
            if (TimeStamp != null) {
                if (TimeStamp != that.TimeStamp)
                    return false;
            } else if (that.TimeStamp != null)
                return false;
            if (Phases != null) {
                if (!Oss.Asn1.Internal.Comparer.CompareSeqOf(Phases, that.Phases))
                    return false;
            } else if (that.Phases != null)
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
            if (IntersectionId != null)
                hash ^= IntersectionId.GetHashCode();
            if (Status != null)
                hash ^= Status.GetHashCode();
            if (Moy != null)
                hash ^= Moy.GetHashCode();
            if (TimeStamp != null)
                hash ^= TimeStamp.GetHashCode();
            if (Phases != null)
                hash ^= Oss.Asn1.Internal.Comparer.HashSeqOf(Phases);
            return hash;
        }

        /// <summary>
        /// Returns the name of the ASN.1 schema type represented by this class.
        /// </summary>
        /// <returns>the string containing the name of the ASN.1 schema type.</returns>
        public override string GetAsn1TypeName()
        {
            return "IntersectionState";
        }

        /// <summary>
        /// Asserts the validity of this object`s ASN.1 data.
        /// </summary>
        /// <exception cref="Oss.Asn1.Asn1InvalidDataException">Thrown if the instance contains invalid data.</exception>
        public override void Validate()
        {
            try {
                try {
                    if (this.IntersectionId == null)
                        throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._null_component_element);
                    this.IntersectionId.Validate();
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "IntersectionId", "MapNode.NodeReferenceID", "intersectionId", "NodeReferenceID", false); throw;
                }
                try {
                    if (this.Status == null)
                        throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._null_component_element);
                    if (this.Status.Count != 16)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Status", "Oss.Asn1.BitStringWithNamedBits", "status", "IntersectionStatusObject", false); throw;
                }
                try {
                    if (this.Moy != null) {
                        if (this.Moy.Value < 0)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                        if (this.Moy.Value > 527040)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Moy.Value", "int", "moy", "MinuteOfTheYear", false); throw;
                }
                try {
                    if (this.TimeStamp != null) {
                        if (this.TimeStamp.Value < 0)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                        if (this.TimeStamp.Value > 65535)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "TimeStamp.Value", "int", "timeStamp", "DSecond", false); throw;
                }
                try {
                    if (this.Phases == null)
                        throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._null_component_element);
                    this.Phases.Validate();
                    if (this.Phases.Count < 1)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                    if (this.Phases.Count > 16)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Phases", "PhaseList", "phases", "PhaseList", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "IntersectionState", null, "IntersectionState", false); throw;
            }
        }

        /// <summary>
        /// Creates the deep copy of this object.
        /// </summary>
        /// <returns>A new object that is a deep copy of this instance.</returns>
        public override object Copy()
        {
            IntersectionState obj0 = new IntersectionState();
            {
                obj0.IntersectionId = Oss.Asn1.Internal.CopyUtil.CopyType(this.IntersectionId);
            }
            {
                obj0.Status = Oss.Asn1.Internal.CopyUtil.CopyBitString(this.Status);
            }
            {
                obj0.Moy = this.Moy;
            }
            {
                obj0.TimeStamp = this.TimeStamp;
            }
            {
                obj0.Phases = this.Phases == null ? null : (PhaseList)this.Phases.Copy();
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
                    prt.Write("intersectionId ");
                    if (this.IntersectionId == null)
                        prt.Write("<<<NULL>>>");
                    else {
                        prt.PrintContent(this.IntersectionId);
                    }
                }
                {
                    prt.WriteLine(",");
                    prt.Write("status ");
                    if (this.Status == null)
                        prt.Write("<<<NULL>>>");
                    else {
                        prt.PrintBitString(this.Status, 
                            delegate(int index)
                            {
                                switch (index)
                                {
                                    case (int)0: return "manualControlIsEnabled";
                                    case (int)1: return "stopTimeIsActivated";
                                    case (int)2: return "failureFlash";
                                    case (int)3: return "preemptIsActive";
                                    case (int)4: return "signalPriorityIsActive";
                                    case (int)5: return "fixedTimeOperation";
                                    case (int)6: return "trafficDependentOperation";
                                    case (int)7: return "standbyOperation";
                                    case (int)8: return "failureMode";
                                    case (int)9: return "off";
                                    case (int)10: return "recentMAPmessageUpdate";
                                    case (int)11: return "recentChangeInMAPassignedLanesIDsUsed";
                                    case (int)12: return "noValidMAPisAvailableAtThisTime";
                                    case (int)13: return "noValidSPATisAvailableAtThisTime";
                                }
                                return null;
                            }
                        );
                    }
                }
                {
                    int? data1 = this.Moy;

                    if (data1 != null) {
                        prt.WriteLine(",");
                        prt.Write("moy ");
                        prt.Write(data1.Value);
                    }
                }
                {
                    int? data1 = this.TimeStamp;

                    if (data1 != null) {
                        prt.WriteLine(",");
                        prt.Write("timeStamp ");
                        prt.Write(data1.Value);
                    }
                }
                {
                    PhaseList data1 = this.Phases;

                    prt.WriteLine(",");
                    prt.Write("phases ");
                    if (data1 == null)
                        prt.Write("<<<NULL>>>");
                    else {
                        data1.PrintAsn1ValueNotation(prt);
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

                if (this.Moy != null)
                    optMask0[0] |= (byte)(0x80 >> 0);
                if (this.TimeStamp != null)
                    optMask0[0] |= (byte)(0x80 >> 1);
                enc.Output.WriteBits(optMask0, 0, 2);
                try {
                    enc.EncodeType(this.IntersectionId);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "IntersectionId", "MapNode.NodeReferenceID", "intersectionId", "NodeReferenceID", false); throw;
                }
                try {
                    int length1 = Oss.Asn1.Internal.MiscUtil.SearchGreaterOrEqual(_InternalMetadata.BerCodecMetaData.Ranges7, this.Status.LastOneBitPos() + 1);
                    enc.EncodeBitStringWithNamedBits(this.Status, length1, 16);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Status", "Oss.Asn1.BitStringWithNamedBits", "status", "IntersectionStatusObject", false); throw;
                }
                try {
                    if (this.Moy != null)
                    {
                        if (enc.BitCount(this.Moy.Value - 0) > 20 || this.Moy.Value < 0)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.Moy.Value);
                        enc.EncodeConstrainedInteger((this.Moy.Value - (0)), 20);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Moy.Value", "int", "moy", "MinuteOfTheYear", false); throw;
                }
                try {
                    if (this.TimeStamp != null)
                    {
                        if (enc.BitCount(this.TimeStamp.Value - 0) > 16 || this.TimeStamp.Value < 0)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.TimeStamp.Value);
                        enc.EncodeConstrainedInteger((this.TimeStamp.Value - (0)), 16);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "TimeStamp.Value", "int", "timeStamp", "DSecond", false); throw;
                }
                try {
                    this.Phases.EncodePer(enc);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Phases", "PhaseList", "phases", "PhaseList", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "IntersectionState", null, "IntersectionState", false); throw;
            }
        }

        protected override void DecodePer(Oss.Asn1.Internal.PerDecoder dec)
        {
            try {
                byte[] optMask0 = new byte[1];

                dec.Input.ReadBits(optMask0, 2);
                try {
                    MapNode.NodeReferenceID data1 = new MapNode.NodeReferenceID();

                    dec.DecodeType(data1);
                    this.IntersectionId = data1;
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "IntersectionId", "MapNode.NodeReferenceID", "intersectionId", "NodeReferenceID", false); throw;
                }
                try {
                    this.Status = dec.DecodeBitStringWithNamedBits(16, _InternalMetadata.BerCodecMetaData.Ranges7);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Status", "Oss.Asn1.BitStringWithNamedBits", "status", "IntersectionStatusObject", false); throw;
                }
                if ((optMask0[0] & (0x80 >> 0)) != 0)
                {
                    try {
                        this.Moy = dec.DecodeConstrainedInteger(20, 0);
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "Moy", "int", "moy", "MinuteOfTheYear", false); throw;
                    }
                }
                else
                {
                    this.Moy = null;
                }
                if ((optMask0[0] & (0x80 >> 1)) != 0)
                {
                    try {
                        this.TimeStamp = dec.DecodeConstrainedInteger(16, 0);
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "TimeStamp", "int", "timeStamp", "DSecond", false); throw;
                    }
                }
                else
                {
                    this.TimeStamp = null;
                }
                try {
                    PhaseList data1 = new PhaseList();

                    data1.DecodePer(dec);
                    this.Phases = data1;
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Phases", "PhaseList", "phases", "PhaseList", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "IntersectionState", null, "IntersectionState", false); throw;
            }
        }
    }
}
