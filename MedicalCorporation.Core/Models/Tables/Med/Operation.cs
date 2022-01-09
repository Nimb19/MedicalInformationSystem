using System;

namespace MedicalCorporation.Core.Models
{
    public class Operation : IHaveIdentifier
    {
        public static string TableName { get; } = $"{Scheme.med}.Operations";

        public int Id { get; set; }
        public int UserId { get; set; }
        public int MedicalInstituteId { get; set; }
        public bool IsSuccess { get; set; }
        public bool IsFatal { get; set; }
        public string Description { get; set; }
        public DateTime OperationStartDateTime { get; set; }
        public int OperationMinutesSpan { get; set; }
    }
}
