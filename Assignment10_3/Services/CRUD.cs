using Assignment10_3.Data;
using Assignment10_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10_3.Services
{
    public class CRUD
    {
        public void AddRecord (CarModel newCar)
        {
            Records.carContext.CarModels.Add(newCar);
            Records.carContext.SaveChanges();
        }
        public void DeleteRecord (string VIN)
        {
            var car = Records.carContext.CarModels.Find(VIN);
            if (car != null)
            {
                Records.carContext.CarModels.Remove(car);
                Records.carContext.SaveChanges();
            }
        }
        public void UpdateRecord (string VIN, CarModel newCar)
        {
            var carUpdate = Records.carContext.CarModels.Find(VIN);
            if (carUpdate != null)
            {
                carUpdate.Price = newCar.Price;
                carUpdate.Color = newCar.Color;
                Records.carContext.SaveChanges();
            }
        }
        public ICollection<CarModel> GetCarModels()
        {
            return Records.carContext.CarModels.ToList();
        }
        public CarModel FindCarModel(string VIN)
        {
            return Records.carContext.CarModels.Find(VIN);
        }
        public string GenerateVIN()
        {
            Random random = new Random();
            string newVIN ="";
            newVIN += random.Next(0, 10).ToString();
            for (int i = 0; i < 6; i++)
            {
                newVIN += ((Char)random.Next(65, 91)).ToString();
            }
            for (int i = 0; i < 8; i++)
            {
                newVIN += random.Next(0, 10).ToString();
            }
            if (Records.carContext.CarModels.Find(newVIN) != null)
            {
                newVIN = GenerateVIN();
            }
            return newVIN;
        }
    }
}
