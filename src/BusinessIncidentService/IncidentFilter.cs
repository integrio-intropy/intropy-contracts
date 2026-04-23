namespace Intropy.Contracts.BusinessIncidentService;

/// <summary>
/// Record that represents the filter for querying for business incidents.
/// </summary>
public sealed record IncidentFilter
{
    /// <summary>
    /// The source component for the business incident.
    /// </summary>
    public string? Source { get; init; }

    /// <summary>
    /// The status of the business incident.
    /// </summary>
    public string? Status { get; init; }

    /// <summary>
    /// The page number.
    /// </summary>
    public int? Page { get; init; }

    /// <summary>
    /// The page size.
    /// </summary>
    public int? PageSize { get; init; }
}
