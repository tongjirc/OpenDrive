

namespace VehStatus.MapLane
{
    /// <summary>
    /// Represents schema type 'AllowedManeuvers' (BIT STRING)
    /// </summary>
    [System.Serializable]
    public enum AllowedManeuvers
    {
        ManeuverStraightAllowed = 0,
        ManeuverLeftAllowed = 1,
        ManeuverRightAllowed = 2,
        ManeuverUTurnAllowed = 3,
        ManeuverLeftTurnOnRedAllowed = 4,
        ManeuverRightTurnOnRedAllowed = 5,
        ManeuverLaneChangeAllowed = 6,
        ManeuverNoStoppingAllowed = 7,
        YieldAllwaysRequired = 8,
        GoWithHalt = 9,
        Caution = 10,
        Reserved1 = 11
    }
}
