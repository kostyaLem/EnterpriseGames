﻿namespace EnterpriseGames.UI.Forms.EditForms
{
    partial class EditProductForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtTitle = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtDesc = new MetroFramework.Controls.MetroTextBox();
            this.btnSubmit = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnRemoveImage = new MetroFramework.Controls.MetroButton();
            this.btnLoadImage = new MetroFramework.Controls.MetroButton();
            this.dtpCreated = new MetroFramework.Controls.MetroDateTime();
            this.dtpProductCreated = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.dtgPrices = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsExist = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddPrice = new MetroFramework.Controls.MetroButton();
            this.txtNewPrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.lstGameGenres = new MetroFramework.Controls.MetroListView();
            this.lstExistedGenres = new MetroFramework.Controls.MetroListView();
            this.btnAddNewGenre = new MetroFramework.Controls.MetroButton();
            this.btnRemoveGanre = new MetroFramework.Controls.MetroButton();
            this.picGame = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrices)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGame)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(324, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(88, 25);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Название";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.Location = new System.Drawing.Point(404, 60);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(19, 25);
            this.metroLabel10.TabIndex = 26;
            this.metroLabel10.Text = "*";
            // 
            // txtTitle
            // 
            // 
            // 
            // 
            this.txtTitle.CustomButton.Image = null;
            this.txtTitle.CustomButton.Location = new System.Drawing.Point(414, 2);
            this.txtTitle.CustomButton.Name = "";
            this.txtTitle.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTitle.CustomButton.TabIndex = 1;
            this.txtTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTitle.CustomButton.UseSelectable = true;
            this.txtTitle.CustomButton.Visible = false;
            this.txtTitle.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtTitle.Lines = new string[0];
            this.txtTitle.Location = new System.Drawing.Point(324, 88);
            this.txtTitle.MaxLength = 32767;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PasswordChar = '\0';
            this.txtTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTitle.SelectedText = "";
            this.txtTitle.SelectionLength = 0;
            this.txtTitle.SelectionStart = 0;
            this.txtTitle.ShortcutsEnabled = true;
            this.txtTitle.Size = new System.Drawing.Size(440, 28);
            this.txtTitle.TabIndex = 25;
            this.txtTitle.UseSelectable = true;
            this.txtTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(324, 116);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(92, 25);
            this.metroLabel2.TabIndex = 27;
            this.metroLabel2.Text = "Описание";
            // 
            // txtDesc
            // 
            // 
            // 
            // 
            this.txtDesc.CustomButton.Image = null;
            this.txtDesc.CustomButton.Location = new System.Drawing.Point(246, 2);
            this.txtDesc.CustomButton.Name = "";
            this.txtDesc.CustomButton.Size = new System.Drawing.Size(191, 191);
            this.txtDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDesc.CustomButton.TabIndex = 1;
            this.txtDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDesc.CustomButton.UseSelectable = true;
            this.txtDesc.CustomButton.Visible = false;
            this.txtDesc.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDesc.Lines = new string[0];
            this.txtDesc.Location = new System.Drawing.Point(324, 144);
            this.txtDesc.MaxLength = 32767;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.PasswordChar = '\0';
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDesc.SelectedText = "";
            this.txtDesc.SelectionLength = 0;
            this.txtDesc.SelectionStart = 0;
            this.txtDesc.ShortcutsEnabled = true;
            this.txtDesc.Size = new System.Drawing.Size(440, 196);
            this.txtDesc.TabIndex = 28;
            this.txtDesc.UseSelectable = true;
            this.txtDesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDesc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSubmit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSubmit.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSubmit.Location = new System.Drawing.Point(151, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(190, 27);
            this.btnSubmit.TabIndex = 33;
            this.btnSubmit.Text = "Подтвердить";
            this.btnSubmit.UseSelectable = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(3, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(142, 27);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseSelectable = true;
            // 
            // btnRemoveImage
            // 
            this.btnRemoveImage.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnRemoveImage.Location = new System.Drawing.Point(23, 313);
            this.btnRemoveImage.Name = "btnRemoveImage";
            this.btnRemoveImage.Size = new System.Drawing.Size(104, 27);
            this.btnRemoveImage.TabIndex = 31;
            this.btnRemoveImage.Text = "Удалить";
            this.btnRemoveImage.UseSelectable = true;
            this.btnRemoveImage.Click += new System.EventHandler(this.btnRemoveImage_Click);
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnLoadImage.Location = new System.Drawing.Point(133, 313);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(174, 27);
            this.btnLoadImage.TabIndex = 30;
            this.btnLoadImage.Text = "Загрузить из ...";
            this.btnLoadImage.UseSelectable = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // dtpCreated
            // 
            this.dtpCreated.Location = new System.Drawing.Point(801, 394);
            this.dtpCreated.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpCreated.Name = "dtpCreated";
            this.dtpCreated.Size = new System.Drawing.Size(345, 29);
            this.dtpCreated.TabIndex = 34;
            // 
            // dtpProductCreated
            // 
            this.dtpProductCreated.Location = new System.Drawing.Point(801, 454);
            this.dtpProductCreated.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpProductCreated.Name = "dtpProductCreated";
            this.dtpProductCreated.Size = new System.Drawing.Size(345, 29);
            this.dtpProductCreated.TabIndex = 35;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(797, 362);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(78, 25);
            this.metroLabel4.TabIndex = 36;
            this.metroLabel4.Text = "Создана";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(797, 426);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(99, 25);
            this.metroLabel5.TabIndex = 37;
            this.metroLabel5.Text = "Добавлена";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(890, 426);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(19, 25);
            this.metroLabel6.TabIndex = 38;
            this.metroLabel6.Text = "*";
            // 
            // dtgPrices
            // 
            this.dtgPrices.AllowUserToAddRows = false;
            this.dtgPrices.AllowUserToDeleteRows = false;
            this.dtgPrices.AllowUserToResizeRows = false;
            this.dtgPrices.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgPrices.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgPrices.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgPrices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPrices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dtgPrices.ColumnHeadersHeight = 30;
            this.dtgPrices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.PriceDate,
            this.IsExist});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgPrices.DefaultCellStyle = dataGridViewCellStyle11;
            this.dtgPrices.EnableHeadersVisualStyles = false;
            this.dtgPrices.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtgPrices.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgPrices.Location = new System.Drawing.Point(797, 124);
            this.dtgPrices.MultiSelect = false;
            this.dtgPrices.Name = "dtgPrices";
            this.dtgPrices.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPrices.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dtgPrices.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgPrices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPrices.Size = new System.Drawing.Size(349, 216);
            this.dtgPrices.TabIndex = 39;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DividerWidth = 1;
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "#";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 15;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // PriceDate
            // 
            this.PriceDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PriceDate.HeaderText = "Дата";
            this.PriceDate.Name = "PriceDate";
            this.PriceDate.ReadOnly = true;
            // 
            // IsExist
            // 
            this.IsExist.HeaderText = "В наличии";
            this.IsExist.Name = "IsExist";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(797, 60);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(208, 25);
            this.metroLabel3.TabIndex = 40;
            this.metroLabel3.Text = "История изменения цен:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnSubmit);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(801, 491);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(346, 35);
            this.flowLayoutPanel1.TabIndex = 41;
            // 
            // btnAddPrice
            // 
            this.btnAddPrice.Location = new System.Drawing.Point(797, 91);
            this.btnAddPrice.Name = "btnAddPrice";
            this.btnAddPrice.Size = new System.Drawing.Size(349, 27);
            this.btnAddPrice.TabIndex = 42;
            this.btnAddPrice.Text = "Добавить";
            this.btnAddPrice.UseSelectable = true;
            this.btnAddPrice.Click += new System.EventHandler(this.btnAddPrice_Click);
            // 
            // txtNewPrice
            // 
            // 
            // 
            // 
            this.txtNewPrice.CustomButton.Image = null;
            this.txtNewPrice.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.txtNewPrice.CustomButton.Name = "";
            this.txtNewPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNewPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNewPrice.CustomButton.TabIndex = 1;
            this.txtNewPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNewPrice.CustomButton.UseSelectable = true;
            this.txtNewPrice.CustomButton.Visible = false;
            this.txtNewPrice.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNewPrice.Lines = new string[0];
            this.txtNewPrice.Location = new System.Drawing.Point(1011, 62);
            this.txtNewPrice.MaxLength = 32767;
            this.txtNewPrice.Name = "txtNewPrice";
            this.txtNewPrice.PasswordChar = '\0';
            this.txtNewPrice.PromptText = "Новая цена";
            this.txtNewPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNewPrice.SelectedText = "";
            this.txtNewPrice.SelectionLength = 0;
            this.txtNewPrice.SelectionStart = 0;
            this.txtNewPrice.ShortcutsEnabled = true;
            this.txtNewPrice.Size = new System.Drawing.Size(135, 23);
            this.txtNewPrice.TabIndex = 43;
            this.txtNewPrice.UseSelectable = true;
            this.txtNewPrice.WaterMark = "Новая цена";
            this.txtNewPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNewPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(23, 362);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(101, 25);
            this.metroLabel7.TabIndex = 46;
            this.metroLabel7.Text = "Все жанры:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.Location = new System.Drawing.Point(416, 362);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(183, 25);
            this.metroLabel8.TabIndex = 47;
            this.metroLabel8.Text = "Добавленные жанры:";
            // 
            // lstGameGenres
            // 
            this.lstGameGenres.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lstGameGenres.FullRowSelect = true;
            this.lstGameGenres.Location = new System.Drawing.Point(416, 394);
            this.lstGameGenres.MultiSelect = false;
            this.lstGameGenres.Name = "lstGameGenres";
            this.lstGameGenres.OwnerDraw = true;
            this.lstGameGenres.ShowGroups = false;
            this.lstGameGenres.Size = new System.Drawing.Size(345, 132);
            this.lstGameGenres.TabIndex = 48;
            this.lstGameGenres.UseCompatibleStateImageBehavior = false;
            this.lstGameGenres.UseSelectable = true;
            this.lstGameGenres.View = System.Windows.Forms.View.SmallIcon;
            this.lstGameGenres.SelectedIndexChanged += new System.EventHandler(this.lstGameGenres_SelectedIndexChanged);
            // 
            // lstExistedGenres
            // 
            this.lstExistedGenres.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lstExistedGenres.Location = new System.Drawing.Point(23, 394);
            this.lstExistedGenres.MultiSelect = false;
            this.lstExistedGenres.Name = "lstExistedGenres";
            this.lstExistedGenres.ShowGroups = false;
            this.lstExistedGenres.Size = new System.Drawing.Size(345, 132);
            this.lstExistedGenres.TabIndex = 49;
            this.lstExistedGenres.UseCompatibleStateImageBehavior = false;
            this.lstExistedGenres.UseSelectable = true;
            this.lstExistedGenres.View = System.Windows.Forms.View.SmallIcon;
            this.lstExistedGenres.SelectedIndexChanged += new System.EventHandler(this.lstExistedGenres_SelectedIndexChanged);
            // 
            // btnAddNewGenre
            // 
            this.btnAddNewGenre.BackgroundImage = global::EnterpriseGames.UI.Properties.Resources.right;
            this.btnAddNewGenre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddNewGenre.Enabled = false;
            this.btnAddNewGenre.Location = new System.Drawing.Point(373, 394);
            this.btnAddNewGenre.Name = "btnAddNewGenre";
            this.btnAddNewGenre.Size = new System.Drawing.Size(37, 63);
            this.btnAddNewGenre.TabIndex = 50;
            this.btnAddNewGenre.UseSelectable = true;
            this.btnAddNewGenre.Click += new System.EventHandler(this.btnAddNewGenre_Click);
            // 
            // btnRemoveGanre
            // 
            this.btnRemoveGanre.BackgroundImage = global::EnterpriseGames.UI.Properties.Resources.left;
            this.btnRemoveGanre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRemoveGanre.Enabled = false;
            this.btnRemoveGanre.Location = new System.Drawing.Point(373, 463);
            this.btnRemoveGanre.Name = "btnRemoveGanre";
            this.btnRemoveGanre.Size = new System.Drawing.Size(37, 63);
            this.btnRemoveGanre.TabIndex = 51;
            this.btnRemoveGanre.UseSelectable = true;
            this.btnRemoveGanre.Click += new System.EventHandler(this.btnRemoveGanre_Click);
            // 
            // picGame
            // 
            this.picGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGame.Location = new System.Drawing.Point(23, 63);
            this.picGame.Name = "picGame";
            this.picGame.Size = new System.Drawing.Size(284, 242);
            this.picGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGame.TabIndex = 0;
            this.picGame.TabStop = false;
            // 
            // EditProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 554);
            this.Controls.Add(this.btnRemoveGanre);
            this.Controls.Add(this.btnAddNewGenre);
            this.Controls.Add(this.lstExistedGenres);
            this.Controls.Add(this.lstGameGenres);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.txtNewPrice);
            this.Controls.Add(this.btnAddPrice);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.dtgPrices);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.dtpProductCreated);
            this.Controls.Add(this.dtpCreated);
            this.Controls.Add(this.btnRemoveImage);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.picGame);
            this.Name = "EditProductForm";
            this.Resizable = false;
            this.Text = "Редактирование игры";
            this.Load += new System.EventHandler(this.EditProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrices)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picGame;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtTitle;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtDesc;
        private MetroFramework.Controls.MetroButton btnSubmit;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnRemoveImage;
        private MetroFramework.Controls.MetroButton btnLoadImage;
        private MetroFramework.Controls.MetroDateTime dtpCreated;
        private MetroFramework.Controls.MetroDateTime dtpProductCreated;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroGrid dtgPrices;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroButton btnAddPrice;
        private MetroFramework.Controls.MetroTextBox txtNewPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsExist;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroListView lstGameGenres;
        private MetroFramework.Controls.MetroListView lstExistedGenres;
        private MetroFramework.Controls.MetroButton btnAddNewGenre;
        private MetroFramework.Controls.MetroButton btnRemoveGanre;
    }
}