using MedicalCorporation.Core.Models;
using MedicalCorporation.Core.SqlShellParts;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MedicalInformationSystem
{
    public partial class AuthorizationForm : Form
    {
        private MedicalSqlShell _sqlshell;

        public AuthorizationForm(MedicalSqlShell sqlshell)
        {
            _sqlshell = sqlshell;

            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void EntryButton_Click(object sender, EventArgs e)
        {
            try
            {
                var login = CommonExtensions.ValidateString(textBoxLogin.Text, nameof(textBoxLogin));
                var password = CommonExtensions.ValidateString(passwordBox.Text, nameof(passwordBox));
                //User authClient = AuthorizeClient(login, password);

                //if (authClient == null)
                //{
                //    MessageBox.Show("Логин или пароль указаны неверно", "Авторизация"
                //        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}
                //else
                //{
                //    MessageBox.Show($"Авторизация прошла успешно", "Авторизация"
                //        , MessageBoxButtons.OK, MessageBoxIcon.Information);

                //    this.Hide();

                //    //if (authClient.ResultType == ResultType.User)
                //    //    new PatientForm((User)authClient, _sqlshell).ShowDialog();
                //    //else if (authClient.ResultType == ResultType.Doctor)
                //    //    new DoctorForm((Doctor)authClient, _sqlshell).ShowDialog();
                //    //else if (authClient.ResultType == ResultType.Admin)
                //    //    new AdminForm((Administrator)authClient, _sqlshell).ShowDialog();
                //    //else
                //    //    throw new NotImplementedException(authClient.ResultType.ToString());

                //    this.DialogResult = DialogResult.OK;
                //    this.Close();
                //}
            }
            catch (Exception exc)
            {
                MessageBox.Show($"Ошибка во время авторизации: {exc.Message}", "Регистрация"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private User AuthorizeClient(string login, string password)
        //{
        //    var checkCondition = $"{nameof(User.Login)} = N'{login}' AND {nameof(User.Password)} = N'{password}'";
        //    var authClient = _sqlshell.GetWhere<User>(checkCondition).FirstOrDefault() as UserBase;
        //    if (authClient == null)
        //    {
        //        authClient = _sqlshell.GetWhere<Doctor>(checkCondition).FirstOrDefault();
        //        if (authClient == null)
        //        {
        //            authClient = _sqlshell.GetWhere<Administrator>(checkCondition).FirstOrDefault();
        //            if (authClient != null)
        //                authClient.ResultType = ResultType.Admin;
        //        }
        //        else
        //            authClient.ResultType = ResultType.Doctor;
        //    }
        //    else
        //        authClient.ResultType = ResultType.User;
        //    return authClient;
        //}

        private void Button1_Click(object sender, EventArgs e)
        {
            //var regForm = new RegistrationForm(_sqlshell);
            //this.Hide();
            //regForm.ShowDialog();

            //this.Show();
        }
    }
}
