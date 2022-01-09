namespace MedicalCorporation.Core.Models
{
    public class MedicalInstitutionPlace : IHaveIdentifier
    {
        public static string TableName { get; } = $"{Scheme.geo}.MedicalInstitutionsPlaces";

        public int Id { get; set; }
        public string Name { get; set; }
        public int RegionId { get; set; }
    }
}
