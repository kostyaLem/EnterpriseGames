namespace EnterpriseGames.UI.Forms
{
    partial class ProductsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGrid = new MetroFramework.Controls.MetroGrid();
            this.RowId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductDateCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsExist = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRemove = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.lblCount = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dtgPrices = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.picGame = new System.Windows.Forms.PictureBox();
            this.txtFilter = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.dtgGenres = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtDesc = new MetroFramework.Controls.MetroTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGenres)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dataGrid.ColumnHeadersHeight = 30;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowId,
            this.TitleId,
            this.DateCreated,
            this.ProductDateCreated,
            this.LastPrice,
            this.IsExist});
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle26;
            this.dataGrid.EnableHeadersVisualStyles = false;
            this.dataGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGrid.Location = new System.Drawing.Point(23, 99);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGrid.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(759, 347);
            this.dataGrid.TabIndex = 1;
            this.dataGrid.SelectionChanged += new System.EventHandler(this.dataGrid_SelectionChanged);
            // 
            // RowId
            // 
            this.RowId.DividerWidth = 1;
            this.RowId.Frozen = true;
            this.RowId.HeaderText = "#";
            this.RowId.Name = "RowId";
            this.RowId.ReadOnly = true;
            this.RowId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RowId.Width = 20;
            // 
            // TitleId
            // 
            this.TitleId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TitleId.HeaderText = "Название";
            this.TitleId.Name = "TitleId";
            this.TitleId.ReadOnly = true;
            // 
            // DateCreated
            // 
            this.DateCreated.HeaderText = "Дата создания";
            this.DateCreated.Name = "DateCreated";
            this.DateCreated.ReadOnly = true;
            // 
            // ProductDateCreated
            // 
            this.ProductDateCreated.HeaderText = "Появилась";
            this.ProductDateCreated.Name = "ProductDateCreated";
            this.ProductDateCreated.ReadOnly = true;
            // 
            // LastPrice
            // 
            this.LastPrice.HeaderText = "Последняя цена";
            this.LastPrice.Name = "LastPrice";
            this.LastPrice.ReadOnly = true;
            // 
            // IsExist
            // 
            this.IsExist.HeaderText = "В наличии";
            this.IsExist.Name = "IsExist";
            this.IsExist.ReadOnly = true;
            this.IsExist.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsExist.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.btnRemove);
            this.flowLayoutPanel1.Controls.Add(this.btnEdit);
            this.flowLayoutPanel1.Controls.Add(this.btnAdd);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(653, 649);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(524, 43);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(3, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(168, 35);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Удалить";
            this.btnRemove.UseSelectable = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(177, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(168, 35);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(351, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(168, 35);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCount.AutoSize = true;
            this.lblCount.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCount.Location = new System.Drawing.Point(126, 657);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 0);
            this.lblCount.TabIndex = 8;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(23, 657);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(106, 25);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Количество:";
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
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPrices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dtgPrices.ColumnHeadersHeight = 30;
            this.dtgPrices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.PriceDate});
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgPrices.DefaultCellStyle = dataGridViewCellStyle30;
            this.dtgPrices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgPrices.EnableHeadersVisualStyles = false;
            this.dtgPrices.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtgPrices.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgPrices.Location = new System.Drawing.Point(3, 34);
            this.dtgPrices.Name = "dtgPrices";
            this.dtgPrices.ReadOnly = true;
            this.dtgPrices.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPrices.RowHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.dtgPrices.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgPrices.RowsDefaultCellStyle = dataGridViewCellStyle32;
            this.dtgPrices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPrices.Size = new System.Drawing.Size(373, 142);
            this.dtgPrices.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DividerWidth = 1;
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "#";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 20;
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
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(3, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(208, 25);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "История изменения цен:";
            // 
            // picGame
            // 
            this.picGame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGame.Location = new System.Drawing.Point(810, 99);
            this.picGame.Name = "picGame";
            this.picGame.Size = new System.Drawing.Size(363, 233);
            this.picGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGame.TabIndex = 11;
            this.picGame.TabStop = false;
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            // 
            // 
            // 
            this.txtFilter.CustomButton.Image = null;
            this.txtFilter.CustomButton.Location = new System.Drawing.Point(731, 2);
            this.txtFilter.CustomButton.Name = "";
            this.txtFilter.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtFilter.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFilter.CustomButton.TabIndex = 1;
            this.txtFilter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFilter.CustomButton.UseSelectable = true;
            this.txtFilter.CustomButton.Visible = false;
            this.txtFilter.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtFilter.Lines = new string[0];
            this.txtFilter.Location = new System.Drawing.Point(23, 63);
            this.txtFilter.MaxLength = 32767;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.PasswordChar = '\0';
            this.txtFilter.PromptText = "Фильтр поиска";
            this.txtFilter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFilter.SelectedText = "";
            this.txtFilter.SelectionLength = 0;
            this.txtFilter.SelectionStart = 0;
            this.txtFilter.ShortcutsEnabled = false;
            this.txtFilter.Size = new System.Drawing.Size(759, 30);
            this.txtFilter.TabIndex = 13;
            this.txtFilter.UseSelectable = true;
            this.txtFilter.WaterMark = "Фильтр поиска";
            this.txtFilter.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFilter.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(382, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(115, 25);
            this.metroLabel3.TabIndex = 15;
            this.metroLabel3.Text = "Жанры игры:";
            // 
            // dtgGenres
            // 
            this.dtgGenres.AllowUserToAddRows = false;
            this.dtgGenres.AllowUserToDeleteRows = false;
            this.dtgGenres.AllowUserToResizeRows = false;
            this.dtgGenres.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgGenres.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgGenres.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgGenres.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgGenres.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle33;
            this.dtgGenres.ColumnHeadersHeight = 30;
            this.dtgGenres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgGenres.DefaultCellStyle = dataGridViewCellStyle34;
            this.dtgGenres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgGenres.EnableHeadersVisualStyles = false;
            this.dtgGenres.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtgGenres.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgGenres.Location = new System.Drawing.Point(382, 34);
            this.dtgGenres.Name = "dtgGenres";
            this.dtgGenres.ReadOnly = true;
            this.dtgGenres.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgGenres.RowHeadersDefaultCellStyle = dataGridViewCellStyle35;
            this.dtgGenres.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgGenres.RowsDefaultCellStyle = dataGridViewCellStyle36;
            this.dtgGenres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgGenres.Size = new System.Drawing.Size(374, 142);
            this.dtgGenres.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DividerWidth = 1;
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "#";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.Width = 20;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Название";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(810, 68);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(168, 25);
            this.metroLabel4.TabIndex = 16;
            this.metroLabel4.Text = "Изображение игры:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(810, 335);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(139, 25);
            this.metroLabel5.TabIndex = 17;
            this.metroLabel5.Text = "Описание игры:";
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtDesc.CustomButton.Image = null;
            this.txtDesc.CustomButton.Location = new System.Drawing.Point(93, 2);
            this.txtDesc.CustomButton.Name = "";
            this.txtDesc.CustomButton.Size = new System.Drawing.Size(267, 267);
            this.txtDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDesc.CustomButton.TabIndex = 1;
            this.txtDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDesc.CustomButton.UseSelectable = true;
            this.txtDesc.CustomButton.Visible = false;
            this.txtDesc.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDesc.Lines = new string[0];
            this.txtDesc.Location = new System.Drawing.Point(810, 363);
            this.txtDesc.MaxLength = 32767;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.PasswordChar = '\0';
            this.txtDesc.ReadOnly = true;
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDesc.SelectedText = "";
            this.txtDesc.SelectionLength = 0;
            this.txtDesc.SelectionStart = 0;
            this.txtDesc.ShortcutsEnabled = true;
            this.txtDesc.Size = new System.Drawing.Size(363, 272);
            this.txtDesc.TabIndex = 18;
            this.txtDesc.UseSelectable = true;
            this.txtDesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDesc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dtgPrices, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtgGenres, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel3, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 456);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.87709F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.1229F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(759, 179);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 715);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.picGame);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dataGrid);
            this.MinimumSize = new System.Drawing.Size(1200, 715);
            this.Name = "ProductsForm";
            this.Text = "Игры";
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGenres)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dataGrid;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroButton btnRemove;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroLabel lblCount;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCreated;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDateCreated;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastPrice;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsExist;
        private MetroFramework.Controls.MetroGrid dtgPrices;
        private System.Windows.Forms.PictureBox picGame;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceDate;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroGrid dtgGenres;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtDesc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}