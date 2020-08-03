namespace VehStatus.VehStatusModule
{
    /// <summary>
    /// Represents schema type 'VehicleEventFlags' (BIT STRING)
    /// </summary>
    [System.Serializable]
    public enum VehicleEventFlags
    {
        EventHazardLights = 0,
        EventStopLineViolation = 1,
        EventABSactivated = 2,
        EventTractionControlLoss = 3,
        EventStabilityControlactivated = 4,
        EventHazardousMaterials = 5,
        EventReserved1 = 6,
        EventHardBraking = 7,
        EventLightsChanged = 8,
        EventWipersChanged = 9,
        EventFlatTire = 10,
        EventDisabledVehicle = 11,
        EventAirBagDeployment = 12
    }
}
