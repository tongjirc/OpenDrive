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


namespace VehStatus.RSM
{
    /// <summary>
    /// Represents schema type 'ParticipantData' (SEQUENCE)
    /// </summary>
    [System.Serializable]
    public partial class ParticipantData : Oss.Asn1.BaseType
    {
        /// <summary>Field 'ptcType'</summary>
        public ParticipantType PtcType { get; set; }
        /// <summary>Field 'ptcId'</summary>
        public int PtcId { get; set; }
        /// <summary>Field 'source'</summary>
        public SourceType Source { get; set; }
        /// <summary>Field 'id'</summary>
        public byte[] Id { get; set; }
        /// <summary>Field 'plateNo'</summary>
        public byte[] PlateNo { get; set; }
        /// <summary>Field 'secMark'</summary>
        public int SecMark { get; set; }
        /// <summary>Field 'pos'</summary>
        public DefPositionOffset.PositionOffsetLLV Pos { get; set; }
        /// <summary>Field 'accuracy'</summary>
        public DefPosition.PositionConfidenceSet Accuracy { get; set; }
        /// <summary>Field 'transmission'</summary>
        public VehStatusModule.TransmissionState? Transmission { get; set; }
        /// <summary>Field 'speed'</summary>
        public int Speed { get; set; }
        /// <summary>Field 'heading'</summary>
        public int Heading { get; set; }
        /// <summary>Field 'angle'</summary>
        public long? Angle { get; set; }
        /// <summary>Field 'motionCfd'</summary>
        public DefMotion.MotionConfidenceSet MotionCfd { get; set; }
        /// <summary>Field 'accelSet'</summary>
        public DefAcceleration.AccelerationSet4Way AccelSet { get; set; }
        /// <summary>Field 'size'</summary>
        public VehSize.VehicleSize Size { get; set; }
        /// <summary>Field 'vehicleClass'</summary>
        public VehClass.VehicleClassification VehicleClass { get; set; }

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
            ParticipantData that = right as ParticipantData;
            if (PtcType != that.PtcType)
                return false;
            if (PtcId != that.PtcId)
                return false;
            if (Source != that.Source)
                return false;
            if (Id != null) {
                if (!Oss.Asn1.Internal.Comparer.CompareArrays(Id, that.Id))
                    return false;
            } else if (that.Id != null)
                return false;
            if (PlateNo != null) {
                if (!Oss.Asn1.Internal.Comparer.CompareArrays(PlateNo, that.PlateNo))
                    return false;
            } else if (that.PlateNo != null)
                return false;
            if (SecMark != that.SecMark)
                return false;
            if (Pos != null) {
                if (!Pos.Equals(that.Pos))
                    return false;
            } else if (that.Pos != null)
                return false;
            if (Accuracy != null) {
                if (!Accuracy.Equals(that.Accuracy))
                    return false;
            } else if (that.Accuracy != null)
                return false;
            if (Transmission != null) {
                if (Transmission != that.Transmission)
                    return false;
            } else if (that.Transmission != null)
                return false;
            if (Speed != that.Speed)
                return false;
            if (Heading != that.Heading)
                return false;
            if (Angle != null) {
                if (Angle != that.Angle)
                    return false;
            } else if (that.Angle != null)
                return false;
            if (MotionCfd != null) {
                if (!MotionCfd.Equals(that.MotionCfd))
                    return false;
            } else if (that.MotionCfd != null)
                return false;
            if (AccelSet != null) {
                if (!AccelSet.Equals(that.AccelSet))
                    return false;
            } else if (that.AccelSet != null)
                return false;
            if (Size != null) {
                if (!Size.Equals(that.Size))
                    return false;
            } else if (that.Size != null)
                return false;
            if (VehicleClass != null) {
                if (!VehicleClass.Equals(that.VehicleClass))
                    return false;
            } else if (that.VehicleClass != null)
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
            hash ^= PtcType.GetHashCode();
            hash ^= PtcId.GetHashCode();
            hash ^= Source.GetHashCode();
            if (Id != null)
                hash ^= Oss.Asn1.Internal.Comparer.HashArray(Id);
            if (PlateNo != null)
                hash ^= Oss.Asn1.Internal.Comparer.HashArray(PlateNo);
            hash ^= SecMark.GetHashCode();
            if (Pos != null)
                hash ^= Pos.GetHashCode();
            if (Accuracy != null)
                hash ^= Accuracy.GetHashCode();
            if (Transmission != null)
                hash ^= Transmission.GetHashCode();
            hash ^= Speed.GetHashCode();
            hash ^= Heading.GetHashCode();
            if (Angle != null)
                hash ^= Angle.GetHashCode();
            if (MotionCfd != null)
                hash ^= MotionCfd.GetHashCode();
            if (AccelSet != null)
                hash ^= AccelSet.GetHashCode();
            if (Size != null)
                hash ^= Size.GetHashCode();
            if (VehicleClass != null)
                hash ^= VehicleClass.GetHashCode();
            return hash;
        }

