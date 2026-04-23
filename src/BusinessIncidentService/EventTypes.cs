namespace Intropy.Contracts.BusinessIncidentService;

/// <summary>
/// Static class containing possible inbound and outbound events.
/// </summary>
public static class EventTypes
{
    /// <summary>
    /// Inbound event type of triggered business incidents
    /// </summary>
    public const string Triggered = "io.intropy.business_incident.triggered";

    /// <summary>
    /// Inbound event type of resolved business incidents
    /// </summary>
    public const string Resolved = "io.intropy.business_incident.resolved";

    /// <summary>
    /// Outbound event type of triggered business incidents
    /// </summary>
    public const string NotificationTriggered = "io.intropy.business_incident.triggered";

    /// <summary>
    /// Outbound event type of retried business incidents
    /// </summary>
    public const string NotificationRetried = "io.intropy.business_incident.retried";

    /// <summary>
    /// Outbound event type of resolved business incidents
    /// </summary>
    public const string NotificationResolved = "io.intropy.business_incident.resolved";

    /// <summary>
    /// Outbound event type of recurred business incidents
    /// </summary>
    public const string NotificationRecurred = "io.intropy.business_incident.recurred";
}
