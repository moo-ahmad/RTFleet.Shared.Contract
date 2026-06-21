namespace RTFleet.Shared.Contract.Faults;

/// <summary>
/// Published when a consumer determines an incoming message violates contract invariants
/// and should be routed to the dead-letter queue rather than retried.
/// </summary>
/// <param name="FaultId">Unique identifier for this fault occurrence.</param>
/// <param name="MessageType">Fully-qualified type name of the message that failed validation.</param>
/// <param name="Reason">Human-readable description of why validation failed.</param>
/// <param name="OccurredAt">UTC timestamp when the fault was raised.</param>
public record ContractValidationFault(
    Guid FaultId,
    string MessageType,
    string Reason,
    DateTime OccurredAt
);
