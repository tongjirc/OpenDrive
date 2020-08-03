

namespace VehStatus.VehStatusModule
{
    /// <summary>
    /// Represents schema type 'ExteriorLights' (BIT STRING)
    /// </summary>
    [System.Serializable]
    public enum ExteriorLights
    {
        LowBeamHeadlightsOn = 0,
        HighBeamHeadlightsOn = 1,
        LeftTurnSignalOn = 2,
        RightTurnSignalOn = 3,
        HazardSignalOn = 4,
        AutomaticLightControlOn = 5,
        DaytimeRunningLightsOn = 6,
        FogLightOn = 7,
        ParkingLightsOn = 8
    }
}
