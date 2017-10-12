using Nancy.Hosting.Self;
using System;
using System.Linq;

namespace Coffee.Service.Api.App_Start
{
    public class SelfHost
    {
        private NancyHost _nancyHost;

        public void Start(Settings settings)
        {
            var configurationToListenOnAllPorts = new HostConfiguration
            {
                UrlReservations = { CreateAutomatically = true },
                AllowChunkedEncoding = false
            };

            var urls = settings.Service.BaseUrls.Split(',').ToList();
            var baseUris = urls.Select(x => new Uri(x)).ToArray();
            _nancyHost = new NancyHost(configurationToListenOnAllPorts, baseUris);
            _nancyHost.Start();
        }

        public void Stop()
        {
            _nancyHost.Stop();
        }
    }
}
