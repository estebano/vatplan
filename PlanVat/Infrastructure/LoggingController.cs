using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Common.Logging;

namespace PlanVat.Infrastructure
{
    public class LoggingController : Controller
    {
        protected static ILog Log = LogManager.GetCurrentClassLogger();

        public LoggingController()
        {

        }
    }
}