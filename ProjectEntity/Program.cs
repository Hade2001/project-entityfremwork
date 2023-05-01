using System;
using System.Linq;

namespace ProjectEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            var _context = new ApplicationDbContext();
            Department department = new Department
            {

                Name = "برمجيات"
            };
            _context.Departments.Add(department);
            _context.SaveChanges();
            while (true)
            {
                Console.WriteLine("department id");
                int id = int.Parse(Console.ReadLine());
                var department1 = _context.Departments.Find(id);
                if (department1 is null)
                {
                    Console.WriteLine("department is not exsiting ");
                    continue;
                }
                Console.WriteLine("enter the new Namedepartment");
                string named = Console.ReadLine();
                department1.Name = named;
                _context.Update(department1);
                _context.SaveChanges();
                break;
            }
            var student = new Student
            {
                UserName = "hadi",
                FirstName = "Ahmad",
                LastName = "altobaje",
                Email = "ahmadt@gmail.com",
                Phone = "0932244654",
                RegisterDate = 2023,
                DepartmentId = 1
            };
            _context.Students.Add(student);
            _context.SaveChanges();
            while (true)
            {
                Console.WriteLine("std id");
                int id = int.Parse(Console.ReadLine());
                var std1 = _context.Students.Find(id);
                if (std1 is null)
                {
                    Console.WriteLine("student is not exsiting ");
                    continue;
                }
                Console.WriteLine("enter the new userName");
                string uname = Console.ReadLine();
                std1.UserName = uname;
                Console.WriteLine("enter the new firstName");
                string fname = Console.ReadLine();
                std1.FirstName = fname;

                Console.WriteLine("enter the new lastName");
                string lname = Console.ReadLine();
                std1.LastName = lname;
                Console.WriteLine("enter the new email");
                string email = Console.ReadLine();
                std1.Email = email;
                Console.WriteLine("enter the new DepartmentId");
                int departmentid1 = int.Parse(Console.ReadLine());
                std1.DepartmentId = departmentid1;
                Console.WriteLine("enter the new phone");
                string phone1 = Console.ReadLine();
                std1.Phone = phone1;
                _context.Update(std1);
                _context.SaveChanges();
                Console.WriteLine("enter id student to delete");
                int id1 = int.Parse(Console.ReadLine());
                _context.Students.DeleteByKey(id1);
                _context.SaveChanges();
                break;
            }
            var subject = new Subject
            {
                Name = "برمجيات",
                MinimumDegree = 60,
                Term = 2,
                DepartmentId = 1,
                Year = 2023
            };
            _context.Subjects.Add(subject);
            _context.SaveChanges();

            while (true)
            {
                Console.WriteLine("sub id");
                int id = int.Parse(Console.ReadLine());
                var sub1 = _context.Subjects.Find(id);
                if (sub1 is null)
                {
                    Console.WriteLine("subject is not exsiting ");
                    continue;
                }
                Console.WriteLine("enter the new Name");
                string name = Console.ReadLine();
                sub1.Name = name;
                Console.WriteLine("enter the new MinimumDegree ");
                int MinimumDegree1 = int.Parse(Console.ReadLine());
                sub1.MinimumDegree = MinimumDegree1;
                Console.WriteLine("enter the new term");
                int term = int.Parse(Console.ReadLine());
                sub1.Term = term;
                Console.WriteLine("enter the new year");
                int year = int.Parse(Console.ReadLine());
                sub1.Year = year;
                _context.Update(sub1);
                _context.SaveChanges();
                Console.WriteLine("enter id subject to delete");
                int id2 = int.Parse(Console.ReadLine());
                _context.Subjects.DeleteByKey(id2);
                _context.SaveChanges();
                break;
            }
            var exam = new Exam
            {
                Date = "26-4-2023",
                Term = 2,
                SubjectId = 1,
            };
            _context.Exams.Add(exam);
            _context.SaveChanges();
            while (true)
            {
                Console.WriteLine("exam id");
                int id = int.Parse(Console.ReadLine());
                var exam1 = _context.Exams.Find(id);
                if (exam1 is null)
                {
                    Console.WriteLine("exam is not exsiting ");
                    continue;
                }
                Console.WriteLine("enter the new date");
                string date = Console.ReadLine();
                exam1.Date = date;
                Console.WriteLine("enter the new term");
                int term1 = int.Parse(Console.ReadLine());
                exam1.Term = term1;
                _context.Update(exam1);
                _context.SaveChanges();
                Console.WriteLine("enter id exam to delete");
                int id3 = int.Parse(Console.ReadLine());
                _context.Exams.DeleteByKey(id3);
                _context.SaveChanges();
                break;
            }
            var studentmark = new StudentMark
            {
                StudentId = 1,
                ExamId = 3,
                Mark = 80,


            };
            _context.StudentMarks.Add(studentmark);
            _context.SaveChanges();

            while (true)
            {
                Console.WriteLine("studentmark id");
                int id = int.Parse(Console.ReadLine());
                var studentmark1 = _context.StudentMarks.Find(id);
                if (studentmark1 is null)
                {
                    Console.WriteLine("studentmark is not exsiting ");
                    continue;
                }
                Console.WriteLine("enter the new mark");
                int mark = int.Parse(Console.ReadLine());
                studentmark1.Mark = mark;
                _context.Update(studentmark1);
                _context.SaveChanges();
                Console.WriteLine("enter id exam to delete");
                int id4 = int.Parse(Console.ReadLine());
                _context.StudentMarks.DeleteByKey(id4);
                _context.SaveChanges();
                break;
            }
            var subjectLecture = new SubjectLecture
            {

                Title = "entity",
                Content = "framwork",

            };
            _context.SubjectLectures.Add(subjectLecture);
            _context.SaveChanges();

            while (true)
            {
                Console.WriteLine("subjectLecture1 id");
                int id = int.Parse(Console.ReadLine());
                var subjectLecture1 = _context.SubjectLectures.Find(id);
                if (subjectLecture1 is null)
                {
                    Console.WriteLine("subjectLecture is not exsiting ");
                    continue;
                }
                Console.WriteLine("enter the new title");
                string title = Console.ReadLine();
                subjectLecture1.Title = title;
                Console.WriteLine("enter the new content");
                string content = Console.ReadLine();
                subjectLecture1.Content = content;
                _context.Update(subjectLecture1);
                _context.SaveChanges();
                Console.WriteLine("enter id exam to delete");
                int id5 = int.Parse(Console.ReadLine());
                _context.SubjectLectures.DeleteByKey(id5);
                _context.SaveChanges();
                break;
            }
            var dep = _context.Departments.ToList();
            foreach (var item in dep)
            {
                Console.WriteLine("id"+item.Id+"name"+item.Name);
            }
            Console.WriteLine("-------------------------------------------------------------------------------");
                var std = _context.Students.ToList();
            foreach (var item in std)
            {
                Console.WriteLine(" stdID : " + item.Id + "user name" +item.UserName+"std name"  + item.FirstName + "last name"+item.LastName+"email"+item.Email+"phone"+item.Phone);
            }
            Console.WriteLine("-------------------------------------------------------------------------------");
            var sub = _context.Subjects.ToList();
            foreach (var item in sub)
            {
                Console.WriteLine("subID: " + item.Id+"departmentid"+item.DepartmentId+" name " + item.Name +"minimumdegree"+item.MinimumDegree+"term"+item.Term+"year"+item.Year );
            }
            Console.WriteLine("-------------------------------------------------------------------------------");
            var ex = _context.Exams.ToList();
            foreach (var item in ex)
            {
                Console.WriteLine("exam id"+item.Id+"subjec id"+item.SubjectId+"date"+item.Date+"term"+item.Term);
            }
            Console.WriteLine("-------------------------------------------------------------------------------");
            var stdm = _context.StudentMarks.ToList();
            foreach (var item in stdm)
            {
                Console.WriteLine("id"+item.Id+"student id"+item.StudentId+"exam id"+item.ExamId+"mark"+item.Mark);
            }
            Console.WriteLine("-------------------------------------------------------------------------------");
            var subl = _context.SubjectLectures.ToList();
            foreach (var item in subl)
            {
                Console.WriteLine("id"+item.Id+"lecture id"+item.LectureId+"title"+item.Title+"content"+item.Content);
            }
            Console.WriteLine("-------------------------------------------------------------------------------");
        }
    }
}
