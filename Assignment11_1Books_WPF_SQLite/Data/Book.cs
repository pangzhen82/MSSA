using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11_1Books_WPF_SQLite.Data
{
    public class Book
    {
        public int ID { get; set; }
        public string BookTitle { get; set; }
        public string AuthorName { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public int ISBN { 
            get
            {
                return this.ID;
            }
        }
    }
}
