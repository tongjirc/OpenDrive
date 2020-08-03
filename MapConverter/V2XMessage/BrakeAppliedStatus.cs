

namespace VehStatus.VehBrake
{
    /// <summary>
    /// Represents schema type 'BrakeAppliedStatus' (BIT STRING)
    /// </summary>
    [System.Serializable]
    public enum BrakeAppliedStatus
    {
        Unavailable = 0,
        LeftFront = 1,
        LeftRear = 2,
        RightFront = 3,
        RightRear = 4
    }
}
