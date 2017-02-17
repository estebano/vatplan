using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanVat.Managers
{
    /// <summary>
    /// Class for Moq tests
    /// </summary>
    public interface ICalculations
    {
        double Calculate(double a, double b);
    }
}
