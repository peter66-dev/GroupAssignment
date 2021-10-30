using Business_Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface ICustomerRepository
    {
        public List<CustomerObject> GetCustomerList();

        public void InsertCustomer(CustomerObject cus);

        public void UpdateCustomer(CustomerObject cus);

        public CustomerObject GetCustomerByID(int id);

        public List<CustomerObject> GetCustomerByEmail(string email);

        public CustomerObject GetCustomerForeignKey(int cusID);

        public void DeleteCustomer(int id);
        public List<CustomerObject> SortCustomerAscendingName();
        public List<CustomerObject> SortCustomerDescendingName();

    }
}
