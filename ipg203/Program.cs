using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ipg203
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            Teacher t = new Teacher("1", "Ali", "Math", "3000");
            Student s = new Student(5, "2", "Sara");
            Classroom c = new Classroom("C1", "First Room", 30);

            List<ISchool> list = new List<ISchool>();
            list.Add(t);
            list.Add(s);
            list.Add(c);

            Console.WriteLine("=== All School Members ===");
            foreach (var item in list) 
            {
                item.ShowInfo();
                Console.WriteLine("-------------------");
            }
        }
    }
}
