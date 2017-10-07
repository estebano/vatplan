using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentValidation;
using PlanVat.Domain.DB;

namespace PlanVat.Validators
{
    public class ContractorValidator : AbstractValidator<Contractors>
    {
        public ContractorValidator()
        {
            RuleFor(x => x.City).Must(city =>
            {
                return new string[]
                {
                    "Radom",
                    "Warszawa"
                }.Contains(city, StringComparer.OrdinalIgnoreCase);
            }).Length(3, 20);

            RuleFor(x => x.NIP)
                .InclusiveBetween(0, 9999999999);
        }

        protected override void EnsureInstanceNotNull(object instanceToValidate)
        {
            base.EnsureInstanceNotNull(instanceToValidate);
        }
    }
}