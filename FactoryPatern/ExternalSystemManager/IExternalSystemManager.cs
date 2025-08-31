using FactoryPattern.DTOs;

namespace FactoryPattern.ExternalSystemManager
{
    internal interface IExternalSystemManager
    {
        HealthStatus CheckHealth();
    }
}
