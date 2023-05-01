using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntity
{
   public class Subject
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public int MinimumDegree { get; set; }
        public int Term { get; set; }
        public int Year { get; set; }
        public ICollection<Exam> Exams { get; } = new List<Exam>();
        public ICollection<SubjectLecture> SubjectLectures { get; } = new List<SubjectLecture>();
        public Department Department { get; set; } = null!;
    }
}
