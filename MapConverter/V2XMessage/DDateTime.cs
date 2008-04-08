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


namespace VehStatus.DefTime
{
    /// <summary>
    /// Represents schema type 'DDateTime' (SEQUENCE)
    /// </summary>
    [System.Serializable]
    public partial class DDateTime : Oss.Asn1.BaseType
    {
        /// <summary>Field 'year'</summary>
        public int? Year { get; set; }
        /// <summary>Field 'month'</summary>
        public int? Month { get; set; }
        /// <summary>Field 'day'</summary>
        public int? Day { get; set; }
        /// <summary>Field 'hour'</summary>
        public int? Hour { get; set; }
        /// <summary>Field 'minute'</summary>
        public int? Minute { get; set; }
        /// <summary>Field 'second'</summary>
        public int? Second { get; set; }
        /// <summary>Field 'offset'</summary>
        public long? Offset { get; set; }

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
            DDateTime that = right as DDateTime;
            if (Year != null) {
                if (Year != that.Year)
                    return false;
            } else if (that.Year != null)
                return false;
            if (Month != null) {
                if (Month != that.Month)
                    return false;
            } else if (that.Month != null)
                return false;
            if (Day != null) {
                if (Day != that.Day)
                    return false;
            } else if (that.Day != null)
                return false;
            if (Hour != null) {
                if (Hour != that.Hour)
                    return false;
            } else if (that.Hour != null)
                return false;
            if (Minute != null) {
                if (Minute != that.Minute)
                    return false;
            } else if (that.Minute != null)
                return false;
            if (Second != null) {
                if (Second != that.Second)
                    return false;
            } else if (that.Second != null)
                return false;
            if (Offset != null) {
                if (Offset != that.Offset)
                    return false;
            } else if (that.Offset != null)
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
            if (Year != null)
                hash ^= Year.GetHashCode();
            if (Month != null)
                hash ^= Month.GetHashCode();
            if (Day != null)
                hash ^= Day.GetHashCode();
            if (Hour != null)
                hash ^= Hour.GetHashCode();
            if (Minute != null)
                hash ^= Minute.GetHashCode();
            if (Second != null)
                hash ^= Second.GetHashCode();
            if (Offset != null)
                hash ^= Offset.GetHashCode();
            return hash;
        }

        /// <summary>
        /// Returns the name of the ASN.1 schema type represented by this class.
        /// </summary>
        /// <returns>the string containing the name of the ASN.1 schema type.</returns>
        public override string GetAsn1TypeName()
        {
            return "DDateTime";
        }

