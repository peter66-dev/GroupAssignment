using Business_Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IBillDetailRepository
    {
        public void InsertBillDetail(BillDetailObject bill);
        public List<BillDetailObject> GetBillDetailList();
    }
}
