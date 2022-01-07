namespace MedicalCorporation.Core.Models
{
    public class Medic
    {
        public static string TableName { get; } = $"{Scheme.med}.Medics";

        public int UserId { get; set; }
        public string AcademicDegree { get; set; }
        public string Rank { get; set; }
    }
}
