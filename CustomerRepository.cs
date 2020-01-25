using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinqExample
{
    class CustomerRepository
    {
        public  Customer  Find(List<Customer> Cust,int custId)
        {
            Customer fCustomer = null;
            var selectedCust = from c in Cust
                               where c.CustomerId == custId 
                               select c;
              fCustomer= selectedCust.First();
            return fCustomer;
        } 
        public List<Customer> Retrive()
        {
            
            List<Customer> Cust = new List<Customer>
            {
                new Customer()
                {
                    CustomerId=100,
                    FirstName="A",
                    LastName="B",
                    CustomerTypeId=2003,
                    EmailAddress="george@gmail.com"
                },
                new Customer()
                {
                     CustomerId=101,
                    FirstName="A1",
                    LastName="B1",
                    CustomerTypeId=2002,
                    EmailAddress="george@gmail.com"
                },
                new Customer()
                {
                    CustomerId=102,
                    FirstName="A2",
                    LastName="B2",
                    CustomerTypeId=2001,
                    EmailAddress="george@gmail.com"
                }
            };
            return Cust;
        }
    }
}
