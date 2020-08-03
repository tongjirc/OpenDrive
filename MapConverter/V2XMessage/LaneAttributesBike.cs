

namespace VehStatus.MapLane
{
    /// <summary>
    /// Represents schema type 'LaneAttributes-Bike' (BIT STRING)
    /// </summary>
    [System.Serializable]
    public enum LaneAttributesBike
    {
        BikeRevocableLane = 0,
        PedestrianUseAllowed = 1,
        IsBikeFlyOverLane = 2,
        FixedCycleTime = 3,
        BiDirectionalCycleTimes = 4,
        IsolatedByBarrier = 5,
        UnsignalizedSegmentsPresent = 6
    }
}
