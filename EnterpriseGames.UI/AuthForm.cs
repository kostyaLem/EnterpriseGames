using EnterpriseGames.Core.Other;
using EnterpriseGames.Core.Services;
using EnterpriseGames.UI.Forms;
using EnterpriseGames.UI.Forms.EditForms;
using EnterpriseGames.UI.Utility;
using MetroFramework;
using MetroFramework.Forms;
using System;

namespace EnterpriseGames.UI
{
    public partial class AuthForm : MetroForm
    {
        private const string EMPTY_FIELDS = "Заполните все поля";
        private const string WRONG_DATA = "Неправильный логин или пароль";

        private readonly AuthService _authService;

        public AuthForm()
        {
            InitializeComponent();

            _authService = new AuthService(Settings.Context);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Helpers.IsAnyEmpty(string.IsNullOrEmpty, txtLogin.Text.Trim(), txtPassword.Text.Trim()))
            {
                lblStatus.Text = EMPTY_FIELDS;
                return;
            }

            try
            {
                if (_authService.LogIn(txtLogin.Text.Trim(), Helpers.CreateHash(txtLogin.Text.Trim()), out User user))
                {
                    Settings.CurrentUser = user;
                    this.Visible = false;

                    txtLogin.Text = string.Empty;
                    txtPassword.Text = string.Empty;

                    new MainForm().ShowDialog();
                    this.Visible = true;
                }
                else
                {
                    lblStatus.Text = WRONG_DATA;
                }
            }
            catch (Exception exc)
            {
                MetroMessageBox.Show(this, exc.Message, "Ошибка", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
    }
}
