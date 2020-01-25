using System;
using System.Collections.Generic;
using System.Text;

namespace LinqExample
{
    class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? CustomerTypeId { get; set; }
        public string EmailAddress { get; set; }
    }
}
