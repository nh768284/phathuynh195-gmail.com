using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;

using System.Collections.Generic;

namespace DAL
{
    public class CustomerDAL
    {
        private static List<Customer> customers = new List<Customer>();

        public void Add(Customer c)
        {
            customers.Add(c);
        }

        public List<Customer> GetAll()
        {
            return customers;
        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
