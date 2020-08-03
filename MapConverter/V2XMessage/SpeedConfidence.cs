
namespace VehStatus.DefMotion
{
    /// <summary>
    /// Represents schema type 'SpeedConfidence' (ENUMERATED)
    /// </summary>
    [System.Serializable]
    public enum SpeedConfidence
    {
        Unavailable = 0,
        Prec100ms = 1,
        Prec10ms = 2,
        Prec5ms = 3,
        Prec1ms = 4,
        Prec01ms = 5,
        Prec005ms = 6,
        Prec001ms = 7
    }
}
