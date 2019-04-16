using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBS.Core.Model.Entity;

namespace SBS.Core.Model
{
    public class Staff : BaseEntity
    {
       // public int StaffId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }

        private string Name => LastName + ", " + FirstName + " " + MiddleName;
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public string JobDescription { get; set; }
        public int ClassId { get; set; }
        public DateTime DateOfEmployment { get; set; }

        public virtual Class Class { get; set; }
        public virtual List<Student> Students { get; set; }

    }
}
