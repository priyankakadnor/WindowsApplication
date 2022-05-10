using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApplication

{
    [Serializable]
    class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public string  categoryname{get;set;}
    }
}
