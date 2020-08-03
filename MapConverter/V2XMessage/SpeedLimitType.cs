
namespace VehStatus.MapSpeedLimit
{
    /// <summary>
    /// Represents schema type 'SpeedLimitType' (ENUMERATED)
    /// </summary>
    [System.Serializable]
    public enum SpeedLimitType
    {
        Unknown = 0,
        MaxSpeedInSchoolZone = 1,
        MaxSpeedInSchoolZoneWhenChildrenArePresent = 2,
        MaxSpeedInConstructionZone = 3,
        VehicleMinSpeed = 4,
        VehicleMaxSpeed = 5,
        VehicleNightMaxSpeed = 6,
        TruckMinSpeed = 7,
        TruckMaxSpeed = 8,
        TruckNightMaxSpeed = 9,
        VehiclesWithTrailersMinSpeed = 10,
        VehiclesWithTrailersMaxSpeed = 11,
        VehiclesWithTrailersNightMaxSpeed = 12
    }
}
