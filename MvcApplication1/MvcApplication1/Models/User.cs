using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class User
    {
        public string Name { get; set; }
        public Address BillingAddress { get; set; }
        public OptionalAddress ShippingAddress { get; set; }
    }
}