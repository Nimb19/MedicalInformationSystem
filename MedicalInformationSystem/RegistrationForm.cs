using MedicalInformationSystem.Models;
using System;
using System.Windows.Forms;

namespace MedicalInformationSystem
{
    public partial class RegistrationForm : Form
    {
        private SqlServerManager _sqlshell;

        public RegistrationForm(SqlServerManager sqlshell)
        {
            _sqlshell = sqlshell;

            InitializeComponent();
            this.MaximizeBox = false;
            this.DialogResult = DialogResult.Cancel;
        }

        private void BtReg_Click(object sender, EventArgs e)
        {
            try
            {
                var name = CommonExtensions.ValidateString(textBoxName.Text, nameof(textBoxName));
                var middlename = CommonExtensions.ValidateString(textBoxPatr.Text, nameof(textBoxPatr));
                var surname = CommonExtensions.ValidateString(textBoxSurname.Text, nameof(textBoxSurname));
                var age = Convert.ToInt32(numericUpDownAge.Value);
                var login = CommonExtensions.ValidateString(textBoxLogin.Text, nameof(textBoxLogin));
                var pass = CommonExtensions.ValidateString(textBoxPassword.Text, nameof(textBoxPassword));
                var sex = radioButtonMan.Checked ? Sex.Male : Sex.Female;

                var user = new User()
                {
                    Name = name,
                    Middlename = middlename,
                    Surname = surname,
                    Login = login,
                    Password = pass,
                    Sex = sex,
                    Age = age,
                    TownId = 1,
                };

                _sqlshell.Insert(user);
                MessageBox.Show("Вы успешно зарегистрированы!", "Регистрация"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show($"Ошибка во время регистрации: {exc.Message}", "Регистрация"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
