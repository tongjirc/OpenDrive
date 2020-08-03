

namespace VehStatus.MapLane
{
    /// <summary>
    /// Represents schema type 'LaneAttributes-Barrier' (BIT STRING)
    /// </summary>
    [System.Serializable]
    public enum LaneAttributesBarrier
    {
        MedianRevocableLane = 0,
        Median = 1,
        WhiteLineHashing = 2,
        StripedLines = 3,
        DoubleStripedLines = 4,
        TrafficCones = 5,
        ConstructionBarrier = 6,
        TrafficChannels = 7,
        LowCurbs = 8,
        HighCurbs = 9
    }
}
