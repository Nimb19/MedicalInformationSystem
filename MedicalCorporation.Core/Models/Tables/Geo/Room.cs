namespace MedicalCorporation.Core.Models
{
    public class Room : IHaveIdentifier
    {
        public static string TableName { get; } = $"{Scheme.geo}.Rooms";

        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public int RoomNumber { get; set; }
        public string Description { get; set; }
        public int? NumberOfBeds { get; set; }
    }
}
