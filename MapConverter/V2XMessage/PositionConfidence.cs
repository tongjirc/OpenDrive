

namespace VehStatus.DefPosition
{
    /// <summary>
    /// Represents schema type 'PositionConfidence' (ENUMERATED)
    /// </summary>
    [System.Serializable]
    public enum PositionConfidence
    {
        Unavailable = 0,
        A500m = 1,
        A200m = 2,
        A100m = 3,
        A50m = 4,
        A20m = 5,
        A10m = 6,
        A5m = 7,
        A2m = 8,
        A1m = 9,
        A50cm = 10,
        A20cm = 11,
        A10cm = 12,
        A5cm = 13,
        A2cm = 14,
        A1cm = 15
    }
}
