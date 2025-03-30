namespace Assignment3_3StuSys
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

            Data.students.Add(new Student("Nathan", "James", 3.8, Month.July, Grade.A));
            Data.students.Add(new Student("Adam", "Johnson", 3.6, Month.August, Grade.B));
            Data.students.Add(new Student("Amy", "Lian", 3.7, Month.April, Grade.A));
            Data.students.Add(new Student("Erica", "Smith", 3.8, Month.May, Grade.A));
            Data.students.Add(new Student("Michael", "Jordan", 3.9, Month.July, Grade.B));
            //Data.students.Add(new Student("Kobe", "Bryant", 3.7, Month.December, Grade.A));
            //Data.students.Add(new Student("Derek", "Top", 3.6, Month.November, Grade.A));
            //Data.students.Add(new Student("Eden", "Hook", 3.8, Month.December, Grade.C));
            //Data.students.Add(new Student("Joseline", "Karr", 3.9, Month.February, Grade.A));
            //Data.students.Add(new Student("Mike", "Ray", 4.0, Month.February, Grade.C));
            //Data.students.Add(new Student("Steve", "Homan", 3.8, Month.May, Grade.A));
            //Data.students.Add(new Student("Conan", "Yoshi", 3.7, Month.November, Grade.A));

            Data.credentials.Add("Admin", "Passw0rd");
            Data.credentials.Add("User", "password123");
            Data.credentials.Add("Teacher", "Admin");

            Application.Run(new formLogin());
        }
    }
}