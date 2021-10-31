﻿using Business_Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public void DeleteCustomer(int id) => CustomerDAO.Instance.DeleteCustomer(id);

        public CustomerObject GetACustomerByEmail(string email) => CustomerDAO.Instance.GetACustomerByEmail(email);

        public CustomerObject GetACustomerByPhone(string phone) => CustomerDAO.Instance.GetACustomerByPhone(phone);

        public List<CustomerObject> GetCustomerByEmail(string email) => CustomerDAO.Instance.GetCustomerByEmail(email);

        public CustomerObject GetCustomerByID(int id) => CustomerDAO.Instance.GetCustomerByID(id);

        public CustomerObject GetCustomerForeignKey(int cusID) => CustomerDAO.Instance.GetCustomerForeignKey(cusID);

        public List<CustomerObject> GetCustomerList() => CustomerDAO.Instance.GetCustomerList();

        public void InsertCustomer(CustomerObject cus) => CustomerDAO.Instance.InsertCustomer(cus);

        public List<CustomerObject> SortCustomerAscendingName() => CustomerDAO.Instance.SortCustomerAscendingName();

        public List<CustomerObject> SortCustomerDescendingName() => CustomerDAO.Instance.SortCustomerDescendingName();

        public void UpdateCustomer(CustomerObject cus) => CustomerDAO.Instance.UpdateCustomer(cus);
    }
}
