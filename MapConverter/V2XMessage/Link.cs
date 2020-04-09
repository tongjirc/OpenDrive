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


namespace VehStatus.MapLink
{
    /// <summary>
    /// Represents schema type 'Link' (SEQUENCE)
    /// </summary>
    [System.Serializable]
    public partial class Link : Oss.Asn1.BaseType
    {
        /// <summary>Field 'name'</summary>
        public string Name { get; set; }
        /// <summary>Field 'upstreamNodeId'</summary>
        public MapNode.NodeReferenceID UpstreamNodeId { get; set; }
        /// <summary>Field 'speedLimits'</summary>
        public MapSpeedLimit.SpeedLimitList SpeedLimits { get; set; }
        /// <summary>Field 'laneWidth'</summary>
        public int LaneWidth { get; set; }
        /// <summary>Field 'points'</summary>
        public MapPoint.PointList Points { get; set; }
        /// <summary>Field 'movements'</summary>
        public MovementList Movements { get; set; }
        /// <summary>Field 'lanes'</summary>
        public MapLane.LaneList Lanes { get; set; }

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
            Link that = right as Link;
            if (Name != null) {
                if (!Name.Equals(that.Name))
                    return false;
            } else if (that.Name != null)
                return false;
            if (UpstreamNodeId != null) {
                if (!UpstreamNodeId.Equals(that.UpstreamNodeId))
                    return false;
            } else if (that.UpstreamNodeId != null)
                return false;
            if (SpeedLimits != null) {
                if (!Oss.Asn1.Internal.Comparer.CompareSeqOf(SpeedLimits, that.SpeedLimits))
                    return false;
            } else if (that.SpeedLimits != null)
                return false;
            if (LaneWidth != that.LaneWidth)
                return false;
            if (Points != null) {
                if (!Oss.Asn1.Internal.Comparer.CompareSeqOf(Points, that.Points))
                    return false;
            } else if (that.Points != null)
                return false;
            if (Movements != null) {
                if (!Oss.Asn1.Internal.Comparer.CompareSeqOf(Movements, that.Movements))
                    return false;
            } else if (that.Movements != null)
                return false;
            if (Lanes != null) {
                if (!Oss.Asn1.Internal.Comparer.CompareSeqOf(Lanes, that.Lanes))
                    return false;
            } else if (that.Lanes != null)
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
            if (Name != null)
                hash ^= Name.GetHashCode();
            if (UpstreamNodeId != null)
                hash ^= UpstreamNodeId.GetHashCode();
            if (SpeedLimits != null)
                hash ^= Oss.Asn1.Internal.Comparer.HashSeqOf(SpeedLimits);
            hash ^= LaneWidth.GetHashCode();
            if (Points != null)
                hash ^= Oss.Asn1.Internal.Comparer.HashSeqOf(Points);
            if (Movements != null)
                hash ^= Oss.Asn1.Internal.Comparer.HashSeqOf(Movements);
            if (Lanes != null)
                hash ^= Oss.Asn1.Internal.Comparer.HashSeqOf(Lanes);
            return hash;
        }

        /// <summary>
        /// Returns the name of the ASN.1 schema type represented by this class.
        /// </summary>
        /// <returns>the string containing the name of the ASN.1 schema type.</returns>
        public override string GetAsn1TypeName()
        {
            return "Link";
        }

        /// <summary>
        /// Asserts the validity of this object`s ASN.1 data.
        /// </summary>
        /// <exception cref="Oss.Asn1.Asn1InvalidDataException">Thrown if the instance contains invalid data.</exception>
        public override void Validate()
        {
            try {
                try {
                    if (this.Name != null) {
                        Oss.Asn1.Internal.Validator.ValidateKMCString(this.Name, _InternalMetadata.CommonMetaData.S0);
                        if (this.Name.Length < 1)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                        if (this.Name.Length > 63)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Name", "string", "name", "DescriptiveName", false); throw;
                }
                try {
                    if (this.UpstreamNodeId == null)
                        throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._null_component_element);
                    this.UpstreamNodeId.Validate();
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "UpstreamNodeId", "MapNode.NodeReferenceID", "upstreamNodeId", "NodeReferenceID", false); throw;
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
                    if (this.LaneWidth < 0)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    if (this.LaneWidth > 32767)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "LaneWidth", "int", "laneWidth", "LaneWidth", false); throw;
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
                try {
                    if (this.Movements != null) {
                        this.Movements.Validate();
                        if (this.Movements.Count < 1)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                        if (this.Movements.Count > 32)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Movements", "MovementList", "movements", "MovementList", false); throw;
                }
                try {
                    if (this.Lanes == null)
                        throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._null_component_element);
                    this.Lanes.Validate();
                    if (this.Lanes.Count < 1)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                    if (this.Lanes.Count > 32)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Lanes", "MapLane.LaneList", "lanes", "LaneList", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "Link", null, "Link", false); throw;
            }
        }

