using System;

namespace MedicalCorporation.Core.Models
{
    public class UserProfile
    {
        public static string TableName { get; } = $"{Scheme.assoc}.UsersProfiles";

        public int UserId { get; set; }
        public int ProfileId { get; set; }
        public double? HoursInMonth { get; set; }
        public int? WorkExperienceInYears { get; set; }
        public DateTime CreateAssocDate { get; set; }
    }
}
