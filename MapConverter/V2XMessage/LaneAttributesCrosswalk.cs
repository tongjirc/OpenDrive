

namespace VehStatus.MapLane
{
    /// <summary>
    /// Represents schema type 'LaneAttributes-Crosswalk' (BIT STRING)
    /// </summary>
    [System.Serializable]
    public enum LaneAttributesCrosswalk
    {
        CrosswalkRevocableLane = 0,
        BicyleUseAllowed = 1,
        IsXwalkFlyOverLane = 2,
        FixedCycleTime = 3,
        BiDirectionalCycleTimes = 4,
        HasPushToWalkButton = 5,
        AudioSupport = 6,
        RfSignalRequestPresent = 7,
        UnsignalizedSegmentsPresent = 8
    }
}
