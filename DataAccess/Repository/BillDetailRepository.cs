using Business_Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class BillDetailRepository : IBillDetailRepository
    {
        public List<BillDetailObject> GetBillDetailList() => BillDetailDAO.Instance.GetBillDetailList();

        public void InsertBillDetail(BillDetailObject bill) => BillDetailDAO.Instance.InsertBillDetail(bill);
    }
}
