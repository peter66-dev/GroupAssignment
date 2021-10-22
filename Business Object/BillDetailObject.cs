using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Object
{
    public class BillDetailObject
    {
        public int BillDetailID { get; set; }
        public int BillID { get; set; }
        public int PetID { get; set; }
        public string UserName { get; set; }
        public bool Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int QuantityBuy { get; set; }
        public decimal SubTotal { get; set; }
        public double Discount { get; set; }
        public BillDetailObject()
        {

        }
        public BillDetailObject(int billdetailid, int billid, int petid, string username, bool gen, string addr, 
            string phone, int quantitybuy, decimal subTotal, double discount)
        {
            BillDetailID = billdetailid;
            BillID = billdetailid;
            PetID = billid;
            UserName = username;
            Gender = gen;
            Address = addr;
            Phone = phone;
            QuantityBuy = quantitybuy;
            SubTotal = subTotal;
            Discount = discount;
        }
    }
}
