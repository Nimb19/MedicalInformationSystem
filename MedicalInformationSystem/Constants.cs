using MedicalCorporation.Core;
using System.Text;

namespace MedicalInformationSystem
{
    public static class Constants
    {
        public static readonly Encoding Encoding = CoreConstants.Encoding;
        public const string ConfigFileName = "SqlServerConfig.json";

        public static readonly string[] PathsToGenerateDbScripts = new[] 
        { 
            "Sources\\CreateDbScript_Part1.sql", 
            "Sources\\CreateDbScript_Part2.sql" 
        };
    }
}
