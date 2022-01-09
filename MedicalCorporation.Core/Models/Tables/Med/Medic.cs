namespace MedicalCorporation.Core.Models
{
    public class Medic
    {
        public static string TableName { get; } = $"{Scheme.med}.Medics";

        public int UserId { get; set; }
        public int AcademicDegreeId { get; set; }
        public int RankId { get; set; }
    }
}
