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
 * F:/OneDrive - 同济大学/MAGIC/车路协同/人车在环/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/BSM.asn
 * F:/OneDrive - 同济大学/MAGIC/车路协同/人车在环/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/DefAcceleration.asn
 * F:/OneDrive - 同济大学/MAGIC/车路协同/人车在环/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/DefMotion.asn
 * F:/OneDrive - 同济大学/MAGIC/车路协同/人车在环/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/DefPosition.asn
 * F:/OneDrive - 同济大学/MAGIC/车路协同/人车在环/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/DefPositionOffset.asn
 * F:/OneDrive - 同济大学/MAGIC/车路协同/人车在环/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/DefTime.asn
 * F:/OneDrive - 同济大学/MAGIC/车路协同/人车在环/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/Map.asn
 * F:/OneDrive - 同济大学/MAGIC/车路协同/人车在环/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/MapLane.asn
 * F:/OneDrive - 同济大学/MAGIC/车路协同/人车在环/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/MapLink.asn
 * F:/OneDrive - 同济大学/MAGIC/车路协同/人车在环/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/MapNode.asn
 * F:/OneDrive - 同济大学/MAGIC/车路协同/人车在环/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/MapPoint.asn
 * F:/OneDrive - 同济大学/MAGIC/车路协同/人车在环/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/MapSpeedLimit.asn
 * F:/OneDrive - 同济大学/MAGIC/车路协同/人车在环/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/MsgFrame.asn
 * F:/OneDrive - 同济大学/MAGIC/车路协同/人车在环/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/RSI.asn
 * F:/OneDrive - 同济大学/MAGIC/车路协同/人车在环/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/RSM.asn
 * F:/OneDrive - 同济大学/MAGIC/车路协同/人车在环/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/SignalPhaseAndTiming.asn
 * F:/OneDrive - 同济大学/MAGIC/车路协同/人车在环/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/SPATIntersectionState.asn
 * F:/OneDrive - 同济大学/MAGIC/车路协同/人车在环/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/VehBrake.asn
 * F:/OneDrive - 同济大学/MAGIC/车路协同/人车在环/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/VehClass.asn
 * F:/OneDrive - 同济大学/MAGIC/车路协同/人车在环/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/VehSafetyExt.asn
 * F:/OneDrive - 同济大学/MAGIC/车路协同/人车在环/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/VehSize.asn
 * F:/OneDrive - 同济大学/MAGIC/车路协同/人车在环/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/VehStatus.asn
 */


namespace VehStatus.VehSafetyExt
{
    /// <summary>
    /// Represents schema type 'PathHistoryPoint' (SEQUENCE)
    /// </summary>
    [System.Serializable]
    public partial class PathHistoryPoint : Oss.Asn1.BaseType
    {
        /// <summary>Field 'llvOffset'</summary>
        public DefPositionOffset.PositionOffsetLLV LlvOffset { get; set; }
        /// <summary>Field 'timeOffset'</summary>
        public int TimeOffset { get; set; }
        /// <summary>Field 'speed'</summary>
        public int? Speed { get; set; }
        /// <summary>Field 'posAccuracy'</summary>
        public DefPosition.PositionConfidenceSet PosAccuracy { get; set; }
        /// <summary>Field 'heading'</summary>
        public int? Heading { get; set; }

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
            PathHistoryPoint that = right as PathHistoryPoint;
            if (LlvOffset != null) {
                if (!LlvOffset.Equals(that.LlvOffset))
                    return false;
            } else if (that.LlvOffset != null)
                return false;
            if (TimeOffset != that.TimeOffset)
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
            if (Heading != null) {
                if (Heading != that.Heading)
                    return false;
            } else if (that.Heading != null)
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
            if (LlvOffset != null)
                hash ^= LlvOffset.GetHashCode();
            hash ^= TimeOffset.GetHashCode();
            if (Speed != null)
                hash ^= Speed.GetHashCode();
            if (PosAccuracy != null)
                hash ^= PosAccuracy.GetHashCode();
            if (Heading != null)
                hash ^= Heading.GetHashCode();
            return hash;
        }

        /// <summary>
        /// Returns the name of the ASN.1 schema type represented by this class.
        /// </summary>
        /// <returns>the string containing the name of the ASN.1 schema type.</returns>
        public override string GetAsn1TypeName()
        {
            return "PathHistoryPoint";
        }

