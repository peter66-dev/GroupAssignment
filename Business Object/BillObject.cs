using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Object
{
    public class BillObject
    {
        public int BillID { get; set; }
        public int CustomerID { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
        public bool Status { get; set; }
        public BillObject()
        {

        }
        public BillObject(int id, int cusID, decimal money, DateTime date, bool status)
        {
            BillID = id;
            CustomerID = cusID;
            Total = money;
            Date = date;
            Status = status;
        }
    }
}
