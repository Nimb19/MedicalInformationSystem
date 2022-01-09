using MedicalCorporation.Core.Models;
using MedicalCorporation.Core.Models.DTO;
using MedicalCorporation.Core.SqlShellParts;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
            CatchException(() =>
            {
                _userInfo = userInfo;
                _config = config;
                _sqlServerManager = sqlServerManager;

                InitializeComponent();
                this.MaximizeBox = false;
                this.MinimumSize = new Size(1504, 788);

                SetDefaultComboBoxValues();
            });
        }

        private void ButtonAllWorkingMedics_Click(object sender, EventArgs e)
        {
            CatchException(() =>
            {
                WorkingMedicInfo[] medics = _sqlServerManager.GetAllWorkingMedics();
                dataGridView.FillTableWithCollection(medics);
            });
        }

        private void ButtonSelectMedics_Click(object sender, EventArgs e)
        {
            CatchException(() =>
            {
                WorkingMedicInfo[] medics = _sqlServerManager.GetAllWorkingMedics(); // TODO: Написать умные запросы
                dataGridView.FillTableWithCollection(medics);
            });
        }

        private void SetDefaultComboBoxValues()
        {
            comboBoxPlace.Items.Clear();
            comboBoxMedicalInstitions.Items.Clear();
            comboBoxMedicsProfile.Items.Clear();
            comboBoxRank.Items.Clear();
            comboBoxAcademicDegree.Items.Clear();

            SetArrayToComboBox(_sqlServerManager.GetMedicalInstitionsPlaces().Select(x => x.Name), comboBoxPlace);
            SetArrayToComboBox(_sqlServerManager.GetMedicalInstitions().Select(x => x.Name), comboBoxMedicalInstitions);
            SetArrayToComboBox(_sqlServerManager.GetProfiles((int)EtalonRolesEnum.Medic).Select(x => x.Name), comboBoxMedicsProfile);
            SetArrayToComboBox(_sqlServerManager.GetRanks().Select(x => x.Name), comboBoxRank);
            SetArrayToComboBox(_sqlServerManager.GetAcademicDegrees().Select(x => x.Name), comboBoxAcademicDegree);
        }

        private static void SetArrayToComboBox(IEnumerable<string> arrayOfNames, ComboBox comboBox)
        {
            foreach (var name in arrayOfNames)
                comboBox.Items.Add(name);
        }

        private void ComboBoxPlace_TextChanged(object sender, EventArgs e)
        {
            CatchException(() =>
            {
                var comboBox = sender as ComboBox;
                if (comboBox == null || string.IsNullOrWhiteSpace(comboBox.Text))
                    return;

                var trimedComboBoxText = comboBox.Text.Trim();
                var place = _sqlServerManager.GetMedicalInstitionsPlaces().FirstOrDefault(x =>
                    string.Equals(x.Name, trimedComboBoxText, StringComparison.InvariantCultureIgnoreCase));
                if (place == null)
                    throw new ArgumentException("Такого города/посёлка не существует");// TOOD: Check exception;

                var institutions = _sqlServerManager.GetMedicalInstitions(place.Id);
                SetArrayToComboBox(institutions.Select(x => x.Name), comboBoxMedicalInstitions);
            });
        }

        private void CatchException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ВыйтиСПриложенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ВыйтиСФормыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatchException(() =>
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            });
        }

        private void ВыйтиИзУчётнойЗаписиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatchException(() =>
            {
                this.DialogResult = DialogResult.Abort; // TODO: Предусмотри и сделай на всех формах
                this.Close();
            });
        }

        private void ОбновитьТекстовыеРедакторыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatchException(() =>
            {
                SetDefaultComboBoxValues();
            });
        }
    }
}
