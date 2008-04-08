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


namespace VehStatus.SignalPhaseAndTiming
{
    /// <summary>
    /// Represents schema type 'SPAT' (SEQUENCE)
    /// </summary>
    [System.Serializable]
    public partial class SPAT : Oss.Asn1.BaseType
    {
        /// <summary>Field 'msgCnt'</summary>
        public int MsgCnt { get; set; }
        /// <summary>Field 'timeStamp'</summary>
        public int? TimeStamp { get; set; }
        /// <summary>Field 'name'</summary>
        public string Name { get; set; }
        /// <summary>Field 'intersections'</summary>
        public SPATIntersectionState.IntersectionStateList Intersections { get; set; }

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
            SPAT that = right as SPAT;
            if (MsgCnt != that.MsgCnt)
                return false;
            if (TimeStamp != null) {
                if (TimeStamp != that.TimeStamp)
                    return false;
            } else if (that.TimeStamp != null)
                return false;
            if (Name != null) {
                if (!Name.Equals(that.Name))
                    return false;
            } else if (that.Name != null)
                return false;
            if (Intersections != null) {
                if (!Oss.Asn1.Internal.Comparer.CompareSeqOf(Intersections, that.Intersections))
                    return false;
            } else if (that.Intersections != null)
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
            hash ^= MsgCnt.GetHashCode();
            if (TimeStamp != null)
                hash ^= TimeStamp.GetHashCode();
            if (Name != null)
                hash ^= Name.GetHashCode();
            if (Intersections != null)
                hash ^= Oss.Asn1.Internal.Comparer.HashSeqOf(Intersections);
            return hash;
        }

        /// <summary>
        /// Returns the name of the ASN.1 schema type represented by this class.
        /// </summary>
        /// <returns>the string containing the name of the ASN.1 schema type.</returns>
        public override string GetAsn1TypeName()
        {
            return "SPAT";
        }

        /// <summary>
        /// Asserts the validity of this object`s ASN.1 data.
        /// </summary>
        /// <exception cref="Oss.Asn1.Asn1InvalidDataException">Thrown if the instance contains invalid data.</exception>
        public override void Validate()
        {
            try {
                try {
                    if (this.MsgCnt < 0)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    if (this.MsgCnt > 127)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "MsgCnt", "int", "msgCnt", "MsgCount", false); throw;
                }
                try {
                    if (this.TimeStamp != null) {
                        if (this.TimeStamp.Value < 0)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                        if (this.TimeStamp.Value > 527040)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "TimeStamp.Value", "int", "timeStamp", "MinuteOfTheYear", false); throw;
                }
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
                    if (this.Intersections == null)
                        throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._null_component_element);
                    this.Intersections.Validate();
                    if (this.Intersections.Count < 1)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                    if (this.Intersections.Count > 32)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Intersections", "SPATIntersectionState.IntersectionStateList", "intersections", "IntersectionStateList", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "SPAT", null, "SPAT", false); throw;
            }
        }

        /// <summary>
        /// Creates the deep copy of this object.
        /// </summary>
        /// <returns>A new object that is a deep copy of this instance.</returns>
        public override object Copy()
        {
            SPAT obj0 = new SPAT();
            {
                obj0.MsgCnt = this.MsgCnt;
            }
            {
                obj0.TimeStamp = this.TimeStamp;
            }
            {
                obj0.Name = this.Name;
            }
            {
                obj0.Intersections = this.Intersections == null ? null : (SPATIntersectionState.IntersectionStateList)this.Intersections.Copy();
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
                    prt.Write("msgCnt ");
                    prt.Write(this.MsgCnt);
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
                    string data1 = this.Name;

                    if (data1 != null) {
                        prt.WriteLine(",");
                        prt.Write("name ");
                        prt.PrintString(data1);
                    }
                }
                {
                    SPATIntersectionState.IntersectionStateList data1 = this.Intersections;

                    prt.WriteLine(",");
                    prt.Write("intersections ");
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
                if (this.TimeStamp != null)
                    optMask0[0] |= (byte)(0x80 >> 0);
                if (this.Name != null)
                    optMask0[0] |= (byte)(0x80 >> 1);
                enc.Output.WriteBits(optMask0, 0, 2);
                try {
                    if (enc.BitCount(this.MsgCnt - 0) > 7 || this.MsgCnt < 0)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.MsgCnt);
                    enc.Output.Write7BitInt((this.MsgCnt - (0)));
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "MsgCnt", "int", "msgCnt", "MsgCount", false); throw;
                }
                try {
                    if (this.TimeStamp != null)
                    {
                        if (enc.BitCount(this.TimeStamp.Value - 0) > 20 || this.TimeStamp.Value < 0)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.TimeStamp.Value);
                        enc.EncodeConstrainedInteger((this.TimeStamp.Value - (0)), 20);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "TimeStamp.Value", "int", "timeStamp", "MinuteOfTheYear", false); throw;
                }
                try {
                    if (this.Name != null)
                    {
                        enc.EncodeKMCString(this.Name, 1, 63, _InternalMetadata.CommonMetaData.S0);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Name", "string", "name", "DescriptiveName", false); throw;
                }
                try {
                    this.Intersections.EncodePer(enc);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Intersections", "SPATIntersectionState.IntersectionStateList", "intersections", "IntersectionStateList", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "SPAT", null, "SPAT", false); throw;
            }
        }

        protected override void DecodePer(Oss.Asn1.Internal.PerDecoder dec)
        {
            try {
                bool extPresent0 = dec.Input.ReadBool();
                byte[] optMask0 = new byte[1];

                dec.Input.ReadBits(optMask0, 2);
                try {
                    this.MsgCnt = 0 + dec.Input.Read7BitInt();
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "MsgCnt", "int", "msgCnt", "MsgCount", false); throw;
                }
                if ((optMask0[0] & (0x80 >> 0)) != 0)
                {
                    try {
                        this.TimeStamp = dec.DecodeConstrainedInteger(20, 0);
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "TimeStamp", "int", "timeStamp", "MinuteOfTheYear", false); throw;
                    }
                }
                else
                {
                    this.TimeStamp = null;
                }
                if ((optMask0[0] & (0x80 >> 1)) != 0)
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
                    SPATIntersectionState.IntersectionStateList data1 = new SPATIntersectionState.IntersectionStateList();

                    data1.DecodePer(dec);
                    this.Intersections = data1;
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Intersections", "SPATIntersectionState.IntersectionStateList", "intersections", "IntersectionStateList", false); throw;
                }
                if (extPresent0)
                {
                    int extMaskLen0 = 0;
                    byte[] extMask0 = dec.DecodeExtPreamble(out extMaskLen0);

                    dec.SkipUnknownExtensions(extMask0, extMaskLen0, 0);
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "SPAT", null, "SPAT", false); throw;
            }
        }
    }
}
