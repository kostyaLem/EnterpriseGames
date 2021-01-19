using EnterpriseGames.Core.Models;
using EnterpriseGames.UI.Utility;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace EnterpriseGames.UI.Forms.EditForms
{
    public partial class EditCustomerForm : MetroForm
    {
        private readonly Customer _customer;

        public EditCustomerForm(Customer customer)
        {
            InitializeComponent();

            _customer = customer;
        }

        private void EditCustomerForm_Load(object sender, EventArgs e)
        {
            dtpBirthday.MaxDate = DateTime.Now.AddYears(-18);

            txtSurname.Text = _customer.Surname;
            txtName.Text = _customer.Name;
            txtPatr.Text = _customer.Patronumic;
            if (DateTime.TryParse(_customer.Birthday, out DateTime dtp))
                dtpBirthday.Value = dtp;
            txtEmail.Text = _customer.Email;
            txtPhone.Text = _customer.Phone;

            txtAdditional.Text = _customer.Additional;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Helpers.IsAnyEmpty(string.IsNullOrEmpty, txtSurname.Text, txtName.Text, txtPhone.Text))
            {
                MetroMessageBox.Show(this, "Заполните обязательные поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
                return;
            }

            try
            {
                if (!string.IsNullOrEmpty(txtEmail.Text))
                    new MailAddress(txtEmail.Text);
            }
            catch 
            {
                MetroMessageBox.Show(this, "Неверно указана почта", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _customer.Surname = txtSurname.Text.Trim();
            _customer.Name = txtName.Text.Trim();
            _customer.Patronumic = txtPatr.Text.Trim();
            _customer.Phone = txtPhone.Text.Trim();
            _customer.Email = txtEmail.Text.Trim();
            _customer.Birthday = dtpBirthday.Value.ToShortDateString();
            _customer.Additional = txtAdditional.Text.Trim();
        }
    }
}
