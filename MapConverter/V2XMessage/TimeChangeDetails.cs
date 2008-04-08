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


namespace VehStatus.SPATIntersectionState
{
    /// <summary>
    /// Represents schema type 'TimeChangeDetails' (SEQUENCE)
    /// </summary>
    [System.Serializable]
    public partial class TimeChangeDetails : Oss.Asn1.BaseType
    {
        /// <summary>Field 'startTime'</summary>
        public int StartTime { get; set; }
        /// <summary>Field 'minEndTime'</summary>
        public int? MinEndTime { get; set; }
        /// <summary>Field 'maxEndTime'</summary>
        public int? MaxEndTime { get; set; }
        /// <summary>Field 'likelyEndTime'</summary>
        public int LikelyEndTime { get; set; }
        /// <summary>Field 'timeConfidence'</summary>
        public int? TimeConfidence { get; set; }
        /// <summary>Field 'nextStartTime'</summary>
        public int? NextStartTime { get; set; }
        /// <summary>Field 'nextDuration'</summary>
        public int? NextDuration { get; set; }

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
            TimeChangeDetails that = right as TimeChangeDetails;
            if (StartTime != that.StartTime)
                return false;
            if (MinEndTime != null) {
                if (MinEndTime != that.MinEndTime)
                    return false;
            } else if (that.MinEndTime != null)
                return false;
            if (MaxEndTime != null) {
                if (MaxEndTime != that.MaxEndTime)
                    return false;
            } else if (that.MaxEndTime != null)
                return false;
            if (LikelyEndTime != that.LikelyEndTime)
                return false;
            if (TimeConfidence != null) {
                if (TimeConfidence != that.TimeConfidence)
                    return false;
            } else if (that.TimeConfidence != null)
                return false;
            if (NextStartTime != null) {
                if (NextStartTime != that.NextStartTime)
                    return false;
            } else if (that.NextStartTime != null)
                return false;
            if (NextDuration != null) {
                if (NextDuration != that.NextDuration)
                    return false;
            } else if (that.NextDuration != null)
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
            hash ^= StartTime.GetHashCode();
            if (MinEndTime != null)
                hash ^= MinEndTime.GetHashCode();
            if (MaxEndTime != null)
                hash ^= MaxEndTime.GetHashCode();
            hash ^= LikelyEndTime.GetHashCode();
            if (TimeConfidence != null)
                hash ^= TimeConfidence.GetHashCode();
            if (NextStartTime != null)
                hash ^= NextStartTime.GetHashCode();
            if (NextDuration != null)
                hash ^= NextDuration.GetHashCode();
            return hash;
        }

        /// <summary>
        /// Returns the name of the ASN.1 schema type represented by this class.
        /// </summary>
        /// <returns>the string containing the name of the ASN.1 schema type.</returns>
        public override string GetAsn1TypeName()
        {
            return "TimeChangeDetails";
        }

