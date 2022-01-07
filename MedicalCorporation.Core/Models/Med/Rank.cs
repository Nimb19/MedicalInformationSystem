namespace MedicalCorporation.Core.Models.Med
{
    public class Rank : IHaveIdentifier
    {
        public static string TableName { get; } = $"{Scheme.med}.Ranks";

        public int Id { get; set; }
        public string Rank { get; set; }
    }
}
