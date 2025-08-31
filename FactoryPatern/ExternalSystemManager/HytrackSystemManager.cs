namespace FactoryPattern.ExternalSystemManager
{
    internal class HytrackSystemManager : IExternalSystemManager
    {
        public DTOs.HealthStatus CheckHealth()
        {
            return new DTOs.HealthStatus
            {
                IsHealthy = false,
                Message = "HytrackSystem is healthy"
            };
        }
    }
}
