using Business_Object;
using DataAccess.Repository;
using System;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomerRepository repo = new CustomerRepository();
            //foreach (var customer in repo.GetCustomerList())
            //{
            //    Console.WriteLine($"Customer Name: {customer.CustomerName}");
            //}
            CustomerObject cus = new
                CustomerObject(0, "Meeee", false, "trieumee24@gmai.com", "023912931", "Gò Vấp TPHCM", 2, true);
            Console.WriteLine(repo.GetCustomerByEmail("mee").CustomerName);
        
        }
    }
}
