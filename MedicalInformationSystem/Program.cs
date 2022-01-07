using MedicalCorporation.Core.SqlShellParts;
using System.Windows.Forms;

namespace MedicalInformationSystem
{
    static class Program
    {
        /// <summary> Главная точка входа для приложения </summary>
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var config = Settings.GetSqlSettingsFromConfigFile(Constants.ConfigFileName);
            using (var sqlshell = new MedicalSqlShell(config, Constants.PathsToGenerateDbScripts))
                Application.Run(new AuthorizationForm(sqlshell));
        }
    }
}
