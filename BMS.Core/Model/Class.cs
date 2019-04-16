using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBS.Core.Model.Entity;

namespace SBS.Core.Model
{
    public class Class : BaseEntity
    {
        public string Name { get; set; }
        public int StaffId { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual List<Class_Subject> ClassSubjects { get; set; }
        public virtual List<Student> Students { get; set; }

    }
}
