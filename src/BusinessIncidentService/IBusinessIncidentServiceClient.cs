namespace Intropy.Contracts.BusinessIncidentService;

/// <summary>
/// Client interface for interacting with the Intropy Business Incident Service.
/// </summary>
public interface IBusinessIncidentServiceClient
{
    /// <summary>
    /// Sends a trigger event to the business incident service.
    /// </summary>
    /// <param name="source">The source of the business incident, in the format urn:org:component-name-example</param>
    /// <param name="subject">The subject of the business incident</param>
    /// <param name="id">The ID of the business incident</param>
    /// <param name="data">The business incident data</param>
    /// <param name="batchId">The batch ID for the business incident, if there is one</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    /// <exception cref="ArgumentException">Thrown when source or messageId is null or empty.</exception>
    /// <exception cref="BusinessIncidentServiceException">Thrown when the service call fails.</exception>
    public Task Trigger(Uri source, string subject, string id, BusinessIncidentData data, string? batchId);

    /// <summary>
    /// Sends a resolve event to the business incident service.
    /// </summary>
    /// <param name="source">The source of the business incident, in the format urn:org:component-name-example</param>
    /// <param name="subject">The subject of the business incident</param>
    /// <param name="id">The ID of the business incident</param>
    /// <param name="batchId">The batch ID for the business incident, if there is one</param>
    public Task Resolve(Uri source, string subject, string id, string? batchId);

    /// <summary>
    /// Fetches a business incident by id.
    /// </summary>
    /// <param name="id">ID of the business incident</param>
    /// <returns>Business incident entry with all details.</returns>
    /// <exception cref="ArgumentNullException">Thrown when id is null.</exception>
    /// <exception cref="BusinessIncidentServiceException">Thrown when the service call fails.</exception>
    public Task<IncidentResponse?> GetById(Guid id);

    /// <summary>
    /// Lists business incidents.
    /// </summary>
    /// <param name="filter">The filter to use when querying.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    /// <exception cref="ArgumentNullException">Thrown when id is null.</exception>
    /// <exception cref="BusinessIncidentServiceException">Thrown when the service call fails.</exception>
    public Task<IncidentListResponse> List(IncidentFilter? filter = null);

    /// <summary>
    /// Gets audit trail events for a business incident. 
    /// </summary>
    /// <param name="id">ID of the business incident.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    /// <exception cref="ArgumentNullException">Thrown when id is null.</exception>
    /// <exception cref="BusinessIncidentServiceException">Thrown when the service call fails.</exception>
    public Task<List<IncidentEventResponse>> GetEvents(Guid id);

    /// <summary>
    /// Method for manually resolving a business incident.
    /// </summary>
    /// <param name="id">ID of the business incident</param>
    /// <returns>A bool that represents success or failure.</returns>
    /// <exception cref="ArgumentNullException">Thrown when id is null.</exception>
    /// <exception cref="BusinessIncidentServiceException">Thrown when the service call fails.</exception>
    public Task<bool> ResolveManual(Guid id);
}
