namespace HospitalDb
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class HPContext : DbContext
    {
        public HPContext()
            : base("name=HPContext")
        {
        }

        public virtual IDbSet<Patient> Patients { get; set; }
        public virtual IDbSet<Visitation> Visitations { get; set; }
        public virtual IDbSet<Diagnose> Diagnoses { get; set; }
        public virtual IDbSet<Medicament> Medicaments { get; set; }
        public virtual IDbSet<Doctor> Doctors { get; set; }
    }
}