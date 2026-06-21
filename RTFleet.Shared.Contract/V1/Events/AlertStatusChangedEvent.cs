namespace RTFleet.Shared.Contract.V1.Events;

/// <summary>
/// Published by AlertService when an alert is acknowledged or resolved.
/// </summary>
/// <param name="EventId">Unique ID for this specific event instance.</param>
/// <param name="AlertId">The AlertEvent whose status changed.</param>
/// <param name="TenantId">Tenant that owns this alert.</param>
/// <param name="PreviousStatus">One of: Open | Acknowledged.</param>
/// <param name="NewStatus">One of: Acknowledged | Resolved.</param>
/// <param name="ChangedBy">UserId of the user who made the change.</param>
/// <param name="OccurredAt">UTC timestamp when the status changed.</param>
public record AlertStatusChangedEvent(
    Guid EventId,
    Guid AlertId,
    Guid TenantId,
    string PreviousStatus,
    string NewStatus,
    Guid ChangedBy,
    DateTime OccurredAt
);
