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
    public partial class OrdersForm : MetroForm
    {
        private const string ORDER_EDITING = "Редактируется";
        private const string ORDER_CLOSED = "Закрыт";

        private readonly EmployeesService _empService = new EmployeesService(Settings.Context);

        private readonly User _user;
        private Record[] _items;

        public OrdersForm()
        {
            InitializeComponent();

            _user = Settings.CurrentUser;
        }

        private void OrdersForm_Load(object sender, System.EventArgs e)
        {
            UpdateOrdersDtg();
            UpdateCounter();
        }



        private void UpdateOrdersDtg()
        {
            dtgOrders.Rows.Clear();
            _items = _empService.GetAllOrders();

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

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            var record = new Record();

            var result = new EditOrderForm(record).ShowDialog();

            if (result == DialogResult.OK)
            {
                record.EmployeeID = _user.ID;

                _empService.AddOrder(_user.ID, record);

                MetroMessageBox.Show(this, "Заказ успешно добавлен", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateOrdersDtg();
                UpdateCounter();
            }
        }

        private void UpdateCounter()
        {
            lblCount.Text = dtgOrders.Rows.Count.ToString();
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
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

        private void dtgOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgOrders.SelectedRows.Count != 0)
            {
                dtgItems.Rows.Clear();

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
                btnEdit.Enabled = false;
                dtgItems.Rows.Clear();
            }
        }
    }
}
