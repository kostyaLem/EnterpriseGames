using EnterpriseGames.Core.Models;
using EnterpriseGames.Core.Services;
using EnterpriseGames.UI.Forms.EditForms;
using EnterpriseGames.UI.Utility;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EnterpriseGames.UI.Forms
{
    public partial class EmployeesForm : MetroForm
    {
        private readonly EmployeesService _empService = new EmployeesService(Settings.Context);

        public EmployeesForm()
        {
            InitializeComponent();
        }

        private void EmployeesForm_Load(object sender, System.EventArgs e)
        {
            UpdateDataGrid();
        }

        private void UpdateDataGrid()
        {
            _empService.GetAll().ToList().ForEach(emp => dataGrid.Rows.Add(
                    emp.Id,
                    string.Join(" ", emp.Surname, emp.Name, emp.Patronymic),
                    emp.Phone,
                    emp.Birthday,
                    emp.Email,
                    emp.UserTypeToString()
                ));            
        }

        private void UpdateCounter()
        {
            lblCount.Text = dataGrid.Rows.Count.ToString();
        }

        private void dataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count != 0)
            {
                btnRemove.Enabled = btnEdit.Enabled = true;
            }
            else
            {
                btnRemove.Enabled = btnEdit.Enabled = false;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGrid.SelectedRows[0].Cells[0].Value);

            if (_empService.Remove(id))
            {
                dataGrid.Rows.Remove(dataGrid.SelectedRows[0]);
                UpdateCounter();
            }
            else
            {
                MetroMessageBox.Show(this, "Ошибка при удалении записи", "Не удалось удалить запись", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var emp = _empService.Find(Convert.ToInt32(dataGrid.SelectedRows[0].Cells[0].Value));

            if (emp != null)
            {
                var dialogResult = new EditEmployeeForm(emp).ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    _empService.Update(emp);
                    MetroMessageBox.Show(this, $"Пользователь {emp.Login} успешно изменен", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}