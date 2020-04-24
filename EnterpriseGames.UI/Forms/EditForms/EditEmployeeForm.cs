using EnterpriseGames.Core.Models;
using EnterpriseGames.Core.Other;
using MetroFramework.Forms;
using System;
using System.Drawing;
using System.IO;

namespace EnterpriseGames.UI.Forms.EditForms
{
    public partial class EditEmployeeForm : MetroForm
    {
        private readonly Employee _employee;

#if DEBUG
        public EditEmployeeForm()
        {
            InitializeComponent();

            _employee = new Employee();
        }
#endif

        public EditEmployeeForm(Employee employee)
        {
            InitializeComponent();

            _employee = employee;
        }

        private void EditEmployeeForm_Load(object sender, EventArgs e)
        {
            dtpBirthday.MaxDate = DateTime.Now.AddYears(-18);

            //txtSurname.Text = _employee.Surname;
            //txtName.Text = _employee.Name;
            //txtPatr.Text = _employee.Patronymic;
            //dtpBirthday.Value = DateTime.Parse(_employee.Birthday);
            //txtEmail.Text = _employee.Email;

            //using (var ms = new MemoryStream(_employee.Photo))
            //{
            //    picImage.Image = Image.FromStream(ms);
            //}

            //switch ((UserType)_employee.UserType)
            //{
            //    case UserType.Admin: rbAdmin.Checked = true; break;
            //    case UserType.Employee: rbAdmin.Checked = true; break;
            //    default: break;
            //}
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            picImage.Image = null;
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            if (openFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                picImage.Image = Image.FromFile(openFD.FileName);
                _employee.Photo = File.ReadAllBytes(openFD.FileName);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            _employee.Surname = txtSurname.Text.Trim();
            _employee.Name = txtName.Text.Trim();
            _employee.Patronymic = txtPatr.Text.Trim();
            _employee.Email = txtEmail.Text.Trim();
            _employee.Birthday = dtpBirthday.Value.ToShortDateString();
            _employee.UserType = (long)(rbAdmin.Checked ? UserType.Admin : (rbUser.Checked ? UserType.Employee : UserType.None));
        }
    }
}