        /// <summary>
        /// Asserts the validity of this object`s ASN.1 data.
        /// </summary>
        /// <exception cref="Oss.Asn1.Asn1InvalidDataException">Thrown if the instance contains invalid data.</exception>
        public override void Validate()
        {
            try {
                try {
                    if (this.Year != null) {
                        if (this.Year.Value < 0)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                        if (this.Year.Value > 4095)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Year.Value", "int", "year", "DYear", false); throw;
                }
                try {
                    if (this.Month != null) {
                        if (this.Month.Value < 0)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                        if (this.Month.Value > 12)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Month.Value", "int", "month", "DMonth", false); throw;
                }
                try {
                    if (this.Day != null) {
                        if (this.Day.Value < 0)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                        if (this.Day.Value > 31)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Day.Value", "int", "day", "DDay", false); throw;
                }
                try {
                    if (this.Hour != null) {
                        if (this.Hour.Value < 0)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                        if (this.Hour.Value > 31)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Hour.Value", "int", "hour", "DHour", false); throw;
                }
                try {
                    if (this.Minute != null) {
                        if (this.Minute.Value < 0)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                        if (this.Minute.Value > 60)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Minute.Value", "int", "minute", "DMinute", false); throw;
                }
                try {
                    if (this.Second != null) {
                        if (this.Second.Value < 0)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                        if (this.Second.Value > 65535)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Second.Value", "int", "second", "DSecond", false); throw;
                }
                try {
                    if (this.Offset != null) {
                        if (this.Offset.Value < -840)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                        if (this.Offset.Value > 840)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Offset.Value", "long", "offset", "DTimeOffset", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "DDateTime", null, "DDateTime", false); throw;
            }
        }

        /// <summary>
        /// Creates the deep copy of this object.
        /// </summary>
        /// <returns>A new object that is a deep copy of this instance.</returns>
        public override object Copy()
        {
            DDateTime obj0 = new DDateTime();
            {
                obj0.Year = this.Year;
            }
            {
                obj0.Month = this.Month;
            }
            {
                obj0.Day = this.Day;
            }
            {
                obj0.Hour = this.Hour;
            }
            {
                obj0.Minute = this.Minute;
            }
            {
                obj0.Second = this.Second;
            }
            {
                obj0.Offset = this.Offset;
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
                    int? data1 = this.Year;

                    if (data1 != null) {
                        prt.WriteLine();
                        first0 = false;
                        prt.Write("year ");
                        prt.Write(data1.Value);
                    }
                }
                {
                    int? data1 = this.Month;

                    if (data1 != null) {
                        prt.WriteLine(first0 ? "" : ",");
                        first0 = false;
                        prt.Write("month ");
                        prt.Write(data1.Value);
                    }
                }
                {
                    int? data1 = this.Day;

                    if (data1 != null) {
                        prt.WriteLine(first0 ? "" : ",");
                        first0 = false;
                        prt.Write("day ");
                        prt.Write(data1.Value);
                    }
                }
                {
                    int? data1 = this.Hour;

                    if (data1 != null) {
                        prt.WriteLine(first0 ? "" : ",");
                        first0 = false;
                        prt.Write("hour ");
                        prt.Write(data1.Value);
                    }
                }
                {
                    int? data1 = this.Minute;

                    if (data1 != null) {
                        prt.WriteLine(first0 ? "" : ",");
                        first0 = false;
                        prt.Write("minute ");
                        prt.Write(data1.Value);
                    }
                }
                {
                    int? data1 = this.Second;

                    if (data1 != null) {
                        prt.WriteLine(first0 ? "" : ",");
                        first0 = false;
                        prt.Write("second ");
                        prt.Write(data1.Value);
                    }
                }
                {
                    long? data1 = this.Offset;

                    if (data1 != null) {
                        prt.WriteLine(first0 ? "" : ",");
                        first0 = false;
                        prt.Write("offset ");
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

                if (this.Year != null)
                    optMask0[0] |= (byte)(0x80 >> 0);
                if (this.Month != null)
                    optMask0[0] |= (byte)(0x80 >> 1);
                if (this.Day != null)
                    optMask0[0] |= (byte)(0x80 >> 2);
                if (this.Hour != null)
                    optMask0[0] |= (byte)(0x80 >> 3);
                if (this.Minute != null)
                    optMask0[0] |= (byte)(0x80 >> 4);
                if (this.Second != null)
                    optMask0[0] |= (byte)(0x80 >> 5);
                if (this.Offset != null)
                    optMask0[0] |= (byte)(0x80 >> 6);
                enc.Output.WriteBits(optMask0, 0, 7);
                try {
                    if (this.Year != null)
                    {
                        if (enc.BitCount(this.Year.Value - 0) > 12 || this.Year.Value < 0)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.Year.Value);
                        enc.EncodeConstrainedInteger((this.Year.Value - (0)), 12);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Year.Value", "int", "year", "DYear", false); throw;
                }
                try {
                    if (this.Month != null)
                    {
                        if (enc.BitCount(this.Month.Value - 0) > 4 || this.Month.Value < 0)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.Month.Value);
                        enc.Output.Write4BitInt((this.Month.Value - (0)));
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Month.Value", "int", "month", "DMonth", false); throw;
                }
                try {
                    if (this.Day != null)
                    {
                        if (enc.BitCount(this.Day.Value - 0) > 5 || this.Day.Value < 0)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.Day.Value);
                        enc.Output.Write5BitInt((this.Day.Value - (0)));
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Day.Value", "int", "day", "DDay", false); throw;
                }
                try {
                    if (this.Hour != null)
                    {
                        if (enc.BitCount(this.Hour.Value - 0) > 5 || this.Hour.Value < 0)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.Hour.Value);
                        enc.Output.Write5BitInt((this.Hour.Value - (0)));
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Hour.Value", "int", "hour", "DHour", false); throw;
                }
                try {
                    if (this.Minute != null)
                    {
                        if (enc.BitCount(this.Minute.Value - 0) > 6 || this.Minute.Value < 0)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.Minute.Value);
                        enc.Output.Write6BitInt((this.Minute.Value - (0)));
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Minute.Value", "int", "minute", "DMinute", false); throw;
                }
                try {
                    if (this.Second != null)
                    {
                        if (enc.BitCount(this.Second.Value - 0) > 16 || this.Second.Value < 0)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.Second.Value);
                        enc.EncodeConstrainedInteger((this.Second.Value - (0)), 16);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Second.Value", "int", "second", "DSecond", false); throw;
                }
                try {
                    if (this.Offset != null)
                    {
                        if (enc.BitCount(this.Offset.Value - -840) > 11 || this.Offset.Value < -840)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.Offset.Value);
                        enc.EncodeConstrainedLongInteger((long)(this.Offset.Value - (-840)), 11);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Offset.Value", "long", "offset", "DTimeOffset", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "DDateTime", null, "DDateTime", false); throw;
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
                        this.Year = dec.DecodeConstrainedInteger(12, 0);
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "Year", "int", "year", "DYear", false); throw;
                    }
                }
                else
                {
                    this.Year = null;
                }
                if ((optMask0[0] & (0x80 >> 1)) != 0)
                {
                    try {
                        this.Month = 0 + dec.Input.Read4BitInt();
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "Month", "int", "month", "DMonth", false); throw;
                    }
                }
                else
                {
                    this.Month = null;
                }
                if ((optMask0[0] & (0x80 >> 2)) != 0)
                {
                    try {
                        this.Day = 0 + dec.Input.Read5BitInt();
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "Day", "int", "day", "DDay", false); throw;
                    }
                }
                else
                {
                    this.Day = null;
                }
                if ((optMask0[0] & (0x80 >> 3)) != 0)
                {
                    try {
                        this.Hour = 0 + dec.Input.Read5BitInt();
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "Hour", "int", "hour", "DHour", false); throw;
                    }
                }
                else
                {
                    this.Hour = null;
                }
                if ((optMask0[0] & (0x80 >> 4)) != 0)
                {
                    try {
                        this.Minute = 0 + dec.Input.Read6BitInt();
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "Minute", "int", "minute", "DMinute", false); throw;
                    }
                }
                else
                {
                    this.Minute = null;
                }
                if ((optMask0[0] & (0x80 >> 5)) != 0)
                {
                    try {
                        this.Second = dec.DecodeConstrainedInteger(16, 0);
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "Second", "int", "second", "DSecond", false); throw;
                    }
                }
                else
                {
                    this.Second = null;
                }
                if ((optMask0[0] & (0x80 >> 6)) != 0)
                {
                    try {
                        this.Offset = dec.DecodeConstrainedLongInteger(11, -840);
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "Offset", "long", "offset", "DTimeOffset", false); throw;
                    }
                }
                else
                {
                    this.Offset = null;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "DDateTime", null, "DDateTime", false); throw;
            }
        }
    }
}
