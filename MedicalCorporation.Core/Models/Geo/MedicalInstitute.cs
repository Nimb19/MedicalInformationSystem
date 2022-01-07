using System;

namespace MedicalCorporation.Core.Models
{
    public class MedicalInstitute : IHaveIdentifier
    {
        public static string TableName { get; } = $"{Scheme.geo}.MedicalInstitutions";

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public double Rating { get; set; }
        public int MedicalInstitutePlaceId { get; set; }
        public int NumberOfRooms { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? CloseTime { get; set; }
    }
}
