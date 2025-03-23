using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_3
{
    internal class Customer
    {
        public string Name { get; set; }
        public string Phone { get; set; }

        public Customer(string name, string phone)
        {
            this.Name = name;
            this.Phone = phone;
        }

        public override string ToString()
        {
            return $"Customer: {this.Name} with phone number {this.Phone}";
        }
    }
}
