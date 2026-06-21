namespace RTFleet.Shared.Contract.V1.Events;

/// <summary>
/// Published by VehicleService when a maintenance schedule's next due date or odometer threshold is reached.
/// </summary>
/// <param name="EventId">Unique ID for this specific event instance.</param>
/// <param name="ScheduleId">The MaintenanceSchedule that became due.</param>
/// <param name="VehicleId">The Vehicle the schedule applies to.</param>
/// <param name="TenantId">Tenant that owns this vehicle.</param>
/// <param name="Type">One of: OilChange | TyreRotation | BrakeInspection | AnnualService.</param>
/// <param name="DueAt">The calendar date the schedule became due, if calendar-based.</param>
/// <param name="DueOdometerKm">The odometer reading the schedule became due at, if distance-based.</param>
/// <param name="OccurredAt">UTC timestamp when the due condition was detected.</param>
public record MaintenanceDueEvent(
    Guid EventId,
    Guid ScheduleId,
    Guid VehicleId,
    Guid TenantId,
    string Type,
    DateTime? DueAt,
    decimal? DueOdometerKm,
    DateTime OccurredAt
);
