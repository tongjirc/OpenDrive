
namespace VehStatus.RSM
{
    /// <summary>
    /// Represents schema type 'SourceType' (ENUMERATED)
    /// </summary>
    [System.Serializable]
    public enum SourceType
    {
        Unknown = 0,
        Selfinfo = 1,
        V2x = 2,
        Video = 3,
        MicrowaveRadar = 4,
        Loop = 5
    }
}
