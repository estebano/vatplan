using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlanVat.Formatters
{
    public class Postal
    {
        public static string PolishFormat(int postal)
        {
            return string.Format("{0:##-###}", postal);
        }
    }
}