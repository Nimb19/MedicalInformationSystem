using MedicalCorporation.Core;
using MedicalCorporation.Core.Models;
using MedicalCorporation.Core.SqlShellParts;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MedicalInformationSystem
{
    public partial class PatientForm : Form
    {
        private User _userInfo;
        private MedicalSqlShell _sqlServerManager;
        private AppSettings _config;

        public PatientForm(User userInfo, AppSettings config, MedicalSqlShell sqlServerManager)
        {
            try
            {
                _userInfo = userInfo;
                _config = config;
                _sqlServerManager = sqlServerManager;

                InitializeComponent();
                this.MaximizeBox = false;
                this.MinimumSize = new Size(1504, 788);

                SetDefaultComboBoxValues();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetDefaultComboBoxValues()
        {
            comboBoxPlace.Items.Clear();
            comboBoxMedicalInstitions.Items.Clear();
            comboBoxMedicsProfile.Items.Clear();
            comboBoxRank.Items.Clear();
            comboBoxAcademicDegree.Items.Clear();
            


            // TODO: поставь дефолт значения из таблиц в комбобоксы
        }

        //private void UpdateApointmentsTable()
        //{
            //dgvAppointments.Rows.Clear();

            //var appointments = _sqlServerManager.GetWhere<Appointment>($"UserId = {_userInfo.Id}")
                //.Where(x => x.AppointmentDate > DateTime.Now);

            //var doctors = _sqlServerManager.GetArrayOf<Doctor>();
            //var hospitals = _sqlServerManager.GetArrayOf<Hospital>();
            //foreach (var apointment in appointments)
            //{
            //    var doctor = doctors.First(x => x.Id == apointment.DoctorId);
            //    var hospital = hospitals.First(x => x.Id == doctor.HospitalId);

            //    dgvAppointments.Rows.Add(doctor.Surname, apointment.AppointmentDate
            //        , apointment.Price, hospital.Name);
            //}
        //}

        private void ВыйтиСПриложенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ВыйтиСФормыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ВыйтиИзУчётнойЗаписиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort; // TODO: Предусмотри  сделай на всех формах
            this.Close();
        }
    }
}
