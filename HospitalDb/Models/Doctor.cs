using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDb.Models
{
    public class Doctor
    {
        public Doctor()
        {
            this.Visitations = new HashSet<Visitation>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Speciality { get; set; }
        public ICollection<Visitation> Visitations { get; set; }

    }
}
