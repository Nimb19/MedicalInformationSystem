namespace MedicalCorporation.Core.Models.Med
{
    public class AcademicDegree : IHaveIdentifier
    {
        public static string TableName { get; } = $"{Scheme.med}.AcademicDegrees";

        public int Id { get; set; }
        public string AcademicDegree { get; set; }
    }
}
