using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlanVat.Managers
{
    /// <summary>
    /// Class for Moq tests
    /// </summary>
    public class DoublesManager
    {
        private ICalculations calculation;
        public DoublesManager(ICalculations calculation)
        {
            this.calculation = calculation;
        }

        public double Operate(double a, double b)
        {
            return calculation.Calculate(a, b);
        }
    }
}