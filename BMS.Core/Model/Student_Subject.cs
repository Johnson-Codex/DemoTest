using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBS.Core.Model.Entity;

namespace SBS.Core.Model
{
    public class Student_Subject : BaseEntity
    {
        public int StudentId { get; set; }
        public int SubjectId { get; set; }

        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }

        public virtual List<Grade> Grades { get; set; }
    }
}
