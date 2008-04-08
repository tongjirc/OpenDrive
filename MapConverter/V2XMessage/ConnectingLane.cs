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


namespace VehStatus.MapLane
{
    /// <summary>
    /// Represents schema type 'ConnectingLane' (SEQUENCE)
    /// </summary>
    [System.Serializable]
    public partial class ConnectingLane : Oss.Asn1.BaseType
    {
        /// <summary>Field 'lane'</summary>
        public int Lane { get; set; }
        /// <summary>Field 'maneuver'</summary>
        public Oss.Asn1.BitStringWithNamedBits Maneuver { get; set; }

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
            ConnectingLane that = right as ConnectingLane;
            if (Lane != that.Lane)
                return false;
            if (Maneuver != null) {
                if (!Maneuver.Equals(that.Maneuver))
                    return false;
            } else if (that.Maneuver != null)
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
            hash ^= Lane.GetHashCode();
            if (Maneuver != null)
                hash ^= Maneuver.GetHashCode();
            return hash;
        }

        /// <summary>
        /// Returns the name of the ASN.1 schema type represented by this class.
        /// </summary>
        /// <returns>the string containing the name of the ASN.1 schema type.</returns>
        public override string GetAsn1TypeName()
        {
            return "ConnectingLane";
        }

        /// <summary>
        /// Asserts the validity of this object`s ASN.1 data.
        /// </summary>
        /// <exception cref="Oss.Asn1.Asn1InvalidDataException">Thrown if the instance contains invalid data.</exception>
        public override void Validate()
        {
            try {
                try {
                    if (this.Lane < 0)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    if (this.Lane > 255)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Lane", "int", "lane", "LaneID", false); throw;
                }
                try {
                    if (this.Maneuver != null) {
                        if (this.Maneuver.Count != 12)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Maneuver", "Oss.Asn1.BitStringWithNamedBits", "maneuver", "AllowedManeuvers", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "ConnectingLane", null, "ConnectingLane", false); throw;
            }
        }

        /// <summary>
        /// Creates the deep copy of this object.
        /// </summary>
        /// <returns>A new object that is a deep copy of this instance.</returns>
        public override object Copy()
        {
            ConnectingLane obj0 = new ConnectingLane();
            {
                obj0.Lane = this.Lane;
            }
            {
                obj0.Maneuver = Oss.Asn1.Internal.CopyUtil.CopyBitString(this.Maneuver);
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
                    prt.Write("lane ");
                    prt.Write(this.Lane);
                }
                {
                    Oss.Asn1.BitStringWithNamedBits data1 = this.Maneuver;

                    if (data1 != null) {
                        prt.WriteLine(",");
                        prt.Write("maneuver ");
                        prt.PrintBitString(data1, 
                            delegate(int index)
                            {
                                switch (index)
                                {
                                    case (int)0: return "maneuverStraightAllowed";
                                    case (int)1: return "maneuverLeftAllowed";
                                    case (int)2: return "maneuverRightAllowed";
                                    case (int)3: return "maneuverUTurnAllowed";
                                    case (int)4: return "maneuverLeftTurnOnRedAllowed";
                                    case (int)5: return "maneuverRightTurnOnRedAllowed";
                                    case (int)6: return "maneuverLaneChangeAllowed";
                                    case (int)7: return "maneuverNoStoppingAllowed";
                                    case (int)8: return "yieldAllwaysRequired";
                                    case (int)9: return "goWithHalt";
                                    case (int)10: return "caution";
                                    case (int)11: return "reserved1";
                                }
                                return null;
                            }
                        );
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

                if (this.Maneuver != null)
                    optMask0[0] |= (byte)(0x80 >> 0);
                enc.Output.WriteBits(optMask0, 0, 1);
                try {
                    if (enc.BitCount(this.Lane - 0) > 8 || this.Lane < 0)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.Lane);
                    if (enc.IsAligned)
                        enc.Output.WritePadding();
                    enc.Output.Write8BitInt((this.Lane - (0)));
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Lane", "int", "lane", "LaneID", false); throw;
                }
                try {
                    if (this.Maneuver != null)
                    {
                        int length1 = Oss.Asn1.Internal.MiscUtil.SearchGreaterOrEqual(_InternalMetadata.BerCodecMetaData.Ranges5, this.Maneuver.LastOneBitPos() + 1);
                        enc.EncodeBitStringWithNamedBits(this.Maneuver, length1, 12);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Maneuver", "Oss.Asn1.BitStringWithNamedBits", "maneuver", "AllowedManeuvers", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "ConnectingLane", null, "ConnectingLane", false); throw;
            }
        }

        protected override void DecodePer(Oss.Asn1.Internal.PerDecoder dec)
        {
            try {
                byte[] optMask0 = new byte[1];

                dec.Input.ReadBits(optMask0, 1);
                try {
                    if (dec.IsAligned)
                        dec.Input.SkipPadding();
                    this.Lane = 0 + dec.Input.Read8BitInt();
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Lane", "int", "lane", "LaneID", false); throw;
                }
                if ((optMask0[0] & (0x80 >> 0)) != 0)
                {
                    try {
                        this.Maneuver = dec.DecodeBitStringWithNamedBits(12, _InternalMetadata.BerCodecMetaData.Ranges5);
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "Maneuver", "Oss.Asn1.BitStringWithNamedBits", "maneuver", "AllowedManeuvers", false); throw;
                    }
                }
                else
                {
                    this.Maneuver = null;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "ConnectingLane", null, "ConnectingLane", false); throw;
            }
        }
    }
}
