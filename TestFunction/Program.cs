using DataAccess;
using Business_Object;
using System;

namespace TestFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            BillDetailObject bill = new BillDetailObject {
                BillID = 1,
                PetID = 1,
                UserName = "No Name",
                Gender = true,
                Address = "Homeless",
                Phone = "097177414",
                QuantityBuy = 3,
                SubTotal = 12000,
                Discount = 0.32
            };
            BillDetailDAO.Instance.InsertBillDetail(bill);


        }
    }
}
