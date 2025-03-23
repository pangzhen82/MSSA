using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_1
{
    internal class HouseNode
    {
        static int ID = 1000;

        private int houseID;
        public string Address { get; set; }
        public string Type { get; set; }
        public int HouseID { get { return houseID; } }
        public HouseNode next;

        public HouseNode(string addr, string type)
        {
            this.Address = addr;
            this.Type = type;
            this.houseID = ++ID;
            this.next = null;
        }
        public HouseNode(string addr, string type, HouseNode node)
        {
            this.Address = addr;
            this.Type = type;
            this.next = node;
            this.houseID = ++ID;
        }

        public override string ToString()
        {
            return $"House#: {this.HouseID}, \taddress: {this.Address}, \ttype: {this.Type}";
        }
    }
}
