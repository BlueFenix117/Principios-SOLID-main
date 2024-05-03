using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsability
{
    internal class StudentExport
    {

        private static FakeStorage<Student> storage;

        public StudentExport()
        {
            storage = new();
        }

        public IEnumerable<Student> GetAll()
        {
            return storage.GetAll();
        }

        public void Export()
        {
            IEnumerable<Student> students = this.GetAll();
            string csv = String.Join(",", students.Select(x => x.ToString()).ToArray());
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine("Id;Fullname;Grades");
            foreach (var item in students)
            {
                sb.AppendLine($"{item.Id};{item.Fullname};{string.Join("|", item.Grades)}");
            }
            System.IO.File.WriteAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Students.csv"), sb.ToString(), Encoding.Unicode);
        }

    }
}
