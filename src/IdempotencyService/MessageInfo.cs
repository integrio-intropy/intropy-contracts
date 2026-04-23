namespace Intropy.Contracts.IdempotencyService;

/// <summary>
/// Represents information about a message for idempotency checking.
/// </summary>
/// <param name="Component">The name of the component.</param>
/// <param name="Id">The unique identifier of the message within the integration.</param>
/// <param name="Hash">A hash of the message content for duplicate detection.</param>
/// <param name="Timestamp">The timestamp when the message was created.</param>
public record MessageInfo(
    string Component,
    string Id,
    string Hash,
    DateTimeOffset Timestamp
);
