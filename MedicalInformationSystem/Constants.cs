using MedicalCorporation.Core;
using System.Text;

namespace MedicalInformationSystem
{
    public static class Constants
    {
        public const string PathToConfigFile = "AppSettings.json";

        public static readonly Encoding Encoding = CoreConstants.Encoding;
        public static readonly string[] PathsToGenerateDbScripts = new[] { "Sources\\CreateDbScript.sql" };
    }
}
