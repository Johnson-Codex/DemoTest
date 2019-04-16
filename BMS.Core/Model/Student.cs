using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBS.Core.Model.Entity;

namespace SBS.Core.Model
{
    public class Student: BaseEntity
    {
        //public int StudentId { get; set; }
        public string LastName { get; set; }

        public string FirstName  { get; set; }
        public string MiddleName { get; set; }

        private string Name => LastName + ", " + FirstName + " " + MiddleName;
        public DateTime DateOfBirth { get; set; }

        public string Address { get; set; }
        public int ClassId { get; set; }
        public int GuardianId { get; set; }
        public string SubjectId { get; set; }
        public int StaffId { get; set; }
        public DateTime DateOfEnrollment { get; set; }

        public virtual Guardian Guardian { get; set; }
        public virtual Class Class { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual List<Student_Subject> StudentSubjects { get; set; } 

    }
}
