
namespace Tinkoff_Бюджет
{
    partial class frmMainMenu
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
            if (disposing && ( components != null )) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelUp = new System.Windows.Forms.Panel();
            this.bttnClose = new System.Windows.Forms.PictureBox();
            this.labelHeader = new System.Windows.Forms.Label();
            this.dataTableIncome = new System.Windows.Forms.DataGridView();
            this.dataTableOExpenses = new System.Windows.Forms.DataGridView();
            this.dataTableExpenses = new System.Windows.Forms.DataGridView();
            this.labelIncome = new System.Windows.Forms.Label();
            this.labelOExpenses = new System.Windows.Forms.Label();
            this.labelExpenses = new System.Windows.Forms.Label();
            this.labelTotalIn = new System.Windows.Forms.Label();
            this.labelTotalInNumb = new System.Windows.Forms.Label();
            this.labelTotalOENumber = new System.Windows.Forms.Label();
            this.labelTotalOE = new System.Windows.Forms.Label();
            this.bttnEdit = new System.Windows.Forms.PictureBox();
            this.bttnAdd = new System.Windows.Forms.PictureBox();
            this.bttnDelete = new System.Windows.Forms.PictureBox();
            this.bttnReload = new System.Windows.Forms.PictureBox();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.bttnConfirm = new System.Windows.Forms.Button();
            this.gBoxAdd = new System.Windows.Forms.Panel();
            this.dateTimeP = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelAdd = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSum = new System.Windows.Forms.TextBox();
            this.labelSum = new System.Windows.Forms.Label();
            this.gBox = new System.Windows.Forms.Panel();
            this.bttnRollUp = new System.Windows.Forms.PictureBox();
            this.labelChoose = new System.Windows.Forms.Label();
            this.radioBttnExpenses = new System.Windows.Forms.RadioButton();
            this.radioBttnIncome = new System.Windows.Forms.RadioButton();
            this.radioBttnOExpenses = new System.Windows.Forms.RadioButton();
            this.panelUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bttnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableIncome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableOExpenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableExpenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttnReload)).BeginInit();
            this.panelYellow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gBoxAdd.SuspendLayout();
            this.gBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bttnRollUp)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUp
            // 
            this.panelUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(13)))));
            this.panelUp.Controls.Add(this.bttnClose);
            this.panelUp.Controls.Add(this.labelHeader);
            this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp.Location = new System.Drawing.Point(0, 0);
            this.panelUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(1500, 38);
            this.panelUp.TabIndex = 0;
            this.panelUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelUp_MouseDown);
            // 
            // bttnClose
            // 
            this.bttnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnClose.Image = ((System.Drawing.Image)(resources.GetObject("bttnClose.Image")));
            this.bttnClose.Location = new System.Drawing.Point(1463, 2);
            this.bttnClose.Margin = new System.Windows.Forms.Padding(0);
            this.bttnClose.Name = "bttnClose";
            this.bttnClose.Size = new System.Drawing.Size(35, 35);
            this.bttnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bttnClose.TabIndex = 1;
            this.bttnClose.TabStop = false;
            this.bttnClose.Click += new System.EventHandler(this.bttnClose_Click);
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelHeader.Location = new System.Drawing.Point(711, 8);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(78, 22);
            this.labelHeader.TabIndex = 1;
            this.labelHeader.Text = "Бюджет";
            // 
            // dataTableIncome
            // 
            this.dataTableIncome.AllowUserToAddRows = false;
            this.dataTableIncome.AllowUserToDeleteRows = false;
            this.dataTableIncome.AllowUserToResizeColumns = false;
            this.dataTableIncome.AllowUserToResizeRows = false;
            this.dataTableIncome.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTableIncome.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.dataTableIncome.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataTableIncome.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTableIncome.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataTableIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTableIncome.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataTableIncome.Location = new System.Drawing.Point(12, 65);
            this.dataTableIncome.Name = "dataTableIncome";
            this.dataTableIncome.ReadOnly = true;
            this.dataTableIncome.Size = new System.Drawing.Size(330, 398);
            this.dataTableIncome.TabIndex = 1;
            this.dataTableIncome.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTableIncome_CellClick);
            // 
            // dataTableOExpenses
            // 
            this.dataTableOExpenses.AllowUserToAddRows = false;
            this.dataTableOExpenses.AllowUserToDeleteRows = false;
            this.dataTableOExpenses.AllowUserToResizeColumns = false;
            this.dataTableOExpenses.AllowUserToResizeRows = false;
            this.dataTableOExpenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTableOExpenses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.dataTableOExpenses.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataTableOExpenses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTableOExpenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataTableOExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTableOExpenses.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataTableOExpenses.Location = new System.Drawing.Point(348, 65);
            this.dataTableOExpenses.Name = "dataTableOExpenses";
            this.dataTableOExpenses.ReadOnly = true;
            this.dataTableOExpenses.Size = new System.Drawing.Size(330, 398);
            this.dataTableOExpenses.TabIndex = 2;
            this.dataTableOExpenses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTableOExpenses_CellClick);
            // 
            // dataTableExpenses
            // 
            this.dataTableExpenses.AllowUserToAddRows = false;
            this.dataTableExpenses.AllowUserToDeleteRows = false;
            this.dataTableExpenses.AllowUserToResizeColumns = false;
            this.dataTableExpenses.AllowUserToResizeRows = false;
            this.dataTableExpenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTableExpenses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.dataTableExpenses.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataTableExpenses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTableExpenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataTableExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTableExpenses.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataTableExpenses.Location = new System.Drawing.Point(684, 65);
            this.dataTableExpenses.Name = "dataTableExpenses";
            this.dataTableExpenses.ReadOnly = true;
            this.dataTableExpenses.Size = new System.Drawing.Size(804, 697);
            this.dataTableExpenses.TabIndex = 3;
            this.dataTableExpenses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTableExpenses_CellClick);
            // 
            // labelIncome
            // 
            this.labelIncome.AutoSize = true;
            this.labelIncome.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIncome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelIncome.Location = new System.Drawing.Point(147, 41);
            this.labelIncome.Name = "labelIncome";
            this.labelIncome.Size = new System.Drawing.Size(60, 21);
            this.labelIncome.TabIndex = 2;
            this.labelIncome.Text = "Доход";
            // 
            // labelOExpenses
            // 
            this.labelOExpenses.AutoSize = true;
            this.labelOExpenses.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOExpenses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelOExpenses.Location = new System.Drawing.Point(415, 41);
            this.labelOExpenses.Name = "labelOExpenses";
            this.labelOExpenses.Size = new System.Drawing.Size(196, 21);
            this.labelOExpenses.TabIndex = 4;
            this.labelOExpenses.Text = "Обязательные расходы";
            // 
            // labelExpenses
            // 
            this.labelExpenses.AutoSize = true;
            this.labelExpenses.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExpenses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelExpenses.Location = new System.Drawing.Point(1044, 41);
            this.labelExpenses.Name = "labelExpenses";
            this.labelExpenses.Size = new System.Drawing.Size(85, 21);
            this.labelExpenses.TabIndex = 5;
            this.labelExpenses.Text = "Рассходы";
            // 
            // labelTotalIn
            // 
            this.labelTotalIn.AutoSize = true;
            this.labelTotalIn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelTotalIn.Location = new System.Drawing.Point(12, 478);
            this.labelTotalIn.Name = "labelTotalIn";
            this.labelTotalIn.Size = new System.Drawing.Size(58, 21);
            this.labelTotalIn.TabIndex = 7;
            this.labelTotalIn.Text = "Всего:";
            // 
            // labelTotalInNumb
            // 
            this.labelTotalInNumb.AutoSize = true;
            this.labelTotalInNumb.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalInNumb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelTotalInNumb.Location = new System.Drawing.Point(76, 478);
            this.labelTotalInNumb.Name = "labelTotalInNumb";
            this.labelTotalInNumb.Size = new System.Drawing.Size(67, 21);
            this.labelTotalInNumb.TabIndex = 8;
            this.labelTotalInNumb.Text = "number";
            // 
            // labelTotalOENumber
            // 
            this.labelTotalOENumber.AutoSize = true;
            this.labelTotalOENumber.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalOENumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelTotalOENumber.Location = new System.Drawing.Point(412, 478);
            this.labelTotalOENumber.Name = "labelTotalOENumber";
            this.labelTotalOENumber.Size = new System.Drawing.Size(67, 21);
            this.labelTotalOENumber.TabIndex = 10;
            this.labelTotalOENumber.Text = "number";
            // 
            // labelTotalOE
            // 
            this.labelTotalOE.AutoSize = true;
            this.labelTotalOE.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalOE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelTotalOE.Location = new System.Drawing.Point(348, 478);
            this.labelTotalOE.Name = "labelTotalOE";
            this.labelTotalOE.Size = new System.Drawing.Size(58, 21);
            this.labelTotalOE.TabIndex = 9;
            this.labelTotalOE.Text = "Всего:";
            // 
            // bttnEdit
            // 
            this.bttnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnEdit.Image = ((System.Drawing.Image)(resources.GetObject("bttnEdit.Image")));
            this.bttnEdit.Location = new System.Drawing.Point(64, 9);
            this.bttnEdit.Name = "bttnEdit";
            this.bttnEdit.Size = new System.Drawing.Size(35, 35);
            this.bttnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bttnEdit.TabIndex = 12;
            this.bttnEdit.TabStop = false;
            this.bttnEdit.Click += new System.EventHandler(this.bttnEdit_Click);
            // 
            // bttnAdd
            // 
            this.bttnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnAdd.Image = ((System.Drawing.Image)(resources.GetObject("bttnAdd.Image")));
            this.bttnAdd.Location = new System.Drawing.Point(23, 9);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(35, 35);
            this.bttnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bttnAdd.TabIndex = 11;
            this.bttnAdd.TabStop = false;
            this.bttnAdd.Click += new System.EventHandler(this.bttnAdd_Click);
            // 
            // bttnDelete
            // 
            this.bttnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnDelete.Image = ((System.Drawing.Image)(resources.GetObject("bttnDelete.Image")));
            this.bttnDelete.Location = new System.Drawing.Point(105, 9);
            this.bttnDelete.Name = "bttnDelete";
            this.bttnDelete.Size = new System.Drawing.Size(35, 35);
            this.bttnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bttnDelete.TabIndex = 13;
            this.bttnDelete.TabStop = false;
            this.bttnDelete.Click += new System.EventHandler(this.bttnDelete_Click);
            // 
            // bttnReload
            // 
            this.bttnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnReload.Image = ((System.Drawing.Image)(resources.GetObject("bttnReload.Image")));
            this.bttnReload.Location = new System.Drawing.Point(146, 9);
            this.bttnReload.Name = "bttnReload";
            this.bttnReload.Size = new System.Drawing.Size(35, 35);
            this.bttnReload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bttnReload.TabIndex = 6;
            this.bttnReload.TabStop = false;
            this.bttnReload.Click += new System.EventHandler(this.bttnReload_Click);
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(13)))));
            this.panelYellow.Controls.Add(this.pictureBox1);
            this.panelYellow.Controls.Add(this.bttnCancel);
            this.panelYellow.Controls.Add(this.bttnConfirm);
            this.panelYellow.Controls.Add(this.gBoxAdd);
            this.panelYellow.Controls.Add(this.gBox);
            this.panelYellow.Controls.Add(this.bttnReload);
            this.panelYellow.Controls.Add(this.bttnDelete);
            this.panelYellow.Controls.Add(this.bttnAdd);
            this.panelYellow.Controls.Add(this.bttnEdit);
            this.panelYellow.Location = new System.Drawing.Point(0, 598);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(580, 180);
            this.panelYellow.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(217, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(5, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // bttnCancel
            // 
            this.bttnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnCancel.FlatAppearance.BorderSize = 0;
            this.bttnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.bttnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(236)))), ((int)(((byte)(72)))));
            this.bttnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCancel.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.bttnCancel.Location = new System.Drawing.Point(405, 128);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(175, 30);
            this.bttnCancel.TabIndex = 23;
            this.bttnCancel.Text = "Отменить";
            this.bttnCancel.UseVisualStyleBackColor = true;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // bttnConfirm
            // 
            this.bttnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnConfirm.FlatAppearance.BorderSize = 0;
            this.bttnConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.bttnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(236)))), ((int)(((byte)(72)))));
            this.bttnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnConfirm.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.bttnConfirm.Location = new System.Drawing.Point(222, 128);
            this.bttnConfirm.Name = "bttnConfirm";
            this.bttnConfirm.Size = new System.Drawing.Size(175, 30);
            this.bttnConfirm.TabIndex = 22;
            this.bttnConfirm.Text = "Подтвердить";
            this.bttnConfirm.UseVisualStyleBackColor = true;
            this.bttnConfirm.Click += new System.EventHandler(this.bttnConfirm_Click);
            // 
            // gBoxAdd
            // 
            this.gBoxAdd.Controls.Add(this.dateTimeP);
            this.gBoxAdd.Controls.Add(this.labelDate);
            this.gBoxAdd.Controls.Add(this.labelAdd);
            this.gBoxAdd.Controls.Add(this.labelName);
            this.gBoxAdd.Controls.Add(this.tbName);
            this.gBoxAdd.Controls.Add(this.tbSum);
            this.gBoxAdd.Controls.Add(this.labelSum);
            this.gBoxAdd.Location = new System.Drawing.Point(227, 9);
            this.gBoxAdd.Name = "gBoxAdd";
            this.gBoxAdd.Size = new System.Drawing.Size(345, 117);
            this.gBoxAdd.TabIndex = 21;
            // 
            // dateTimeP
            // 
            this.dateTimeP.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dateTimeP.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.dateTimeP.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(13)))));
            this.dateTimeP.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dateTimeP.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.dateTimeP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeP.Location = new System.Drawing.Point(149, 85);
            this.dateTimeP.MinDate = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            this.dateTimeP.Name = "dateTimeP";
            this.dateTimeP.Size = new System.Drawing.Size(189, 23);
            this.dateTimeP.TabIndex = 19;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelDate.Location = new System.Drawing.Point(3, 86);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(122, 21);
            this.labelDate.TabIndex = 18;
            this.labelDate.Text = "Дата покупки:";
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.labelAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelAdd.Location = new System.Drawing.Point(127, 4);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(92, 19);
            this.labelAdd.TabIndex = 16;
            this.labelAdd.Text = "add/editTxt";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelName.Location = new System.Drawing.Point(3, 26);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(133, 21);
            this.labelName.TabIndex = 15;
            this.labelName.Text = "Наименование:";
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.tbName.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.tbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tbName.Location = new System.Drawing.Point(149, 26);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(189, 23);
            this.tbName.TabIndex = 16;
            // 
            // tbSum
            // 
            this.tbSum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.tbSum.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.tbSum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tbSum.Location = new System.Drawing.Point(149, 55);
            this.tbSum.Name = "tbSum";
            this.tbSum.Size = new System.Drawing.Size(189, 23);
            this.tbSum.TabIndex = 16;
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelSum.Location = new System.Drawing.Point(3, 55);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(66, 21);
            this.labelSum.TabIndex = 17;
            this.labelSum.Text = "Сумма:";
            // 
            // gBox
            // 
            this.gBox.Controls.Add(this.bttnRollUp);
            this.gBox.Controls.Add(this.labelChoose);
            this.gBox.Controls.Add(this.radioBttnExpenses);
            this.gBox.Controls.Add(this.radioBttnIncome);
            this.gBox.Controls.Add(this.radioBttnOExpenses);
            this.gBox.Location = new System.Drawing.Point(15, 50);
            this.gBox.Name = "gBox";
            this.gBox.Size = new System.Drawing.Size(205, 126);
            this.gBox.TabIndex = 20;
            // 
            // bttnRollUp
            // 
            this.bttnRollUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnRollUp.Image = ((System.Drawing.Image)(resources.GetObject("bttnRollUp.Image")));
            this.bttnRollUp.Location = new System.Drawing.Point(79, 106);
            this.bttnRollUp.Name = "bttnRollUp";
            this.bttnRollUp.Size = new System.Drawing.Size(37, 21);
            this.bttnRollUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bttnRollUp.TabIndex = 15;
            this.bttnRollUp.TabStop = false;
            this.bttnRollUp.Click += new System.EventHandler(this.bttnRollUp_Click);
            // 
            // labelChoose
            // 
            this.labelChoose.AutoSize = true;
            this.labelChoose.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.labelChoose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelChoose.Location = new System.Drawing.Point(8, 3);
            this.labelChoose.Name = "labelChoose";
            this.labelChoose.Size = new System.Drawing.Size(190, 19);
            this.labelChoose.TabIndex = 15;
            this.labelChoose.Text = "Что требуется добавить?";
            // 
            // radioBttnExpenses
            // 
            this.radioBttnExpenses.AutoSize = true;
            this.radioBttnExpenses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioBttnExpenses.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.radioBttnExpenses.Location = new System.Drawing.Point(12, 82);
            this.radioBttnExpenses.Name = "radioBttnExpenses";
            this.radioBttnExpenses.Size = new System.Drawing.Size(171, 21);
            this.radioBttnExpenses.TabIndex = 2;
            this.radioBttnExpenses.TabStop = true;
            this.radioBttnExpenses.Text = "Повседневные расходы";
            this.radioBttnExpenses.UseVisualStyleBackColor = true;
            this.radioBttnExpenses.CheckedChanged += new System.EventHandler(this.bttnExpenses_CheckedChanged);
            // 
            // radioBttnIncome
            // 
            this.radioBttnIncome.AutoSize = true;
            this.radioBttnIncome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioBttnIncome.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.radioBttnIncome.Location = new System.Drawing.Point(12, 28);
            this.radioBttnIncome.Name = "radioBttnIncome";
            this.radioBttnIncome.Size = new System.Drawing.Size(64, 21);
            this.radioBttnIncome.TabIndex = 0;
            this.radioBttnIncome.TabStop = true;
            this.radioBttnIncome.Text = "Доход";
            this.radioBttnIncome.UseVisualStyleBackColor = true;
            this.radioBttnIncome.CheckedChanged += new System.EventHandler(this.radioBttnIncome_CheckedChanged);
            // 
            // radioBttnOExpenses
            // 
            this.radioBttnOExpenses.AutoSize = true;
            this.radioBttnOExpenses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioBttnOExpenses.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.radioBttnOExpenses.Location = new System.Drawing.Point(12, 55);
            this.radioBttnOExpenses.Name = "radioBttnOExpenses";
            this.radioBttnOExpenses.Size = new System.Drawing.Size(169, 21);
            this.radioBttnOExpenses.TabIndex = 1;
            this.radioBttnOExpenses.TabStop = true;
            this.radioBttnOExpenses.Text = "Обязательные расходы";
            this.radioBttnOExpenses.UseVisualStyleBackColor = true;
            this.radioBttnOExpenses.CheckedChanged += new System.EventHandler(this.bttnOExpenses_CheckedChanged);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1500, 777);
            this.Controls.Add(this.panelYellow);
            this.Controls.Add(this.labelTotalOENumber);
            this.Controls.Add(this.labelTotalOE);
            this.Controls.Add(this.labelTotalInNumb);
            this.Controls.Add(this.labelTotalIn);
            this.Controls.Add(this.labelExpenses);
            this.Controls.Add(this.labelOExpenses);
            this.Controls.Add(this.labelIncome);
            this.Controls.Add(this.dataTableExpenses);
            this.Controls.Add(this.dataTableOExpenses);
            this.Controls.Add(this.dataTableIncome);
            this.Controls.Add(this.panelUp);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.formMainMenu_Load);
            this.panelUp.ResumeLayout(false);
            this.panelUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bttnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableIncome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableOExpenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableExpenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttnReload)).EndInit();
            this.panelYellow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gBoxAdd.ResumeLayout(false);
            this.gBoxAdd.PerformLayout();
            this.gBox.ResumeLayout(false);
            this.gBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bttnRollUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.PictureBox bttnClose;
        private System.Windows.Forms.DataGridView dataTableIncome;
        private System.Windows.Forms.DataGridView dataTableOExpenses;
        private System.Windows.Forms.DataGridView dataTableExpenses;
        private System.Windows.Forms.Label labelIncome;
        private System.Windows.Forms.Label labelOExpenses;
        private System.Windows.Forms.Label labelExpenses;
        private System.Windows.Forms.Label labelTotalIn;
        private System.Windows.Forms.Label labelTotalInNumb;
        private System.Windows.Forms.Label labelTotalOENumber;
        private System.Windows.Forms.Label labelTotalOE;
        private System.Windows.Forms.PictureBox bttnEdit;
        private System.Windows.Forms.PictureBox bttnAdd;
        private System.Windows.Forms.PictureBox bttnDelete;
        private System.Windows.Forms.PictureBox bttnReload;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.RadioButton radioBttnExpenses;
        private System.Windows.Forms.RadioButton radioBttnOExpenses;
        private System.Windows.Forms.RadioButton radioBttnIncome;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox tbSum;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Panel gBox;
        private System.Windows.Forms.Label labelChoose;
        private System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.Panel gBoxAdd;
        private System.Windows.Forms.Button bttnConfirm;
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.DateTimePicker dateTimeP;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox bttnRollUp;
    }
}

