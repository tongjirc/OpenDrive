
namespace VehStatus.RSM
{
    /// <summary>
    /// Represents schema type 'ParticipantType' (ENUMERATED)
    /// </summary>
    [System.Serializable]
    public enum ParticipantType
    {
        Unknown = 0,
        Motor = 1,
        NonMotor = 2,
        Pedestrian = 3,
        Rsu = 4
    }
}
