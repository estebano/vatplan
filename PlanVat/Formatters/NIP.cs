using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlanVat.Formatters
{
    public class NIP
    {
        public static string OldFashionFormat(long nip)
        {
            return string.Format("{0:###-##-##-###}", nip);
        }
    }
}