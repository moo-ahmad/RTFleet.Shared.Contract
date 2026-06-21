namespace RTFleet.Shared.Contract.V1.Events;

/// <summary>
/// Published by RoutingService when a predicted ETA slips beyond the scheduled arrival plus a configured buffer.
/// </summary>
/// <param name="EventId">Unique ID for this specific event instance.</param>
/// <param name="VehicleId">The Vehicle whose ETA slipped.</param>
/// <param name="TenantId">Tenant that owns this vehicle.</param>
/// <param name="RouteAssignmentId">The active VehicleRouteAssignment.</param>
/// <param name="ScheduledArrival">The originally scheduled arrival time, UTC.</param>
/// <param name="PredictedArrival">The newly predicted arrival time, UTC.</param>
/// <param name="SlipMinutes">How many minutes late the prediction is.</param>
/// <param name="OccurredAt">UTC timestamp when the slip was detected.</param>
public record ETASlipEvent(
    Guid EventId,
    Guid VehicleId,
    Guid TenantId,
    Guid RouteAssignmentId,
    DateTime ScheduledArrival,
    DateTime PredictedArrival,
    int SlipMinutes,
    DateTime OccurredAt
);
