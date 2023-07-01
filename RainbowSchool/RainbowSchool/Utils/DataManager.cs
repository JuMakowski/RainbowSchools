using RainbowSchool.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainbowSchool.Utils
{
    public class DataManager
    {
        private  static List<Student>? studentsList;
        public DataManager(List<Student> students) {
            studentsList = students;
        }
        public void GetData(string dir)
        {
            string[] lines;
            string filename = dir + "\\Data\\students.txt";
            if (File.Exists(filename))
            {
                Console.WriteLine(filename + " exists");
                lines = File.ReadAllLines(filename);
            }
            else
            {
                Console.WriteLine(filename + " does not exist");
                using (StreamWriter wrt = File.CreateText(filename))
                {
                    wrt.WriteLine("Name,1,Grade");
                }
                lines = File.ReadAllLines(filename);

            }
            foreach (string line in lines)
            {
                string[] data = line.Split(',');
                Student student = new Student
                {
                    Name = data[0],
                    Age = int.Parse(data[1]),
                    Grade = data[2]
                };

                studentsList.Add(student);
            }
        }
        public void DisplayStudents()
        {
            Console.WriteLine("Students:");
            foreach (Student student in studentsList)
            {
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Grade: {student.Grade}");
            }
        }
        public void SaveDataToFile()
        {
            using (StreamWriter writer = new StreamWriter("Data/students.txt", append: true))
            {
                foreach (Student student in studentsList)
                {
                    writer.WriteLine($"{student.Name},{student.Age},{student.Grade}");
                }
            }
        }
    }
}
