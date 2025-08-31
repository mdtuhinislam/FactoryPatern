using FactoryPattern.ExternalSystemManager;
using FactoryPattern.HealthCheckupFactory;

HealthCheckupFactoryManager healthCheckupFactoryManager = new HealthCheckupFactoryManager();
IExternalSystemManager externalSystemManager = HealthCheckupFactoryManager.GetHealthCheckupFactory("hytrack-system-activate");
var healthStatus = externalSystemManager.CheckHealth();

Console.WriteLine($"{nameof(externalSystemManager)} Is Healthy: {healthStatus.IsHealthy}, Message: {healthStatus.Message}");
