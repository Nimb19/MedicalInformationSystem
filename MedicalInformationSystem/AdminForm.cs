using MedicalInformationSystem.Models;
using System.Windows.Forms;

namespace MedicalInformationSystem
{
    public partial class AdminForm : Form
    {
        private Administrator _authClient;
        private SqlServerManager _sqlServerManager;

        public AdminForm(Administrator authClient, SqlServerManager sqlshell)
        {
            _authClient = authClient;
            _sqlServerManager = sqlshell;

            InitializeComponent();
            MaximizeBox = false;

            //SetName();
        }
    }
}
