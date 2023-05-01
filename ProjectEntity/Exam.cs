using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntity
{
   public class Exam
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public string Date { get; set; }
        public int Term { get; set; }
        public ICollection<StudentMark> StudentMarks { get; } = new List<StudentMark>();
        public Subject Subject { get; set; } = null!;
    }
}
