using System.Text.Json.Serialization;

namespace Intropy.Contracts.BusinessIncidentService;

/// <summary>
/// Represents information about the business incident.
/// </summary>
public sealed record BusinessIncidentData
{
    /// <summary>
    /// Details why it has been flagged as a business incident.
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; init; }

    /// <summary>
    /// Additional information about the business incident that can be supplied to give more context.
    /// </summary>
    [JsonPropertyName("context")]
    public Dictionary<string, string>? Context { get; init; }
}
