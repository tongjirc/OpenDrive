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
    /// Represents schema type 'PathHistory' (SEQUENCE)
    /// </summary>
    [System.Serializable]
    public partial class PathHistory : Oss.Asn1.BaseType
    {
        /// <summary>Field 'initialPosition'</summary>
        public FullPositionVector InitialPosition { get; set; }
        /// <summary>Field 'currGNSSstatus'</summary>
        public Oss.Asn1.BitStringWithNamedBits CurrGNSSstatus { get; set; }
        /// <summary>Field 'crumbData'</summary>
        public PathHistoryPointList CrumbData { get; set; }

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
            PathHistory that = right as PathHistory;
            if (InitialPosition != null) {
                if (!InitialPosition.Equals(that.InitialPosition))
                    return false;
            } else if (that.InitialPosition != null)
                return false;
            if (CurrGNSSstatus != null) {
                if (!CurrGNSSstatus.Equals(that.CurrGNSSstatus))
                    return false;
            } else if (that.CurrGNSSstatus != null)
                return false;
            if (CrumbData != null) {
                if (!Oss.Asn1.Internal.Comparer.CompareSeqOf(CrumbData, that.CrumbData))
                    return false;
            } else if (that.CrumbData != null)
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
            if (InitialPosition != null)
                hash ^= InitialPosition.GetHashCode();
            if (CurrGNSSstatus != null)
                hash ^= CurrGNSSstatus.GetHashCode();
            if (CrumbData != null)
                hash ^= Oss.Asn1.Internal.Comparer.HashSeqOf(CrumbData);
            return hash;
        }

        /// <summary>
        /// Returns the name of the ASN.1 schema type represented by this class.
        /// </summary>
        /// <returns>the string containing the name of the ASN.1 schema type.</returns>
        public override string GetAsn1TypeName()
        {
            return "PathHistory";
        }

        /// <summary>
        /// Asserts the validity of this object`s ASN.1 data.
        /// </summary>
        /// <exception cref="Oss.Asn1.Asn1InvalidDataException">Thrown if the instance contains invalid data.</exception>
        public override void Validate()
        {
            try {
                try {
                    if (this.InitialPosition != null) {
                        this.InitialPosition.Validate();
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "InitialPosition", "FullPositionVector", "initialPosition", "FullPositionVector", false); throw;
                }
                try {
                    if (this.CurrGNSSstatus != null) {
                        if (this.CurrGNSSstatus.Count != 8)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "CurrGNSSstatus", "Oss.Asn1.BitStringWithNamedBits", "currGNSSstatus", "GNSSstatus", false); throw;
                }
                try {
                    if (this.CrumbData == null)
                        throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._null_component_element);
                    this.CrumbData.Validate();
                    if (this.CrumbData.Count < 1)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                    if (this.CrumbData.Count > 23)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "CrumbData", "PathHistoryPointList", "crumbData", "PathHistoryPointList", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "PathHistory", null, "PathHistory", false); throw;
            }
        }

        /// <summary>
        /// Creates the deep copy of this object.
        /// </summary>
        /// <returns>A new object that is a deep copy of this instance.</returns>
        public override object Copy()
        {
            PathHistory obj0 = new PathHistory();
            {
                obj0.InitialPosition = Oss.Asn1.Internal.CopyUtil.CopyType(this.InitialPosition);
            }
            {
                obj0.CurrGNSSstatus = Oss.Asn1.Internal.CopyUtil.CopyBitString(this.CurrGNSSstatus);
            }
            {
                obj0.CrumbData = this.CrumbData == null ? null : (PathHistoryPointList)this.CrumbData.Copy();
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
                    FullPositionVector data1 = this.InitialPosition;

                    if (data1 != null) {
                        prt.WriteLine();
                        first0 = false;
                        prt.Write("initialPosition ");
                        prt.PrintContent(data1);
                    }
                }
                {
                    Oss.Asn1.BitStringWithNamedBits data1 = this.CurrGNSSstatus;

                    if (data1 != null) {
                        prt.WriteLine(first0 ? "" : ",");
                        first0 = false;
                        prt.Write("currGNSSstatus ");
                        prt.PrintBitString(data1, 
                            delegate(int index)
                            {
                                switch (index)
                                {
                                    case (int)0: return "unavailable";
                                    case (int)1: return "isHealthy";
                                    case (int)2: return "isMonitored";
                                    case (int)3: return "baseStationType";
                                    case (int)4: return "aPDOPofUnder5";
                                    case (int)5: return "inViewOfUnder5";
                                    case (int)6: return "localCorrectionsPresent";
                                    case (int)7: return "networkCorrectionsPresent";
                                }
                                return null;
                            }
                        );
                    }
                }
                {
                    PathHistoryPointList data1 = this.CrumbData;

                    prt.WriteLine(first0 ? "" : ",");
                    prt.Write("crumbData ");
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
                if (this.InitialPosition != null)
                    optMask0[0] |= (byte)(0x80 >> 0);
                if (this.CurrGNSSstatus != null)
                    optMask0[0] |= (byte)(0x80 >> 1);
                enc.Output.WriteBits(optMask0, 0, 2);
                try {
                    FullPositionVector data1 = this.InitialPosition;

                    if (data1 != null)
                    {
                        enc.EncodeType(data1);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "InitialPosition", "FullPositionVector", "initialPosition", "FullPositionVector", false); throw;
                }
                try {
                    if (this.CurrGNSSstatus != null)
                    {
                        int length1 = Oss.Asn1.Internal.MiscUtil.SearchGreaterOrEqual(_InternalMetadata.BerCodecMetaData.Ranges4, this.CurrGNSSstatus.LastOneBitPos() + 1);
                        enc.EncodeBitStringWithNamedBits(this.CurrGNSSstatus, length1, 8);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "CurrGNSSstatus", "Oss.Asn1.BitStringWithNamedBits", "currGNSSstatus", "GNSSstatus", false); throw;
                }
                try {
                    this.CrumbData.EncodePer(enc);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "CrumbData", "PathHistoryPointList", "crumbData", "PathHistoryPointList", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "PathHistory", null, "PathHistory", false); throw;
            }
        }

        protected override void DecodePer(Oss.Asn1.Internal.PerDecoder dec)
        {
            try {
                bool extPresent0 = dec.Input.ReadBool();
                byte[] optMask0 = new byte[1];

                dec.Input.ReadBits(optMask0, 2);
                if ((optMask0[0] & (0x80 >> 0)) != 0)
                {
                    try {
                        FullPositionVector data1 = new FullPositionVector();

                        dec.DecodeType(data1);
                        this.InitialPosition = data1;
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "InitialPosition", "FullPositionVector", "initialPosition", "FullPositionVector", false); throw;
                    }
                }
                else
                {
                    this.InitialPosition = null;
                }
                if ((optMask0[0] & (0x80 >> 1)) != 0)
                {
                    try {
                        this.CurrGNSSstatus = dec.DecodeBitStringWithNamedBits(8, _InternalMetadata.BerCodecMetaData.Ranges4);
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "CurrGNSSstatus", "Oss.Asn1.BitStringWithNamedBits", "currGNSSstatus", "GNSSstatus", false); throw;
                    }
                }
                else
                {
                    this.CurrGNSSstatus = null;
                }
                try {
                    PathHistoryPointList data1 = new PathHistoryPointList();

                    data1.DecodePer(dec);
                    this.CrumbData = data1;
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "CrumbData", "PathHistoryPointList", "crumbData", "PathHistoryPointList", false); throw;
                }
                if (extPresent0)
                {
                    int extMaskLen0 = 0;
                    byte[] extMask0 = dec.DecodeExtPreamble(out extMaskLen0);

                    dec.SkipUnknownExtensions(extMask0, extMaskLen0, 0);
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "PathHistory", null, "PathHistory", false); throw;
            }
        }
    }
}
