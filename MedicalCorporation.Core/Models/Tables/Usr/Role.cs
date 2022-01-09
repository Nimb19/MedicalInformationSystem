namespace MedicalCorporation.Core.Models
{
    public class Role : IHaveIdentifier
    {
        public static string TableName { get; } = $"{Scheme.usr}.Roles";

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
