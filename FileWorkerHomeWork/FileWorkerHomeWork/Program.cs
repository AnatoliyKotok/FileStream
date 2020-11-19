using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWorkerHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname = "Student.txt";
            Student student = new Student("Anatoliy", "Kotok", new int[] { 11, 12, 11 }, ProfesionType.Programmer);
            Console.WriteLine(student);
            Student student2 = new Student("Bob", "Kotok", new int[] { 11, 12, 11 }, ProfesionType.Designer);
            FileWorker.SaveStudent(student, fname);
            FileWorker.SaveStudent(student2, fname);
            FileWorker.LoadStudent(fname);
        }
    }
}
