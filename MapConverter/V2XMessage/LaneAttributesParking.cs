
namespace VehStatus.MapLane
{
    /// <summary>
    /// Represents schema type 'LaneAttributes-Parking' (BIT STRING)
    /// </summary>
    [System.Serializable]
    public enum LaneAttributesParking
    {
        ParkingRevocableLane = 0,
        ParallelParkingInUse = 1,
        HeadInParkingInUse = 2,
        DoNotParkZone = 3,
        ParkingForBusUse = 4,
        ParkingForTaxiUse = 5,
        NoPublicParkingUse = 6
    }
}
