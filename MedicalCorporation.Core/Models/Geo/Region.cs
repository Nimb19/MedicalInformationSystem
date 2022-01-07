namespace MedicalCorporation.Core.Models
{
    public class Region : IHaveIdentifier
    {
        public static string TableName { get; } = $"{Scheme.geo}.Regions";

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
