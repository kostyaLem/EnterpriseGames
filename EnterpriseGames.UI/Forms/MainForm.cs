using EnterpriseGames.Core.Models;
using EnterpriseGames.Core.Other;
using EnterpriseGames.Core.Services;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EnterpriseGames.UI.Forms
{
    public partial class MainForm : MetroForm
    {
        private const string ORDER_EDITING = "Редактируется";
        private const string ORDER_CLOSED = "Закрыт";

        private readonly EmployeesService _empService = new EmployeesService(Settings.Context);

        private readonly User _currentUser;
        private Record[] _items;

        private System.Timers.Timer _timer;

        public MainForm()
        {
            InitializeComponent();

            Application.ApplicationExit += Application_ApplicationExit;

            _currentUser = Settings.CurrentUser;
        }

        private void tglShowMenu_CheckedChanged(object sender, System.EventArgs e)
        {
            if (flpShowsMenu.Visible)
            {
                flpShowsMenu.Visible = false;
                dtgOrders.Margin = new Padding(0);

                lblPositions.Margin = new Padding(0);
                dtgItems.Margin = new Padding(0);
            }
            else
            {
                flpShowsMenu.Visible = true;
                dtgOrders.Margin = new Padding(30, 0, 0, 0);

                lblPositions.Margin = new Padding(30, 0, 0, 0);
                dtgItems.Margin = new Padding(30, 0, 0, 0);
            }
        }


        private void UpdateOrdersDtg()
        {
            _items = _empService.GetOrders(_currentUser.ID);

            if (_items != null)
            {
                foreach (var order in _items)
                {
                    dtgOrders.Rows.Add(order.ID, order.EmployeeFullName, order.CustomerFullName,
                                       order.Items.Length, order.DateCreated, order.DateClosed,
                                       order.State == RecordState.Editing ? ORDER_EDITING : ORDER_CLOSED);
                }
            }
        }

        private void dtgOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgOrders.SelectedRows.Count != 0)
            {
                dtgItems.Rows.Clear();

                var recordID = Convert.ToInt32(dtgOrders.SelectedRows[0].Cells[0].FormattedValue);
                var record = _items.First(x => x.ID == recordID);

                foreach(var item in record.Items)
                {
                    dtgItems.Rows.Add(item.ID, item.Name, item.Price);
                }
            }
            else if (dtgOrders.Rows.Count == 0)
            {
                dtgItems.Rows.Clear();
            }
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            _timer = new System.Timers.Timer();
            _timer.Elapsed += (s, _) => lblCurrentTime.Invoke(new Action(() => lblCurrentTime.Text = $"Текущее время: {DateTime.Now.ToLongTimeString()}"));
            _timer.Interval = 1_000;
            _timer.Start();

            lblEmployee.Text = _currentUser.UserType == UserType.Admin ? "Администратор: " : "Сотрудник: ";
            lblEmployee.Text += string.Join(" ", _currentUser.Surname, _currentUser.Name, _currentUser.Patronymic);

            if (Settings.CurrentUser.UserType == UserType.Employee)
            {
                btnShowEmployees.Enabled = false;
                btnShowOrders.Enabled = false;
            }
        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            if (tlpItems.Visible)
            {
                tlpItems.Visible = false;

                tlpItems.SetRowSpan(dtgOrders, 2);
            }
            else
            {
                tlpItems.Visible = true;

                tlpItems.SetRowSpan(dtgOrders, 1);
            }
        }

        private void btnShowGames_Click(object sender, EventArgs e)
        {
            new ProductsForm().ShowDialog();
        }

        private void btnShowGenres_Click(object sender, EventArgs e)
        {
            new GenresForm().ShowDialog();
        }

        private void btnShowEmployees_Click(object sender, EventArgs e)
        {
            new EmployeesForm().ShowDialog();
        }

        private void btnShowOrders_Click(object sender, EventArgs e)
        {

        }

        private void btnShowHelp_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Данное приложение предоставляет пользователю возможность организовать хранение информации о" +
                " производимой предприятием продукции", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnChangeUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Application_ApplicationExit(object sender, EventArgs e)
        {
            _timer?.Stop();
            _timer?.Dispose();
        }
    }
}
