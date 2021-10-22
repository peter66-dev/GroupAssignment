using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Object
{
    public class CategoryObject
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public CategoryObject()
        {

        }
        public CategoryObject(int cateid, string name)
        {
            CategoryID = cateid;
            CategoryName = name;
        }
    }
}
