using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBS.Core.Model.Entity;

namespace SBS.Core.Model
{
    public class Student_Subject_Grade : BaseEntity
    {
        public int Student_SubjectId { get; set; }
        public int GradeId { get; set; }
        public virtual Student_Subject StudentSubject { get; set; }
        public virtual Grade Grade { get; set; }

    }
}
