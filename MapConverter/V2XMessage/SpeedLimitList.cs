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


namespace VehStatus.MapSpeedLimit
{
    /// <summary>
    /// Represents schema type 'SpeedLimitList' (SEQUENCE OF)
    /// </summary>
    [System.Serializable]
    public partial class SpeedLimitList : System.Collections.Generic.List<RegulatorySpeedLimit>
    {
        /// <summary>
        /// Initializes a new instance of the SpeedLimitList class that is empty and has the default initial capacity.
        /// </summary>
        public SpeedLimitList() : base() {}
        /// <summary>
        /// Initializes a new instance of the SpeedLimitList class that contains elements copied from the specified collection
        /// and has sufficient capacity to accommodate the number of elements copied.
        /// <param name="collection">The collection whose elements are copied to the new SpeedLimitList.</param>
        /// </summary>
        public SpeedLimitList(System.Collections.Generic.IEnumerable<RegulatorySpeedLimit> collection) : base(collection) {}
        /// <summary>
        /// Initializes a new instance of the SpeedLimitList class that is empty and has the specified capacity.
        /// <param name="capacity">The number of elements that the new SpeedLimitList can initially store.</param>
        /// </summary>
        public SpeedLimitList(int capacity) : base(capacity) {}


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
            SpeedLimitList that = right as SpeedLimitList;
            return Oss.Asn1.Internal.Comparer.CompareSeqOf(this, that);
        }
        /// <summary>
        /// Serves as a hash function for a particular type.
        /// </summary>
        /// <returns>A hash code for the current object.</returns>
        public override int GetHashCode()
        {
            return GetType().GetHashCode() ^ Oss.Asn1.Internal.Comparer.HashSeqOf(this);
        }

        public override string ToString()
        {
            return Oss.Asn1.BaseType.ToString(PrintAsn1ValueNotation);
        }

        /// <summary>
        /// Asserts the validity of this object`s ASN.1 data.
        /// </summary>
        /// <exception cref="Oss.Asn1.Asn1InvalidDataException">Thrown if the instance contains invalid data.</exception>
        public void Validate()
        {
            try {
                for (int i1 = 0; i1 < this.Count; i1++)
                {
                    try {
                        this[i1].Validate();
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, System.String.Format("[{0}]", i1), "RegulatorySpeedLimit", "#" + i1.ToString(), "RegulatorySpeedLimit", false); throw;
                    }
                }
                if (this.Count < 1)
                    throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                if (this.Count > 9)
                    throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "SpeedLimitList", null, "SpeedLimitList", false); throw;
            }
        }

        /// <summary>
        /// Creates the deep copy of this object.
        /// </summary>
        /// <returns>A new object that is a deep copy of this instance.</returns>
        public object Copy()
        {
            SpeedLimitList obj0 = new SpeedLimitList();
            for (int i0 = 0; i0 < this.Count; i0++) {
                obj0.Add(Oss.Asn1.Internal.CopyUtil.CopyType(this[i0]));
            }
            return obj0;
        }

        public void PrintAsn1ValueNotation(Oss.Asn1.Internal.ValueNotationHelper prt)
        {
            try
            {
                prt.BeginConstructedValue();
                for (int i1 = 0; i1 < this.Count; i1++) {
                    if (i1 != 0)
                        prt.Write(",");
                    if (this[i1] == null)
                        prt.Write("<<<NULL>>>");
                    else {
                        prt.PrintContent(this[i1]);
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

        public void EncodePer(Oss.Asn1.Internal.PerEncoder enc)
        {
            try {
                int i0 = 0;
                if (this.Count < 1 || this.Count > 9)
                    throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint, ", length of value = " + this.Count);
                enc.EncodeConstrainedLength(this.Count, 1, 9);
                for (i0 = 0; i0 < this.Count; i0++)
                {
                    try {
                        enc.EncodeType(this[i0]);
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, System.String.Format("[{0}]", i0), "RegulatorySpeedLimit", "#" + i0.ToString(), "RegulatorySpeedLimit", false); throw;
                    }
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "SpeedLimitList", null, "SpeedLimitList", false); throw;
            }
        }

        public void DecodePer(Oss.Asn1.Internal.PerDecoder dec)
        {
            try {
                int i0 = 0;
                int fragcount0 = 0;
                int fraglast0 = 65536;
                while (true)
                {
                    fragcount0 = dec.DecodeConstrainedLength(1, 9, ref fraglast0);
                    for (i0 = 0; i0 < fragcount0; i0++)
                    {
                        try {
                            RegulatorySpeedLimit data1 = new RegulatorySpeedLimit();

                            dec.DecodeType(data1);
                            this.Add(data1);
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, System.String.Format("[{0}]", this.Count), "RegulatorySpeedLimit", "#" + this.Count.ToString(), "RegulatorySpeedLimit", false); throw;
                        }
                    }
                    if (fraglast0 < 0)
                        break;
                    fraglast0 = fragcount0;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "SpeedLimitList", null, "SpeedLimitList", false); throw;
            }
        }
    }
}
