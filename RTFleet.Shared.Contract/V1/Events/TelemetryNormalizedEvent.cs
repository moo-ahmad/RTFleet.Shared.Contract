namespace RTFleet.Shared.Contract.V1.Events;

/// <summary>
/// Published by TelemetryService after GPS validation and UTC normalisation.
/// </summary>
/// <param name="EventId">Unique ID for this specific event instance.</param>
/// <param name="VehicleId">The Vehicle this telemetry sample belongs to.</param>
/// <param name="TenantId">Tenant that owns this vehicle.</param>
/// <param name="Latitude">WGS84 latitude, 7 decimal places.</param>
/// <param name="Longitude">WGS84 longitude, 7 decimal places.</param>
/// <param name="SpeedKmh">Vehicle speed in kilometres per hour.</param>
/// <param name="HeadingDeg">Heading in degrees, 0-359, null if stationary.</param>
/// <param name="EngineOn">Whether the engine is currently running.</param>
/// <param name="AccelerationX">Lateral g-force, used for harsh braking/cornering detection.</param>
/// <param name="AccelerationY">Longitudinal g-force, used for harsh braking/cornering detection.</param>
/// <param name="DeviceEventId">Original idempotency key from the telemetry device.</param>
/// <param name="DeviceTimestamp">Device-reported timestamp, UTC normalised.</param>
/// <param name="ReceivedAt">Server receive timestamp, UTC.</param>
public record TelemetryNormalizedEvent(
    Guid EventId,
    Guid VehicleId,
    Guid TenantId,
    decimal Latitude,
    decimal Longitude,
    decimal SpeedKmh,
    short? HeadingDeg,
    bool EngineOn,
    decimal? AccelerationX,
    decimal? AccelerationY,
    string DeviceEventId,
    DateTime DeviceTimestamp,
    DateTime ReceivedAt
);
