namespace RTFleet.Shared.Contract.V1.Events;

/// <summary>
/// Published by VehicleService when a driver is unassigned from a vehicle.
/// </summary>
/// <param name="EventId">Unique ID for this specific event instance.</param>
/// <param name="VehicleId">The Vehicle the driver was unassigned from.</param>
/// <param name="TenantId">Tenant that owns this vehicle.</param>
/// <param name="DriverId">The Driver being unassigned.</param>
/// <param name="UnassignedAt">UTC timestamp when the assignment ended.</param>
public record DriverUnassignedEvent(
    Guid EventId,
    Guid VehicleId,
    Guid TenantId,
    Guid DriverId,
    DateTime UnassignedAt
);
