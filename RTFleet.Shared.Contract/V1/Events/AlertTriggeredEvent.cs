namespace RTFleet.Shared.Contract.V1.Events;

/// <summary>
/// Published by AlertService when a rule fires outside its cooldown window (via Outbox).
/// </summary>
/// <param name="EventId">Unique ID for this specific event instance.</param>
/// <param name="AlertId">AlertEvents.Id in rtfleet_alerts.</param>
/// <param name="TenantId">Tenant that owns this alert.</param>
/// <param name="VehicleId">The Vehicle the alert was raised for.</param>
/// <param name="RuleId">The AlertRule that fired.</param>
/// <param name="RuleType">One of: IdleThreshold | GeofenceBreach | SpeedViolation | ETASlip | RouteDeviation | NoHeartbeat.</param>
/// <param name="Severity">1=Info 2=Warning 3=Critical. See <see cref="RTFleet.Shared.Contract.V1.Common.Severity"/>.</param>
/// <param name="Message">Human-readable description, e.g. "VAN-318 idle for 12 minutes on City-7".</param>
/// <param name="Latitude">Vehicle latitude at the time of the alert, if available.</param>
/// <param name="Longitude">Vehicle longitude at the time of the alert, if available.</param>
/// <param name="OccurredAt">UTC timestamp when the alert was raised.</param>
public record AlertTriggeredEvent(
    Guid EventId,
    Guid AlertId,
    Guid TenantId,
    Guid VehicleId,
    Guid RuleId,
    string RuleType,
    byte Severity,
    string Message,
    decimal? Latitude,
    decimal? Longitude,
    DateTime OccurredAt
);
