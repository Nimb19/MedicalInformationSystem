namespace MedicalCorporation.Core.Models
{
    public class ProfilePrivilege
    {
        public static string TableName { get; } = $"{Scheme.assoc}.ProfilesPrivileges";

        public int ProfileId { get; set; }
        public int PrivilegeId { get; set; }
    }
}
