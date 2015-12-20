using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QK.QuartzManage.Models
{
    public class JobModel
    {
        public string groupName { get; set; }

        public string jobName { get; set; }

        public string triggerName { get; set; }

        public string cronExp { get; set; }
    }

    public class HttpModel
    {
        public string Url { get; set; }

        public string Method { get; set; }

        public int Timeout { get; set; }

        public Dictionary<string, string> Params { get; set; }

        public string ContentType { get; set; }
    }

    public class AddJobModel
    {
        public JobModel job { get; set; }

        public HttpModel http { get; set; }


    }
}