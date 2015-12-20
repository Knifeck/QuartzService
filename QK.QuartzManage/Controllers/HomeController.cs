using EmitMapper;
using QK.Quartz.IBizJob;
using QK.QuartzManage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QK.QuartzManage.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public JsonResult AddJonHttp(AddJobModel model)
        {
            ReturnResult result = new ReturnResult();
            try {
                HttpJobData jobdata = new HttpJobData();
                var mapper = ObjectMapperManager.DefaultInstance.GetMapper<JobModel, JobExcuteModel>();
                var job = mapper.Map(model.job);

                var mapHttp = ObjectMapperManager.DefaultInstance.GetMapper<HttpModel, HttpJobData>();
                var http = mapHttp.Map(model.http);

                JobHelper.AddJobHttp(job, http);
            }
            catch (Exception ex)
            {
                result.Statu = false;
                result.RtnMsg = "添加失败"+ex.Message;
            }
            result.Statu = true;
            result.RtnMsg = "添加成功";
            return Json(result);
        }


        public JsonResult TestAddJsonHttp()
        {
            ReturnResult result = new ReturnResult();
            try
            {
                var job = new JobExcuteModel();
                job.groupName = "test";
                job.jobName = "testjob";
                job.triggerName = "testtrigger";
                job.cronExp = @"/5 * * ? * *";

                var http = new HttpJobData();
                http.Method = "Get";
                http.Timeout = 120;
                http.Url = @"http://localhost:21424/home/index";

                JobHelper.AddJobHttp(job, http);
            }
            catch (Exception ex)
            {
                result.Statu = false;
                result.RtnMsg = "添加失败" + ex.Message;
            }
            result.Statu = true;
            result.RtnMsg = "添加成功";
            return Json(result);
        }
    }
}