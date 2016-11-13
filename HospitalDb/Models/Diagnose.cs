using System;

namespace HospitalDb.Models
{
    public class Diagnose
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public string Name { get; set; }
        public string Comments { get; set; }
    }
}