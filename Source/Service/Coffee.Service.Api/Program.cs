using Coffee.Service.Api.App_Start;
using System;
using System.Collections.Generic;
using System.Configuration.Abstractions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace Coffee.Service.Api
{
    class Program
    {
        static void Main(string[] args)
        {
            var settings = ConfigurationManager.Instance.AppSettings.Map<Settings>();

            HostFactory.Run(config =>
            {
                config.Service<SelfHost>(sc =>
                {
                    sc.ConstructUsing(() => new SelfHost());
                    sc.WhenStarted(s => s.Start(settings));
                    sc.WhenStopped(s => s.Stop());
                });

                config.SetServiceName(settings.Service.ServiceName);
                config.SetDisplayName(settings.Service.DisplayName);
                config.SetDescription(settings.Service.Description);
            });
        }
    }
}
