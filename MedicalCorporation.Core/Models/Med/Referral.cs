using System;

namespace MedicalCorporation.Core.Models
{
    public class Referral : IHaveIdentifier
    {
        public static string TableName { get; } = $"{Scheme.med}.Referrals";

        public int Id { get; set; }
        public int UserId { get; set; }
        public int? ReferralMedicId { get; set; }
        public int DestinationMedicalInstituteId { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
