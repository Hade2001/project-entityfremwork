using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntity
{
   public class StudentMark
    {
        public int Id { get; set; }
        public int ExamId { get; set; }
        public int Mark { get; set; }
        
        public int StudentId { get; set; }
        public Student Student { get; set; } = null!;
        public Exam Exam { get; set; } = null!;
    }
}