        /// <summary>
        /// Asserts the validity of this object`s ASN.1 data.
        /// </summary>
        /// <exception cref="Oss.Asn1.Asn1InvalidDataException">Thrown if the instance contains invalid data.</exception>
        public override void Validate()
        {
            try {
                try {
                    if (this.LlvOffset == null)
                        throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._null_component_element);
                    this.LlvOffset.Validate();
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "LlvOffset", "DefPositionOffset.PositionOffsetLLV", "llvOffset", "PositionOffsetLLV", false); throw;
                }
                try {
                    if (this.TimeOffset < 1)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    if (this.TimeOffset > 65535)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "TimeOffset", "int", "timeOffset", "TimeOffset", false); throw;
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
                    if (this.Heading != null) {
                        if (this.Heading.Value < 0)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                        if (this.Heading.Value > 240)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Heading.Value", "int", "heading", "CoarseHeading", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "PathHistoryPoint", null, "PathHistoryPoint", false); throw;
            }
        }

        /// <summary>
        /// Creates the deep copy of this object.
        /// </summary>
        /// <returns>A new object that is a deep copy of this instance.</returns>
        public override object Copy()
        {
            PathHistoryPoint obj0 = new PathHistoryPoint();
            {
                obj0.LlvOffset = Oss.Asn1.Internal.CopyUtil.CopyType(this.LlvOffset);
            }
            {
                obj0.TimeOffset = this.TimeOffset;
            }
            {
                obj0.Speed = this.Speed;
            }
            {
                obj0.PosAccuracy = Oss.Asn1.Internal.CopyUtil.CopyType(this.PosAccuracy);
            }
            {
                obj0.Heading = this.Heading;
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
                    prt.Write("llvOffset ");
                    if (this.LlvOffset == null)
                        prt.Write("<<<NULL>>>");
                    else {
                        prt.PrintContent(this.LlvOffset);
                    }
                }
                {
                    prt.WriteLine(",");
                    prt.Write("timeOffset ");
                    prt.Write(this.TimeOffset);
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
                    int? data1 = this.Heading;

                    if (data1 != null) {
                        prt.WriteLine(",");
                        prt.Write("heading ");
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
                bool extPresent0 = false;
                byte[] optMask0 = new byte[1];

                enc.Output.WriteBool(extPresent0);
                if (this.Speed != null)
                    optMask0[0] |= (byte)(0x80 >> 0);
                if (this.PosAccuracy != null)
                    optMask0[0] |= (byte)(0x80 >> 1);
                if (this.Heading != null)
                    optMask0[0] |= (byte)(0x80 >> 2);
                enc.Output.WriteBits(optMask0, 0, 3);
                try {
                    enc.EncodeType(this.LlvOffset);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "LlvOffset", "DefPositionOffset.PositionOffsetLLV", "llvOffset", "PositionOffsetLLV", false); throw;
                }
                try {
                    if (enc.BitCount(this.TimeOffset - 1) > 16 || this.TimeOffset < 1)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.TimeOffset);
                    enc.EncodeConstrainedInteger((this.TimeOffset - (1)), 16);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "TimeOffset", "int", "timeOffset", "TimeOffset", false); throw;
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
                    if (this.Heading != null)
                    {
                        if (enc.BitCount(this.Heading.Value - 0) > 8 || this.Heading.Value < 0)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.Heading.Value);
                        enc.Output.Write8BitInt((this.Heading.Value - (0)));
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Heading.Value", "int", "heading", "CoarseHeading", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "PathHistoryPoint", null, "PathHistoryPoint", false); throw;
            }
        }

        protected override void DecodePer(Oss.Asn1.Internal.PerDecoder dec)
        {
            try {
                bool extPresent0 = dec.Input.ReadBool();
                byte[] optMask0 = new byte[1];

                dec.Input.ReadBits(optMask0, 3);
                try {
                    DefPositionOffset.PositionOffsetLLV data1 = new DefPositionOffset.PositionOffsetLLV();

                    dec.DecodeType(data1);
                    this.LlvOffset = data1;
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "LlvOffset", "DefPositionOffset.PositionOffsetLLV", "llvOffset", "PositionOffsetLLV", false); throw;
                }
                try {
                    this.TimeOffset = dec.DecodeConstrainedInteger(16, 1);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "TimeOffset", "int", "timeOffset", "TimeOffset", false); throw;
                }
                if ((optMask0[0] & (0x80 >> 0)) != 0)
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
                if ((optMask0[0] & (0x80 >> 1)) != 0)
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
                if ((optMask0[0] & (0x80 >> 2)) != 0)
                {
                    try {
                        this.Heading = 0 + dec.Input.Read8BitInt();
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "Heading", "int", "heading", "CoarseHeading", false); throw;
                    }
                }
                else
                {
                    this.Heading = null;
                }
                if (extPresent0)
                {
                    int extMaskLen0 = 0;
                    byte[] extMask0 = dec.DecodeExtPreamble(out extMaskLen0);

                    dec.SkipUnknownExtensions(extMask0, extMaskLen0, 0);
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "PathHistoryPoint", null, "PathHistoryPoint", false); throw;
            }
        }
    }
}
