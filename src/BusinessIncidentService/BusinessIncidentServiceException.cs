namespace Intropy.Contracts.BusinessIncidentService;

/// <summary>
/// Exception thrown when an idempotency service operation fails.
/// </summary>
public class BusinessIncidentServiceException : Exception
{
    /// <summary>
    /// Gets the HTTP status code associated with the error, if available.
    /// </summary>
    public int? StatusCode { get; }

    /// <summary>
    /// Gets additional error details, if available.
    /// </summary>
    public string? Details { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="BusinessIncidentServiceException"/> class with a specified error message
    /// and a reference to the inner exception that is the cause of this exception.
    /// </summary>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    /// <param name="innerException">The exception that is the cause of the current exception.</param>
    public BusinessIncidentServiceException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BusinessIncidentServiceException"/> class with a specified error message,
    /// HTTP status code, and additional details.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    /// <param name="statusCode">The HTTP status code associated with the error.</param>
    /// <param name="details">Additional details about the error.</param>
    /// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
    public BusinessIncidentServiceException(string message, int statusCode, string? details, Exception? innerException)
        : base(message, innerException)
    {
        StatusCode = statusCode;
        Details = details;
    }
}
