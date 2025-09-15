# WorkCentre Work 10

Asp.net Core Request Pipeline

This diagram shows:

Kestrel as the entry point.

Middleware pipeline processing requests step by step.

Endpoint mapping to controllers, Razor Pages, Blazor, or gRPC.

Response sent back to the client.

flowchart TD
    A[Client Request] --> B[Kestrel Web Server]
    B --> C[Middleware Pipeline]
    C -->|Auth| D[Authentication Middleware]
    D -->|Routing| E[Routing Middleware]
    E -->|Logging| F[Logging Middleware]
    F -->|Custom| G[Custom Middleware]
    G --> H[Endpoint]
    H --> I[Controller / Razor Page / Blazor / gRPC]
    I --> J[Response Returned]

Dependency Injection lifetimes in ASP.NET Core

Singleton → created once for the entire app lifetime. Best for shared services (e.g., caching, config).

Scoped → created once per client request. Best for per-request state like DbContext.

Transient → created every time it’s injected. Best for lightweight, stateless services.

When to use which 
Use Singleton for stateless, thread-safe services.

Use Scoped for request-specific services (like EF DbContext).

Use Transient when service is cheap to construct and doesn’t hold state

graph TD
    A[Dependency Injection Container] --> B[Singleton Service]
    A --> C[Scoped Service]
    A --> D[Transient Service]

    B -->|One instance for entire app| B1[Same object everywhere]
    C -->|One instance per request| C1[New object per HTTP request]
    D -->|New instance every time| D1[Different object every injection]
