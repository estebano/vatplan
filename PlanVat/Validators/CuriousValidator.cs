using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentValidation;
using PlanVat.Domain.DB;

namespace PlanVat.Validators
{
    public class CuriousValidator : AbstractValidator<Contractors>
    {
        public CuriousValidator()
        {

        }
    }
}