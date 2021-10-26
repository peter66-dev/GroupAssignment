using Business_Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IBillRepository
    {
        public List<BillObject> GetBillList();
        public BillObject GetBillByID(int id);
        public void InsertBill(int id, decimal total);
        public void UpdateBill(int id, decimal total);
        public void RemoveBill(int id);
        public int GetTotalBill();
    }
}
