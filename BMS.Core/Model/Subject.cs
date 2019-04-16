using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBS.Core.Model.Entity;

namespace SBS.Core.Model
{
    public class Subject : BaseEntity
    {
        public string Name { get; set; }
        public virtual List<Class_Subject> ClassSubjects { get; set; }
        public virtual List<Student_Subject> StudentSubjects { get; set; }
    }
}
