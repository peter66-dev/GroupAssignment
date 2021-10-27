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

        public int GetTotalBill() => BillDAO.Instance.GetTotalBill();

        public void InsertBill(int id, decimal total) => BillDAO.Instance.InsertBill(id, total);

        public void RemoveBill(int id) => BillDAO.Instance.RemoveBill(id);

        public void UpdateBill(int id, decimal total) => BillDAO.Instance.UpdateBill(id, total);

        public List<BillObject> GetBillListByDate(DateTime start, DateTime end) => BillDAO.Instance.GetBillListByDate(start, end);

        public decimal GetTotalImportMoney() => BillDAO.Instance.GetTotalImportMoney();

        public List<BillObject> SortByTotalAscending() => BillDAO.Instance.SortByTotalAscending();

        public List<BillObject> SortByTotalDescending() => BillDAO.Instance.SortByTotalDescending();
    }
}
