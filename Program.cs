using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework_6_Week_7
{
    internal class Program
    {
        public class Company
        {
            public static string Nationality(string nationality, int totalPayment)
            {
                int percentGeorgia = 18;
                int percentForeign = 5;
                int totalToPay = 0;
                if (nationality == "Georgia")
                {
                    totalToPay = totalPayment * percentGeorgia / 100;
                }
                else
                {
                    totalToPay = totalPayment * percentForeign / 100;
                }
                return "Total to pay to government: " + totalToPay;
            }
        }

        public class Emploee
        {
            public static string CountingSalary()
            {
                string name = "Mike";
                string surname = "Wazowski";
                int age = 25;
                string position = "Developer";
                int[] workingHours = new int[] { 8, 8, 10, 8, 9, 0, 0 };
                int developerSalary = 30;
                int managerSalary = 40;
                int testerSalary = 20;
                int diffSalary = 10;
                int salary = 0;
                int totalWorkHours = 0;
                int bonusSalary = 20;
                int overTimeSalary = 5;
                if (position == "Developer")
                {
                    for (int i = 0; i < workingHours.Length; i++)
                    {
                        totalWorkHours += workingHours[i];
                        if (workingHours[i] <= 8)
                        {
                            salary += workingHours[i] * developerSalary;
                        }
                        else
                        {
                            salary += (workingHours[i] * developerSalary) + ((workingHours[i] - 8) * overTimeSalary);
                        }

                    }
                    if (totalWorkHours >= 50)
                    {
                        salary += salary * bonusSalary / 100;
                    }
                }
                return $"{name}--{surname}-- total salary is {salary} ";
            }


        }
        public class Teacher
        {

            public string Name { get; set; }
            public string Status { get; set; }

            public static string Subject()
            {
                Student studentClass = new Student();
                var subject = Student.GetSubject();
                Random rand = new Random();
                int x = rand.Next(0, 100);
                int y = rand.Next(0, 100);
                switch (subject)
                {
                    case "Mathematics":
                        Console.WriteLine(x + y);
                        break;
                    case "Chemistry":
                        Console.WriteLine("H2O");
                        break;
                    case "English":
                        Console.WriteLine("This look's like a job for me!");
                        break;
                    default:
                        Console.WriteLine("Ohh, i am not very competent in this subject");
                        break;
                }
                return null;
            }


        }
        public class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public int AdmissionTime { get; set; }

            public static string GetSubject()
            {
                string[] subject = new string[] { "Mathematics", "English", "History", "Geography", "Chemistry" };
                Random rand = new Random();
                int y = rand.Next(subject.Length);
                return subject[y];
            }
            public void LeftYears(int admissionTime)
            {
                AdmissionTime = admissionTime;
                Console.WriteLine((AdmissionTime + 4) - 2022);
            }
        }
        static void StudentInfo()
        {
            Student studentClass = new Student();
            Teacher teacherClass = new Teacher();
            Console.WriteLine("Enter Name of a student");
            studentClass.Name = Console.ReadLine(); ;
            Console.WriteLine("Enter Age of a student");
            studentClass.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Admission time of a student in university");
            studentClass.AdmissionTime = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Student.GetSubject());
            int admissionTime = studentClass.AdmissionTime;
            var newStudent = new Student();
            Console.WriteLine("this is how much is left to study: ");
            newStudent.LeftYears(admissionTime);
            Console.WriteLine("Subject is: ");
            Console.WriteLine(Student.GetSubject());
        }
        static void CompanyAndEmploeeInfo()
        {
            Company myclass = new Company();
            Emploee mycalss = new Emploee();
            Console.WriteLine("Enter Nationality of the company");
            string nationality = Console.ReadLine();
            Console.WriteLine("Enter total payment of the company");
            int totalPayment = Convert.ToInt32(Console.ReadLine());
            string v = Company.Nationality(nationality, totalPayment);
            Console.WriteLine(v);
            string y = Emploee.CountingSalary();
            Console.WriteLine(y);
        }
        public class StudentsInformation
        {
            public string Name { get; set; }
            public void Study(string studying)
            {
                studying = null;
            }
            public void Read(string read)
            {
                read = null;
            }
            public void Write(string write)
            {
                write = null;
            }
            public void Relax(string relax)
            {
                relax = null;
            }

        }
        public class GoodStudent : StudentsInformation
        {
            public GoodStudent()
            {
                Study("He is studying very good!");
                Read("He is reading William Shakespear");
                Write("he is writing novels");
                Relax("He is not relaxed");
            }
        }
        public class LazyStudent : StudentsInformation
        {
            public LazyStudent()
            {
                Study("He is not studying");
                Read("he is not readying anything!");
                Write("he is stil writing Novels!");
                Relax("He is relaxed");
            }
        }
        public class ClassRoom
        {
            public ClassRoom()
            {
            }

            public ClassRoom(string Name)
            {
                StudentsInformation studentsInformation = new StudentsInformation();
                studentsInformation.Name = Name;
                var goodStudent = new GoodStudent();
                Console.WriteLine(goodStudent);
                var lazyStudent = new LazyStudent();
                Console.WriteLine(lazyStudent);
            }
        }
        static void TeacherInfo()
        {
            Teacher teacher = new Teacher();
            Console.WriteLine("Enter Teacher's Name: ");
            teacher.Name = Console.ReadLine();
            Console.WriteLine("Enter if Teacher is certified or not: ");
            teacher.Status = Console.ReadLine();
            Teacher.Subject();

        }
        static void Main(string[] args)
        {
            #region SolutionN1
            CompanyAndEmploeeInfo();
            #endregion

            #region SolutionN2
            StudentInfo();
            TeacherInfo();
            ClassRoom classRoomClass = new ClassRoom();
            var classRoom = new ClassRoom();
            Console.WriteLine(classRoom);
            #endregion
        }
    }
}

