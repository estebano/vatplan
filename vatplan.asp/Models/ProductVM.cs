using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace vatplan.asp.Models
{
    public class ProductVM
    {
        [Required]
        public string Name
        {
            get;
            set;
        }

        public string Description { get; set; }

        [Required]
        public string PKWiU { get; set; }


    }
}