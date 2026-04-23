namespace Intropy.Contracts.IdempotencyService;

/// <summary>
/// Indicates the action to take for a message.
/// </summary>
public enum Action
{
    /// <summary>
    /// The message should be processed.
    /// </summary>
    Proceed,

    /// <summary>
    /// The message should be ignored.
    /// </summary>
    Ignore
}

/// <summary>
/// Indicates the reason for the action decision.
/// </summary>
public enum Reason
{
    /// <summary>
    /// The message contains newer data than what was previously stored.
    /// </summary>
    NewerData,

    /// <summary>
    /// The message contains the same data as previously stored.
    /// </summary>
    SameData,

    /// <summary>
    /// The message contains stale/older data than what was previously stored.
    /// </summary>
    StaleData,

    /// <summary>
    /// No previous data exists for this message.
    /// </summary>
    NoPreviousData
}

/// <summary>
/// Represents the status response from the idempotency service.
/// </summary>
/// <param name="Action">The action to take (Proceed or Ignore).</param>
/// <param name="Reason">The reason for the action decision.</param>
public record StatusResponse(Action Action, Reason Reason);
