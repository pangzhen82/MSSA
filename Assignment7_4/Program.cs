namespace Assignment7_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- Test parking system ---
            TestParkingSystemProg();

            Console.ReadKey();
        } 

        static void TestParkingSystemProg()
        {
            Console.WriteLine("\n--- Test parking system ---\n");
            ParkingSystem parkingSystem = new ParkingSystem(1, 1, 0);
            Console.WriteLine(parkingSystem.AddCar(1)); // return true because there is 1 available slot for a big car
            Console.WriteLine(parkingSystem.AddCar(2)); // return true because there is 1 available slot for a medium car
            Console.WriteLine(parkingSystem.AddCar(3)); // return false because there is no available slot for a small car
            Console.WriteLine(parkingSystem.AddCar(1)); // return false because there is no available slot for a big car. It is already occupied.
        }
    }
}
