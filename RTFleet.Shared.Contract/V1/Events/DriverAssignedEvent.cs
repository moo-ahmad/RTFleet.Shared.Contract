namespace RTFleet.Shared.Contract.V1.Events;

/// <summary>
/// Published by VehicleService when a driver is assigned to a vehicle.
/// </summary>
/// <param name="EventId">Unique ID for this specific event instance.</param>
/// <param name="VehicleId">The Vehicle the driver was assigned to.</param>
/// <param name="TenantId">Tenant that owns this vehicle.</param>
/// <param name="DriverId">The Driver being assigned.</param>
/// <param name="DriverName">Full name of the driver, for display without a round-trip lookup.</param>
/// <param name="AssignedAt">UTC timestamp when the assignment was created.</param>
public record DriverAssignedEvent(
    Guid EventId,
    Guid VehicleId,
    Guid TenantId,
    Guid DriverId,
    string DriverName,
    DateTime AssignedAt
);
