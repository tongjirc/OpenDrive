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


namespace VehStatus.DefMotion
{
    /// <summary>
    /// Represents schema type 'MotionConfidenceSet' (SEQUENCE)
    /// </summary>
    [System.Serializable]
    public partial class MotionConfidenceSet : Oss.Asn1.BaseType
    {
        /// <summary>Field 'speedCfd'</summary>
        public SpeedConfidence? SpeedCfd { get; set; }
        /// <summary>Field 'headingCfd'</summary>
        public HeadingConfidence? HeadingCfd { get; set; }
        /// <summary>Field 'steerCfd'</summary>
        public SteeringWheelAngleConfidence? SteerCfd { get; set; }

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
            MotionConfidenceSet that = right as MotionConfidenceSet;
            if (SpeedCfd != null) {
                if (SpeedCfd != that.SpeedCfd)
                    return false;
            } else if (that.SpeedCfd != null)
                return false;
            if (HeadingCfd != null) {
                if (HeadingCfd != that.HeadingCfd)
                    return false;
            } else if (that.HeadingCfd != null)
                return false;
            if (SteerCfd != null) {
                if (SteerCfd != that.SteerCfd)
                    return false;
            } else if (that.SteerCfd != null)
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
            if (SpeedCfd != null)
                hash ^= SpeedCfd.GetHashCode();
            if (HeadingCfd != null)
                hash ^= HeadingCfd.GetHashCode();
            if (SteerCfd != null)
                hash ^= SteerCfd.GetHashCode();
            return hash;
        }

        /// <summary>
        /// Returns the name of the ASN.1 schema type represented by this class.
        /// </summary>
        /// <returns>the string containing the name of the ASN.1 schema type.</returns>
        public override string GetAsn1TypeName()
        {
            return "MotionConfidenceSet";
        }