        /// <summary>
        /// Creates the deep copy of this object.
        /// </summary>
        /// <returns>A new object that is a deep copy of this instance.</returns>
        public override object Copy()
        {
            Link obj0 = new Link();
            {
                obj0.Name = this.Name;
            }
            {
                obj0.UpstreamNodeId = Oss.Asn1.Internal.CopyUtil.CopyType(this.UpstreamNodeId);
            }
            {
                obj0.SpeedLimits = this.SpeedLimits == null ? null : (MapSpeedLimit.SpeedLimitList)this.SpeedLimits.Copy();
            }
            {
                obj0.LaneWidth = this.LaneWidth;
            }
            {
                obj0.Points = this.Points == null ? null : (MapPoint.PointList)this.Points.Copy();
            }
            {
                obj0.Movements = this.Movements == null ? null : (MovementList)this.Movements.Copy();
            }
            {
                obj0.Lanes = this.Lanes == null ? null : (MapLane.LaneList)this.Lanes.Copy();
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
                    string data1 = this.Name;

                    if (data1 != null) {
                        prt.WriteLine();
                        first0 = false;
                        prt.Write("name ");
                        prt.PrintString(data1);
                    }
                }
                {
                    prt.WriteLine(first0 ? "" : ",");
                    prt.Write("upstreamNodeId ");
                    if (this.UpstreamNodeId == null)
                        prt.Write("<<<NULL>>>");
                    else {
                        prt.PrintContent(this.UpstreamNodeId);
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
                    prt.WriteLine(",");
                    prt.Write("laneWidth ");
                    prt.Write(this.LaneWidth);
                }
                {
                    MapPoint.PointList data1 = this.Points;

                    if (data1 != null) {
                        prt.WriteLine(",");
                        prt.Write("points ");
                        data1.PrintAsn1ValueNotation(prt);
                    }
                }
                {
                    MovementList data1 = this.Movements;

                    if (data1 != null) {
                        prt.WriteLine(",");
                        prt.Write("movements ");
                        data1.PrintAsn1ValueNotation(prt);
                    }
                }
                {
                    MapLane.LaneList data1 = this.Lanes;

                    prt.WriteLine(",");
                    prt.Write("lanes ");
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
                bool extPresent0 = false;
                byte[] optMask0 = new byte[1];

                enc.Output.WriteBool(extPresent0);
                if (this.Name != null)
                    optMask0[0] |= (byte)(0x80 >> 0);
                if (this.SpeedLimits != null)
                    optMask0[0] |= (byte)(0x80 >> 1);
                if (this.Points != null)
                    optMask0[0] |= (byte)(0x80 >> 2);
                if (this.Movements != null)
                    optMask0[0] |= (byte)(0x80 >> 3);
                enc.Output.WriteBits(optMask0, 0, 4);
                try {
                    if (this.Name != null)
                    {
                        enc.EncodeKMCString(this.Name, 1, 63, _InternalMetadata.CommonMetaData.S0);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Name", "string", "name", "DescriptiveName", false); throw;
                }
                try {
                    enc.EncodeType(this.UpstreamNodeId);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "UpstreamNodeId", "MapNode.NodeReferenceID", "upstreamNodeId", "NodeReferenceID", false); throw;
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
                    if (enc.BitCount(this.LaneWidth - 0) > 15 || this.LaneWidth < 0)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.LaneWidth);
                    enc.EncodeConstrainedInteger((this.LaneWidth - (0)), 15);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "LaneWidth", "int", "laneWidth", "LaneWidth", false); throw;
                }
                try {
                    if (this.Points != null)
                    {
                        this.Points.EncodePer(enc);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Points", "MapPoint.PointList", "points", "PointList", false); throw;
                }
                try {
                    MovementList data1 = this.Movements;

                    if (data1 != null)
                    {
                        data1.EncodePer(enc);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Movements", "MovementList", "movements", "MovementList", false); throw;
                }
                try {
                    this.Lanes.EncodePer(enc);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Lanes", "MapLane.LaneList", "lanes", "LaneList", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "Link", null, "Link", false); throw;
            }
        }

        protected override void DecodePer(Oss.Asn1.Internal.PerDecoder dec)
        {
            try {
                bool extPresent0 = dec.Input.ReadBool();
                byte[] optMask0 = new byte[1];

                dec.Input.ReadBits(optMask0, 4);
                if ((optMask0[0] & (0x80 >> 0)) != 0)
                {
                    try {
                        this.Name = dec.DecodeKMCString(1, 63, _InternalMetadata.CommonMetaData.S0);
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "Name", "string", "name", "DescriptiveName", false); throw;
                    }
                }
                else
                {
                    this.Name = null;
                }
                try {
                    MapNode.NodeReferenceID data1 = new MapNode.NodeReferenceID();

                    dec.DecodeType(data1);
                    this.UpstreamNodeId = data1;
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "UpstreamNodeId", "MapNode.NodeReferenceID", "upstreamNodeId", "NodeReferenceID", false); throw;
                }
                if ((optMask0[0] & (0x80 >> 1)) != 0)
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
                try {
                    this.LaneWidth = dec.DecodeConstrainedInteger(15, 0);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "LaneWidth", "int", "laneWidth", "LaneWidth", false); throw;
                }
                if ((optMask0[0] & (0x80 >> 2)) != 0)
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
                if ((optMask0[0] & (0x80 >> 3)) != 0)
                {
                    try {
                        MovementList data1 = new MovementList();

                        data1.DecodePer(dec);
                        this.Movements = data1;
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "Movements", "MovementList", "movements", "MovementList", false); throw;
                    }
                }
                else
                {
                    this.Movements = null;
                }
                try {
                    MapLane.LaneList data1 = new MapLane.LaneList();

                    data1.DecodePer(dec);
                    this.Lanes = data1;
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Lanes", "MapLane.LaneList", "lanes", "LaneList", false); throw;
                }
                if (extPresent0)
                {
                    int extMaskLen0 = 0;
                    byte[] extMask0 = dec.DecodeExtPreamble(out extMaskLen0);

                    dec.SkipUnknownExtensions(extMask0, extMaskLen0, 0);
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "Link", null, "Link", false); throw;
            }
        }
    }
}
