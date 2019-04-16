using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBS.Core.Model.Entity;

namespace SBS.Core.Model
{
    public class Guardian : BaseEntity
    {
        //public int GuardianId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }

        private string Name => LastName + ", " + FirstName + " " + MiddleName;
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public int StudentId { get; set; }
        public string RelationshipWithStudent { get; set; }
        public string Occupation { get; set; }

        public virtual ICollection<Student>  Students { get; set; }
    }
}
