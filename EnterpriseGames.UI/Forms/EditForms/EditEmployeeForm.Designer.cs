namespace EnterpriseGames.UI.Forms.EditForms
{
    partial class EditEmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoadImage = new MetroFramework.Controls.MetroButton();
            this.btnRemoveImage = new MetroFramework.Controls.MetroButton();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtSurname = new MetroFramework.Controls.MetroTextBox();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.txtPatr = new MetroFramework.Controls.MetroTextBox();
            this.dtpBirthday = new MetroFramework.Controls.MetroDateTime();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.rbAdmin = new MetroFramework.Controls.MetroRadioButton();
            this.rbUser = new MetroFramework.Controls.MetroRadioButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnSubmit = new MetroFramework.Controls.MetroButton();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnLoadImage.Location = new System.Drawing.Point(23, 336);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(217, 27);
            this.btnLoadImage.TabIndex = 1;
            this.btnLoadImage.Text = "Загрузить из ...";
            this.btnLoadImage.UseSelectable = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // btnRemoveImage
            // 
            this.btnRemoveImage.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnRemoveImage.Location = new System.Drawing.Point(23, 369);
            this.btnRemoveImage.Name = "btnRemoveImage";
            this.btnRemoveImage.Size = new System.Drawing.Size(217, 27);
            this.btnRemoveImage.TabIndex = 2;
            this.btnRemoveImage.Text = "Удалить";
            this.btnRemoveImage.UseSelectable = true;
            this.btnRemoveImage.Click += new System.EventHandler(this.btnRemoveImage_Click);
            // 
            // picImage
            // 
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage.Location = new System.Drawing.Point(23, 77);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(217, 252);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(300, 82);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(83, 25);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Фамилия";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(300, 111);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 25);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Имя";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(300, 190);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(133, 25);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Дата рождения";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(300, 140);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(85, 25);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Отчество";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(300, 222);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(59, 25);
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "Почта";
            // 
            // txtSurname
            // 
            // 
            // 
            // 
            this.txtSurname.CustomButton.Image = null;
            this.txtSurname.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.txtSurname.CustomButton.Name = "";
            this.txtSurname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSurname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSurname.CustomButton.TabIndex = 1;
            this.txtSurname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSurname.CustomButton.UseSelectable = true;
            this.txtSurname.CustomButton.Visible = false;
            this.txtSurname.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSurname.Lines = new string[0];
            this.txtSurname.Location = new System.Drawing.Point(445, 83);
            this.txtSurname.MaxLength = 32767;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.PasswordChar = '\0';
            this.txtSurname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSurname.SelectedText = "";
            this.txtSurname.SelectionLength = 0;
            this.txtSurname.SelectionStart = 0;
            this.txtSurname.ShortcutsEnabled = true;
            this.txtSurname.Size = new System.Drawing.Size(198, 23);
            this.txtSurname.TabIndex = 8;
            this.txtSurname.UseSelectable = true;
            this.txtSurname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSurname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(445, 112);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(198, 23);
            this.txtName.TabIndex = 9;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPatr
            // 
            // 
            // 
            // 
            this.txtPatr.CustomButton.Image = null;
            this.txtPatr.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.txtPatr.CustomButton.Name = "";
            this.txtPatr.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPatr.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPatr.CustomButton.TabIndex = 1;
            this.txtPatr.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPatr.CustomButton.UseSelectable = true;
            this.txtPatr.CustomButton.Visible = false;
            this.txtPatr.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPatr.Lines = new string[0];
            this.txtPatr.Location = new System.Drawing.Point(445, 141);
            this.txtPatr.MaxLength = 32767;
            this.txtPatr.Name = "txtPatr";
            this.txtPatr.PasswordChar = '\0';
            this.txtPatr.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPatr.SelectedText = "";
            this.txtPatr.SelectionLength = 0;
            this.txtPatr.SelectionStart = 0;
            this.txtPatr.ShortcutsEnabled = true;
            this.txtPatr.Size = new System.Drawing.Size(198, 23);
            this.txtPatr.TabIndex = 10;
            this.txtPatr.UseSelectable = true;
            this.txtPatr.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPatr.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(445, 188);
            this.dtpBirthday.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(198, 29);
            this.dtpBirthday.TabIndex = 11;
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(445, 223);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(198, 23);
            this.txtEmail.TabIndex = 12;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(299, 279);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(119, 50);
            this.metroLabel6.TabIndex = 13;
            this.metroLabel6.Text = "Тип \r\nпользователя";
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rbAdmin.Location = new System.Drawing.Point(445, 279);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(125, 19);
            this.rbAdmin.TabIndex = 14;
            this.rbAdmin.Text = "Администратор";
            this.rbAdmin.UseSelectable = true;
            // 
            // rbUser
            // 
            this.rbUser.AutoSize = true;
            this.rbUser.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rbUser.Location = new System.Drawing.Point(445, 310);
            this.rbUser.Name = "rbUser";
            this.rbUser.Size = new System.Drawing.Size(94, 19);
            this.rbUser.TabIndex = 15;
            this.rbUser.Text = "Сотрудник";
            this.rbUser.UseSelectable = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(300, 369);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 27);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseSelectable = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSubmit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSubmit.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSubmit.Location = new System.Drawing.Point(511, 369);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(132, 27);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "Подтвердить";
            this.btnSubmit.UseSelectable = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // openFD
            // 
            this.openFD.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif;" +
    " *.png";
            this.openFD.Title = "Выбор изображения пользователя";
            // 
            // EditEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 426);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.rbUser);
            this.Controls.Add(this.rbAdmin);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.txtPatr);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnRemoveImage);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.picImage);
            this.MaximizeBox = false;
            this.Name = "EditEmployeeForm";
            this.Resizable = false;
            this.Text = "Редактирование данных пользователя";
            this.Load += new System.EventHandler(this.EditEmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picImage;
        private MetroFramework.Controls.MetroButton btnLoadImage;
        private MetroFramework.Controls.MetroButton btnRemoveImage;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtSurname;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroTextBox txtPatr;
        private MetroFramework.Controls.MetroDateTime dtpBirthday;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroRadioButton rbAdmin;
        private MetroFramework.Controls.MetroRadioButton rbUser;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnSubmit;
        private System.Windows.Forms.OpenFileDialog openFD;
    }
}