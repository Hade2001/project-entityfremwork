using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntity
{
   public class Student
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int RegisterDate { get; set; }
        public int DepartmentId { get; set; }
        public int StudentMarkId { get; set; }
        public ICollection<StudentMark> StudentMarks { get; set; } = new List<StudentMark>();
        public Department Department { get; set; } = null!;
       
    }
}
