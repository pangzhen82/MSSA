using Assignment10_3.Data;
using Microsoft.EntityFrameworkCore;

namespace Assignment10_3
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            InitializeDB();
            Application.Run(new Form1());
        }
        static void InitializeDB()
        {
            Records.carContext = new CarContext();
            Records.carContext.Database.EnsureCreated();
            Records.carContext.CarModels.Load();
        }
    }
}