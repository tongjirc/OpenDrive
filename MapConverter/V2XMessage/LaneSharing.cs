
namespace VehStatus.MapLane
{
    /// <summary>
    /// Represents schema type 'LaneSharing' (BIT STRING)
    /// </summary>
    [System.Serializable]
    public enum LaneSharing
    {
        OverlappingLaneDescriptionProvided = 0,
        MultipleLanesTreatedAsOneLane = 1,
        OtherNonMotorizedTrafficTypes = 2,
        IndividualMotorizedVehicleTraffic = 3,
        BusVehicleTraffic = 4,
        TaxiVehicleTraffic = 5,
        PedestriansTraffic = 6,
        CyclistVehicleTraffic = 7,
        TrackedVehicleTraffic = 8,
        PedestrianTraffic = 9
    }
}
