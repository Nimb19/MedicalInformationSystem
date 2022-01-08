using System.Reflection;
using System.Text;

namespace MedicalCorporation.Core
{
    public static class CoreConstants
    {
        public static readonly Encoding Encoding = Encoding.UTF8;
        public const string DbName = "MedicalCorporation";
        public const int CommandTimeout = 30;

        public const string StructVersion = "001001007";
        public static readonly string ProductVersion 
            = Assembly.GetExecutingAssembly().GetName().Version.ToString();
    }
}
