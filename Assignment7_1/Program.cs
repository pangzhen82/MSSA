namespace Assignment7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- Sort students by scores ---
            SortStudentsByScoreProg();

            // --- Merge two strings ---
            MergeStringsProg();

            Console.ReadKey();
        }

        static void SortStudentsByScoreProg()
        {
            Console.WriteLine("\n--- Sort students by Scores ---\n");
            Student[] students = new Student[5];
            students[0] = new Student("Jack", 65);
            students[1] = new Student("Nathan", 83);
            students[2] = new Student("Amy", 85);
            students[3] = new Student("David", 78);
            students[4] = new Student("Tim", 98);

            Console.WriteLine("Students scores:");
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }

            SortStudentsByScore(students);
            Console.WriteLine("\nAfter sort by students scores:\n");
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
        }
        static void SortStudentsByScore(Student[] students)
        {
            if (students == null || students.Length == 0) return;
            for(int i = 0; i < students.Length - 1; i++)
            {
                int maxIndex = i;
                for (int j = i + 1; j < students.Length; j++)
                {
                    if (students[j].HasHigherScore(students[maxIndex]))
                        maxIndex = j;
                }
                if (maxIndex != i)
                {
                    Student temp = students[i];
                    students[i] = students[maxIndex];
                    students[maxIndex] = temp;
                }
            }
        }
        static void MergeStringsProg()
        {
            Console.WriteLine("\n--- Merge two strings --- \n");
            string str1 = GetUserString();
            string str2 = GetUserString();
            if (str1 != null) Console.WriteLine($"\nString 1: \"{str1}\"");
            if (str2 != null) Console.WriteLine($"String 2: \"{str2}\"");
            Console.WriteLine("\n After merging: \"" + MergeStrings(str1, str2) + "\""); 
        }
        static string MergeStrings(string str1, string str2)
        {
            if (str1 == null || str1 == string.Empty) return str2;
            else if (str2 == null || str2 == string.Empty) return str1;

            string newString = "";
            for (int i = 0; i < Math.Max(str1.Length, str2.Length); i++)
            {
                if(i < str1.Length) newString += str1[i];
                if(i < str2.Length) newString += str2[i];
            }
            return newString;
        }
        static string GetUserString()
        {
            Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine();
            return str.Trim();
        }
    }

    internal class Student
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public Student(string name, int score)
        {
            Name = name;
            Score = score;
        }
        public override string ToString()
        {
            return $"Student - {Name, 10} \t- final score: {Score}";
        }

        public bool HasHigherScore(Student stu)
        {
            return this.Score > stu.Score;
        }
    }
}
