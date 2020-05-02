using EnterpriseGames.Core.Models;
using EnterpriseGames.Core.Services;
using EnterpriseGames.UI.Forms.EditForms;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EnterpriseGames.UI.Forms
{
    public partial class CustomersForm : MetroForm
    {
        private readonly CustomersService _cutomerService = new CustomersService(Settings.Context);

        public CustomersForm()
        {
            InitializeComponent();
        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            UpdateDataGrid();

            if (Settings.CurrentUser.UserType == Core.Other.UserType.Employee)
            {
                btnRemove.Enabled = false;
            }

            UpdateCounter();
        }

        private void UpdateDataGrid()
        {
            dataGrid.Rows.Clear();
            _cutomerService.GetAll().ToList().ForEach(c => dataGrid.Rows.Add(
                    c.Id,
                    string.Join(" ", c.Surname, c.Name, c.Patronumic),
                    c.Phone,
                    c.Birthday,
                    c.Email
                ));
        }

        private void UpdateCounter()
        {
            lblCount.Text = dataGrid.Rows.Count.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var customer = new Customer();

            var dialogResult = new EditCustomerForm(customer).ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                _cutomerService.Add(customer);
                MetroMessageBox.Show(this, $"Клиент успешно добавлен", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateDataGrid();
                UpdateCounter();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var customer = _cutomerService.Find(Convert.ToInt32(dataGrid.SelectedRows[0].Cells[0].Value));

            if (customer != null)
            {
                var dialogResult = new EditCustomerForm(customer).ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    _cutomerService.Update(customer);
                    MetroMessageBox.Show(this, $"Данные клиента изменены", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateDataGrid();
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGrid.SelectedRows[0].Cells[0].Value);

            if (_cutomerService.Remove(id))
            {
                dataGrid.Rows.Remove(dataGrid.SelectedRows[0]);
                MetroMessageBox.Show(this, $"Клиент удалён", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateCounter();
            }
            else
            {
                MetroMessageBox.Show(this, "Ошибка при удалении записи", "Не удалось удалить запись", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count != 0)
            {
                if (Settings.CurrentUser.UserType == Core.Other.UserType.Admin)
                    btnRemove.Enabled = true;
                else
                    btnRemove.Enabled = false;

                btnEdit.Enabled = true;
            }
            else
            {
                btnEdit.Enabled = false;
                btnRemove.Enabled = false;
            }
        }
    }
}
