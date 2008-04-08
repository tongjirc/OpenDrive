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
    /// Represents schema type 'RegulatorySpeedLimit' (SEQUENCE)
    /// </summary>
    [System.Serializable]
    public partial class RegulatorySpeedLimit : Oss.Asn1.BaseType
    {
        /// <summary>Field 'type'</summary>
        public SpeedLimitType Type { get; set; }
        /// <summary>Field 'speed'</summary>
        public int Speed { get; set; }

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
            RegulatorySpeedLimit that = right as RegulatorySpeedLimit;
            if (Type != that.Type)
                return false;
            if (Speed != that.Speed)
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
            hash ^= Type.GetHashCode();
            hash ^= Speed.GetHashCode();
            return hash;
        }

        /// <summary>
        /// Returns the name of the ASN.1 schema type represented by this class.
        /// </summary>
        /// <returns>the string containing the name of the ASN.1 schema type.</returns>
        public override string GetAsn1TypeName()
        {
            return "RegulatorySpeedLimit";
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
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Type", "SpeedLimitType", "type", "SpeedLimitType", false); throw;
                }
                try {
                    if (this.Speed < 0)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    if (this.Speed > 8191)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Speed", "int", "speed", "Speed", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "RegulatorySpeedLimit", null, "RegulatorySpeedLimit", false); throw;
            }
        }

        /// <summary>
        /// Creates the deep copy of this object.
        /// </summary>
        /// <returns>A new object that is a deep copy of this instance.</returns>
        public override object Copy()
        {
            RegulatorySpeedLimit obj0 = new RegulatorySpeedLimit();
            {
                obj0.Type = this.Type;
            }
            {
                obj0.Speed = this.Speed;
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
                    prt.Write("type ");
                    switch (this.Type) {
                    case SpeedLimitType.Unknown:
                        prt.Write("unknown");
                        break;
                    case SpeedLimitType.MaxSpeedInSchoolZone:
                        prt.Write("maxSpeedInSchoolZone");
                        break;
                    case SpeedLimitType.MaxSpeedInSchoolZoneWhenChildrenArePresent:
                        prt.Write("maxSpeedInSchoolZoneWhenChildrenArePresent");
                        break;
                    case SpeedLimitType.MaxSpeedInConstructionZone:
                        prt.Write("maxSpeedInConstructionZone");
                        break;
                    case SpeedLimitType.VehicleMinSpeed:
                        prt.Write("vehicleMinSpeed");
                        break;
                    case SpeedLimitType.VehicleMaxSpeed:
                        prt.Write("vehicleMaxSpeed");
                        break;
                    case SpeedLimitType.VehicleNightMaxSpeed:
                        prt.Write("vehicleNightMaxSpeed");
                        break;
                    case SpeedLimitType.TruckMinSpeed:
                        prt.Write("truckMinSpeed");
                        break;
                    case SpeedLimitType.TruckMaxSpeed:
                        prt.Write("truckMaxSpeed");
                        break;
                    case SpeedLimitType.TruckNightMaxSpeed:
                        prt.Write("truckNightMaxSpeed");
                        break;
                    case SpeedLimitType.VehiclesWithTrailersMinSpeed:
                        prt.Write("vehiclesWithTrailersMinSpeed");
                        break;
                    case SpeedLimitType.VehiclesWithTrailersMaxSpeed:
                        prt.Write("vehiclesWithTrailersMaxSpeed");
                        break;
                    case SpeedLimitType.VehiclesWithTrailersNightMaxSpeed:
                        prt.Write("vehiclesWithTrailersNightMaxSpeed");
                        break;
                    default:
                        prt.Write((int)this.Type);
                        break;
                    }
                }
                {
                    prt.WriteLine(",");
                    prt.Write("speed ");
                    prt.Write(this.Speed);
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
                try {
                    enc.EncodeEnumWithExtension((int)this.Type, _InternalMetadata.PerCodecMetaData.SortedEnum13, _InternalMetadata.PerCodecMetaData.SortedExtensionEnum13);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Type", "SpeedLimitType", "type", "SpeedLimitType", false); throw;
                }
                try {
                    if (enc.BitCount(this.Speed - 0) > 13 || this.Speed < 0)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.Speed);
                    enc.EncodeConstrainedInteger((this.Speed - (0)), 13);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Speed", "int", "speed", "Speed", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "RegulatorySpeedLimit", null, "RegulatorySpeedLimit", false); throw;
            }
        }

        protected override void DecodePer(Oss.Asn1.Internal.PerDecoder dec)
        {
            try {
                try {
                    long data1;

                    data1 = dec.DecodeEnumWithExtension(_InternalMetadata.PerCodecMetaData.SortedEnum13, _InternalMetadata.PerCodecMetaData.SortedExtensionEnum13, _InternalMetadata.PerCodecMetaData.UnknownExtensionEnum13);
                    this.Type = (SpeedLimitType)data1;
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Type", "SpeedLimitType", "type", "SpeedLimitType", false); throw;
                }
                try {
                    this.Speed = dec.DecodeConstrainedInteger(13, 0);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Speed", "int", "speed", "Speed", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "RegulatorySpeedLimit", null, "RegulatorySpeedLimit", false); throw;
            }
        }
    }
}
