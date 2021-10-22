using Business_Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class BillRepository : IBillRepository
    {
        public BillObject GetBillByID(int id) => BillDAO.Instance.GetBillByID(id);

        public List<BillObject> GetBillList() => BillDAO.Instance.GetBillList();

        public void InsertBill(int id, decimal total) => BillDAO.Instance.InsertBill(id, total);

        public void RemoveBill(int id) => BillDAO.Instance.RemoveBill(id);

        public void UpdateBill(int id, decimal total) => BillDAO.Instance.UpdateBill(id, total);
    }
}
