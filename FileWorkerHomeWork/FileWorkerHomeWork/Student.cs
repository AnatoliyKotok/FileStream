using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWorkerHomeWork
{
    enum ProfesionType {Designer, Programmer };
    class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int[] Marks { get; set; }
        public ProfesionType Profesion { get; set; }
        public Student(string name,string surname,int[]marks,ProfesionType profesion)
        {
            this.Name = name;
            this.Surname = surname;
            this.Marks = marks;
            this.Profesion = profesion;
        }
        public override string ToString()
        {
            return $"{Name}\n{Surname}\n{String.Join(" ",Marks)}\n{Profesion}";
        }

    }

    class FileWorker
    {
        public static void SaveStudent(Student student, string fname)
        {
            using (StreamWriter sw = new StreamWriter(fname, true, System.Text.Encoding.Default))
            {
                
                sw.WriteLine(student);
            }
        }
        public static void LoadStudent(string fname)
        {
            using (StreamReader sr = new StreamReader(fname, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line); 
                    
                    //Student student;
                    //string[] items = line.Split(' '); 
                }
            }
        }
    }
}
