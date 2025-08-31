using FactoryPattern.DTOs;

namespace FactoryPattern.ExternalSystemManager
{
    /// <summary>
    /// All the concrete external system manager should implement this interface
    /// <summary/>
    internal interface IExternalSystemManager
    {
        HealthStatus CheckHealth();
    }
}
