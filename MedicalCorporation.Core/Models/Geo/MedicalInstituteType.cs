namespace MedicalCorporation.Core.Models
{
    public class MedicalInstituteType
    {
        public static string TableName { get; } = $"{Scheme.geo}.MedicalInstituteTypes";

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
