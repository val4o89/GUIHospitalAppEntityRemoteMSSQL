namespace HospitalDb.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HospitalDb.HPContext>
    {
        public Configuration()
        {
            AutomaticMigrationDataLossAllowed = true;
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(HPContext context)
        {
            var medicament = new Medicament()
            {
                Name = "Paracetamax",
                Label = "PL"
            };
            var diagnose = new Diagnose()
            {
                Name = "Flue",
                Label = "SR"

            };
            var visitation = new Visitation()
            {
                Date = new DateTime(2016, 10, 11),
                Label = "V"
            };
            var patient = new Patient()
            {
                FirstName = "Valeri",
                LastName = "Slavabogov",
                DateOfBirth = new DateTime(1990, 06, 22),
                Address = "kv. Levski 'G'",
                Email = "valerislavabogov@gmail.com",
                HasMedicalInsurance = true
            };

            patient.Visitations.Add(visitation);
            patient.Medicaments.Add(medicament);
            patient.Diagnoses.Add(diagnose);

            var doctor = new Doctor()
            {
                Name = "Boev",
                Speciality = "UNG"
            };
            doctor.Visitations.Add(visitation);

            context.Visitations.AddOrUpdate(v => v.Label, visitation);
            context.Medicaments.AddOrUpdate(m => m.Label, medicament);
            context.Diagnoses.AddOrUpdate(d => d.Label, diagnose);
            context.Patients.AddOrUpdate(p => p.FirstName, patient);
            context.Doctors.AddOrUpdate(d => d.Name, doctor);

        }
    }
}
