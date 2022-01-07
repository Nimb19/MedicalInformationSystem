using System;

namespace MedicalCorporation.Core.Models
{
    public class StationaryRecord : IHaveIdentifier
    {
        public static string TableName { get; } = $"{Scheme.med}.StationaryAccounting";

        public int Id { get; set; }
        public int UserId { get; set; }
        public int TreatingMedicId { get; set; }
        public int? ReferralId { get; set; }
        public int MedicalInstituteId { get; set; }
        public int? DepartmentId { get; set; }
        public int? RoomId { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
