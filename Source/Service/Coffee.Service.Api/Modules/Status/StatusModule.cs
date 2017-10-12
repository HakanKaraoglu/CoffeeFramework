using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.Service.Api.Modules.Status
{
    public class StatusModule : NancyModule
    {
        public StatusModule()
     : base("/status")
        {
            //Get["/"] = _ =>
            //{
            //    var healthChecks = HealthCheckManager.Run();
            //    var healthCheckResponse = Serializer.Serialize(healthChecks);

            //    if (healthChecks.Any(service => !service.Value.IsHealthy))
            //    {
            //        //Write Log
            //    }


            //    return
            //        Response.AsText(healthCheckResponse)
            //            .WithContentType("application/json")
            //            .WithStatusCode(HttpStatusCode.OK);
            //};
        }
    }
}
