using System.Text.Json.Serialization;

namespace Intropy.Contracts.BusinessIncidentService;

/// <summary>
/// Model representing the response when getting a business incident.
/// </summary>
public sealed record IncidentResponse
{
    /// <summary>
    /// The internal ID of the business incident.
    /// </summary>
    [JsonPropertyName("id")]
    public Guid Id { get; init; }

    /// <summary>
    /// The ID of a previous business incident with the same ID and source, that has been closed.
    /// </summary>
    [JsonPropertyName("previous_id")]
    public Guid? PreviousId { get; init; }

    /// <summary>
    /// The source component of the business incident.
    /// </summary>
    [JsonPropertyName("source")]
    public required string Source { get; init; }

    /// <summary>
    /// The business incident id.
    /// </summary>
    [JsonPropertyName("ce_id")]
    public required string CeId { get; init; }

    /// <summary>
    /// The subject of the business incident.
    /// </summary>
    [JsonPropertyName("subject")]
    public required string Subject { get; init; }

    /// <summary>
    /// The description of the business incident.
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; init; }

    /// <summary>
    /// The status of the business incident.
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; init; }

    /// <summary>
    /// The batch id of the business incident, if there is one.
    /// </summary>
    [JsonPropertyName("batch_id")]
    public string? BatchId { get; init; }

    /// <summary>
    /// The business incident context.
    /// </summary>
    [JsonPropertyName("context")]
    public Dictionary<string, string>? Context { get; init; }

    /// <summary>
    /// Number of times the business incident has been retried.
    /// </summary>
    [JsonPropertyName("retry_count")]
    public int RetryCount { get; init; }

    /// <summary>
    /// The date and time that the business incident was triggered.
    /// </summary>
    [JsonPropertyName("triggered_at")]
    public DateTimeOffset TriggeredAt { get; init; }

    /// <summary>
    /// The date and time that the business incident was last retried at.
    /// </summary>
    [JsonPropertyName("last_retried_at")]
    public DateTimeOffset? LastRetriedAt { get; init; }

    /// <summary>
    /// The date and time that the business incident was resolved.
    /// </summary>
    [JsonPropertyName("resolved_at")]
    public DateTimeOffset? ResolvedAt { get; init; }

    /// <summary>
    /// The method that was used to resolve the business incident.
    /// </summary>
    [JsonPropertyName("resolved_by")]
    public string? ResolvedBy { get; init; }
}

/// <summary>
/// Model that represents an event in the audit trail.
/// </summary>
public sealed record IncidentEventResponse
{
    /// <summary>
    /// Internal ID of the event.
    /// </summary>
    [JsonPropertyName("id")]
    public Guid Id { get; init; }

    /// <summary>
    /// Internal ID of the business incident. 
    /// </summary>
    [JsonPropertyName("incident_id")]
    public Guid IncidentId { get; init; }

    /// <summary>
    /// What type of event that occurred.
    /// </summary>
    [JsonPropertyName("event_type")]
    public required string EventType { get; init; }

    /// <summary>
    /// Metadata about the event.
    /// </summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; init; }

    /// <summary>
    /// The date and time that the event occurred.
    /// </summary>
    [JsonPropertyName("occurred_at")]
    public DateTimeOffset OccurredAt { get; init; }
}

/// <summary>
/// Model that represents the paginated response.
/// </summary>
public sealed record IncidentListResponse
{
    /// <summary>
    /// The business incidents.
    /// </summary>
    [JsonPropertyName("items")]
    public required List<IncidentResponse> Items { get; init; }

    /// <summary>
    /// The total number of business incidents that match the query.
    /// </summary>
    [JsonPropertyName("total")]
    public int Total { get; init; }
}
