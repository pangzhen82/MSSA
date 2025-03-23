namespace Assignment6_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyCallLineProg();

            Console.ReadKey();
        }

        static void MyCallLineProg()
        {
            CallQueue<Customer> callLine = new CallQueue<Customer>();
            char option = 'y';
            while (option == 'y' || option == 'Y')
            {
                CallMenu(callLine);
                Console.WriteLine("\nContinue? (y/n)");
                option = GetOption();
            }
        }

        static void CallMenu(CallQueue<Customer> callLine)
        {
            Console.WriteLine("\n ** Call Line Menu: **");
            Console.WriteLine("1 - Add a customer call");
            Console.WriteLine("2 - Take a customer call");
            Console.WriteLine("3 - Show my call line");
            Console.Write("\nChoose: ");
            int choice = GetChoice();
            switch (choice)
            {
                case 1:
                    Customer newCustomer = GetCustomer();
                    callLine.Enqueue(newCustomer);
                    break;
                case 2:
                    callLine.Dequeue();
                    break;
                case 3:
                    callLine.Display();
                    break;
                default:
                    break;
            }
        }
        static char GetOption()
        {
            char option;
            bool isValid;
            GetOption:
            isValid = char.TryParse(Console.ReadLine(), out option);
            if(!isValid || !(option == 'y' || option == 'n') )
            {
                Console.WriteLine("\nError! Enter valid option!\nContinue? (y/n)");
                goto GetOption;
            }
            return option;
        }
        static int GetChoice()
        {
            int choice;
            bool isValid;
        GetChoice:
            isValid = int.TryParse(Console.ReadLine(), out choice);
            if (!isValid || choice > 3 || choice < 1)
            {
                Console.WriteLine("\nError! Enter valid choice! (1, 2, 3)");
                goto GetChoice;
            }
            return choice;
        }
        static Customer GetCustomer()
        {
            string name, phone;
        getName:
            Console.Write("Enter name of caller: ");
            name = Console.ReadLine();
            if (name == string.Empty)
            {
                Console.WriteLine("\nError! Name can't be empty!");
                goto getName;
            }
        getPhone:
            Console.Write("Enter phone number of caller: ");
            phone = Console.ReadLine();
            if (phone == string.Empty)
            {
                Console.WriteLine("\nError! Phone can't be empty!");
                goto getPhone;
            }
            return new Customer(name, phone);
        }
    }
}
