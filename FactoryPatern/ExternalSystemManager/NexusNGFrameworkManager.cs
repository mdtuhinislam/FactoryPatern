using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.ExternalSystemManager
{
    internal class NexusNGFrameworkManager : IExternalSystemManager
    {
        public DTOs.HealthStatus CheckHealth()
        {
            return new DTOs.HealthStatus(true, "Nexus NG framework");
        }
    }
}
