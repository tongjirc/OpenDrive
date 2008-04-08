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
    /// Represents schema type 'LaneTypeAttributes' (CHOICE)
    /// </summary>
    [System.Serializable]
    public partial class LaneTypeAttributes : Oss.Asn1.BaseType
    {
        /// <summary>CHOICE alternatives</summary>
        public enum Id {
            Unselected = 0,
            VehicleChosen = 1,
            CrosswalkChosen = 2,
            BikeLaneChosen = 3,
            SidewalkChosen = 4,
            MedianChosen = 5,
            StripingChosen = 6,
            TrackedVehicleChosen = 7,
            ParkingChosen = 8
        }
        private Id _id;
        private object _contained;
        /// <summary>Gets current selection</summary>
        public Id Selected {
            get { return _id; }
        }
        /// <summary>Gets or selects alternative 'vehicle'</summary>
        public Oss.Asn1.BitStringWithNamedBits Vehicle {
            get {
                if (_id == Id.VehicleChosen)
                    return (_contained as Oss.Asn1.BitStringWithNamedBits);
                else
                    return null;
            }
            set {
                _contained = value;
                _id = Id.VehicleChosen;
            }
        }
        /// <summary>Gets or selects alternative 'crosswalk'</summary>
        public Oss.Asn1.BitStringWithNamedBits Crosswalk {
            get {
                if (_id == Id.CrosswalkChosen)
                    return (_contained as Oss.Asn1.BitStringWithNamedBits);
                else
                    return null;
            }
            set {
                _contained = value;
                _id = Id.CrosswalkChosen;
            }
        }
        /// <summary>Gets or selects alternative 'bikeLane'</summary>
        public Oss.Asn1.BitStringWithNamedBits BikeLane {
            get {
                if (_id == Id.BikeLaneChosen)
                    return (_contained as Oss.Asn1.BitStringWithNamedBits);
                else
                    return null;
            }
            set {
                _contained = value;
                _id = Id.BikeLaneChosen;
            }
        }
        /// <summary>Gets or selects alternative 'sidewalk'</summary>
        public Oss.Asn1.BitStringWithNamedBits Sidewalk {
            get {
                if (_id == Id.SidewalkChosen)
                    return (_contained as Oss.Asn1.BitStringWithNamedBits);
                else
                    return null;
            }
            set {
                _contained = value;
                _id = Id.SidewalkChosen;
            }
        }
        /// <summary>Gets or selects alternative 'median'</summary>
        public Oss.Asn1.BitStringWithNamedBits Median {
            get {
                if (_id == Id.MedianChosen)
                    return (_contained as Oss.Asn1.BitStringWithNamedBits);
                else
                    return null;
            }
            set {
                _contained = value;
                _id = Id.MedianChosen;
            }
        }
        /// <summary>Gets or selects alternative 'striping'</summary>
        public Oss.Asn1.BitStringWithNamedBits Striping {
            get {
                if (_id == Id.StripingChosen)
                    return (_contained as Oss.Asn1.BitStringWithNamedBits);
                else
                    return null;
            }
            set {
                _contained = value;
                _id = Id.StripingChosen;
            }
        }
        /// <summary>Gets or selects alternative 'trackedVehicle'</summary>
        public Oss.Asn1.BitStringWithNamedBits TrackedVehicle {
            get {
                if (_id == Id.TrackedVehicleChosen)
                    return (_contained as Oss.Asn1.BitStringWithNamedBits);
                else
                    return null;
            }
            set {
                _contained = value;
                _id = Id.TrackedVehicleChosen;
            }
        }
        /// <summary>Gets or selects alternative 'parking'</summary>
        public Oss.Asn1.BitStringWithNamedBits Parking {
            get {
                if (_id == Id.ParkingChosen)
                    return (_contained as Oss.Asn1.BitStringWithNamedBits);
                else
                    return null;
            }
            set {
                _contained = value;
                _id = Id.ParkingChosen;
            }
        }

        public void Clear()
        {
            _id = Id.Unselected;
            _contained = null;
        }

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
            LaneTypeAttributes that = right as LaneTypeAttributes;
            if (_id != that._id)
                return false;
            return _contained.Equals(that._contained);
        }

        /// <summary>
        /// Serves as a hash function for a particular type.
        /// </summary>
        /// <returns>A hash code for the current object.</returns>
        public override int GetHashCode()
        {
            return GetType().GetHashCode() ^ _id.GetHashCode() ^ _contained.GetHashCode();
        }

        /// <summary>
        /// Returns the name of the ASN.1 schema type represented by this class.
        /// </summary>
        /// <returns>the string containing the name of the ASN.1 schema type.</returns>
        public override string GetAsn1TypeName()
        {
            return "LaneTypeAttributes";
        }

        /// <summary>
        /// Asserts the validity of this object`s ASN.1 data.
        /// </summary>
        /// <exception cref="Oss.Asn1.Asn1InvalidDataException">Thrown if the instance contains invalid data.</exception>
        public override void Validate()
        {
            try {
                switch (this.Selected) {
                case LaneTypeAttributes.Id.VehicleChosen:
                    try {
                        if (this.Vehicle == null)
                            throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._null_component_element);
                        else {
                            try {
                                if (this.Vehicle.Count != 8)
                                    throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                            } catch (System.Exception) {
                            }
                        }
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "Vehicle", "Oss.Asn1.BitStringWithNamedBits", "vehicle", "LaneAttributes-Vehicle", false); throw;
                    }
                    break;
                case LaneTypeAttributes.Id.CrosswalkChosen:
                    try {
                        if (this.Crosswalk == null)
                            throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._null_component_element);
                        else {
                            if (this.Crosswalk.Count != 16)
                                throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                        }
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "Crosswalk", "Oss.Asn1.BitStringWithNamedBits", "crosswalk", "LaneAttributes-Crosswalk", false); throw;
                    }
                    break;
                case LaneTypeAttributes.Id.BikeLaneChosen:
                    try {
                        if (this.BikeLane == null)
                            throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._null_component_element);
                        else {
                            if (this.BikeLane.Count != 16)
                                throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                        }
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "BikeLane", "Oss.Asn1.BitStringWithNamedBits", "bikeLane", "LaneAttributes-Bike", false); throw;
                    }
                    break;
                case LaneTypeAttributes.Id.SidewalkChosen:
                    try {
                        if (this.Sidewalk == null)
                            throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._null_component_element);
                        else {
                            if (this.Sidewalk.Count != 16)
                                throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                        }
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "Sidewalk", "Oss.Asn1.BitStringWithNamedBits", "sidewalk", "LaneAttributes-Sidewalk", false); throw;
                    }
                    break;
                case LaneTypeAttributes.Id.MedianChosen:
                    try {
                        if (this.Median == null)
                            throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._null_component_element);
                        else {
                            if (this.Median.Count != 16)
                                throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                        }
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "Median", "Oss.Asn1.BitStringWithNamedBits", "median", "LaneAttributes-Barrier", false); throw;
                    }
                    break;
                case LaneTypeAttributes.Id.StripingChosen:
                    try {
                        if (this.Striping == null)
                            throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._null_component_element);
                        else {
                            if (this.Striping.Count != 16)
                                throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                        }
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "Striping", "Oss.Asn1.BitStringWithNamedBits", "striping", "LaneAttributes-Striping", false); throw;
                    }
                    break;
                case LaneTypeAttributes.Id.TrackedVehicleChosen:
                    try {
                        if (this.TrackedVehicle == null)
                            throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._null_component_element);
                        else {
                            if (this.TrackedVehicle.Count != 16)
                                throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                        }
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "TrackedVehicle", "Oss.Asn1.BitStringWithNamedBits", "trackedVehicle", "LaneAttributes-TrackedVehicle", false); throw;
                    }
                    break;
                case LaneTypeAttributes.Id.ParkingChosen:
                    try {
                        if (this.Parking == null)
                            throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._null_component_element);
                        else {
                            if (this.Parking.Count != 16)
                                throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                        }
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "Parking", "Oss.Asn1.BitStringWithNamedBits", "parking", "LaneAttributes-Parking", false); throw;
                    }
                    break;
                default:
                    throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._bad_choice);
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "LaneTypeAttributes", null, "LaneTypeAttributes", false); throw;
            }
        }

        /// <summary>
        /// Creates the deep copy of this object.
        /// </summary>
        /// <returns>A new object that is a deep copy of this instance.</returns>
        public override object Copy()
        {
            LaneTypeAttributes obj0 = new LaneTypeAttributes();
            switch (this.Selected) {
                case LaneTypeAttributes.Id.VehicleChosen:
                {
                    obj0.Vehicle = Oss.Asn1.Internal.CopyUtil.CopyBitString(this.Vehicle);
                    break;
                }
                case LaneTypeAttributes.Id.CrosswalkChosen:
                {
                    obj0.Crosswalk = Oss.Asn1.Internal.CopyUtil.CopyBitString(this.Crosswalk);
                    break;
                }
                case LaneTypeAttributes.Id.BikeLaneChosen:
                {
                    obj0.BikeLane = Oss.Asn1.Internal.CopyUtil.CopyBitString(this.BikeLane);
                    break;
                }
                case LaneTypeAttributes.Id.SidewalkChosen:
                {
                    obj0.Sidewalk = Oss.Asn1.Internal.CopyUtil.CopyBitString(this.Sidewalk);
                    break;
                }
                case LaneTypeAttributes.Id.MedianChosen:
                {
                    obj0.Median = Oss.Asn1.Internal.CopyUtil.CopyBitString(this.Median);
                    break;
                }
                case LaneTypeAttributes.Id.StripingChosen:
                {
                    obj0.Striping = Oss.Asn1.Internal.CopyUtil.CopyBitString(this.Striping);
                    break;
                }
                case LaneTypeAttributes.Id.TrackedVehicleChosen:
                {
                    obj0.TrackedVehicle = Oss.Asn1.Internal.CopyUtil.CopyBitString(this.TrackedVehicle);
                    break;
                }
                case LaneTypeAttributes.Id.ParkingChosen:
                {
                    obj0.Parking = Oss.Asn1.Internal.CopyUtil.CopyBitString(this.Parking);
                    break;
                }
                default:
                    throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._bad_choice);
            }
            return obj0;
        }

        protected override void PrintAsn1ValueNotation(Oss.Asn1.Internal.ValueNotationHelper prt)
        {
            try
            {
                switch (this.Selected) {
                case LaneTypeAttributes.Id.ParkingChosen:
                    {
                        prt.Write("parking : ");
                        if (this.Parking == null)
                            prt.Write("<<<NULL>>>");
                        else {
                            prt.PrintBitString(this.Parking, 
                                delegate(int index)
                                {
                                    switch (index)
                                    {
                                        case (int)0: return "parkingRevocableLane";
                                        case (int)1: return "parallelParkingInUse";
                                        case (int)2: return "headInParkingInUse";
                                        case (int)3: return "doNotParkZone";
                                        case (int)4: return "parkingForBusUse";
                                        case (int)5: return "parkingForTaxiUse";
                                        case (int)6: return "noPublicParkingUse";
                                    }
                                    return null;
                                }
                            );
                        }
                    }
                    break;
                case LaneTypeAttributes.Id.TrackedVehicleChosen:
                    {
                        prt.Write("trackedVehicle : ");
                        if (this.TrackedVehicle == null)
                            prt.Write("<<<NULL>>>");
                        else {
                            prt.PrintBitString(this.TrackedVehicle, 
                                delegate(int index)
                                {
                                    switch (index)
                                    {
                                        case (int)0: return "spec-RevocableLane";
                                        case (int)1: return "spec-commuterRailRoadTrack";
                                        case (int)2: return "spec-lightRailRoadTrack";
                                        case (int)3: return "spec-heavyRailRoadTrack";
                                        case (int)4: return "spec-otherRailType";
                                    }
                                    return null;
                                }
                            );
                        }
                    }
                    break;
                case LaneTypeAttributes.Id.StripingChosen:
                    {
                        prt.Write("striping : ");
                        if (this.Striping == null)
                            prt.Write("<<<NULL>>>");
                        else {
                            prt.PrintBitString(this.Striping, 
                                delegate(int index)
                                {
                                    switch (index)
                                    {
                                        case (int)0: return "stripeToConnectingLanesRevocableLane";
                                        case (int)1: return "stripeDrawOnLeft";
                                        case (int)2: return "stripeDrawOnRight";
                                        case (int)3: return "stripeToConnectingLanesLeft";
                                        case (int)4: return "stripeToConnectingLanesRight";
                                        case (int)5: return "stripeToConnectingLanesAhead";
                                    }
                                    return null;
                                }
                            );
                        }
                    }
                    break;
                case LaneTypeAttributes.Id.MedianChosen:
                    {
                        prt.Write("median : ");
                        if (this.Median == null)
                            prt.Write("<<<NULL>>>");
                        else {
                            prt.PrintBitString(this.Median, 
                                delegate(int index)
                                {
                                    switch (index)
                                    {
                                        case (int)0: return "median-RevocableLane";
                                        case (int)1: return "median";
                                        case (int)2: return "whiteLineHashing";
                                        case (int)3: return "stripedLines";
                                        case (int)4: return "doubleStripedLines";
                                        case (int)5: return "trafficCones";
                                        case (int)6: return "constructionBarrier";
                                        case (int)7: return "trafficChannels";
                                        case (int)8: return "lowCurbs";
                                        case (int)9: return "highCurbs";
                                    }
                                    return null;
                                }
                            );
                        }
                    }
                    break;
                case LaneTypeAttributes.Id.SidewalkChosen:
                    {
                        prt.Write("sidewalk : ");
                        if (this.Sidewalk == null)
                            prt.Write("<<<NULL>>>");
                        else {
                            prt.PrintBitString(this.Sidewalk, 
                                delegate(int index)
                                {
                                    switch (index)
                                    {
                                        case (int)0: return "sidewalk-RevocableLane";
                                        case (int)1: return "bicyleUseAllowed";
                                        case (int)2: return "isSidewalkFlyOverLane";
                                        case (int)3: return "walkBikes";
                                    }
                                    return null;
                                }
                            );
                        }
                    }
                    break;
                case LaneTypeAttributes.Id.BikeLaneChosen:
                    {
                        prt.Write("bikeLane : ");
                        if (this.BikeLane == null)
                            prt.Write("<<<NULL>>>");
                        else {
                            prt.PrintBitString(this.BikeLane, 
                                delegate(int index)
                                {
                                    switch (index)
                                    {
                                        case (int)0: return "bikeRevocableLane";
                                        case (int)1: return "pedestrianUseAllowed";
                                        case (int)2: return "isBikeFlyOverLane";
                                        case (int)3: return "fixedCycleTime";
                                        case (int)4: return "biDirectionalCycleTimes";
                                        case (int)5: return "isolatedByBarrier";
                                        case (int)6: return "unsignalizedSegmentsPresent";
                                    }
                                    return null;
                                }
                            );
                        }
                    }
                    break;
                case LaneTypeAttributes.Id.CrosswalkChosen:
                    {
                        prt.Write("crosswalk : ");
                        if (this.Crosswalk == null)
                            prt.Write("<<<NULL>>>");
                        else {
                            prt.PrintBitString(this.Crosswalk, 
                                delegate(int index)
                                {
                                    switch (index)
                                    {
                                        case (int)0: return "crosswalkRevocableLane";
                                        case (int)1: return "bicyleUseAllowed";
                                        case (int)2: return "isXwalkFlyOverLane";
                                        case (int)3: return "fixedCycleTime";
                                        case (int)4: return "biDirectionalCycleTimes";
                                        case (int)5: return "hasPushToWalkButton";
                                        case (int)6: return "audioSupport";
                                        case (int)7: return "rfSignalRequestPresent";
                                        case (int)8: return "unsignalizedSegmentsPresent";
                                    }
                                    return null;
                                }
                            );
                        }
                    }
                    break;
                case LaneTypeAttributes.Id.VehicleChosen:
                    {
                        prt.Write("vehicle : ");
                        if (this.Vehicle == null)
                            prt.Write("<<<NULL>>>");
                        else {
                            prt.PrintBitString(this.Vehicle, 
                                delegate(int index)
                                {
                                    switch (index)
                                    {
                                        case (int)0: return "isVehicleRevocableLane";
                                        case (int)1: return "isVehicleFlyOverLane";
                                        case (int)2: return "hovLaneUseOnly";
                                        case (int)3: return "restrictedToBusUse";
                                        case (int)4: return "restrictedToTaxiUse";
                                        case (int)5: return "restrictedFromPublicUse";
                                        case (int)6: return "hasIRbeaconCoverage";
                                        case (int)7: return "permissionOnRequest";
                                    }
                                    return null;
                                }
                            );
                        }
                    }
                    break;
                default:
                    prt.Write("<unknown choice>");
                    break;
                }
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
                bool extPresent0;
                Oss.Asn1.Internal.ArrayBitOutput tempOut0 = new Oss.Asn1.Internal.ArrayBitOutput();
                Oss.Asn1.Internal.IBitOutput savedOut0 = (Oss.Asn1.Internal.IBitOutput)enc.Output;

                if ((int)this.Selected - 1 < 8)
                    extPresent0 = false;
                else
                    extPresent0 = true;
                enc.EncodeBool(extPresent0);
                if (extPresent0)
                    enc.EncodeNormSmallNonNegativeInteger((int)this.Selected - 9);
                else
                {
                    enc.Output.Write3BitInt((int)this.Selected - 1);
                }
                if (extPresent0)
                    enc.Output = tempOut0;
                switch (this.Selected)
                {
                    case LaneTypeAttributes.Id.VehicleChosen:
                        try {
                            int length1 = Oss.Asn1.Internal.MiscUtil.SearchGreaterOrEqual(_InternalMetadata.BerCodecMetaData.Ranges4, this.Vehicle.LastOneBitPos() + 1);
                            bool extPresent1 = !(length1 == 8);
                            enc.EncodeBool(extPresent1);
                            if (extPresent1)
                                enc.EncodeBitStringWithNamedBits(this.Vehicle, length1);
                            else {
                                enc.EncodeBitStringWithNamedBits(this.Vehicle, length1, 8);
                            }
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "Vehicle", "Oss.Asn1.BitStringWithNamedBits", "vehicle", "LaneAttributes-Vehicle", false); throw;
                        }
                        break;
                    case LaneTypeAttributes.Id.CrosswalkChosen:
                        try {
                            int length1 = Oss.Asn1.Internal.MiscUtil.SearchGreaterOrEqual(_InternalMetadata.BerCodecMetaData.Ranges7, this.Crosswalk.LastOneBitPos() + 1);
                            enc.EncodeBitStringWithNamedBits(this.Crosswalk, length1, 16);
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "Crosswalk", "Oss.Asn1.BitStringWithNamedBits", "crosswalk", "LaneAttributes-Crosswalk", false); throw;
                        }
                        break;
                    case LaneTypeAttributes.Id.BikeLaneChosen:
                        try {
                            int length1 = Oss.Asn1.Internal.MiscUtil.SearchGreaterOrEqual(_InternalMetadata.BerCodecMetaData.Ranges7, this.BikeLane.LastOneBitPos() + 1);
                            enc.EncodeBitStringWithNamedBits(this.BikeLane, length1, 16);
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "BikeLane", "Oss.Asn1.BitStringWithNamedBits", "bikeLane", "LaneAttributes-Bike", false); throw;
                        }
                        break;
                    case LaneTypeAttributes.Id.SidewalkChosen:
                        try {
                            int length1 = Oss.Asn1.Internal.MiscUtil.SearchGreaterOrEqual(_InternalMetadata.BerCodecMetaData.Ranges7, this.Sidewalk.LastOneBitPos() + 1);
                            enc.EncodeBitStringWithNamedBits(this.Sidewalk, length1, 16);
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "Sidewalk", "Oss.Asn1.BitStringWithNamedBits", "sidewalk", "LaneAttributes-Sidewalk", false); throw;
                        }
                        break;
                    case LaneTypeAttributes.Id.MedianChosen:
                        try {
                            int length1 = Oss.Asn1.Internal.MiscUtil.SearchGreaterOrEqual(_InternalMetadata.BerCodecMetaData.Ranges7, this.Median.LastOneBitPos() + 1);
                            enc.EncodeBitStringWithNamedBits(this.Median, length1, 16);
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "Median", "Oss.Asn1.BitStringWithNamedBits", "median", "LaneAttributes-Barrier", false); throw;
                        }
                        break;
                    case LaneTypeAttributes.Id.StripingChosen:
                        try {
                            int length1 = Oss.Asn1.Internal.MiscUtil.SearchGreaterOrEqual(_InternalMetadata.BerCodecMetaData.Ranges7, this.Striping.LastOneBitPos() + 1);
                            enc.EncodeBitStringWithNamedBits(this.Striping, length1, 16);
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "Striping", "Oss.Asn1.BitStringWithNamedBits", "striping", "LaneAttributes-Striping", false); throw;
                        }
                        break;
                    case LaneTypeAttributes.Id.TrackedVehicleChosen:
                        try {
                            int length1 = Oss.Asn1.Internal.MiscUtil.SearchGreaterOrEqual(_InternalMetadata.BerCodecMetaData.Ranges7, this.TrackedVehicle.LastOneBitPos() + 1);
                            enc.EncodeBitStringWithNamedBits(this.TrackedVehicle, length1, 16);
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "TrackedVehicle", "Oss.Asn1.BitStringWithNamedBits", "trackedVehicle", "LaneAttributes-TrackedVehicle", false); throw;
                        }
                        break;
                    case LaneTypeAttributes.Id.ParkingChosen:
                        try {
                            int length1 = Oss.Asn1.Internal.MiscUtil.SearchGreaterOrEqual(_InternalMetadata.BerCodecMetaData.Ranges7, this.Parking.LastOneBitPos() + 1);
                            enc.EncodeBitStringWithNamedBits(this.Parking, length1, 16);
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "Parking", "Oss.Asn1.BitStringWithNamedBits", "parking", "LaneAttributes-Parking", false); throw;
                        }
                        break;
                    default:
                        throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._bad_choice);
                }
                if (extPresent0)
                {
                    enc.CompleteEncoding();
                    enc.Output = savedOut0;
                    enc.EncodeOctetString(tempOut0.Consolidate());
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "LaneTypeAttributes", null, "LaneTypeAttributes", false); throw;
            }
        }

        protected override void DecodePer(Oss.Asn1.Internal.PerDecoder dec)
        {
            try {
                int choice_alt0 = 0;
                bool extPresent0 = dec.DecodeBool();
                int fraglast0 = 65536;
                Oss.Asn1.Internal.IBitInput savedInput0 = dec.Input;
                int extLen0 = 0;
                int bitPos0 = 0;

                if (extPresent0)
                {
                    choice_alt0 = dec.DecodeNormSmallNonNegativeInteger() + 9;
                    extLen0 = dec.DecodeExtAdditonLength(ref fraglast0);
                    if (fraglast0 >= 0)
                        extLen0 = dec.PrepareExtInputFrag(extLen0);
                    bitPos0 = dec.Input.BitsRead();
                }
                else
                {
                    choice_alt0 = dec.Input.Read3BitInt() + 1;
                    if (choice_alt0 > 8)
                        throw new Oss.Asn1.Asn1InvalidEncodingException(Oss.Asn1.Internal.ExceptionDescriptor._bad_choice);
                }
                switch ((LaneTypeAttributes.Id)choice_alt0)
                {
                    case LaneTypeAttributes.Id.VehicleChosen:
                        try {
                            Oss.Asn1.BitStringWithNamedBits data1;
                            bool extPresent1 = dec.Input.ReadBool();
                            if (extPresent1)
                                data1 = dec.DecodeExtBitStringWithNamedBits(_InternalMetadata.BerCodecMetaData.Ranges4);
                            else
                                data1 = dec.DecodeBitStringWithNamedBits(8, _InternalMetadata.BerCodecMetaData.Ranges4);
                            if (dec.Options.StrictDecoding && extPresent1 == (data1.Length == 8))
                                dec.RaiseExtLengthError(extPresent1);
                            this.Vehicle = data1;
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "Vehicle", "Oss.Asn1.BitStringWithNamedBits", "vehicle", "LaneAttributes-Vehicle", false); throw;
                        }
                        break;
                    case LaneTypeAttributes.Id.CrosswalkChosen:
                        try {
                            this.Crosswalk = dec.DecodeBitStringWithNamedBits(16, _InternalMetadata.BerCodecMetaData.Ranges7);
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "Crosswalk", "Oss.Asn1.BitStringWithNamedBits", "crosswalk", "LaneAttributes-Crosswalk", false); throw;
                        }
                        break;
                    case LaneTypeAttributes.Id.BikeLaneChosen:
                        try {
                            this.BikeLane = dec.DecodeBitStringWithNamedBits(16, _InternalMetadata.BerCodecMetaData.Ranges7);
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "BikeLane", "Oss.Asn1.BitStringWithNamedBits", "bikeLane", "LaneAttributes-Bike", false); throw;
                        }
                        break;
                    case LaneTypeAttributes.Id.SidewalkChosen:
                        try {
                            this.Sidewalk = dec.DecodeBitStringWithNamedBits(16, _InternalMetadata.BerCodecMetaData.Ranges7);
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "Sidewalk", "Oss.Asn1.BitStringWithNamedBits", "sidewalk", "LaneAttributes-Sidewalk", false); throw;
                        }
                        break;
                    case LaneTypeAttributes.Id.MedianChosen:
                        try {
                            this.Median = dec.DecodeBitStringWithNamedBits(16, _InternalMetadata.BerCodecMetaData.Ranges7);
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "Median", "Oss.Asn1.BitStringWithNamedBits", "median", "LaneAttributes-Barrier", false); throw;
                        }
                        break;
                    case LaneTypeAttributes.Id.StripingChosen:
                        try {
                            this.Striping = dec.DecodeBitStringWithNamedBits(16, _InternalMetadata.BerCodecMetaData.Ranges7);
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "Striping", "Oss.Asn1.BitStringWithNamedBits", "striping", "LaneAttributes-Striping", false); throw;
                        }
                        break;
                    case LaneTypeAttributes.Id.TrackedVehicleChosen:
                        try {
                            this.TrackedVehicle = dec.DecodeBitStringWithNamedBits(16, _InternalMetadata.BerCodecMetaData.Ranges7);
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "TrackedVehicle", "Oss.Asn1.BitStringWithNamedBits", "trackedVehicle", "LaneAttributes-TrackedVehicle", false); throw;
                        }
                        break;
                    case LaneTypeAttributes.Id.ParkingChosen:
                        try {
                            this.Parking = dec.DecodeBitStringWithNamedBits(16, _InternalMetadata.BerCodecMetaData.Ranges7);
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "Parking", "Oss.Asn1.BitStringWithNamedBits", "parking", "LaneAttributes-Parking", false); throw;
                        }
                        break;
                    default:
                        if (!extPresent0)
                            throw new Oss.Asn1.Asn1InvalidEncodingException(Oss.Asn1.Internal.ExceptionDescriptor._bad_choice);
                        this.Clear();
                        break;
                }
                if (extPresent0)
                {
                    if (dec.Options.StrictDecoding)
                        dec.CheckExtEncodingCompletion(bitPos0, extLen0);
                    if (fraglast0 < 0)
                        dec.Input.SkipBits(extLen0 * 8 - (dec.Input.BitsRead() - bitPos0));
                }
                dec.Input = savedInput0;
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "LaneTypeAttributes", null, "LaneTypeAttributes", false); throw;
            }
        }
    }
}
