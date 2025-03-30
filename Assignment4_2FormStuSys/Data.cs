using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_3StuSys
{
    internal class Data
    {
        // ----- List obj to hold Students Data
        public static List<Student> students = new List<Student>();

        // ----- Dictionary obj avoids DUPLICATES user names
        public static Dictionary<string, string> credentials = new Dictionary<string, string>();
    }

    internal class FileRecord
    {
        const string PATH = @"C:\Files\";
        public static void RecordTopStudentinFile(string fileName)
        {
            string AbsFilePath = PATH + fileName;
            StreamWriter streamWriter = null;

            if (!File.Exists(AbsFilePath))
            {
                streamWriter = File.CreateText(AbsFilePath);
                streamWriter.WriteLine($"New file {fileName} has been created at {DateTime.Now}");
                streamWriter.Close();
            }
            File.AppendAllText(AbsFilePath, Data.students[0].ToString());

            MessageBox.Show($"Top student recorded in file {fileName}");
        }
    }
}