        /// <summary>
        /// Asserts the validity of this object`s ASN.1 data.
        /// </summary>
        /// <exception cref="Oss.Asn1.Asn1InvalidDataException">Thrown if the instance contains invalid data.</exception>
        public override void Validate()
        {
            try {
                try {
                    if (this.SpeedCfd != null) {
                        switch (this.SpeedCfd.Value)
                        {
                            case SpeedConfidence.Unavailable:
                            case SpeedConfidence.Prec100ms:
                            case SpeedConfidence.Prec10ms:
                            case SpeedConfidence.Prec5ms:
                            case SpeedConfidence.Prec1ms:
                            case SpeedConfidence.Prec01ms:
                            case SpeedConfidence.Prec005ms:
                            case SpeedConfidence.Prec001ms:
                                break;
                            default:
                                throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._not_enumerated);
                        }
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "SpeedCfd.Value", "SpeedConfidence", "speedCfd", "SpeedConfidence", false); throw;
                }
                try {
                    if (this.HeadingCfd != null) {
                        switch (this.HeadingCfd.Value)
                        {
                            case HeadingConfidence.Unavailable:
                            case HeadingConfidence.Prec10deg:
                            case HeadingConfidence.Prec05deg:
                            case HeadingConfidence.Prec01degId0:
                            case HeadingConfidence.Prec01degId:
                            case HeadingConfidence.Prec005deg:
                            case HeadingConfidence.Prec001deg:
                            case HeadingConfidence.Prec00125deg:
                                break;
                            default:
                                throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._not_enumerated);
                        }
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "HeadingCfd.Value", "HeadingConfidence", "headingCfd", "HeadingConfidence", false); throw;
                }
                try {
                    if (this.SteerCfd != null) {
                        switch (this.SteerCfd.Value)
                        {
                            case SteeringWheelAngleConfidence.Unavailable:
                            case SteeringWheelAngleConfidence.Prec2deg:
                            case SteeringWheelAngleConfidence.Prec1deg:
                            case SteeringWheelAngleConfidence.Prec002deg:
                                break;
                            default:
                                throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._not_enumerated);
                        }
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "SteerCfd.Value", "SteeringWheelAngleConfidence", "steerCfd", "SteeringWheelAngleConfidence", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "MotionConfidenceSet", null, "MotionConfidenceSet", false); throw;
            }
        }

        /// <summary>
        /// Creates the deep copy of this object.
        /// </summary>
        /// <returns>A new object that is a deep copy of this instance.</returns>
        public override object Copy()
        {
            MotionConfidenceSet obj0 = new MotionConfidenceSet();
            {
                obj0.SpeedCfd = this.SpeedCfd;
            }
            {
                obj0.HeadingCfd = this.HeadingCfd;
            }
            {
                obj0.SteerCfd = this.SteerCfd;
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
                    SpeedConfidence? data1 = this.SpeedCfd;

                    if (data1 != null) {
                        prt.WriteLine();
                        first0 = false;
                        prt.Write("speedCfd ");
                        switch (data1.Value) {
                        case SpeedConfidence.Unavailable:
                            prt.Write("unavailable");
                            break;
                        case SpeedConfidence.Prec100ms:
                            prt.Write("prec100ms");
                            break;
                        case SpeedConfidence.Prec10ms:
                            prt.Write("prec10ms");
                            break;
                        case SpeedConfidence.Prec5ms:
                            prt.Write("prec5ms");
                            break;
                        case SpeedConfidence.Prec1ms:
                            prt.Write("prec1ms");
                            break;
                        case SpeedConfidence.Prec01ms:
                            prt.Write("prec0-1ms");
                            break;
                        case SpeedConfidence.Prec005ms:
                            prt.Write("prec0-05ms");
                            break;
                        case SpeedConfidence.Prec001ms:
                            prt.Write("prec0-01ms");
                            break;
                        default:
                            prt.Write((int)data1.Value);
                            break;
                        }
                    }
                }
                {
                    HeadingConfidence? data1 = this.HeadingCfd;

                    if (data1 != null) {
                        prt.WriteLine(first0 ? "" : ",");
                        first0 = false;
                        prt.Write("headingCfd ");
                        switch (data1.Value) {
                        case HeadingConfidence.Unavailable:
                            prt.Write("unavailable");
                            break;
                        case HeadingConfidence.Prec10deg:
                            prt.Write("prec10deg");
                            break;
                        case HeadingConfidence.Prec05deg:
                            prt.Write("prec05deg");
                            break;
                        case HeadingConfidence.Prec01degId0:
                            prt.Write("prec01deg");
                            break;
                        case HeadingConfidence.Prec01degId:
                            prt.Write("prec0-1deg");
                            break;
                        case HeadingConfidence.Prec005deg:
                            prt.Write("prec0-05deg");
                            break;
                        case HeadingConfidence.Prec001deg:
                            prt.Write("prec0-01deg");
                            break;
                        case HeadingConfidence.Prec00125deg:
                            prt.Write("prec0-0125deg");
                            break;
                        default:
                            prt.Write((int)data1.Value);
                            break;
                        }
                    }
                }
                {
                    SteeringWheelAngleConfidence? data1 = this.SteerCfd;

                    if (data1 != null) {
                        prt.WriteLine(first0 ? "" : ",");
                        first0 = false;
                        prt.Write("steerCfd ");
                        switch (data1.Value) {
                        case SteeringWheelAngleConfidence.Unavailable:
                            prt.Write("unavailable");
                            break;
                        case SteeringWheelAngleConfidence.Prec2deg:
                            prt.Write("prec2deg");
                            break;
                        case SteeringWheelAngleConfidence.Prec1deg:
                            prt.Write("prec1deg");
                            break;
                        case SteeringWheelAngleConfidence.Prec002deg:
                            prt.Write("prec0-02deg");
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

                if (this.SpeedCfd != null)
                    optMask0[0] |= (byte)(0x80 >> 0);
                if (this.HeadingCfd != null)
                    optMask0[0] |= (byte)(0x80 >> 1);
                if (this.SteerCfd != null)
                    optMask0[0] |= (byte)(0x80 >> 2);
                enc.Output.WriteBits(optMask0, 0, 3);
                try {
                    if (this.SpeedCfd != null)
                    {
                        enc.EncodeEnum((int)this.SpeedCfd.Value, _InternalMetadata.PerCodecMetaData.SortedEnum3);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "SpeedCfd.Value", "SpeedConfidence", "speedCfd", "SpeedConfidence", false); throw;
                }
                try {
                    if (this.HeadingCfd != null)
                    {
                        enc.EncodeEnum((int)this.HeadingCfd.Value, _InternalMetadata.PerCodecMetaData.SortedEnum4);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "HeadingCfd.Value", "HeadingConfidence", "headingCfd", "HeadingConfidence", false); throw;
                }
                try {
                    if (this.SteerCfd != null)
                    {
                        enc.EncodeEnum((int)this.SteerCfd.Value, _InternalMetadata.PerCodecMetaData.SortedEnum5);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "SteerCfd.Value", "SteeringWheelAngleConfidence", "steerCfd", "SteeringWheelAngleConfidence", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "MotionConfidenceSet", null, "MotionConfidenceSet", false); throw;
            }
        }

        protected override void DecodePer(Oss.Asn1.Internal.PerDecoder dec)
        {
            try {
                byte[] optMask0 = new byte[1];

                dec.Input.ReadBits(optMask0, 3);
                if ((optMask0[0] & (0x80 >> 0)) != 0)
                {
                    try {
                        this.SpeedCfd = (SpeedConfidence)dec.DecodeEnum(_InternalMetadata.PerCodecMetaData.SortedEnum3);
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "SpeedCfd", "SpeedConfidence", "speedCfd", "SpeedConfidence", false); throw;
                    }
                }
                else
                {
                    this.SpeedCfd = null;
                }
                if ((optMask0[0] & (0x80 >> 1)) != 0)
                {
                    try {
                        this.HeadingCfd = (HeadingConfidence)dec.DecodeEnum(_InternalMetadata.PerCodecMetaData.SortedEnum4);
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "HeadingCfd", "HeadingConfidence", "headingCfd", "HeadingConfidence", false); throw;
                    }
                }
                else
                {
                    this.HeadingCfd = null;
                }
                if ((optMask0[0] & (0x80 >> 2)) != 0)
                {
                    try {
                        this.SteerCfd = (SteeringWheelAngleConfidence)dec.DecodeEnum(_InternalMetadata.PerCodecMetaData.SortedEnum5);
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "SteerCfd", "SteeringWheelAngleConfidence", "steerCfd", "SteeringWheelAngleConfidence", false); throw;
                    }
                }
                else
                {
                    this.SteerCfd = null;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "MotionConfidenceSet", null, "MotionConfidenceSet", false); throw;
            }
        }
    }
}
