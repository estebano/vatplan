using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using vatplan.DB;

namespace vatplan.Extensions
{
    public static class ContextExtensions
    {
        public static readonly string EFCONTEXT = "EFContext";

        public static VatplanEntities GetEfContext(this HttpContext me)
        {
            return me.Items[EFCONTEXT] as VatplanEntities;
        }
    }
}