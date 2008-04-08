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


namespace VehStatus.DefPosition
{
    /// <summary>
    /// Represents schema type 'PositionConfidenceSet' (SEQUENCE)
    /// </summary>
    [System.Serializable]
    public partial class PositionConfidenceSet : Oss.Asn1.BaseType
    {
        /// <summary>Field 'pos'</summary>
        public PositionConfidence Pos { get; set; }
        /// <summary>Field 'elevation'</summary>
        public ElevationConfidence? Elevation { get; set; }

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
            PositionConfidenceSet that = right as PositionConfidenceSet;
            if (Pos != that.Pos)
                return false;
            if (Elevation != null) {
                if (Elevation != that.Elevation)
                    return false;
            } else if (that.Elevation != null)
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
            hash ^= Pos.GetHashCode();
            if (Elevation != null)
                hash ^= Elevation.GetHashCode();
            return hash;
        }

        /// <summary>
        /// Returns the name of the ASN.1 schema type represented by this class.
        /// </summary>
        /// <returns>the string containing the name of the ASN.1 schema type.</returns>
        public override string GetAsn1TypeName()
        {
            return "PositionConfidenceSet";
        }

        /// <summary>
        /// Asserts the validity of this object`s ASN.1 data.
        /// </summary>
        /// <exception cref="Oss.Asn1.Asn1InvalidDataException">Thrown if the instance contains invalid data.</exception>
        public override void Validate()
        {
            try {
                try {
                    switch (this.Pos)
                    {
                        case PositionConfidence.Unavailable:
                        case PositionConfidence.A500m:
                        case PositionConfidence.A200m:
                        case PositionConfidence.A100m:
                        case PositionConfidence.A50m:
                        case PositionConfidence.A20m:
                        case PositionConfidence.A10m:
                        case PositionConfidence.A5m:
                        case PositionConfidence.A2m:
                        case PositionConfidence.A1m:
                        case PositionConfidence.A50cm:
                        case PositionConfidence.A20cm:
                        case PositionConfidence.A10cm:
                        case PositionConfidence.A5cm:
                        case PositionConfidence.A2cm:
                        case PositionConfidence.A1cm:
                            break;
                        default:
                            throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._not_enumerated);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Pos", "PositionConfidence", "pos", "PositionConfidence", false); throw;
                }
                try {
                    if (this.Elevation != null) {
                        switch (this.Elevation.Value)
                        {
                            case ElevationConfidence.Unavailable:
                            case ElevationConfidence.Elev50000:
                            case ElevationConfidence.Elev20000:
                            case ElevationConfidence.Elev10000:
                            case ElevationConfidence.Elev05000:
                            case ElevationConfidence.Elev02000:
                            case ElevationConfidence.Elev01000:
                            case ElevationConfidence.Elev00500:
                            case ElevationConfidence.Elev00200:
                            case ElevationConfidence.Elev00100:
                            case ElevationConfidence.Elev00050:
                            case ElevationConfidence.Elev00020:
                            case ElevationConfidence.Elev00010:
                            case ElevationConfidence.Elev00005:
                            case ElevationConfidence.Elev00002:
                            case ElevationConfidence.Elev00001:
                                break;
                            default:
                                throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._not_enumerated);
                        }
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Elevation.Value", "ElevationConfidence", "elevation", "ElevationConfidence", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "PositionConfidenceSet", null, "PositionConfidenceSet", false); throw;
            }
        }

        /// <summary>
        /// Creates the deep copy of this object.
        /// </summary>
        /// <returns>A new object that is a deep copy of this instance.</returns>
        public override object Copy()
        {
            PositionConfidenceSet obj0 = new PositionConfidenceSet();
            {
                obj0.Pos = this.Pos;
            }
            {
                obj0.Elevation = this.Elevation;
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
                    prt.Write("pos ");
                    switch (this.Pos) {
                    case PositionConfidence.Unavailable:
                        prt.Write("unavailable");
                        break;
                    case PositionConfidence.A500m:
                        prt.Write("a500m");
                        break;
                    case PositionConfidence.A200m:
                        prt.Write("a200m");
                        break;
                    case PositionConfidence.A100m:
                        prt.Write("a100m");
                        break;
                    case PositionConfidence.A50m:
                        prt.Write("a50m");
                        break;
                    case PositionConfidence.A20m:
                        prt.Write("a20m");
                        break;
                    case PositionConfidence.A10m:
                        prt.Write("a10m");
                        break;
                    case PositionConfidence.A5m:
                        prt.Write("a5m");
                        break;
                    case PositionConfidence.A2m:
                        prt.Write("a2m");
                        break;
                    case PositionConfidence.A1m:
                        prt.Write("a1m");
                        break;
                    case PositionConfidence.A50cm:
                        prt.Write("a50cm");
                        break;
                    case PositionConfidence.A20cm:
                        prt.Write("a20cm");
                        break;
                    case PositionConfidence.A10cm:
                        prt.Write("a10cm");
                        break;
                    case PositionConfidence.A5cm:
                        prt.Write("a5cm");
                        break;
                    case PositionConfidence.A2cm:
                        prt.Write("a2cm");
                        break;
                    case PositionConfidence.A1cm:
                        prt.Write("a1cm");
                        break;
                    default:
                        prt.Write((int)this.Pos);
                        break;
                    }
                }
                {
                    ElevationConfidence? data1 = this.Elevation;

                    if (data1 != null) {
                        prt.WriteLine(",");
                        prt.Write("elevation ");
                        switch (data1.Value) {
                        case ElevationConfidence.Unavailable:
                            prt.Write("unavailable");
                            break;
                        case ElevationConfidence.Elev50000:
                            prt.Write("elev-500-00");
                            break;
                        case ElevationConfidence.Elev20000:
                            prt.Write("elev-200-00");
                            break;
                        case ElevationConfidence.Elev10000:
                            prt.Write("elev-100-00");
                            break;
                        case ElevationConfidence.Elev05000:
                            prt.Write("elev-050-00");
                            break;
                        case ElevationConfidence.Elev02000:
                            prt.Write("elev-020-00");
                            break;
                        case ElevationConfidence.Elev01000:
                            prt.Write("elev-010-00");
                            break;
                        case ElevationConfidence.Elev00500:
                            prt.Write("elev-005-00");
                            break;
                        case ElevationConfidence.Elev00200:
                            prt.Write("elev-002-00");
                            break;
                        case ElevationConfidence.Elev00100:
                            prt.Write("elev-001-00");
                            break;
                        case ElevationConfidence.Elev00050:
                            prt.Write("elev-000-50");
                            break;
                        case ElevationConfidence.Elev00020:
                            prt.Write("elev-000-20");
                            break;
                        case ElevationConfidence.Elev00010:
                            prt.Write("elev-000-10");
                            break;
                        case ElevationConfidence.Elev00005:
                            prt.Write("elev-000-05");
                            break;
                        case ElevationConfidence.Elev00002:
                            prt.Write("elev-000-02");
                            break;
                        case ElevationConfidence.Elev00001:
                            prt.Write("elev-000-01");
                            break;
                        default:
                            prt.Write((int)data1.Value);
                            break;
                        }
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

                if (this.Elevation != null)
                    optMask0[0] |= (byte)(0x80 >> 0);
                enc.Output.WriteBits(optMask0, 0, 1);
                try {
                    enc.EncodeEnum((int)this.Pos, _InternalMetadata.PerCodecMetaData.SortedEnum0);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Pos", "PositionConfidence", "pos", "PositionConfidence", false); throw;
                }
                try {
                    if (this.Elevation != null)
                    {
                        enc.EncodeEnum((int)this.Elevation.Value, _InternalMetadata.PerCodecMetaData.SortedEnum1);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Elevation.Value", "ElevationConfidence", "elevation", "ElevationConfidence", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "PositionConfidenceSet", null, "PositionConfidenceSet", false); throw;
            }
        }

        protected override void DecodePer(Oss.Asn1.Internal.PerDecoder dec)
        {
            try {
                byte[] optMask0 = new byte[1];

                dec.Input.ReadBits(optMask0, 1);
                try {
                    this.Pos = (PositionConfidence)dec.DecodeEnum(_InternalMetadata.PerCodecMetaData.SortedEnum0);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Pos", "PositionConfidence", "pos", "PositionConfidence", false); throw;
                }
                if ((optMask0[0] & (0x80 >> 0)) != 0)
                {
                    try {
                        this.Elevation = (ElevationConfidence)dec.DecodeEnum(_InternalMetadata.PerCodecMetaData.SortedEnum1);
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "Elevation", "ElevationConfidence", "elevation", "ElevationConfidence", false); throw;
                    }
                }
                else
                {
                    this.Elevation = null;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "PositionConfidenceSet", null, "PositionConfidenceSet", false); throw;
            }
        }
    }
}
