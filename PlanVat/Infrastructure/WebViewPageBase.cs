using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PlanVat.Infrastructure
{
    public class WebViewPageBase<T> : WebViewPage<T>
    {
        public override void InitHelpers()
        {
            base.InitHelpers();
        }

        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }
}