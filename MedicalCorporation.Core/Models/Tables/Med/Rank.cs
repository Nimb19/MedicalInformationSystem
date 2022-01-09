namespace MedicalCorporation.Core.Models
{
    public class Rank : IHaveIdentifier
    {
        public static string TableName { get; } = $"{Scheme.med}.Ranks";

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
