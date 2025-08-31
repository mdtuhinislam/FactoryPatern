using FactoryPattern.ExternalSystemManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.HealthCheckupFactory
{
    internal class HealthCheckupFactoryManager
    {
        public static IExternalSystemManager GetHealthCheckupFactory(string factoryType)
        {
            switch (factoryType)
            {
                case "reprocessing-db-context":
                    return new ReprocessingDbContextManager();
                case "hytrack-system-activate":
                    return new HytrackSystemManager();
                case "ng-framework-activate":
                    return new HytrackSystemManager();
                default:
                    throw new ArgumentException("Invalid factory type");
            }
        }
    }
}
