using System;

namespace MedicalCorporation.Core.Models
{
    public class Privilege : IHaveIdentifier
    {
        public static string TableName { get; } = $"{Scheme.usr}.Privileges";

        public int Id { get; set; }
        public Guid Uid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
