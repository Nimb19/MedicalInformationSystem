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

        public PatientForm(User userInfo, MedicalSqlShell sqlServerManager)
        {
            try
            {
                _userInfo = userInfo;
                _sqlServerManager = sqlServerManager;

                InitializeComponent();
                this.MaximizeBox = false;
                this.MinimumSize = new Size(1504, 788);

                SetName();
                //SetDefaultComboBoxValues();

                SetFormInfo();
                UpdateApointmentsTable();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateApointmentsTable()
        {
            //dgvAppointments.Rows.Clear();

            //var appointments = _sqlServerManager.GetWhere<Appointment>($"UserId = {_userInfo.Id}")
                /*.Where(x => x.AppointmentDate > DateTime.Now)*/;

            //var doctors = _sqlServerManager.GetArrayOf<Doctor>();
            //var hospitals = _sqlServerManager.GetArrayOf<Hospital>();
            //foreach (var apointment in appointments)
            //{
            //    var doctor = doctors.First(x => x.Id == apointment.DoctorId);
            //    var hospital = hospitals.First(x => x.Id == doctor.HospitalId);

            //    dgvAppointments.Rows.Add(doctor.Surname, apointment.AppointmentDate
            //        , apointment.Price, hospital.Name);
            //}
        }

        private void SetFormInfo()
        {
            //_doctors = _sqlServerManager.GetArrayOf<Doctor>().Take(3).ToArray();
            //Appointment[] appointments = GetAppointments();

            //var dateFormat = "dd.MM.yyyy HH:mm";

            //var date1 = GetDateTimeForDoctor(appointments, _doctors[0].Id);
            //labelDoctorName1.Text = _doctors[0].GetFIO();
            //labelOffice1.Text = _doctors[0].Office.ToString();
            //labelSpeciality1.Text = _doctors[0].Speciality;
            //labelPrice1.Text = _doctors[0].AppointmentPrice.ToString("0.00");
            //labelVisitDate1.Text = date1.ToString(dateFormat);

            //var date2 = GetDateTimeForDoctor(appointments, _doctors[1].Id);
            //labelDoctorName2.Text = _doctors[1].GetFIO();
            //labelOffice2.Text = _doctors[1].Office.ToString();
            //labelSpeciality2.Text = _doctors[1].Speciality;
            //labelPrice2.Text = _doctors[1].AppointmentPrice.ToString("0.00");
            //labelVisitDate2.Text = date2.ToString(dateFormat);

            //var date3 = GetDateTimeForDoctor(appointments, _doctors[2].Id);
            //labelDoctorName3.Text = _doctors[2].GetFIO();
            //labelOffice3.Text = _doctors[2].Office.ToString();
            //labelSpeciality3.Text = _doctors[2].Speciality;
            //labelPrice3.Text = _doctors[2].AppointmentPrice.ToString("0.00");
            //labelVisitDate3.Text = date3.ToString(dateFormat);
        }

        //private Appointment[] GetAppointments()
        //{
        //    return _sqlServerManager.GetWhere<Appointment>
        //        ($"Id = {_doctors[0].Id} OR Id = {_doctors[1].Id} OR Id = {_doctors[2].Id}");
        //}

        //private Appointment[] GetAppointmentsById(int id)
        //{
        //    return _sqlServerManager.GetWhere<Appointment>($"Id = {id}");
        //}

        //private DateTime GetDateTimeForDoctor(Appointment[] appointments, int doctorId)
        //{
        //    DateTime? date = null;
        //    var apps = appointments.Where(x => x.DoctorId == doctorId);
        //    if (apps.Count() > 0)
        //    {
        //        var max = apps.Max(x => x.AppointmentDate);
        //        if (max < DateTime.Now)
        //            date = DateTime.Now;
        //        else
        //            date = max;
        //    }
        //    else
        //        date = DateTime.Now;
        //    return date.Value.RoundUp(TimeSpan.FromHours(3));
        //}

        private void ButtonAppointment1_Click(object sender, EventArgs e)
        {
            try
            {
                //var doctor = _doctors[0];
                //var description = comboBoxAppointmentType1.Text;

                //Appointment appointment = RegNewAppointment(doctor, description);
                //_sqlServerManager.Insert(appointment);

                //UpdateApointmentsTable();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private Appointment RegNewAppointment(Doctor doctor, string description)
        //{
        //    Appointment[] appointments = GetAppointmentsById(doctor.Id);
        //    var date = GetDateTimeForDoctor(appointments, doctor.Id);
        //    return new Appointment()
        //    {
        //        DoctorId = doctor.Id,
        //        Description = description,
        //        AppointmentDate = date,
        //        Price = doctor.AppointmentPrice,
        //        UserId = _userInfo.Id,
        //    };
        //}

        private void ButtonAppointment2_Click(object sender, EventArgs e)
        {
            try
            {
                //var doctor = _doctors[1];
                //var description = comboBoxAppointmentType2.Text;

                //Appointment appointment = RegNewAppointment(doctor, description);
                //_sqlServerManager.Insert(appointment);

                //UpdateApointmentsTable();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonAppointment3_Click(object sender, EventArgs e)
        {
            try
            {
                //var doctor = _doctors[2];
                //var description = comboBoxAppointmentType3.Text;

                //Appointment appointment = RegNewAppointment(doctor, description);
                //_sqlServerManager.Insert(appointment);

                //UpdateApointmentsTable();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonAppointmentVaccine_Click(object sender, EventArgs e)
        {
            try
            {
                //var doctor = _sqlServerManager.GetById<Doctor>(7);
                //var description = comboBoxVaccine.Text;
                //if (!DateTime.TryParse($"{dateVaccine.Value.FormatToDate()} {textBoxTimeVaccine.Text}", out var date))
                //{
                //    MessageBox.Show("Неверно написана дата", "Ошибка"
                //        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}

                //var appointment = new Appointment()
                //{
                //    DoctorId = doctor.Id,
                //    Description = description,
                //    AppointmentDate = date,
                //    Price = 0,
                //    UserId = _userInfo.Id,
                //};

                //_sqlServerManager.Insert(appointment);

                //UpdateApointmentsTable();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void SetDefaultComboBoxValues()
        //{
        //    comboBoxAppointmentType1.SelectedItem = comboBoxAppointmentType1.Items[0];
        //    comboBoxAppointmentType2.SelectedItem = comboBoxAppointmentType2.Items[0];
        //    comboBoxAppointmentType3.SelectedItem = comboBoxAppointmentType3.Items[0];
        //    comboBoxVaccine.SelectedItem = comboBoxVaccine.Items[0];
        //    dateVaccine.Value = DateTime.Now.AddDays(3);
        //}

        private void SetName()
        {
            const string NAME_ID = "@@FULLNAME@@";
            labelHello.Text = labelHello.Text.Replace(NAME_ID, _userInfo.GetFIO());
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //var detailForm = new MyApointmentsInDetailsForm(_userInfo, _sqlServerManager);
            //detailForm.ShowDialog();
            //detailForm.Dispose();
        }

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
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }
    }
}
