using System;

namespace MedicalCorporation.Core.Models
{
    public class Worker
    {
        public static string TableName { get; } = $"{Scheme.usr}.Workers";

        public int UserId { get; set; }
        public string Position { get; set; }
        public string PassportSeries { get; set; }
        public string PasportNumber { get; set; }
        public double? SpecifiedSalary { get; set; }
        public string Characteristic { get; set; }
        public bool IsEnabled { get; set; }
        public DateTime EmploymentDate { get; set; }
    }
}
