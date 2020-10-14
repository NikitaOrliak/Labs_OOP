using System;
using System.Collections.Generic;


namespace Homework_Group
{
    class Program
    {
        abstract class Student
        {
            public string Name;
            public string State;

            public Student(string name)
            { 
                this.Name = name;
                this.State = "";
            }

            public void Read()
            {
                this.State += "Read ";
            }

            public void Write()
            {
                this.State += "Write ";
            }

            public void Relax()
            {
                this.State += "Relax ";
            }

            public abstract void Study();
        }

        class GoodStudent : Student
        {
            public GoodStudent(string name) : base(name)
            {
                this.State = "good ";
            }

            public override void Study()
            {
                this.Read();
                this.Write();
                this.Read();
                this.Write();
                this.Relax();
            }
        }

        class BadStudent : Student
        {
            public BadStudent(string name) : base(name)
            {
                this.State = "bad ";
            }

            public override void Study()
            {
                this.Relax();
                this.Relax();
                this.Relax();
                this.Relax();
                this.Read();
            }
        }

        class Group
        {
            public string Name;
            public List<Student> Students;

            public Group(string name)
            {
                this.Name = name;
                this.Students = new List<Student>();
            }

            public void AddStudent(Student st)
            {
                this.Students.Add(st);
            }

            public void Study()
            {
                foreach (Student st in this.Students)
                {
                    st.Study();
                }
            }

            public void GetInfo()
            {
                Console.Write(this.Name + " \n");
                foreach (Student st in this.Students)
                {
                    Console.Write(st.Name + " \n");
                }
            }

            public void GetFullInfo()
            {
                Console.Write(this.Name + " \n");
                foreach (Student st in this.Students)
                {
                    Console.WriteLine(st.Name + " " + st.State);
                }
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Орляк Нiкiта К-24");

            Console.WriteLine("Введiть назву групи: ");
            string groupName = Console.ReadLine();

            Console.WriteLine("Введiть iм'я першого студента: ");
            string student_1 = Console.ReadLine();

            Console.WriteLine("Введiть iм'я другого студента: ");
            string student_2 = Console.ReadLine();

            Console.WriteLine("Введiть iм'я третього студента: ");
            string student_3 = Console.ReadLine();

            Group group = new Group(groupName);
            group.AddStudent(new BadStudent(student_1));
            group.AddStudent(new GoodStudent(student_2));
            group.AddStudent(new BadStudent(student_3));

            group.Study();

            Console.WriteLine("Бажаєте переглянути часткову(1) чи повну(2) iнформацiю?");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num == 1)
            {
                group.GetInfo();
            }
            else
            {
                group.GetFullInfo();
            }

            Console.ReadKey();
        }
    }
}