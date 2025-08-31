using FactoryPattern.ExternalSystemManager;

namespace FactoryPattern.HealthCheckupFactory;

internal class HealthCheckupFactoryManager
{
    public static IExternalSystemManager GetHealthCheckupFactory(string factoryType)
    {
        return factoryType switch
        {
            "reprocessing-db-context" => new ReprocessingDbContextManager(),
            "hytrack-system-activate" => new HytrackSystemManager(),
            "ng-framework-activate" => new NexusNGFrameworkManager(),
            _ => throw new ArgumentException("Invalid factory type"),
        };
    }
}
