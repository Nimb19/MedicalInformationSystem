namespace MedicalCorporation.Core.Models
{
    public class AcademicDegree : IHaveIdentifier
    {
        public static string TableName { get; } = $"{Scheme.med}.AcademicDegrees";

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
