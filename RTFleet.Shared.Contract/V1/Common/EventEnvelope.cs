namespace RTFleet.Shared.Contract.V1.Common;

/// <summary>
/// Optional wrapper carrying cross-cutting metadata around a domain event payload.
/// </summary>
/// <typeparam name="T">The event payload type.</typeparam>
/// <param name="MessageId">Unique identifier for this specific message delivery.</param>
/// <param name="CorrelationId">Identifier correlating this message with a broader operation or request.</param>
/// <param name="OccurredAt">UTC timestamp when the underlying event occurred.</param>
/// <param name="Payload">The strongly typed event payload.</param>
public record EventEnvelope<T>(
    Guid MessageId,
    Guid CorrelationId,
    DateTime OccurredAt,
    T Payload
);
