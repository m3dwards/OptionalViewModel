using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Models
{
    public class Address
    {
        public string Line1 { get; set; }

        [RequiredIf("IsRequired", ErrorMessage = "Post code is required")]
        public string PostCode { get; set; }

        [ScaffoldColumn(false)]
        public virtual bool IsRequired
        {
            get 
            {
                return true;
            }
        }
    }
}