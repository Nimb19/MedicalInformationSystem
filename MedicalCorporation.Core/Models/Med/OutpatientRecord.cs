using System;

namespace MedicalCorporation.Core.Models
{
    public class OutpatientRecord : IHaveIdentifier
    {
        public static string TableName { get; } = $"{Scheme.med}.OutpatientAccounting";

        public int Id { get; set; }
        public int UserId { get; set; }
        public int TreatingMedicId { get; set; }
        public int IssuingPersonId { get; set; }
        public int? ReferralId { get; set; }
        public int MedicalInstituteId { get; set; }
        public int? DepartmentId { get; set; }
        public int? RoomId { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
