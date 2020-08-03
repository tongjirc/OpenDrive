namespace VehStatus.VehClass
{
    /// <summary>
    /// Represents values defined in the 'VehClass' ASN.1 module.
    /// </summary>
    public static class Values
    {
        private static readonly int _unknownVehicleClass = 0;
        /// <summary>Represents schema value 'VehClass.unknownVehicleClass'</summary>
        public static int UnknownVehicleClass {
            get {
                return _unknownVehicleClass;
            }
        }
        private static readonly int _specialVehicleClass = 1;
        /// <summary>Represents schema value 'VehClass.specialVehicleClass'</summary>
        public static int SpecialVehicleClass {
            get {
                return _specialVehicleClass;
            }
        }
        private static readonly int _passengerVehicleTypeUnknown = 10;
        /// <summary>Represents schema value 'VehClass.passenger-Vehicle-TypeUnknown'</summary>
        public static int PassengerVehicleTypeUnknown {
            get {
                return _passengerVehicleTypeUnknown;
            }
        }
        private static readonly int _passengerVehicleTypeOther = 11;
        /// <summary>Represents schema value 'VehClass.passenger-Vehicle-TypeOther'</summary>
        public static int PassengerVehicleTypeOther {
            get {
                return _passengerVehicleTypeOther;
            }
        }
        private static readonly int _lightTruckVehicleTypeUnknown = 20;
        /// <summary>Represents schema value 'VehClass.lightTruck-Vehicle-TypeUnknown'</summary>
        public static int LightTruckVehicleTypeUnknown {
            get {
                return _lightTruckVehicleTypeUnknown;
            }
        }
        private static readonly int _lightTruckVehicleTypeOther = 21;
        /// <summary>Represents schema value 'VehClass.lightTruck-Vehicle-TypeOther'</summary>
        public static int LightTruckVehicleTypeOther {
            get {
                return _lightTruckVehicleTypeOther;
            }
        }
        private static readonly int _truckVehicleTypeUnknown = 25;
        /// <summary>Represents schema value 'VehClass.truck-Vehicle-TypeUnknown'</summary>
        public static int TruckVehicleTypeUnknown {
            get {
                return _truckVehicleTypeUnknown;
            }
        }
        private static readonly int _truckVehicleTypeOther = 26;
        /// <summary>Represents schema value 'VehClass.truck-Vehicle-TypeOther'</summary>
        public static int TruckVehicleTypeOther {
            get {
                return _truckVehicleTypeOther;
            }
        }
        private static readonly int _truckAxleCnt2 = 27;
        /// <summary>Represents schema value 'VehClass.truck-axleCnt2'</summary>
        public static int TruckAxleCnt2 {
            get {
                return _truckAxleCnt2;
            }
        }
        private static readonly int _truckAxleCnt3 = 28;
        /// <summary>Represents schema value 'VehClass.truck-axleCnt3'</summary>
        public static int TruckAxleCnt3 {
            get {
                return _truckAxleCnt3;
            }
        }
        private static readonly int _truckAxleCnt4 = 29;
        /// <summary>Represents schema value 'VehClass.truck-axleCnt4'</summary>
        public static int TruckAxleCnt4 {
            get {
                return _truckAxleCnt4;
            }
        }
        private static readonly int _truckAxleCnt4Trailer = 30;
        /// <summary>Represents schema value 'VehClass.truck-axleCnt4Trailer'</summary>
        public static int TruckAxleCnt4Trailer {
            get {
                return _truckAxleCnt4Trailer;
            }
        }
        private static readonly int _truckAxleCnt5Trailer = 31;
        /// <summary>Represents schema value 'VehClass.truck-axleCnt5Trailer'</summary>
        public static int TruckAxleCnt5Trailer {
            get {
                return _truckAxleCnt5Trailer;
            }
        }
        private static readonly int _truckAxleCnt6Trailer = 32;
        /// <summary>Represents schema value 'VehClass.truck-axleCnt6Trailer'</summary>
        public static int TruckAxleCnt6Trailer {
            get {
                return _truckAxleCnt6Trailer;
            }
        }
        private static readonly int _truckAxleCnt5MultiTrailer = 33;
        /// <summary>Represents schema value 'VehClass.truck-axleCnt5MultiTrailer'</summary>
        public static int TruckAxleCnt5MultiTrailer {
            get {
                return _truckAxleCnt5MultiTrailer;
            }
        }
        private static readonly int _truckAxleCnt6MultiTrailer = 34;
        /// <summary>Represents schema value 'VehClass.truck-axleCnt6MultiTrailer'</summary>
        public static int TruckAxleCnt6MultiTrailer {
            get {
                return _truckAxleCnt6MultiTrailer;
            }
        }
        private static readonly int _truckAxleCnt7MultiTrailer = 35;
        /// <summary>Represents schema value 'VehClass.truck-axleCnt7MultiTrailer'</summary>
        public static int TruckAxleCnt7MultiTrailer {
            get {
                return _truckAxleCnt7MultiTrailer;
            }
        }
        private static readonly int _motorcycleTypeUnknown = 40;
        /// <summary>Represents schema value 'VehClass.motorcycle-TypeUnknown'</summary>
        public static int MotorcycleTypeUnknown {
            get {
                return _motorcycleTypeUnknown;
            }
        }
        private static readonly int _motorcycleTypeOther = 41;
        /// <summary>Represents schema value 'VehClass.motorcycle-TypeOther'</summary>
        public static int MotorcycleTypeOther {
            get {
                return _motorcycleTypeOther;
            }
        }
        private static readonly int _motorcycleCruiserStandard = 42;
        /// <summary>Represents schema value 'VehClass.motorcycle-Cruiser-Standard'</summary>
        public static int MotorcycleCruiserStandard {
            get {
                return _motorcycleCruiserStandard;
            }
        }
        private static readonly int _motorcycleSportUnclad = 43;
        /// <summary>Represents schema value 'VehClass.motorcycle-SportUnclad'</summary>
        public static int MotorcycleSportUnclad {
            get {
                return _motorcycleSportUnclad;
            }
        }
        private static readonly int _motorcycleSportTouring = 44;
        /// <summary>Represents schema value 'VehClass.motorcycle-SportTouring'</summary>
        public static int MotorcycleSportTouring {
            get {
                return _motorcycleSportTouring;
            }
        }
        private static readonly int _motorcycleSuperSport = 45;
        /// <summary>Represents schema value 'VehClass.motorcycle-SuperSport'</summary>
        public static int MotorcycleSuperSport {
            get {
                return _motorcycleSuperSport;
            }
        }
        private static readonly int _motorcycleTouring = 46;
        /// <summary>Represents schema value 'VehClass.motorcycle-Touring'</summary>
        public static int MotorcycleTouring {
            get {
                return _motorcycleTouring;
            }
        }
        private static readonly int _motorcycleTrike = 47;
        /// <summary>Represents schema value 'VehClass.motorcycle-Trike'</summary>
        public static int MotorcycleTrike {
            get {
                return _motorcycleTrike;
            }
        }
        private static readonly int _motorcycleWPassengers = 48;
        /// <summary>Represents schema value 'VehClass.motorcycle-wPassengers'</summary>
        public static int MotorcycleWPassengers {
            get {
                return _motorcycleWPassengers;
            }
        }
        private static readonly int _transitTypeUnknown = 50;
        /// <summary>Represents schema value 'VehClass.transit-TypeUnknown'</summary>
        public static int TransitTypeUnknown {
            get {
                return _transitTypeUnknown;
            }
        }
        private static readonly int _transitTypeOther = 51;
        /// <summary>Represents schema value 'VehClass.transit-TypeOther'</summary>
        public static int TransitTypeOther {
            get {
                return _transitTypeOther;
            }
        }
        private static readonly int _transitBRT = 52;
        /// <summary>Represents schema value 'VehClass.transit-BRT'</summary>
        public static int TransitBRT {
            get {
                return _transitBRT;
            }
        }
        private static readonly int _transitExpressBus = 53;
        /// <summary>Represents schema value 'VehClass.transit-ExpressBus'</summary>
        public static int TransitExpressBus {
            get {
                return _transitExpressBus;
            }
        }
        private static readonly int _transitLocalBus = 54;
        /// <summary>Represents schema value 'VehClass.transit-LocalBus'</summary>
        public static int TransitLocalBus {
            get {
                return _transitLocalBus;
            }
        }
        private static readonly int _transitSchoolBus = 55;
        /// <summary>Represents schema value 'VehClass.transit-SchoolBus'</summary>
        public static int TransitSchoolBus {
            get {
                return _transitSchoolBus;
            }
        }
        private static readonly int _transitFixedGuideway = 56;
        /// <summary>Represents schema value 'VehClass.transit-FixedGuideway'</summary>
        public static int TransitFixedGuideway {
            get {
                return _transitFixedGuideway;
            }
        }
        private static readonly int _transitParatransit = 57;
        /// <summary>Represents schema value 'VehClass.transit-Paratransit'</summary>
        public static int TransitParatransit {
            get {
                return _transitParatransit;
            }
        }
        private static readonly int _transitParatransitAmbulance = 58;
        /// <summary>Represents schema value 'VehClass.transit-Paratransit-Ambulance'</summary>
        public static int TransitParatransitAmbulance {
            get {
                return _transitParatransitAmbulance;
            }
        }
        private static readonly int _emergencyTypeUnknown = 60;
        /// <summary>Represents schema value 'VehClass.emergency-TypeUnknown'</summary>
        public static int EmergencyTypeUnknown {
            get {
                return _emergencyTypeUnknown;
            }
        }
        private static readonly int _emergencyTypeOther = 61;
        /// <summary>Represents schema value 'VehClass.emergency-TypeOther'</summary>
        public static int EmergencyTypeOther {
            get {
                return _emergencyTypeOther;
            }
        }
        private static readonly int _emergencyFireLightVehicle = 62;
        /// <summary>Represents schema value 'VehClass.emergency-Fire-Light-Vehicle'</summary>
        public static int EmergencyFireLightVehicle {
            get {
                return _emergencyFireLightVehicle;
            }
        }
        private static readonly int _emergencyFireHeavyVehicle = 63;
        /// <summary>Represents schema value 'VehClass.emergency-Fire-Heavy-Vehicle'</summary>
        public static int EmergencyFireHeavyVehicle {
            get {
                return _emergencyFireHeavyVehicle;
            }
        }
        private static readonly int _emergencyFireParamedicVehicle = 64;
        /// <summary>Represents schema value 'VehClass.emergency-Fire-Paramedic-Vehicle'</summary>
        public static int EmergencyFireParamedicVehicle {
            get {
                return _emergencyFireParamedicVehicle;
            }
        }
        private static readonly int _emergencyFireAmbulanceVehicle = 65;
        /// <summary>Represents schema value 'VehClass.emergency-Fire-Ambulance-Vehicle'</summary>
        public static int EmergencyFireAmbulanceVehicle {
            get {
                return _emergencyFireAmbulanceVehicle;
            }
        }
        private static readonly int _emergencyPoliceLightVehicle = 66;
        /// <summary>Represents schema value 'VehClass.emergency-Police-Light-Vehicle'</summary>
        public static int EmergencyPoliceLightVehicle {
            get {
                return _emergencyPoliceLightVehicle;
            }
        }
        private static readonly int _emergencyPoliceHeavyVehicle = 67;
        /// <summary>Represents schema value 'VehClass.emergency-Police-Heavy-Vehicle'</summary>
        public static int EmergencyPoliceHeavyVehicle {
            get {
                return _emergencyPoliceHeavyVehicle;
            }
        }
        private static readonly int _emergencyOtherResponder = 68;
        /// <summary>Represents schema value 'VehClass.emergency-Other-Responder'</summary>
        public static int EmergencyOtherResponder {
            get {
                return _emergencyOtherResponder;
            }
        }
        private static readonly int _emergencyOtherAmbulance = 69;
        /// <summary>Represents schema value 'VehClass.emergency-Other-Ambulance'</summary>
        public static int EmergencyOtherAmbulance {
            get {
                return _emergencyOtherAmbulance;
            }
        }
        private static readonly int _otherTravelerTypeUnknown = 80;
        /// <summary>Represents schema value 'VehClass.otherTraveler-TypeUnknown'</summary>
        public static int OtherTravelerTypeUnknown {
            get {
                return _otherTravelerTypeUnknown;
            }
        }
        private static readonly int _otherTravelerTypeOther = 81;
        /// <summary>Represents schema value 'VehClass.otherTraveler-TypeOther'</summary>
        public static int OtherTravelerTypeOther {
            get {
                return _otherTravelerTypeOther;
            }
        }
        private static readonly int _otherTravelerPedestrian = 82;
        /// <summary>Represents schema value 'VehClass.otherTraveler-Pedestrian'</summary>
        public static int OtherTravelerPedestrian {
            get {
                return _otherTravelerPedestrian;
            }
        }
        private static readonly int _otherTravelerVisuallyDisabled = 83;
        /// <summary>Represents schema value 'VehClass.otherTraveler-Visually-Disabled'</summary>
        public static int OtherTravelerVisuallyDisabled {
            get {
                return _otherTravelerVisuallyDisabled;
            }
        }
        private static readonly int _otherTravelerPhysicallyDisabled = 84;
        /// <summary>Represents schema value 'VehClass.otherTraveler-Physically-Disabled'</summary>
        public static int OtherTravelerPhysicallyDisabled {
            get {
                return _otherTravelerPhysicallyDisabled;
            }
        }
        private static readonly int _otherTravelerBicycle = 85;
        /// <summary>Represents schema value 'VehClass.otherTraveler-Bicycle'</summary>
        public static int OtherTravelerBicycle {
            get {
                return _otherTravelerBicycle;
            }
        }
        private static readonly int _otherTravelerVulnerableRoadworker = 86;
        /// <summary>Represents schema value 'VehClass.otherTraveler-Vulnerable-Roadworker'</summary>
        public static int OtherTravelerVulnerableRoadworker {
            get {
                return _otherTravelerVulnerableRoadworker;
            }
        }
        private static readonly int _infrastructureTypeUnknown = 90;
        /// <summary>Represents schema value 'VehClass.infrastructure-TypeUnknown'</summary>
        public static int InfrastructureTypeUnknown {
            get {
                return _infrastructureTypeUnknown;
            }
        }
        private static readonly int _infrastructureFixed = 91;
        /// <summary>Represents schema value 'VehClass.infrastructure-Fixed'</summary>
        public static int InfrastructureFixed {
            get {
                return _infrastructureFixed;
            }
        }
        private static readonly int _infrastructureMovable = 92;
        /// <summary>Represents schema value 'VehClass.infrastructure-Movable'</summary>
        public static int InfrastructureMovable {
            get {
                return _infrastructureMovable;
            }
        }
        private static readonly int _equippedCargoTrailer = 93;
        /// <summary>Represents schema value 'VehClass.equipped-CargoTrailer'</summary>
        public static int EquippedCargoTrailer {
            get {
                return _equippedCargoTrailer;
            }
        }
    }
}
