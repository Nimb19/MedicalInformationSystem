using MedicalInformationSystem.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MedicalInformationSystem
{
    public partial class DoctorForm : Form
    {
        private Doctor _authClient;
        private SqlServerManager _sqlServerManager;

        private Timer _timer;

        public DoctorForm(Doctor authClient, SqlServerManager sqlshell)
        {
            _authClient = authClient;
            _sqlServerManager = sqlshell;

            InitializeComponent();
            MaximizeBox = false;

            SetName();
            StartTimer();
            UpdateOrdersTable();
        }

        private void StartTimer()
        {
            _timer = new Timer();
            _timer.Interval = TimeSpan.FromSeconds(1).Seconds;
            _timer.Tick += (x, y) => labelDate.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
            _timer.Start();
        }

        private void SetName()
        {
            const string NAME_ID = "@@FULLNAME@@";
            var fullName = $"{_authClient.Surname} {_authClient.Name} {_authClient.Middlename}";
            labelHello.Text = labelHello.Text.Replace(NAME_ID, fullName);
        }

        private void UpdateOrdersTable()
        {
            //dgvOrders.Rows.Clear();

            //var airplanes = _sqlServerManager.GetArrayOf<Airplane>();
            //var users = _sqlServerManager.GetArrayOf<User>();
            //var orders = _sqlServerManager.GetArrayOf<Order>();

            //foreach (var order in orders)
            //{
            //    var airplaneById = airplanes.First(x => x.Id == order.AirplaneId);
            //    var userById = users.First(x => x.Id == order.UserId);
            //    dgvOrders.Rows.Add(order.Id, $"{userById.Surname} {userById.Name}", airplaneById.TypeName, order.Count,
            //        order.TotalPrice, order.OrderCloseTime.FormatToDate(), order.OrderCreatedTime.FormatToDate());
            //}

            //labelOrdersCount.Text = orders.Length.ToString();
            //labelCompetedOrdersCount.Text = orders.Where(x => x.OrderCloseTime < DateTime.Now).Count().ToString();
            //labelOrdersOnWork.Text = orders.Where(x => x.OrderCloseTime > DateTime.Now).Count().ToString();
            //labelTotalTime.Text = orders.Select(x => x.TotalPrice).Aggregate((x, y) => x + y).ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                //var id = Convert.ToInt32(numericOrderId.Value);
                //var orderById = _sqlServerManager.GetById<Order>(id);

                //var etalonOrder = CommonExtensions.CloneBySerialize(orderById);

                //var userId = string.IsNullOrWhiteSpace(textBoxUserId.Text) ? null : textBoxUserId.Text;
                //var airplaneId = string.IsNullOrWhiteSpace(textBoxAirplaneId.Text) ? null : textBoxAirplaneId.Text;
                //var count = string.IsNullOrWhiteSpace(textBoxCount.Text) ? null : textBoxCount.Text;
                //var totalPrice = string.IsNullOrWhiteSpace(textBoxTotalPrice.Text) ? null : textBoxTotalPrice.Text;
                //var createdDate = string.IsNullOrWhiteSpace(textBoxDateCreated.Text) ? null : textBoxDateCreated.Text;
                //var closeDate = string.IsNullOrWhiteSpace(textBoxDateClose.Text) ? null : textBoxDateClose.Text;

                //if (userId != null) orderById.UserId = int.Parse(userId);
                //if (airplaneId != null) orderById.AirplaneId = int.Parse(airplaneId);
                //if (count != null) orderById.Count = int.Parse(count);
                //if (totalPrice != null) orderById.TotalPrice = int.Parse(totalPrice);
                //if (createdDate != null) orderById.OrderCreatedTime = DateTime.Parse(createdDate);
                //if (closeDate != null) orderById.OrderCloseTime = DateTime.Parse(closeDate);

                //_sqlServerManager.Update(orderById, etalonOrder);

                //UpdateOrdersTable();

                MessageBox.Show("Успешно!", "Редактирование", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _timer.Stop();
            _timer.Dispose();
        }
    }
}
