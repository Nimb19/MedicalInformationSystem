namespace MedicalCorporation.Core.Models
{
    public class Param : IHaveIdentifier
    {
        public static string TableName { get; } = $"{Scheme.m}.{nameof(Param)}";

        public int Id { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
    }
}
