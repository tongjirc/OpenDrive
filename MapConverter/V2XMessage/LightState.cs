

namespace VehStatus.SPATIntersectionState
{
    /// <summary>
    /// Represents schema type 'LightState' (ENUMERATED)
    /// </summary>
    [System.Serializable]
    public enum LightState
    {
        Unavailable = 0,
        Dark = 1,
        StopThenProceed = 2,
        StopAndRemain = 3,
        PreMovement = 4,
        PermissiveMovementAllowed = 5,
        ProtectedMovementAllowed = 6,
        IntersectionClearance = 7,
        CautionConflictingTraffic = 8
    }
}
