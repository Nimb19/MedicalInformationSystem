using MedicalCorporation.Core;
using MedicalCorporation.Core.SqlShellParts;

namespace MedicalInformationSystem
{
    public class AppSettings
    {
        public DefaultUserSettings DefaultUserSettings { get; set; }
        public SqlServerSettings SqlServerSettings { get; set; }

        public static AppSettings GetAppSettingsFromConfigFile(string pathToConfig = Constants.PathToConfigFile)
        {
            var config = CoreExtensions.DeserializeFile<AppSettings>(pathToConfig);

            if (config.SqlServerSettings == null)
                config.SqlServerSettings = SqlServerSettings.GetDefaultSettings();
            if (config.DefaultUserSettings == null)
                config.DefaultUserSettings = new DefaultUserSettings();

            return config;
        }
    }

    public class DefaultUserSettings
    {
        public int? UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
