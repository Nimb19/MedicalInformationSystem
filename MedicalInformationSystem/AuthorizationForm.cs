﻿using MedicalCorporation.Core;
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
        private AppSettings _config;

        public AuthorizationForm(AppSettings config, MedicalSqlShell sqlshell)
        {
            _sqlshell = sqlshell;
            _config = config;

            // TODO: автоподключение

            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void EntryButton_Click(object sender, EventArgs e)
        {
            try
            {
                var login = CoreExtensions.ValidateString(textBoxLogin.Text, nameof(textBoxLogin));
                var password = CoreExtensions.ValidateString(passwordBox.Text, nameof(passwordBox));
                User authClient = AuthorizeClient(login, password);

                if (authClient == null)
                {
                    MessageBox.Show("Логин или пароль указаны неверно", "Авторизация"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show($"Авторизация прошла успешно", "Авторизация"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();

                    new PatientForm(authClient, _config, _sqlshell).ShowDialog();

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show($"Ошибка во время авторизации: {exc.Message}", "Регистрация"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private User AuthorizeClient(string login, string password, int? userId = null) // TODO: userId
        {
            var checkCondition = $"{nameof(User.Login)} = N'{login}' AND {nameof(User.Password)} = N'{password}'";
            var authClient = _sqlshell.GetWhere<User>(checkCondition).FirstOrDefault();
            return authClient;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //var regForm = new RegistrationForm(_sqlshell);
            //this.Hide();
            //regForm.ShowDialog();

            //this.Show();
        }
    }
}
