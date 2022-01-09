namespace MedicalCorporation.Core.Models
{
    public class UserMedicalInstitute
    {
        public static string TableName { get; } = $"{Scheme.assoc}.UsersMedicalInstitutions";

        public int UserId { get; set; }
        public int MedicalInstituteId { get; set; }
    }
}
