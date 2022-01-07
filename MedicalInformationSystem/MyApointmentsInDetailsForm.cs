using MedicalInformationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MedicalInformationSystem
{
    public partial class MyApointmentsInDetailsForm : Form
    {
        public MyApointmentsInDetailsForm(User user, SqlServerManager sqlServerManager)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            ShowToDgv(user, sqlServerManager);
        }

        private void ShowToDgv(User user, SqlServerManager sqlServerManager)
        {
            dgvAppointments.Rows.Clear();

            var appointments = sqlServerManager.GetWhere<Appointment>($"UserId = {user.Id}")
                /*.Where(x => x.AppointmentDate > DateTime.Now)*/;

            var doctors = sqlServerManager.GetArrayOf<Doctor>();
            var hospitals = sqlServerManager.GetArrayOf<Hospital>();
            foreach (var apointment in appointments)
            {
                var doctor = doctors.First(x => x.Id == apointment.DoctorId);
                var doctorNameSurname = doctor.Surname + " " + doctor.Name;
                var hospital = hospitals.First(x => x.Id == doctor.HospitalId);

                dgvAppointments.Rows.Add(doctorNameSurname, hospital.Name
                    , doctor.Office, apointment.AppointmentDate
                    , apointment.Price, apointment.Description);
            }
        }
    }
}
