namespace RTFleet.Shared.Contract.V1.Events;

/// <summary>
/// Published by VehicleService when a vehicle's health score crosses a status threshold boundary.
/// </summary>
/// <param name="EventId">Unique ID for this specific event instance.</param>
/// <param name="VehicleId">The Vehicle whose status changed.</param>
/// <param name="TenantId">Tenant that owns this vehicle.</param>
/// <param name="PreviousStatus">One of: Moving | Idle | Alert | Maintenance | Unknown.</param>
/// <param name="NewStatus">One of: Moving | Idle | Alert | Maintenance | Unknown.</param>
/// <param name="HealthScore">Health score at the time of the change, 0-100.</param>
/// <param name="OccurredAt">UTC timestamp when the status changed.</param>
public record VehicleStatusChangedEvent(
    Guid EventId,
    Guid VehicleId,
    Guid TenantId,
    string PreviousStatus,
    string NewStatus,
    byte HealthScore,
    DateTime OccurredAt
);
