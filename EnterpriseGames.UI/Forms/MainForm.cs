using EnterpriseGames.Core.Models;
using EnterpriseGames.Core.Other;
using EnterpriseGames.Core.Services;
using EnterpriseGames.UI.Forms.EditForms;
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

        private readonly User _user;
        private Record[] _items;

        private System.Timers.Timer _timer;

        public MainForm()
        {
            InitializeComponent();

            Application.ApplicationExit += Application_ApplicationExit;

            _user = Settings.CurrentUser;
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
            dtgOrders.Rows.Clear();
            _items = _empService.GetOrders(_user.ID);

            if (_items != null)
            {
                foreach (var order in _items)
                {
                    dtgOrders.Rows.Add(order.ID, order.EmployeeFullName, order.CustomerFullName,
                                       order.Items.Count, order.DateCreated, order.DateClosed, order.Items.Sum(x => x.Price).ToString("N2") + " р.",
                                       order.State == RecordState.Editing ? ORDER_EDITING : ORDER_CLOSED);
                }
            }
        }

        private void dtgOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgOrders.SelectedRows.Count != 0)
            {
                dtgItems.Rows.Clear();

                if (_user.UserType == UserType.Admin)
                    btnRemove.Enabled = true;

                var recordID = Convert.ToInt32(dtgOrders.SelectedRows[0].Cells[0].FormattedValue);
                var record = _items.First(x => x.ID == recordID);

                btnEdit.Enabled = record.State != RecordState.Closed ? true : false;

                foreach (var item in record.Items)
                {
                    dtgItems.Rows.Add(item.ID, item.Name, item.Price.ToString("N2") + " р.");
                }
            }
            else if (dtgOrders.Rows.Count == 0)
            {
                btnRemove.Enabled = false;
                btnEdit.Enabled = false;
                dtgItems.Rows.Clear();
            }
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            _timer = new System.Timers.Timer();
            _timer.Elapsed += (s, _) => lblCurrentTime.Invoke(new Action(() => lblCurrentTime.Text = $"Текущее время: {DateTime.Now.ToLongTimeString()}"));
            _timer.Interval = 1_000;
            _timer.Start();

            lblEmployee.Text = _user.UserType == UserType.Admin ? "Администратор: " : "Сотрудник: ";
            lblEmployee.Text += string.Join(" ", _user.Surname, _user.Name, _user.Patronymic);

            if (Settings.CurrentUser.UserType == UserType.Employee)
            {
                btnEdit.Enabled = false;
                btnRemove.Enabled = false;
                btnShowEmployees.Enabled = false;
                btnShowOrders.Enabled = false;
            }

            UpdateOrdersDtg();
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

        private void brnAdd_Click(object sender, EventArgs e)
        {
            var record = new Record();

            var result = new EditOrderForm(record).ShowDialog();

            if (result == DialogResult.OK)
            {
                record.EmployeeID = _user.ID;

                _empService.AddOrder(_user.ID, record);

                MetroMessageBox.Show(this, "Заказ успешно добавлен", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateOrdersDtg();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var record = _items.FirstOrDefault(x => x.ID == Convert.ToInt32(dtgOrders.SelectedRows[0].Cells[0].FormattedValue));

            if (record != null)
            {
                var result = new EditOrderForm(record).ShowDialog();

                if (result == DialogResult.OK)
                {
                    record.EmployeeID = _user.ID;

                    _empService.Update(_user.ID, record);

                    MetroMessageBox.Show(this, "Заказ успешно изменен", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateOrdersDtg();
                }
            }
        }

        private void btnShowCustomers_Click(object sender, EventArgs e)
        {
            new CustomersForm().ShowDialog();
        }
    }
}
