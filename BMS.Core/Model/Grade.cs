using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBS.Core.Model.Entity;

namespace SBS.Core.Model
{
   public class Grade : BaseEntity
    {
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public int Test01 { get; set; }
        public int Test02 { get; set; }
        public int GradeTotal { get; set; }
        public string Comment { get; set; }

        public virtual ICollection<Student_Subject> StudentSubjects { get; set; }
        
    }
}
