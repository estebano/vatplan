using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentValidation.Attributes;
using PlanVat.Domain.DB;
using PlanVat.Infrastructure;
using PlanVat.Validators;

namespace PlanVat.Models
{
    [Validator(typeof(ContractorValidator))]
    public class ContractorViewModel : Contractors
    {
        public Contractors ToDTO()
        {
            var sourceProperties = this.GetType().GetProperties();
            var destinationProperties = typeof(Contractors).GetProperties();

            var result = new Contractors();

            foreach (var src in sourceProperties)
            {
                if(destinationProperties.Contains(src, PropertyInfoComparer.OrdinalName))
                {
                    destinationProperties.Single(x => x.Name.Equals(src.Name)).SetValue(result, src.GetValue(this));
                }
            }

            return result;
        }
    }
}