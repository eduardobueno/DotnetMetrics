using DotnetMetrics;
using Prometheus;

var eventCounterRegistration = EventCounterAdapter.StartListening();
var metricAdapterRegistration = MeterAdapter.StartListening();

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHealthChecks()
    .AddCheck<DotnetMetricsHealthCheck>(nameof(DotnetMetricsHealthCheck))
    .ForwardToPrometheus();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpMetrics();

app.UseMetricServer();

app.UseHttpsRedirection();

app.MapControllers();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapMetrics();
});

app.Run();

eventCounterRegistration.Dispose();
metricAdapterRegistration.Dispose();