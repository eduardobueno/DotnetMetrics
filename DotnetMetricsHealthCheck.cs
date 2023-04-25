using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace DotnetMetrics;

public sealed class DotnetMetricsHealthCheck : IHealthCheck
{
    public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
    {
        return Task.FromResult(HealthCheckResult.Healthy());
    }
}