        /// <summary>
        /// Asserts the validity of this object`s ASN.1 data.
        /// </summary>
        /// <exception cref="Oss.Asn1.Asn1InvalidDataException">Thrown if the instance contains invalid data.</exception>
        public override void Validate()
        {
            try {
                try {
                    if (this.StartTime < 0)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    if (this.StartTime > 36001)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "StartTime", "int", "startTime", "TimeMark", false); throw;
                }
                try {
                    if (this.MinEndTime != null) {
                        if (this.MinEndTime.Value < 0)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                        if (this.MinEndTime.Value > 36001)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "MinEndTime.Value", "int", "minEndTime", "TimeMark", false); throw;
                }
                try {
                    if (this.MaxEndTime != null) {
                        if (this.MaxEndTime.Value < 0)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                        if (this.MaxEndTime.Value > 36001)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "MaxEndTime.Value", "int", "maxEndTime", "TimeMark", false); throw;
                }
                try {
                    if (this.LikelyEndTime < 0)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    if (this.LikelyEndTime > 36001)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "LikelyEndTime", "int", "likelyEndTime", "TimeMark", false); throw;
                }
                try {
                    if (this.TimeConfidence != null) {
                        if (this.TimeConfidence.Value < 0)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                        if (this.TimeConfidence.Value > 200)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "TimeConfidence.Value", "int", "timeConfidence", "Confidence", false); throw;
                }
                try {
                    if (this.NextStartTime != null) {
                        if (this.NextStartTime.Value < 0)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                        if (this.NextStartTime.Value > 36001)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "NextStartTime.Value", "int", "nextStartTime", "TimeMark", false); throw;
                }
                try {
                    if (this.NextDuration != null) {
                        if (this.NextDuration.Value < 0)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                        if (this.NextDuration.Value > 36001)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "NextDuration.Value", "int", "nextDuration", "TimeMark", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "TimeChangeDetails", null, "TimeChangeDetails", false); throw;
            }
        }

        /// <summary>
        /// Creates the deep copy of this object.
        /// </summary>
        /// <returns>A new object that is a deep copy of this instance.</returns>
        public override object Copy()
        {
            TimeChangeDetails obj0 = new TimeChangeDetails();
            {
                obj0.StartTime = this.StartTime;
            }
            {
                obj0.MinEndTime = this.MinEndTime;
            }
            {
                obj0.MaxEndTime = this.MaxEndTime;
            }
            {
                obj0.LikelyEndTime = this.LikelyEndTime;
            }
            {
                obj0.TimeConfidence = this.TimeConfidence;
            }
            {
                obj0.NextStartTime = this.NextStartTime;
            }
            {
                obj0.NextDuration = this.NextDuration;
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
                    prt.Write("startTime ");
                    prt.Write(this.StartTime);
                }
                {
                    int? data1 = this.MinEndTime;

                    if (data1 != null) {
                        prt.WriteLine(",");
                        prt.Write("minEndTime ");
                        prt.Write(data1.Value);
                    }
                }
                {
                    int? data1 = this.MaxEndTime;

                    if (data1 != null) {
                        prt.WriteLine(",");
                        prt.Write("maxEndTime ");
                        prt.Write(data1.Value);
                    }
                }
                {
                    prt.WriteLine(",");
                    prt.Write("likelyEndTime ");
                    prt.Write(this.LikelyEndTime);
                }
                {
                    int? data1 = this.TimeConfidence;

                    if (data1 != null) {
                        prt.WriteLine(",");
                        prt.Write("timeConfidence ");
                        prt.Write(data1.Value);
                    }
                }
                {
                    int? data1 = this.NextStartTime;

                    if (data1 != null) {
                        prt.WriteLine(",");
                        prt.Write("nextStartTime ");
                        prt.Write(data1.Value);
                    }
                }
                {
                    int? data1 = this.NextDuration;

                    if (data1 != null) {
                        prt.WriteLine(",");
                        prt.Write("nextDuration ");
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

                if (this.MinEndTime != null)
                    optMask0[0] |= (byte)(0x80 >> 0);
                if (this.MaxEndTime != null)
                    optMask0[0] |= (byte)(0x80 >> 1);
                if (this.TimeConfidence != null)
                    optMask0[0] |= (byte)(0x80 >> 2);
                if (this.NextStartTime != null)
                    optMask0[0] |= (byte)(0x80 >> 3);
                if (this.NextDuration != null)
                    optMask0[0] |= (byte)(0x80 >> 4);
                enc.Output.WriteBits(optMask0, 0, 5);
                try {
                    if (enc.BitCount(this.StartTime - 0) > 16 || this.StartTime < 0)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.StartTime);
                    enc.EncodeConstrainedInteger((this.StartTime - (0)), 16);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "StartTime", "int", "startTime", "TimeMark", false); throw;
                }
                try {
                    if (this.MinEndTime != null)
                    {
                        if (enc.BitCount(this.MinEndTime.Value - 0) > 16 || this.MinEndTime.Value < 0)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.MinEndTime.Value);
                        enc.EncodeConstrainedInteger((this.MinEndTime.Value - (0)), 16);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "MinEndTime.Value", "int", "minEndTime", "TimeMark", false); throw;
                }
                try {
                    if (this.MaxEndTime != null)
                    {
                        if (enc.BitCount(this.MaxEndTime.Value - 0) > 16 || this.MaxEndTime.Value < 0)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.MaxEndTime.Value);
                        enc.EncodeConstrainedInteger((this.MaxEndTime.Value - (0)), 16);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "MaxEndTime.Value", "int", "maxEndTime", "TimeMark", false); throw;
                }
                try {
                    if (enc.BitCount(this.LikelyEndTime - 0) > 16 || this.LikelyEndTime < 0)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.LikelyEndTime);
                    enc.EncodeConstrainedInteger((this.LikelyEndTime - (0)), 16);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "LikelyEndTime", "int", "likelyEndTime", "TimeMark", false); throw;
                }
                try {
                    if (this.TimeConfidence != null)
                    {
                        if (enc.BitCount(this.TimeConfidence.Value - 0) > 8 || this.TimeConfidence.Value < 0)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.TimeConfidence.Value);
                        enc.Output.Write8BitInt((this.TimeConfidence.Value - (0)));
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "TimeConfidence.Value", "int", "timeConfidence", "Confidence", false); throw;
                }
                try {
                    if (this.NextStartTime != null)
                    {
                        if (enc.BitCount(this.NextStartTime.Value - 0) > 16 || this.NextStartTime.Value < 0)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.NextStartTime.Value);
                        enc.EncodeConstrainedInteger((this.NextStartTime.Value - (0)), 16);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "NextStartTime.Value", "int", "nextStartTime", "TimeMark", false); throw;
                }
                try {
                    if (this.NextDuration != null)
                    {
                        if (enc.BitCount(this.NextDuration.Value - 0) > 16 || this.NextDuration.Value < 0)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.NextDuration.Value);
                        enc.EncodeConstrainedInteger((this.NextDuration.Value - (0)), 16);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "NextDuration.Value", "int", "nextDuration", "TimeMark", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "TimeChangeDetails", null, "TimeChangeDetails", false); throw;
            }
        }

        protected override void DecodePer(Oss.Asn1.Internal.PerDecoder dec)
        {
            try {
                byte[] optMask0 = new byte[1];

                dec.Input.ReadBits(optMask0, 5);
                try {
                    this.StartTime = dec.DecodeConstrainedInteger(16, 0);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "StartTime", "int", "startTime", "TimeMark", false); throw;
                }
                if ((optMask0[0] & (0x80 >> 0)) != 0)
                {
                    try {
                        this.MinEndTime = dec.DecodeConstrainedInteger(16, 0);
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "MinEndTime", "int", "minEndTime", "TimeMark", false); throw;
                    }
                }
                else
                {
                    this.MinEndTime = null;
                }
                if ((optMask0[0] & (0x80 >> 1)) != 0)
                {
                    try {
                        this.MaxEndTime = dec.DecodeConstrainedInteger(16, 0);
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "MaxEndTime", "int", "maxEndTime", "TimeMark", false); throw;
                    }
                }
                else
                {
                    this.MaxEndTime = null;
                }
                try {
                    this.LikelyEndTime = dec.DecodeConstrainedInteger(16, 0);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "LikelyEndTime", "int", "likelyEndTime", "TimeMark", false); throw;
                }
                if ((optMask0[0] & (0x80 >> 2)) != 0)
                {
                    try {
                        this.TimeConfidence = 0 + dec.Input.Read8BitInt();
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "TimeConfidence", "int", "timeConfidence", "Confidence", false); throw;
                    }
                }
                else
                {
                    this.TimeConfidence = null;
                }
                if ((optMask0[0] & (0x80 >> 3)) != 0)
                {
                    try {
                        this.NextStartTime = dec.DecodeConstrainedInteger(16, 0);
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "NextStartTime", "int", "nextStartTime", "TimeMark", false); throw;
                    }
                }
                else
                {
                    this.NextStartTime = null;
                }
                if ((optMask0[0] & (0x80 >> 4)) != 0)
                {
                    try {
                        this.NextDuration = dec.DecodeConstrainedInteger(16, 0);
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "NextDuration", "int", "nextDuration", "TimeMark", false); throw;
                    }
                }
                else
                {
                    this.NextDuration = null;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "TimeChangeDetails", null, "TimeChangeDetails", false); throw;
            }
        }
    }
}
