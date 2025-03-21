using Assignment10_3.Data;
using Assignment10_3.Models;
using Assignment10_3.Services;

namespace Assignment10_3
{
    public partial class Form1 : Form
    {
        CRUD _crud;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _crud = new CRUD();
            Refresh();
            btnSubmit.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            //UpdateDB();
        }
        private void UpdateDB()
        {
            _crud.AddRecord(new CarModel { VIN = "7ASDFSD34563456", Make = "TOYOTA", Model = "CAMRY", Price = 35_000, Year = 2024, Color = "Gray" });
            _crud.AddRecord(new CarModel { VIN = "7DKDKDK78436474", Make = "HONDA", Model = "TYPE R", Price = 65_000, Year = 2021, Color = "Red" });
            _crud.AddRecord(new CarModel { VIN = "7ASDDDF34563456", Make = "PORSCHE", Model = "911", Price = 95_000, Year = 2022, Color = "Light Blue" });
            _crud.AddRecord(new CarModel { VIN = "6JDJDKD85484948", Make = "TESLA", Model = "Y", Price = 65_000, Year = 2025, Color = "Quick Silver" });
            _crud.AddRecord(new CarModel { VIN = "4JDJDDK85757474", Make = "FORD", Model = "EXPLORER", Price = 35_000, Year = 2019, Color = "Black" });
            _crud.AddRecord(new CarModel { VIN = "5ASDU3JDD345236", Make = "MERCEDEZ", Model = "CLA200", Price = 35_000, Year = 2024, Color = "White" });
            _crud.AddRecord(new CarModel { VIN = "7AJDJDK84849856", Make = "BMW", Model = "Z4", Price = 55_000, Year = 2020, Color = "Neon Blue" });
        }
        private void Refresh()
        {
            carGrid.DataSource = _crud.GetCarModels();
        }
        private void ClearAll()
        {
            txtVIN.Clear();
            txtMake.Clear();
            txtModel.Clear();
            txtPrice.Clear();
            txtYear.Clear();
            txtColor.Clear();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtVIN.Text = _crud.GenerateVIN();
            txtVIN.ReadOnly = true;
            txtMake.Clear();
            txtModel.Clear();
            txtPrice.Clear();
            txtYear.Clear();
            btnSubmit.Enabled = true;
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (_crud.GetCarModels().Count != 0)
            {
                var vin = carGrid.CurrentRow.Cells[0].Value;
                var carUpdate = _crud.FindCarModel(vin.ToString());
                txtVIN.Text = carUpdate.VIN;
                txtVIN.ReadOnly = true;
                txtMake.Text = carUpdate.Make;
                txtMake.ReadOnly = true;
                txtModel.Text = carUpdate.Model;
                txtModel.ReadOnly = true;
                txtPrice.Text = carUpdate.Price.ToString();
                txtYear.Text = carUpdate.Year.ToString();
                txtColor.Text = carUpdate.Color;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                MessageBox.Show("Empty List!");
            }
        }
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            ClearAll();
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnSubmit.Enabled = false;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMake.Text) && !string.IsNullOrEmpty(txtModel.Text)
                && !string.IsNullOrEmpty(txtPrice.Text) && !string.IsNullOrEmpty(txtYear.Text)
                && !string.IsNullOrEmpty(txtColor.Text))
            {
                var newCar = new CarModel();
                newCar.VIN = txtVIN.Text;
                newCar.Make = txtMake.Text;
                newCar.Model = txtModel.Text;
                newCar.Price = double.Parse(txtPrice.Text);
                newCar.Year = int.Parse(txtYear.Text);
                newCar.Color = txtColor.Text;
                _crud.AddRecord(newCar);
                MessageBox.Show("New car added!");
            }
            else
            {
                MessageBox.Show("Make and model can't be empty!");
            }
            btnSubmit.Enabled = false;
            ClearAll();
            Refresh();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var vin = txtVIN.Text;
            var carUpdate = _crud.FindCarModel(vin);
            carUpdate.Price = double.Parse(txtPrice.Text);
            carUpdate.Year = int.Parse(txtYear.Text);
            carUpdate.Color = txtColor.Text;
            _crud.UpdateRecord(vin, carUpdate);
            MessageBox.Show("Record updated!");
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            Refresh();
            ClearAll();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            var vin = carGrid.CurrentRow.Cells[0].Value;
            _crud.DeleteRecord(vin.ToString());
            MessageBox.Show("Record deleted!");
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            ClearAll();
            Refresh();
        }
    }
}
