
namespace VehStatus.DefMotion
{
    /// <summary>
    /// Represents schema type 'HeadingConfidence' (ENUMERATED)
    /// </summary>
    [System.Serializable]
    public enum HeadingConfidence
    {
        Unavailable = 0,
        Prec10deg = 1,
        Prec05deg = 2,
        Prec01degId0 = 3,
        Prec01degId = 4,
        Prec005deg = 5,
        Prec001deg = 6,
        Prec00125deg = 7
    }
}
