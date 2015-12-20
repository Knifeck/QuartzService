using QK.Common.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace QK.QuartzService
{
    class Program
    {
        static void Main(string[] args)
        {
            LogHelper.SetConfig();
            HostFactory.Run(x =>
            {
                x.Service<Manager>(s =>
                {
                    s.ConstructUsing(name => new Manager());
                    s.WhenStarted(tc => tc.OnStart());
                    s.WhenStopped(tc => tc.OnStop());
                });
                x.RunAsLocalSystem();
                x.SetDescription("QK QuartzService");
                x.SetDisplayName("QuartzService");
                x.SetServiceName("QuartzService");
            });
        }
    }
}
