using MedicalCorporation.Core;
using MedicalCorporation.Core.Models;
using MedicalCorporation.Core.SqlShellParts;
using System.Windows.Forms;

namespace MedicalInformationSystem
{
    public partial class SelectForm : Form
    {
        private User _userInfo;
        private MedicalSqlShell _sqlServerManager;
        private AppSettings _config;

        public SelectForm(User userInfo, AppSettings config, MedicalSqlShell sqlServerManager)
        {
            _userInfo = userInfo;
            _config = config;
            _sqlServerManager = sqlServerManager;

            InitializeComponent();
            this.MaximizeBox = false;

            SetName();
        }

        private void SetName()
        {
            const string NAME_ID = "@@FULLNAME@@";
            labelHello.Text = labelHello.Text.Replace(NAME_ID, _userInfo.GetFIO());
        }
    }
}
