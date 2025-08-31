using FactoryPattern.DTOs;

namespace FactoryPattern.ExternalSystemManager
{
    internal class ReprocessingDbContextManager : IExternalSystemManager
    {
        public HealthStatus CheckHealth()
        {
            return new HealthStatus(false, "ReprocessingDbContext");
        }
    }
}
