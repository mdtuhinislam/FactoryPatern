namespace FactoryPattern.ExternalSystemManager
{
    internal class HytrackSystemManager : IExternalSystemManager
    {
        public DTOs.HealthStatus CheckHealth()
        {
            return new DTOs.HealthStatus(true, "Hytract is health");
        }
    }
}
