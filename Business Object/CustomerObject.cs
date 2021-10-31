using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Object
{
    public class CustomerObject
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public bool Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int AccumulatedPoint { get; set; }
        public bool Status { get; set; }
        public CustomerObject()
        {

        }
        public CustomerObject(int id, string name, bool gen, string email, string phone, string addre, int point, bool status)
        {
            CustomerID = id;
            CustomerName = name;
            Gender = gen;
            Email = email;
            Phone = phone;
            Address = addre;
            AccumulatedPoint = point;
            Status = status;
        }
    }
}
