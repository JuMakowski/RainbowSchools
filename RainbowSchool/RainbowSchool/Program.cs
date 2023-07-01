using RainbowSchool.Users;
using RainbowSchool.Utils;
using System;
using System.Collections.Generic;
using System.IO;

namespace RainbowSchool
{
    class Program
    {
        static List<Student> students = new List<Student>();
        static DataManager studentsData = new DataManager(students);

        static void Main(string[] args)
        {
            studentsData.GetData(Directory.GetCurrentDirectory());
            studentsData.DisplayStudents();


        }
    }
}