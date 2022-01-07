using MedicalCorporation.Core.SqlShellParts;
using System.Windows.Forms;

namespace MedicalInformationSystem
{
    static class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var config = AppSettings.GetAppSettingsFromConfigFile();

            using (var sqlshell = new MedicalSqlShell(config.SqlServerSettings, Constants.PathsToGenerateDbScripts))
                Application.Run(new AuthorizationForm(config, sqlshell));
        }
    }
}
