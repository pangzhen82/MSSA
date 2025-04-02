using Assignment4_1_1Form;

namespace testForm
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

            DataPhoneBook.myPhoneBook.Add("jason williams", new Person("Jason", "Williams", "123-245-3225", "jwilliams@usa.com", "Fort Carson, CO"));
            DataPhoneBook.myPhoneBook.Add("amy johnson", new Person("Amy", "Johnson", "1357-225-1725", "ajohnson@usa.com", "Fremont, CA"));
            DataPhoneBook.myPhoneBook.Add("tom hanks", new Person("Tom", "Hanks", "542-445-5544", "thanks@usa.com", "Tempa, FL"));
            DataPhoneBook.myPhoneBook.Add("jason kidd", new Person("Jason", "Kidd", "243-557-8863", "jkidd@usa.com", "Honululu, HI"));
            DataPhoneBook.myPhoneBook.Add("ben johnson", new Person("Ben", "Johnson", "414-227-2347", "ben.johnson@usa.com", "Fort Campbell, KS"));
            
            Application.Run(new MainForm());
        }
    }
}