namespace MedicalCorporation.Core.Models
{
    public class Department : IHaveIdentifier
    {
        public static string TableName { get; } = $"{Scheme.geo}.Departments";

        public int Id { get; set; }
        public int MedicalInstituteId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
