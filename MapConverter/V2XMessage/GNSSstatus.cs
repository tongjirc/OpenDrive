
namespace VehStatus.VehSafetyExt
{
    /// <summary>
    /// Represents schema type 'GNSSstatus' (BIT STRING)
    /// </summary>
    [System.Serializable]
    public enum GNSSstatus
    {
        Unavailable = 0,
        IsHealthy = 1,
        IsMonitored = 2,
        BaseStationType = 3,
        APDOPofUnder5 = 4,
        InViewOfUnder5 = 5,
        LocalCorrectionsPresent = 6,
        NetworkCorrectionsPresent = 7
    }
}