        /// <summary>
        /// Returns the name of the ASN.1 schema type represented by this class.
        /// </summary>
        /// <returns>the string containing the name of the ASN.1 schema type.</returns>
        public override string GetAsn1TypeName()
        {
            return "ParticipantData";
        }

        /// <summary>
        /// Asserts the validity of this object`s ASN.1 data.
        /// </summary>
        /// <exception cref="Oss.Asn1.Asn1InvalidDataException">Thrown if the instance contains invalid data.</exception>
        public override void Validate()
        {
            try {
                try {
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "PtcType", "ParticipantType", "ptcType", "ParticipantType", false); throw;
                }
                try {
                    if (this.PtcId < 0)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    if (this.PtcId > 65535)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "PtcId", "int", "ptcId", "INTEGER", false); throw;
                }
                try {
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Source", "SourceType", "source", "SourceType", false); throw;
                }
                try {
                    if (this.Id != null) {
                        if (this.Id.Length != 8)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Id", "byte[]", "id", "OCTET STRING", false); throw;
                }
                try {
                    if (this.PlateNo != null) {
                        if (this.PlateNo.Length < 4)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                        if (this.PlateNo.Length > 16)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "PlateNo", "byte[]", "plateNo", "OCTET STRING", false); throw;
                }
                try {
                    if (this.SecMark < 0)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    if (this.SecMark > 65535)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "SecMark", "int", "secMark", "DSecond", false); throw;
                }
                try {
                    if (this.Pos == null)
                        throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._null_component_element);
                    this.Pos.Validate();
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Pos", "DefPositionOffset.PositionOffsetLLV", "pos", "PositionOffsetLLV", false); throw;
                }
                try {
                    if (this.Accuracy == null)
                        throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._null_component_element);
                    this.Accuracy.Validate();
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Accuracy", "DefPosition.PositionConfidenceSet", "accuracy", "PositionConfidenceSet", false); throw;
                }
                try {
                    if (this.Transmission != null) {
                        switch (this.Transmission.Value)
                        {
                            case VehStatusModule.TransmissionState.Neutral:
                            case VehStatusModule.TransmissionState.Park:
                            case VehStatusModule.TransmissionState.ForwardGears:
                            case VehStatusModule.TransmissionState.ReverseGears:
                            case VehStatusModule.TransmissionState.Reserved1:
                            case VehStatusModule.TransmissionState.Reserved2:
                            case VehStatusModule.TransmissionState.Reserved3:
                            case VehStatusModule.TransmissionState.Unavailable:
                                break;
                            default:
                                throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._not_enumerated);
                        }
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Transmission.Value", "VehStatusModule.TransmissionState", "transmission", "TransmissionState", false); throw;
                }
                try {
                    if (this.Speed < 0)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    if (this.Speed > 8191)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Speed", "int", "speed", "Speed", false); throw;
                }
                try {
                    if (this.Heading < 0)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    if (this.Heading > 28800)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Heading", "int", "heading", "Heading", false); throw;
                }
                try {
                    if (this.Angle != null) {
                        if (this.Angle.Value < -126)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                        if (this.Angle.Value > 127)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Angle.Value", "long", "angle", "SteeringWheelAngle", false); throw;
                }
                try {
                    if (this.MotionCfd != null) {
                        this.MotionCfd.Validate();
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "MotionCfd", "DefMotion.MotionConfidenceSet", "motionCfd", "MotionConfidenceSet", false); throw;
                }
                try {
                    if (this.AccelSet != null) {
                        this.AccelSet.Validate();
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "AccelSet", "DefAcceleration.AccelerationSet4Way", "accelSet", "AccelerationSet4Way", false); throw;
                }
                try {
                    if (this.Size == null)
                        throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._null_component_element);
                    this.Size.Validate();
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Size", "VehSize.VehicleSize", "size", "VehicleSize", false); throw;
                }
                try {
                    if (this.VehicleClass != null) {
                        this.VehicleClass.Validate();
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "VehicleClass", "VehClass.VehicleClassification", "vehicleClass", "VehicleClassification", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "ParticipantData", null, "ParticipantData", false); throw;
            }
        }

        /// <summary>
        /// Creates the deep copy of this object.
        /// </summary>
        /// <returns>A new object that is a deep copy of this instance.</returns>
        public override object Copy()
        {
            ParticipantData obj0 = new ParticipantData();
            {
                obj0.PtcType = this.PtcType;
            }
            {
                obj0.PtcId = this.PtcId;
            }
            {
                obj0.Source = this.Source;
            }
            {
                obj0.Id = Oss.Asn1.Internal.CopyUtil.CopyByteArray(this.Id);
            }
            {
                obj0.PlateNo = Oss.Asn1.Internal.CopyUtil.CopyByteArray(this.PlateNo);
            }
            {
                obj0.SecMark = this.SecMark;
            }
            {
                obj0.Pos = Oss.Asn1.Internal.CopyUtil.CopyType(this.Pos);
            }
            {
                obj0.Accuracy = Oss.Asn1.Internal.CopyUtil.CopyType(this.Accuracy);
            }
            {
                obj0.Transmission = this.Transmission;
            }
            {
                obj0.Speed = this.Speed;
            }
            {
                obj0.Heading = this.Heading;
            }
            {
                obj0.Angle = this.Angle;
            }
            {
                obj0.MotionCfd = Oss.Asn1.Internal.CopyUtil.CopyType(this.MotionCfd);
            }
            {
                obj0.AccelSet = Oss.Asn1.Internal.CopyUtil.CopyType(this.AccelSet);
            }
            {
                obj0.Size = Oss.Asn1.Internal.CopyUtil.CopyType(this.Size);
            }
            {
                obj0.VehicleClass = Oss.Asn1.Internal.CopyUtil.CopyType(this.VehicleClass);
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
                    prt.Write("ptcType ");
                    switch (this.PtcType) {
                    case ParticipantType.Unknown:
                        prt.Write("unknown");
                        break;
                    case ParticipantType.Motor:
                        prt.Write("motor");
                        break;
                    case ParticipantType.NonMotor:
                        prt.Write("non-motor");
                        break;
                    case ParticipantType.Pedestrian:
                        prt.Write("pedestrian");
                        break;
                    case ParticipantType.Rsu:
                        prt.Write("rsu");
                        break;
                    default:
                        prt.Write((int)this.PtcType);
                        break;
                    }
                }
                {
                    prt.WriteLine(",");
                    prt.Write("ptcId ");
                    prt.Write(this.PtcId);
                }
                {
                    prt.WriteLine(",");
                    prt.Write("source ");
                    switch (this.Source) {
                    case SourceType.Unknown:
                        prt.Write("unknown");
                        break;
                    case SourceType.Selfinfo:
                        prt.Write("selfinfo");
                        break;
                    case SourceType.V2x:
                        prt.Write("v2x");
                        break;
                    case SourceType.Video:
                        prt.Write("video");
                        break;
                    case SourceType.MicrowaveRadar:
                        prt.Write("microwaveRadar");
                        break;
                    case SourceType.Loop:
                        prt.Write("loop");
                        break;
                    default:
                        prt.Write((int)this.Source);
                        break;
                    }
                }
                {
                    byte[] data1 = this.Id;

                    if (data1 != null) {
                        prt.WriteLine(",");
                        prt.Write("id ");
                        prt.PrintOctetString(data1);
                    }
                }
                {
                    byte[] data1 = this.PlateNo;

                    if (data1 != null) {
                        prt.WriteLine(",");
                        prt.Write("plateNo ");
                        prt.PrintOctetString(data1);
                    }
                }
                {
                    prt.WriteLine(",");
                    prt.Write("secMark ");
                    prt.Write(this.SecMark);
                }
                {
                    prt.WriteLine(",");
                    prt.Write("pos ");
                    if (this.Pos == null)
                        prt.Write("<<<NULL>>>");
                    else {
                        prt.PrintContent(this.Pos);
                    }
                }
                {
                    prt.WriteLine(",");
                    prt.Write("accuracy ");
                    if (this.Accuracy == null)
                        prt.Write("<<<NULL>>>");
                    else {
                        prt.PrintContent(this.Accuracy);
                    }
                }
                {
                    VehStatusModule.TransmissionState? data1 = this.Transmission;

                    if (data1 != null) {
                        prt.WriteLine(",");
                        prt.Write("transmission ");
                        switch (data1.Value) {
                        case VehStatusModule.TransmissionState.Neutral:
                            prt.Write("neutral");
                            break;
                        case VehStatusModule.TransmissionState.Park:
                            prt.Write("park");
                            break;
                        case VehStatusModule.TransmissionState.ForwardGears:
                            prt.Write("forwardGears");
                            break;
                        case VehStatusModule.TransmissionState.ReverseGears:
                            prt.Write("reverseGears");
                            break;
                        case VehStatusModule.TransmissionState.Reserved1:
                            prt.Write("reserved1");
                            break;
                        case VehStatusModule.TransmissionState.Reserved2:
                            prt.Write("reserved2");
                            break;
                        case VehStatusModule.TransmissionState.Reserved3:
                            prt.Write("reserved3");
                            break;
                        case VehStatusModule.TransmissionState.Unavailable:
                            prt.Write("unavailable");
                            break;
                        default:
                            prt.Write((int)data1.Value);
                            break;
                        }
                    }
                }
                {
                    prt.WriteLine(",");
                    prt.Write("speed ");
                    prt.Write(this.Speed);
                }
                {
                    prt.WriteLine(",");
                    prt.Write("heading ");
                    prt.Write(this.Heading);
                }
                {
                    long? data1 = this.Angle;

                    if (data1 != null) {
                        prt.WriteLine(",");
                        prt.Write("angle ");
                        prt.Write(data1.Value);
                    }
                }
                {
                    DefMotion.MotionConfidenceSet data1 = this.MotionCfd;

                    if (data1 != null) {
                        prt.WriteLine(",");
                        prt.Write("motionCfd ");
                        prt.PrintContent(data1);
                    }
                }
                {
                    DefAcceleration.AccelerationSet4Way data1 = this.AccelSet;

                    if (data1 != null) {
                        prt.WriteLine(",");
                        prt.Write("accelSet ");
                        prt.PrintContent(data1);
                    }
                }
                {
                    prt.WriteLine(",");
                    prt.Write("size ");
                    if (this.Size == null)
                        prt.Write("<<<NULL>>>");
                    else {
                        prt.PrintContent(this.Size);
                    }
                }
                {
                    VehClass.VehicleClassification data1 = this.VehicleClass;

                    if (data1 != null) {
                        prt.WriteLine(",");
                        prt.Write("vehicleClass ");
                        prt.PrintContent(data1);
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
                if (this.Id != null)
                    optMask0[0] |= (byte)(0x80 >> 0);
                if (this.PlateNo != null)
                    optMask0[0] |= (byte)(0x80 >> 1);
                if (this.Transmission != null)
                    optMask0[0] |= (byte)(0x80 >> 2);
                if (this.Angle != null)
                    optMask0[0] |= (byte)(0x80 >> 3);
                if (this.MotionCfd != null)
                    optMask0[0] |= (byte)(0x80 >> 4);
                if (this.AccelSet != null)
                    optMask0[0] |= (byte)(0x80 >> 5);
                if (this.VehicleClass != null)
                    optMask0[0] |= (byte)(0x80 >> 6);
                enc.Output.WriteBits(optMask0, 0, 7);
                try {
                    enc.EncodeEnumWithExtension((int)this.PtcType, _InternalMetadata.PerCodecMetaData.SortedEnum14, _InternalMetadata.PerCodecMetaData.SortedExtensionEnum14);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "PtcType", "ParticipantType", "ptcType", "ParticipantType", false); throw;
                }
                try {
                    if (enc.BitCount(this.PtcId - 0) > 16 || this.PtcId < 0)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.PtcId);
                    enc.EncodeConstrainedInteger((this.PtcId - (0)), 16);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "PtcId", "int", "ptcId", "INTEGER", false); throw;
                }
                try {
                    enc.EncodeEnumWithExtension((int)this.Source, _InternalMetadata.PerCodecMetaData.SortedEnum15, _InternalMetadata.PerCodecMetaData.SortedExtensionEnum15);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Source", "SourceType", "source", "SourceType", false); throw;
                }
                try {
                    if (this.Id != null)
                    {
                        enc.EncodeOctetString(this.Id, 8);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Id", "byte[]", "id", "OCTET STRING", false); throw;
                }
                try {
                    if (this.PlateNo != null)
                    {
                        enc.EncodeOctetString(this.PlateNo, 4, 16);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "PlateNo", "byte[]", "plateNo", "OCTET STRING", false); throw;
                }
                try {
                    if (enc.BitCount(this.SecMark - 0) > 16 || this.SecMark < 0)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.SecMark);
                    enc.EncodeConstrainedInteger((this.SecMark - (0)), 16);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "SecMark", "int", "secMark", "DSecond", false); throw;
                }
                try {
                    enc.EncodeType(this.Pos);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Pos", "DefPositionOffset.PositionOffsetLLV", "pos", "PositionOffsetLLV", false); throw;
                }
                try {
                    enc.EncodeType(this.Accuracy);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Accuracy", "DefPosition.PositionConfidenceSet", "accuracy", "PositionConfidenceSet", false); throw;
                }
                try {
                    if (this.Transmission != null)
                    {
                        enc.EncodeEnum((int)this.Transmission.Value, _InternalMetadata.PerCodecMetaData.SortedEnum2);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Transmission.Value", "VehStatusModule.TransmissionState", "transmission", "TransmissionState", false); throw;
                }
                try {
                    if (enc.BitCount(this.Speed - 0) > 13 || this.Speed < 0)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.Speed);
                    enc.EncodeConstrainedInteger((this.Speed - (0)), 13);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Speed", "int", "speed", "Speed", false); throw;
                }
                try {
                    if (enc.BitCount(this.Heading - 0) > 15 || this.Heading < 0)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.Heading);
                    enc.EncodeConstrainedInteger((this.Heading - (0)), 15);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Heading", "int", "heading", "Heading", false); throw;
                }
                try {
                    if (this.Angle != null)
                    {
                        if (enc.BitCount(this.Angle.Value - -126) > 8 || this.Angle.Value < -126)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.Angle.Value);
                        enc.Output.Write8BitInt((int)(this.Angle.Value - (-126)));
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Angle.Value", "long", "angle", "SteeringWheelAngle", false); throw;
                }
                try {
                    if (this.MotionCfd != null)
                    {
                        enc.EncodeType(this.MotionCfd);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "MotionCfd", "DefMotion.MotionConfidenceSet", "motionCfd", "MotionConfidenceSet", false); throw;
                }
                try {
                    if (this.AccelSet != null)
                    {
                        enc.EncodeType(this.AccelSet);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "AccelSet", "DefAcceleration.AccelerationSet4Way", "accelSet", "AccelerationSet4Way", false); throw;
                }
                try {
                    enc.EncodeType(this.Size);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Size", "VehSize.VehicleSize", "size", "VehicleSize", false); throw;
                }
                try {
                    if (this.VehicleClass != null)
                    {
                        enc.EncodeType(this.VehicleClass);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "VehicleClass", "VehClass.VehicleClassification", "vehicleClass", "VehicleClassification", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "ParticipantData", null, "ParticipantData", false); throw;
            }
        }

        protected override void DecodePer(Oss.Asn1.Internal.PerDecoder dec)
        {
            try {
                bool extPresent0 = dec.Input.ReadBool();
                byte[] optMask0 = new byte[1];

                dec.Input.ReadBits(optMask0, 7);
                try {
                    long data1;

                    data1 = dec.DecodeEnumWithExtension(_InternalMetadata.PerCodecMetaData.SortedEnum14, _InternalMetadata.PerCodecMetaData.SortedExtensionEnum14, _InternalMetadata.PerCodecMetaData.UnknownExtensionEnum14);
                    this.PtcType = (ParticipantType)data1;
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "PtcType", "ParticipantType", "ptcType", "ParticipantType", false); throw;
                }
                try {
                    this.PtcId = dec.DecodeConstrainedInteger(16, 0);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "PtcId", "int", "ptcId", "INTEGER", false); throw;
                }
                try {
                    long data1;

                    data1 = dec.DecodeEnumWithExtension(_InternalMetadata.PerCodecMetaData.SortedEnum15, _InternalMetadata.PerCodecMetaData.SortedExtensionEnum15, _InternalMetadata.PerCodecMetaData.UnknownExtensionEnum15);
                    this.Source = (SourceType)data1;
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Source", "SourceType", "source", "SourceType", false); throw;
                }
                if ((optMask0[0] & (0x80 >> 0)) != 0)
                {
                    try {
                        this.Id = dec.DecodeOctetString(8);
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "Id", "byte[]", "id", "OCTET STRING", false); throw;
                    }
                }
                else
                {
                    this.Id = null;
                }
                if ((optMask0[0] & (0x80 >> 1)) != 0)
                {
                    try {
                        this.PlateNo = dec.DecodeOctetString(4, 16);
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "PlateNo", "byte[]", "plateNo", "OCTET STRING", false); throw;
                    }
                }
                else
                {
                    this.PlateNo = null;
                }
                try {
                    this.SecMark = dec.DecodeConstrainedInteger(16, 0);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "SecMark", "int", "secMark", "DSecond", false); throw;
                }
                try {
                    DefPositionOffset.PositionOffsetLLV data1 = new DefPositionOffset.PositionOffsetLLV();

                    dec.DecodeType(data1);
                    this.Pos = data1;
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Pos", "DefPositionOffset.PositionOffsetLLV", "pos", "PositionOffsetLLV", false); throw;
                }
                try {
                    DefPosition.PositionConfidenceSet data1 = new DefPosition.PositionConfidenceSet();

                    dec.DecodeType(data1);
                    this.Accuracy = data1;
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Accuracy", "DefPosition.PositionConfidenceSet", "accuracy", "PositionConfidenceSet", false); throw;
                }
                if ((optMask0[0] & (0x80 >> 2)) != 0)
                {
                    try {
                        this.Transmission = (VehStatusModule.TransmissionState)dec.DecodeEnum(_InternalMetadata.PerCodecMetaData.SortedEnum2);
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "Transmission", "VehStatusModule.TransmissionState", "transmission", "TransmissionState", false); throw;
                    }
                }
                else
                {
                    this.Transmission = null;
                }
                try {
                    this.Speed = dec.DecodeConstrainedInteger(13, 0);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Speed", "int", "speed", "Speed", false); throw;
                }
                try {
                    this.Heading = dec.DecodeConstrainedInteger(15, 0);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Heading", "int", "heading", "Heading", false); throw;
                }
                if ((optMask0[0] & (0x80 >> 3)) != 0)
                {
                    try {
                        this.Angle = -126 + dec.Input.Read8BitInt();
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "Angle", "long", "angle", "SteeringWheelAngle", false); throw;
                    }
                }
                else
                {
                    this.Angle = null;
                }
                if ((optMask0[0] & (0x80 >> 4)) != 0)
                {
                    try {
                        DefMotion.MotionConfidenceSet data1 = new DefMotion.MotionConfidenceSet();

                        dec.DecodeType(data1);
                        this.MotionCfd = data1;
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "MotionCfd", "DefMotion.MotionConfidenceSet", "motionCfd", "MotionConfidenceSet", false); throw;
                    }
                }
                else
                {
                    this.MotionCfd = null;
                }
                if ((optMask0[0] & (0x80 >> 5)) != 0)
                {
                    try {
                        DefAcceleration.AccelerationSet4Way data1 = new DefAcceleration.AccelerationSet4Way();

                        dec.DecodeType(data1);
                        this.AccelSet = data1;
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "AccelSet", "DefAcceleration.AccelerationSet4Way", "accelSet", "AccelerationSet4Way", false); throw;
                    }
                }
                else
                {
                    this.AccelSet = null;
                }
                try {
                    VehSize.VehicleSize data1 = new VehSize.VehicleSize();

                    dec.DecodeType(data1);
                    this.Size = data1;
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Size", "VehSize.VehicleSize", "size", "VehicleSize", false); throw;
                }
                if ((optMask0[0] & (0x80 >> 6)) != 0)
                {
                    try {
                        VehClass.VehicleClassification data1 = new VehClass.VehicleClassification();

                        dec.DecodeType(data1);
                        this.VehicleClass = data1;
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "VehicleClass", "VehClass.VehicleClassification", "vehicleClass", "VehicleClassification", false); throw;
                    }
                }
                else
                {
                    this.VehicleClass = null;
                }
                if (extPresent0)
                {
                    int extMaskLen0 = 0;
                    byte[] extMask0 = dec.DecodeExtPreamble(out extMaskLen0);

                    dec.SkipUnknownExtensions(extMask0, extMaskLen0, 0);
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "ParticipantData", null, "ParticipantData", false); throw;
            }
        }
    }
}
