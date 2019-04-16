using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBS.Core.Model.Entity;

namespace SBS.Core.Model
{
    public class Class_Subject : BaseEntity
    {
        public int ClassId { get; set; }
        public int SubjectId { get; set; }
        public virtual Class Class { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
