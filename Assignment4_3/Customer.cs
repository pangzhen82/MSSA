using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_3
{
    internal class Customer
    {
        static private int ID = 1001;
        public int cusID;
        public string Name { get; set; }
        public int Unit {  get; set; }

        public double Surcharge { get { return this.surcharge; } }

        private int CusID { get {return this.cusID; } }
        private double electricBill;
        private double unitCharge;
        private double surcharge;

        public double ElectricBill { get { return this.electricBill; } }
        public double UnitCharge { get { return this.unitCharge; } }

        public Customer(string name, int unit)
        {
            this.cusID = ID++;
            this.Name = name;
            this.Unit = unit;
            CalculateUnitCharge();
            CalculateElectricBill();
        }

        private void CalculateUnitCharge()
        {
            if (this.Unit >600)
            {
                this.unitCharge = 2.0d;
            }
            else if (this.Unit > 400)
            {
                this.unitCharge = 1.8d;
            }
            else if (this.Unit > 200)
            {
                this.unitCharge = 1.5d;
            }
            else if (this.Unit >= 0)
            {
                this.unitCharge = 1.2d;
            }
        }

        private void ApplySurcharge()
        {
            if (this.electricBill > 400)
            {
                this.surcharge = this.ElectricBill * 0.15;
                this.electricBill += this.surcharge;
            }
            else
                this.surcharge = 0d;
        }
        private void CalculateElectricBill()
        {
            this.electricBill = this.unitCharge * this.Unit;
            ApplySurcharge();

        }

        public void Display()
        {
            Console.WriteLine("\n************************   Electric Bill   ******************************\n");
            Console.WriteLine("-------------------------------------------------------------------------\n");
            Console.WriteLine($"Customer ID No. : \t{this.CusID}");
            Console.WriteLine($"Customer name: \t\t{this.Name}");
            Console.WriteLine($"Unit consumed: \t\t{this.Unit}\n");
            Console.WriteLine($"Amount charges @${this.unitCharge.ToString("0.00")} per unit : \t\t${(this.unitCharge * this.Unit).ToString("0.00")}");
            Console.WriteLine($"Surcharge Amount: \t\t\t\t${this.Surcharge.ToString("0.00")}");
            Console.WriteLine($"Net amount paid by the customer: \t\t${this.ElectricBill.ToString("0.00")}");
            Console.WriteLine("-------------------------------------------------------------------------\n");
        }
    }
}
