using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using DAL;
using System.Collections.Generic;

namespace BLL
{
    public class CustomerBLL
    {
        CustomerDAL dal = new CustomerDAL();

        public string SaveCustomer(string name, string phone, string address)
        {
            if (string.IsNullOrWhiteSpace(name))
                return "Tên không được để trống!";
            if (string.IsNullOrWhiteSpace(phone))
                return "Điện thoại không được để trống!";
            if (string.IsNullOrWhiteSpace(address))
                return "Địa chỉ không được để trống!";

            Customer c = new Customer()
            {
                Name = name,
                Phone = phone,
                Address = address
            };

            dal.Add(c);
            return "Lưu thành công!";
        }

        public List<Customer> GetAll()
        {
            return dal.GetAll();
        }
    }
}