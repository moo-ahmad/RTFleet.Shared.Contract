namespace RTFleet.Shared.Contract.V1.Events;

/// <summary>
/// Published by VehicleService when a new vehicle is registered to a tenant's fleet.
/// Delivered via the Outbox pattern — guaranteed at-least-once.
/// </summary>
/// <param name="EventId">Unique ID for this specific event instance (not the vehicle).</param>
/// <param name="VehicleId">The newly created Vehicle's primary key.</param>
/// <param name="TenantId">Tenant that owns this vehicle.</param>
/// <param name="VIN">17-character Vehicle Identification Number.</param>
/// <param name="Plate">License plate string, tenant-scoped uniqueness only.</param>
/// <param name="Type">One of: BoxTruck | CargoVan | Flatbed | Tanker.</param>
/// <param name="OccurredAt">UTC timestamp when the vehicle was created.</param>
public record VehicleRegisteredEvent(
    Guid EventId,
    Guid VehicleId,
    Guid TenantId,
    string VIN,
    string Plate,
    string Type,
    DateTime OccurredAt
);
