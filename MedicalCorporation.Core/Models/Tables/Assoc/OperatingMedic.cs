namespace MedicalCorporation.Core.Models
{
    public class OperatingMedic
    {
        public static string TableName { get; } = $"{Scheme.assoc}.OperatingMedics";

        public int OperationId { get; set; }
        public int MedicId { get; set; }
    }
}
