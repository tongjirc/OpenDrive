

namespace VehStatus.MapLane
{
    /// <summary>
    /// Represents schema type 'Lane' (SEQUENCE)
    /// </summary>
    [System.Serializable]
    public partial class Lane : Oss.Asn1.BaseType
    {
        /// <summary>Field 'laneID'</summary>
        public int LaneID { get; set; }
        /// <summary>Field 'laneAttributes'</summary>
        public MapLane.LaneAttributes LaneAttributes { get; set; }
        /// <summary>Field 'maneuvers'</summary>
        public Oss.Asn1.BitStringWithNamedBits Maneuvers { get; set; }
        /// <summary>Field 'connectsTo'</summary>
        public ConnectsToList ConnectsTo { get; set; }
        /// <summary>Field 'speedLimits'</summary>
        public MapSpeedLimit.SpeedLimitList SpeedLimits { get; set; }
        /// <summary>Field 'points'</summary>
        public MapPoint.PointList Points { get; set; }

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
            Lane that = right as Lane;
            if (LaneID != that.LaneID)
                return false;
            if (LaneAttributes != null) {
                if (!LaneAttributes.Equals(that.LaneAttributes))
                    return false;
            } else if (that.LaneAttributes != null)
                return false;
            if (Maneuvers != null) {
                if (!Maneuvers.Equals(that.Maneuvers))
                    return false;
            } else if (that.Maneuvers != null)
                return false;
            if (ConnectsTo != null) {
                if (!Oss.Asn1.Internal.Comparer.CompareSeqOf(ConnectsTo, that.ConnectsTo))
                    return false;
            } else if (that.ConnectsTo != null)
                return false;
            if (SpeedLimits != null) {
                if (!Oss.Asn1.Internal.Comparer.CompareSeqOf(SpeedLimits, that.SpeedLimits))
                    return false;
            } else if (that.SpeedLimits != null)
                return false;
            if (Points != null) {
                if (!Oss.Asn1.Internal.Comparer.CompareSeqOf(Points, that.Points))
                    return false;
            } else if (that.Points != null)
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
            hash ^= LaneID.GetHashCode();
            if (LaneAttributes != null)
                hash ^= LaneAttributes.GetHashCode();
            if (Maneuvers != null)
                hash ^= Maneuvers.GetHashCode();
            if (ConnectsTo != null)
                hash ^= Oss.Asn1.Internal.Comparer.HashSeqOf(ConnectsTo);
            if (SpeedLimits != null)
                hash ^= Oss.Asn1.Internal.Comparer.HashSeqOf(SpeedLimits);
            if (Points != null)
                hash ^= Oss.Asn1.Internal.Comparer.HashSeqOf(Points);
            return hash;
        }

        /// <summary>
        /// Returns the name of the ASN.1 schema type represented by this class.
        /// </summary>
        /// <returns>the string containing the name of the ASN.1 schema type.</returns>
        public override string GetAsn1TypeName()
        {
            return "Lane";
        }

