using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QK.Quartz.IBizJob
{
    public class JobExcuteModel
    {
        public string groupName { get; set; }

        public string jobName { get; set; }

        public string triggerName { get; set; }

        public string cronExp { get; set; }

    }
}
