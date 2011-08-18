using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Objects;
using System.Data.Services;
using System.Data.Services.Common;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Web;
using BellWether.Models;

namespace BellWether.svc
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class BellService : DataService<BellwetherContext>
    {
        // This method is called only once to initialize service-wide policies.

        public static void InitializeService(DataServiceConfiguration config)
        {
            // TODO: set rules to indicate which entity sets and service operations are visible, updatable, etc.
            // Examples:
            // config.SetEntitySetAccessRule("MyEntityset", EntitySetRights.AllRead);
            // config.SetServiceOperationAccessRule("MyServiceOperation", ServiceOperationRights.All);
            config.SetEntitySetAccessRule("Bells", EntitySetRights.AllRead);
            config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V2;

        }

        protected override BellwetherContext CreateDataSource()
        {
            BellwetherContext ctx = new BellwetherContext();

            var objectContext = ((IObjectContextAdapter)ctx).ObjectContext;
            objectContext.ContextOptions.ProxyCreationEnabled = false;
            return ctx;

        }


    }
}