        /// <summary>
        /// Asserts the validity of this object`s ASN.1 data.
        /// </summary>
        /// <exception cref="Oss.Asn1.Asn1InvalidDataException">Thrown if the instance contains invalid data.</exception>
        public override void Validate()
        {
            try {
                try {
                    if (this.LaneID < 0)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    if (this.LaneID > 255)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "LaneID", "int", "laneID", "LaneID", false); throw;
                }
                try {
                    if (this.LaneAttributes != null) {
                        this.LaneAttributes.Validate();
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "LaneAttributes", "MapLane.LaneAttributes", "laneAttributes", "LaneAttributes", false); throw;
                }
                try {
                    if (this.Maneuvers != null) {
                        if (this.Maneuvers.Count != 12)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Maneuvers", "Oss.Asn1.BitStringWithNamedBits", "maneuvers", "AllowedManeuvers", false); throw;
                }
                try {
                    if (this.ConnectsTo != null) {
                        this.ConnectsTo.Validate();
                        if (this.ConnectsTo.Count < 1)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                        if (this.ConnectsTo.Count > 8)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "ConnectsTo", "ConnectsToList", "connectsTo", "ConnectsToList", false); throw;
                }
                try {
                    if (this.SpeedLimits != null) {
                        this.SpeedLimits.Validate();
                        if (this.SpeedLimits.Count < 1)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                        if (this.SpeedLimits.Count > 9)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "SpeedLimits", "MapSpeedLimit.SpeedLimitList", "speedLimits", "SpeedLimitList", false); throw;
                }
                try {
                    if (this.Points != null) {
                        this.Points.Validate();
                        if (this.Points.Count < 2)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                        if (this.Points.Count > 31)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Points", "MapPoint.PointList", "points", "PointList", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "Lane", null, "Lane", false); throw;
            }
        }

        /// <summary>
        /// Creates the deep copy of this object.
        /// </summary>
        /// <returns>A new object that is a deep copy of this instance.</returns>
        public override object Copy()
        {
            Lane obj0 = new Lane();
            {
                obj0.LaneID = this.LaneID;
            }
            {
                obj0.LaneAttributes = Oss.Asn1.Internal.CopyUtil.CopyType(this.LaneAttributes);
            }
            {
                obj0.Maneuvers = Oss.Asn1.Internal.CopyUtil.CopyBitString(this.Maneuvers);
            }
            {
                obj0.ConnectsTo = this.ConnectsTo == null ? null : (ConnectsToList)this.ConnectsTo.Copy();
            }
            {
                obj0.SpeedLimits = this.SpeedLimits == null ? null : (MapSpeedLimit.SpeedLimitList)this.SpeedLimits.Copy();
            }
            {
                obj0.Points = this.Points == null ? null : (MapPoint.PointList)this.Points.Copy();
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
                    prt.Write("laneID ");
                    prt.Write(this.LaneID);
                }
                {
                    MapLane.LaneAttributes data1 = this.LaneAttributes;

                    if (data1 != null) {
                        prt.WriteLine(",");
                        prt.Write("laneAttributes ");
                        prt.PrintContent(data1);
                    }
                }
                {
                    Oss.Asn1.BitStringWithNamedBits data1 = this.Maneuvers;

                    if (data1 != null) {
                        prt.WriteLine(",");
                        prt.Write("maneuvers ");
                        prt.PrintBitString(data1, 
                            delegate(int index)
                            {
                                switch (index)
                                {
                                    case (int)0: return "maneuverStraightAllowed";
                                    case (int)1: return "maneuverLeftAllowed";
                                    case (int)2: return "maneuverRightAllowed";
                                    case (int)3: return "maneuverUTurnAllowed";
                                    case (int)4: return "maneuverLeftTurnOnRedAllowed";
                                    case (int)5: return "maneuverRightTurnOnRedAllowed";
                                    case (int)6: return "maneuverLaneChangeAllowed";
                                    case (int)7: return "maneuverNoStoppingAllowed";
                                    case (int)8: return "yieldAllwaysRequired";
                                    case (int)9: return "goWithHalt";
                                    case (int)10: return "caution";
                                    case (int)11: return "reserved1";
                                }
                                return null;
                            }
                        );
                    }
                }
                {
                    ConnectsToList data1 = this.ConnectsTo;

                    if (data1 != null) {
                        prt.WriteLine(",");
                        prt.Write("connectsTo ");
                        data1.PrintAsn1ValueNotation(prt);
                    }
                }
                {
                    MapSpeedLimit.SpeedLimitList data1 = this.SpeedLimits;

                    if (data1 != null) {
                        prt.WriteLine(",");
                        prt.Write("speedLimits ");
                        data1.PrintAsn1ValueNotation(prt);
                    }
                }
                {
                    MapPoint.PointList data1 = this.Points;

                    if (data1 != null) {
                        prt.WriteLine(",");
                        prt.Write("points ");
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
                bool extPresent0 = false;
                byte[] optMask0 = new byte[1];

                enc.Output.WriteBool(extPresent0);
                if (this.LaneAttributes != null)
                    optMask0[0] |= (byte)(0x80 >> 0);
                if (this.Maneuvers != null)
                    optMask0[0] |= (byte)(0x80 >> 1);
                if (this.ConnectsTo != null)
                    optMask0[0] |= (byte)(0x80 >> 2);
                if (this.SpeedLimits != null)
                    optMask0[0] |= (byte)(0x80 >> 3);
                if (this.Points != null)
                    optMask0[0] |= (byte)(0x80 >> 4);
                enc.Output.WriteBits(optMask0, 0, 5);
                try {
                    if (enc.BitCount(this.LaneID - 0) > 8 || this.LaneID < 0)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.LaneID);
                    if (enc.IsAligned)
                        enc.Output.WritePadding();
                    enc.Output.Write8BitInt((this.LaneID - (0)));
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "LaneID", "int", "laneID", "LaneID", false); throw;
                }
                try {
                    MapLane.LaneAttributes data1 = this.LaneAttributes;

                    if (data1 != null)
                    {
                        enc.EncodeType(data1);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "LaneAttributes", "MapLane.LaneAttributes", "laneAttributes", "LaneAttributes", false); throw;
                }
                try {
                    if (this.Maneuvers != null)
                    {
                        int length1 = Oss.Asn1.Internal.MiscUtil.SearchGreaterOrEqual(_InternalMetadata.BerCodecMetaData.Ranges5, this.Maneuvers.LastOneBitPos() + 1);
                        enc.EncodeBitStringWithNamedBits(this.Maneuvers, length1, 12);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Maneuvers", "Oss.Asn1.BitStringWithNamedBits", "maneuvers", "AllowedManeuvers", false); throw;
                }
                try {
                    ConnectsToList data1 = this.ConnectsTo;

                    if (data1 != null)
                    {
                        data1.EncodePer(enc);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "ConnectsTo", "ConnectsToList", "connectsTo", "ConnectsToList", false); throw;
                }
                try {
                    if (this.SpeedLimits != null)
                    {
                        this.SpeedLimits.EncodePer(enc);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "SpeedLimits", "MapSpeedLimit.SpeedLimitList", "speedLimits", "SpeedLimitList", false); throw;
                }
                try {
                    if (this.Points != null)
                    {
                        this.Points.EncodePer(enc);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Points", "MapPoint.PointList", "points", "PointList", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "Lane", null, "Lane", false); throw;
            }
        }

        protected override void DecodePer(Oss.Asn1.Internal.PerDecoder dec)
        {
            try {
                bool extPresent0 = dec.Input.ReadBool();
                byte[] optMask0 = new byte[1];

                dec.Input.ReadBits(optMask0, 5);
                try {
                    if (dec.IsAligned)
                        dec.Input.SkipPadding();
                    this.LaneID = 0 + dec.Input.Read8BitInt();
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "LaneID", "int", "laneID", "LaneID", false); throw;
                }
                if ((optMask0[0] & (0x80 >> 0)) != 0)
                {
                    try {
                        MapLane.LaneAttributes data1 = new MapLane.LaneAttributes();

                        dec.DecodeType(data1);
                        this.LaneAttributes = data1;
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "LaneAttributes", "MapLane.LaneAttributes", "laneAttributes", "LaneAttributes", false); throw;
                    }
                }
                else
                {
                    this.LaneAttributes = null;
                }
                if ((optMask0[0] & (0x80 >> 1)) != 0)
                {
                    try {
                        this.Maneuvers = dec.DecodeBitStringWithNamedBits(12, _InternalMetadata.BerCodecMetaData.Ranges5);
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "Maneuvers", "Oss.Asn1.BitStringWithNamedBits", "maneuvers", "AllowedManeuvers", false); throw;
                    }
                }
                else
                {
                    this.Maneuvers = null;
                }
                if ((optMask0[0] & (0x80 >> 2)) != 0)
                {
                    try {
                        ConnectsToList data1 = new ConnectsToList();

                        data1.DecodePer(dec);
                        this.ConnectsTo = data1;
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "ConnectsTo", "ConnectsToList", "connectsTo", "ConnectsToList", false); throw;
                    }
                }
                else
                {
                    this.ConnectsTo = null;
                }
                if ((optMask0[0] & (0x80 >> 3)) != 0)
                {
                    try {
                        MapSpeedLimit.SpeedLimitList data1 = new MapSpeedLimit.SpeedLimitList();

                        data1.DecodePer(dec);
                        this.SpeedLimits = data1;
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "SpeedLimits", "MapSpeedLimit.SpeedLimitList", "speedLimits", "SpeedLimitList", false); throw;
                    }
                }
                else
                {
                    this.SpeedLimits = null;
                }
                if ((optMask0[0] & (0x80 >> 4)) != 0)
                {
                    try {
                        MapPoint.PointList data1 = new MapPoint.PointList();

                        data1.DecodePer(dec);
                        this.Points = data1;
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "Points", "MapPoint.PointList", "points", "PointList", false); throw;
                    }
                }
                else
                {
                    this.Points = null;
                }
                if (extPresent0)
                {
                    int extMaskLen0 = 0;
                    byte[] extMask0 = dec.DecodeExtPreamble(out extMaskLen0);

                    dec.SkipUnknownExtensions(extMask0, extMaskLen0, 0);
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "Lane", null, "Lane", false); throw;
            }
        }
    }
}
