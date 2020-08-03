

namespace VehStatus.MapLane
{
    /// <summary>
    /// Represents schema type 'LaneAttributes-TrackedVehicle' (BIT STRING)
    /// </summary>
    [System.Serializable]
    public enum LaneAttributesTrackedVehicle
    {
        SpecRevocableLane = 0,
        SpecCommuterRailRoadTrack = 1,
        SpecLightRailRoadTrack = 2,
        SpecHeavyRailRoadTrack = 3,
        SpecOtherRailType = 4
    }
}
