namespace Intropy.Contracts.IdempotencyService;

/// <summary>
/// Client interface for interacting with the Intropy Idempotency Service.
/// </summary>
public interface IIdempotencyServiceClient
{
    /// <summary>
    /// Retrieves message information if it exists in the idempotency store.
    /// </summary>
    /// <param name="component">The name of the component.</param>
    /// <param name="id">The unique identifier of the message within the integration.</param>
    /// <param name="cancellationToken">Optional cancellation token.</param>
    /// <returns>The message information if found; otherwise, null.</returns>
    /// <exception cref="ArgumentException">Thrown when integration or id is null or empty.</exception>
    /// <exception cref="IdempotencyServiceException">Thrown when the service call fails.</exception>
    public Task<MessageInfo?> GetInfoAsync(string component, string id,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Checks whether a message should be processed or ignored based on idempotency rules.
    /// </summary>
    /// <param name="messageInfo">The message information containing integration, id, hash, and timestamp.</param>
    /// <param name="cancellationToken">Optional cancellation token.</param>
    /// <returns>A status response indicating whether to proceed or ignore the message, along with the reason.</returns>
    /// <exception cref="ArgumentNullException">Thrown when messageInfo is null.</exception>
    /// <exception cref="IdempotencyServiceException">Thrown when the service call fails.</exception>
    public Task<StatusResponse> GetStatusAsync(MessageInfo messageInfo, CancellationToken cancellationToken = default);

    /// <summary>
    /// Commits a message record to the idempotency store, marking it as processed.
    /// </summary>
    /// <param name="messageInfo">The message information to commit.</param>
    /// <param name="cancellationToken">Optional cancellation token.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    /// <exception cref="ArgumentNullException">Thrown when messageInfo is null.</exception>
    /// <exception cref="IdempotencyServiceException">Thrown when the service call fails or a conflict occurs (409).</exception>
    Task CommitAsync(MessageInfo messageInfo, CancellationToken cancellationToken = default);
}
