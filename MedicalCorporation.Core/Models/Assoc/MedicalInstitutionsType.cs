namespace MedicalCorporation.Core.Models
{
    public class MedicalInstitutionsType
    {
        public static string TableName { get; } = $"{Scheme.assoc}.MedicalInstitutionsTypes";

        public int MedicalInstituteId { get; set; }
        public int MedicalInstituteTypeId { get; set; }
    }
}
