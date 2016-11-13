using System;

namespace HospitalDb.Models
{
    public class Visitation
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public DateTime? Date { get; set; }
        public string Comments { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}