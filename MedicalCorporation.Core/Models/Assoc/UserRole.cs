namespace MedicalCorporation.Core.Models
{
    public class UserRole
    {
        public static string TableName { get; } = $"{Scheme.assoc}.UsersRoles";

        public int UserId { get; set; }
        public int RoleId { get; set; }
    }
}
