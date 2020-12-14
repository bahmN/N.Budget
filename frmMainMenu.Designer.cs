
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle67 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle68 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle69 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle70 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle71 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle72 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.gBox = new System.Windows.Forms.GroupBox();
            this.radioBttnIncome = new System.Windows.Forms.RadioButton();
            this.bttnOExpenses = new System.Windows.Forms.RadioButton();
            this.bttnExpenses = new System.Windows.Forms.RadioButton();
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
            this.gBox.SuspendLayout();
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
            dataGridViewCellStyle67.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle67.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle67.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle67.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle67.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle67.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle67.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTableIncome.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle67;
            this.dataTableIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle68.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle68.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle68.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle68.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle68.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle68.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle68.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTableIncome.DefaultCellStyle = dataGridViewCellStyle68;
            this.dataTableIncome.Location = new System.Drawing.Point(12, 65);
            this.dataTableIncome.Name = "dataTableIncome";
            this.dataTableIncome.Size = new System.Drawing.Size(330, 398);
            this.dataTableIncome.TabIndex = 1;
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
            dataGridViewCellStyle69.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle69.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle69.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle69.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle69.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle69.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle69.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTableOExpenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle69;
            this.dataTableOExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle70.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle70.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle70.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle70.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle70.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle70.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle70.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTableOExpenses.DefaultCellStyle = dataGridViewCellStyle70;
            this.dataTableOExpenses.Location = new System.Drawing.Point(348, 65);
            this.dataTableOExpenses.Name = "dataTableOExpenses";
            this.dataTableOExpenses.Size = new System.Drawing.Size(330, 398);
            this.dataTableOExpenses.TabIndex = 2;
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
            dataGridViewCellStyle71.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle71.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle71.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle71.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle71.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle71.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle71.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTableExpenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle71;
            this.dataTableExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle72.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle72.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle72.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle72.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle72.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle72.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle72.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTableExpenses.DefaultCellStyle = dataGridViewCellStyle72;
            this.dataTableExpenses.Location = new System.Drawing.Point(684, 65);
            this.dataTableExpenses.Name = "dataTableExpenses";
            this.dataTableExpenses.Size = new System.Drawing.Size(804, 697);
            this.dataTableExpenses.TabIndex = 3;
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
            this.labelExpenses.Location = new System.Drawing.Point(1039, 41);
            this.labelExpenses.Name = "labelExpenses";
            this.labelExpenses.Size = new System.Drawing.Size(95, 21);
            this.labelExpenses.TabIndex = 5;
            this.labelExpenses.Text = "Рассоходы";
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
            this.bttnEdit.Location = new System.Drawing.Point(57, 9);
            this.bttnEdit.Name = "bttnEdit";
            this.bttnEdit.Size = new System.Drawing.Size(35, 35);
            this.bttnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bttnEdit.TabIndex = 12;
            this.bttnEdit.TabStop = false;
            // 
            // bttnAdd
            // 
            this.bttnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnAdd.Image = ((System.Drawing.Image)(resources.GetObject("bttnAdd.Image")));
            this.bttnAdd.Location = new System.Drawing.Point(16, 9);
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
            this.bttnDelete.Location = new System.Drawing.Point(98, 9);
            this.bttnDelete.Name = "bttnDelete";
            this.bttnDelete.Size = new System.Drawing.Size(35, 35);
            this.bttnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bttnDelete.TabIndex = 13;
            this.bttnDelete.TabStop = false;
            // 
            // bttnReload
            // 
            this.bttnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnReload.Image = ((System.Drawing.Image)(resources.GetObject("bttnReload.Image")));
            this.bttnReload.Location = new System.Drawing.Point(139, 9);
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
            this.panelYellow.Controls.Add(this.gBox);
            this.panelYellow.Controls.Add(this.bttnReload);
            this.panelYellow.Controls.Add(this.bttnDelete);
            this.panelYellow.Controls.Add(this.bttnAdd);
            this.panelYellow.Controls.Add(this.bttnEdit);
            this.panelYellow.Location = new System.Drawing.Point(0, 598);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(675, 165);
            this.panelYellow.TabIndex = 14;
            // 
            // gBox
            // 
            this.gBox.Controls.Add(this.bttnExpenses);
            this.gBox.Controls.Add(this.bttnOExpenses);
            this.gBox.Controls.Add(this.radioBttnIncome);
            this.gBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.gBox.Location = new System.Drawing.Point(16, 50);
            this.gBox.Margin = new System.Windows.Forms.Padding(0);
            this.gBox.Name = "gBox";
            this.gBox.Size = new System.Drawing.Size(199, 109);
            this.gBox.TabIndex = 15;
            this.gBox.TabStop = false;
            this.gBox.Text = "Что требуется добавить? ";
            // 
            // radioBttnIncome
            // 
            this.radioBttnIncome.AutoSize = true;
            this.radioBttnIncome.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.radioBttnIncome.Location = new System.Drawing.Point(11, 24);
            this.radioBttnIncome.Name = "radioBttnIncome";
            this.radioBttnIncome.Size = new System.Drawing.Size(64, 21);
            this.radioBttnIncome.TabIndex = 0;
            this.radioBttnIncome.TabStop = true;
            this.radioBttnIncome.Text = "Доход";
            this.radioBttnIncome.UseVisualStyleBackColor = true;
            this.radioBttnIncome.CheckedChanged += new System.EventHandler(this.radioBttnIncome_CheckedChanged);
            // 
            // bttnOExpenses
            // 
            this.bttnOExpenses.AutoSize = true;
            this.bttnOExpenses.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.bttnOExpenses.Location = new System.Drawing.Point(11, 51);
            this.bttnOExpenses.Name = "bttnOExpenses";
            this.bttnOExpenses.Size = new System.Drawing.Size(169, 21);
            this.bttnOExpenses.TabIndex = 1;
            this.bttnOExpenses.TabStop = true;
            this.bttnOExpenses.Text = "Обязательные расходы";
            this.bttnOExpenses.UseVisualStyleBackColor = true;
            this.bttnOExpenses.CheckedChanged += new System.EventHandler(this.bttnOExpenses_CheckedChanged);
            // 
            // bttnExpenses
            // 
            this.bttnExpenses.AutoSize = true;
            this.bttnExpenses.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.bttnExpenses.Location = new System.Drawing.Point(11, 78);
            this.bttnExpenses.Name = "bttnExpenses";
            this.bttnExpenses.Size = new System.Drawing.Size(76, 21);
            this.bttnExpenses.TabIndex = 2;
            this.bttnExpenses.TabStop = true;
            this.bttnExpenses.Text = "Расходы";
            this.bttnExpenses.UseVisualStyleBackColor = true;
            this.bttnExpenses.CheckedChanged += new System.EventHandler(this.bttnExpenses_CheckedChanged);
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
            this.gBox.ResumeLayout(false);
            this.gBox.PerformLayout();
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
        private System.Windows.Forms.GroupBox gBox;
        private System.Windows.Forms.RadioButton bttnExpenses;
        private System.Windows.Forms.RadioButton bttnOExpenses;
        private System.Windows.Forms.RadioButton radioBttnIncome;
    }
}

