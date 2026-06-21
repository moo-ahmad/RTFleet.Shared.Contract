namespace RTFleet.Shared.Contract.V1.Events;

/// <summary>
/// Published by RoutingService when a vehicle exceeds its route's deviation threshold.
/// </summary>
/// <param name="EventId">Unique ID for this specific event instance.</param>
/// <param name="VehicleId">The Vehicle that deviated from its route.</param>
/// <param name="TenantId">Tenant that owns this vehicle.</param>
/// <param name="RouteAssignmentId">The active VehicleRouteAssignment.</param>
/// <param name="DeviationMetres">Distance from the planned route, in metres.</param>
/// <param name="VehicleLatitude">Vehicle latitude at the time of the deviation check.</param>
/// <param name="VehicleLongitude">Vehicle longitude at the time of the deviation check.</param>
/// <param name="IsReturningToRoute">True if the deviation is clearing; false if newly off-route.</param>
/// <param name="OccurredAt">UTC timestamp when the deviation was detected.</param>
public record RouteDeviationEvent(
    Guid EventId,
    Guid VehicleId,
    Guid TenantId,
    Guid RouteAssignmentId,
    decimal DeviationMetres,
    decimal VehicleLatitude,
    decimal VehicleLongitude,
    bool IsReturningToRoute,
    DateTime OccurredAt
);
