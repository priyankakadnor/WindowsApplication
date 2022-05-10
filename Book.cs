using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApplication
{
    [Serializable]
    class Book
    {
        public int id { get; set; }
        public string name { get; set;}
        public string authorname { get; set; }
        public int price { get; set; }
    }
}
