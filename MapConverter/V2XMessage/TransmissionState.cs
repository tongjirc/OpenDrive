namespace VehStatus.VehStatusModule
{
    /// <summary>
    /// Represents schema type 'TransmissionState' (ENUMERATED)
    /// </summary>
    [System.Serializable]
    public enum TransmissionState
    {
        Neutral = 0,
        Park = 1,
        ForwardGears = 2,
        ReverseGears = 3,
        Reserved1 = 4,
        Reserved2 = 5,
        Reserved3 = 6,
        Unavailable = 7
    }
}
