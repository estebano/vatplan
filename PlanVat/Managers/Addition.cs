using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Class for Moq tests
/// </summary>
namespace PlanVat.Managers
{
    public class Addition : ICalculations
    {
        public double Calculate(double a, double b)
        {
            return a + b;
        }
    }
}