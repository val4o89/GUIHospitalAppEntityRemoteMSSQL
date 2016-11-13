using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDb.Models
{
    public class Patient
    {
        private ICollection<Medicament> medicaments;
        private ICollection<Visitation> visitations;
        private ICollection<Diagnose> diagnoses;
        public Patient()
        {
            this.medicaments = new HashSet<Medicament>();
            this.visitations = new HashSet<Visitation>();
            this.diagnoses = new HashSet<Diagnose>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string  LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public byte?[] Picture { get; set; }
        public bool HasMedicalInsurance { get; set; }
        public ICollection<Visitation> Visitations
        {
            get
            {
                return this.visitations;
            }
            set
            {
                this.visitations = value;
            }
        }
        public ICollection<Diagnose> Diagnoses
        {
            get
            {
                return this.diagnoses;
            }
            set
            {
                this.diagnoses = value;
            }
        }
        public ICollection<Medicament> Medicaments
        {
            get
            {
                return this.medicaments;
            }
            set
            {
                this.medicaments = value;
            }
        }
    }
}
