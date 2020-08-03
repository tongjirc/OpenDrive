

namespace VehStatus.MapLane
{
    /// <summary>
    /// Represents schema type 'LaneAttributes-Striping' (BIT STRING)
    /// </summary>
    [System.Serializable]
    public enum LaneAttributesStriping
    {
        StripeToConnectingLanesRevocableLane = 0,
        StripeDrawOnLeft = 1,
        StripeDrawOnRight = 2,
        StripeToConnectingLanesLeft = 3,
        StripeToConnectingLanesRight = 4,
        StripeToConnectingLanesAhead = 5
    }
}
