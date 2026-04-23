# Intropy.Contracts

Contracts and interfaces for Intropy platform services. Use this package to depend on service contracts without taking a dependency on their implementations.

## Services

| Namespace | Description |
|-----------|-------------|
| `Intropy.Contracts.BusinessIncidentService` | Trigger, resolve, and query business incidents |
| `Intropy.Contracts.IdempotencyService` | Check and commit message idempotency status |

## Getting Started

```bash
dotnet add package Intropy.Contracts
```

### Business Incident Service

```csharp
using Intropy.Contracts.BusinessIncidentService;

public class MyHandler(IBusinessIncidentServiceClient incidents)
{
    public async Task HandleFailure(Uri source, string subject, string id)
    {
        var data = new BusinessIncidentData { Description = "Payment processing failed" };
        await incidents.Trigger(source, subject, id, data, batchId: null);
    }
}
```

### Idempotency Service

```csharp
using Intropy.Contracts.IdempotencyService;

public class MyProcessor(IIdempotencyServiceClient idempotency)
{
    public async Task Process(string component, string messageId, string hash, DateTime timestamp)
    {
        var info = await idempotency.GetInfoAsync(component, messageId);

        var messageInfo = info ?? new MessageInfo(component, messageId, hash, timestamp);
        var status = await idempotency.GetStatusAsync(messageInfo);

        if (status.Action == Action.Ignore)
            return;

        // Process the message...

        await idempotency.CommitAsync(messageInfo);
    }
}
```

## Requirements

- .NET 10.0+

## Contributing

To build locally:

```bash
dotnet build
```

## License

This project is licensed under the [MIT License](LICENSE).
