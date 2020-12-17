using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Tinkoff_Бюджет
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }
        static public MySqlConnection connection;
        /*
         * Параметры перемещения
         */
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);
        // Функция передачи данных параметров(само действие перемешения)
        private void panelUp_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        /*
         * Закрыть приложение
         */
        private void bttnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formMainMenu_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection("server = 127.0.0.1; port = 3306; user = root; password = Vfhnvfhn23@; database = tinkoffbudget; sslmode = none;");
            connection.Open();
            bttnReload_Click(sender, e);

            panelYellow.Width = 185;
            panelYellow.Height = 55;

            dateTimeP.Value = DateTime.Now;
            dateTimeP.MaxDate = DateTime.Now;
        }

        /*
         * Отобразить бд(обновить)
         */
        private void bttnReload_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter daIncome = new MySqlDataAdapter("SELECT * FROM доход", connection);
            DataTable dtIncome = new DataTable();
            daIncome.Fill(dtIncome);
            dataTableIncome.DataSource = dtIncome;
            dataTableIncome.RowHeadersVisible = false; // Hide the display of the left column
            dataTableIncome.AllowUserToAddRows = false; // Hide the display of the bottom column
            dataTableIncome.Columns[0].Visible = false;

            //Вывод суммы дохода в label 
            MySqlCommand cSumI = new MySqlCommand("SELECT SUM(Сумма) FROM доход", connection);
            object sumIObj = cSumI.ExecuteScalar();
            labelTotalInNumb.Text = sumIObj.ToString() + " ₽";

            MySqlDataAdapter daOExpenses = new MySqlDataAdapter("SELECT * FROM траты WHERE `Вид трат`= 'Обязательные'", connection);
            DataTable dtOExpenses = new DataTable();
            daOExpenses.Fill(dtOExpenses);
            dataTableOExpenses.DataSource = dtOExpenses;
            dataTableOExpenses.RowHeadersVisible = false; // Hide the display of the left column
            dataTableOExpenses.AllowUserToAddRows = false; // Hide the display of the bottom column
            dataTableOExpenses.Columns[0].Visible = false;
            dataTableOExpenses.Columns[3].Visible = false;
            dataTableOExpenses.Columns[4].Visible = false;

            //Вывод суммы обязательных трат в label
            MySqlCommand cSumOE = new MySqlCommand("SELECT SUM(Сумма) FROM траты WHERE `Вид трат`= 'Обязательные'", connection);
            object sumOEObj = cSumOE.ExecuteScalar();
            labelTotalOENumber.Text = sumOEObj.ToString() + " ₽";

            MySqlDataAdapter daIExpenses = new MySqlDataAdapter("SELECT * FROM траты WHERE `Вид трат`= 'Необязательные'", connection);
            DataTable dtExpenses = new DataTable();
            daIExpenses.Fill(dtExpenses);
            dataTableExpenses.DataSource = dtExpenses;
            dataTableExpenses.RowHeadersVisible = false; // Hide the display of the left column
            dataTableExpenses.AllowUserToAddRows = false; // Hide the display of the bottom column
            dataTableExpenses.Columns[0].Visible = false;
            dataTableExpenses.Columns[3].Visible = false;
        }

        /*
         * События добавить/изменить/удалить
         */
        //Добавить
        private void bttnAdd_Click(object sender, EventArgs e)
        {
            gBox.Visible = true;
            panelYellow.Width = 225;
            panelYellow.Height = 180;
            labelChoose.Text = "Что требуется добавить?";

            tbName.Text = default;
            tbSum.Text = default;

            radioBttnIncome.Checked = default;
            radioBttnOExpenses.Checked = default;
            radioBttnExpenses.Checked = default;
        }

        //Изменить
        private void bttnEdit_Click(object sender, EventArgs e)
        {
            gBox.Visible = false;
            panelYellow.Width = 580;
            panelYellow.Height = 180;
            labelAdd.Text = "Изменить";

            tbName.Text = default;
            tbSum.Text = default;

            if (dataTableIncome.SelectedRows.Count == 1) {
                tbName.Text = dataTableIncome.SelectedRows[0].Cells[1].Value.ToString();
                tbSum.Text = dataTableIncome.SelectedRows[0].Cells[2].Value.ToString();

                labelDate.Visible = false;
                dateTimeP.Visible = false;
            }
            else if (dataTableOExpenses.SelectedRows.Count == 1) {
                tbName.Text = dataTableOExpenses.SelectedRows[0].Cells[1].Value.ToString();
                tbSum.Text = dataTableOExpenses.SelectedRows[0].Cells[2].Value.ToString();

                labelDate.Visible = false;
                dateTimeP.Visible = false;
            }
            else if (dataTableExpenses.SelectedRows.Count == 1) {
                tbName.Text = dataTableExpenses.SelectedRows[0].Cells[1].Value.ToString();
                tbSum.Text = dataTableExpenses.SelectedRows[0].Cells[2].Value.ToString();
            }
        }

        //Удалить
        private void bttnDelete_Click(object sender, EventArgs e)
        {
            if (dataTableIncome.SelectedRows.Count == 1) {
                MySqlCommand cDel = new MySqlCommand("DELETE FROM доход WHERE `" + dataTableIncome.Columns[0].HeaderText + "` = '" + dataTableIncome.SelectedRows[0].Cells[0].Value.ToString() + "'", connection);
                cDel.ExecuteNonQuery();
                bttnReload_Click(sender, e);
            }
            else if (dataTableOExpenses.SelectedRows.Count == 1) {
                MySqlCommand cDel = new MySqlCommand("DELETE FROM траты WHERE `" + dataTableOExpenses.Columns[0].HeaderText + "` = '" + dataTableOExpenses.SelectedRows[0].Cells[0].Value.ToString() + "'", connection);
                cDel.ExecuteNonQuery();
                bttnReload_Click(sender, e);
            }
            else if (dataTableExpenses.SelectedRows.Count == 1) {
                MySqlCommand cDel = new MySqlCommand("DELETE FROM траты WHERE `" + dataTableExpenses.Columns[0].HeaderText + "` = '" + dataTableExpenses.SelectedRows[0].Cells[0].Value.ToString() + "'", connection);
                cDel.ExecuteNonQuery();
                bttnReload_Click(sender, e);
            }
        }

        /*
         *  События при выборе radioButton
         */
        private void radioBttnIncome_CheckedChanged(object sender, EventArgs e)
        {
            gBox.Width = 200;
            gBox.Height = 150;
            gBox.Location = new Point(15, 9);

            panelYellow.Width = 580;
            panelYellow.Height = 180;

            labelAdd.Text = "Добавить";
            labelAdd.Left = ( gBoxAdd.Width - labelAdd.Width ) / 2;

            labelDate.Visible = false;
            dateTimeP.Visible = false;

            bttnRollUp.Visible = false;
        }

        private void bttnOExpenses_CheckedChanged(object sender, EventArgs e)
        {
            gBox.Width = 200;
            gBox.Height = 150;
            gBox.Location = new Point(15, 9);

            panelYellow.Width = 580;
            panelYellow.Height = 180;

            labelAdd.Text = "Добавить";
            labelAdd.Left = ( gBoxAdd.Width - labelAdd.Width ) / 2;

            labelDate.Visible = false;
            dateTimeP.Visible = false;

            bttnRollUp.Visible = false;
        }

        private void bttnExpenses_CheckedChanged(object sender, EventArgs e)
        {
            gBox.Width = 200;
            gBox.Height = 150;
            gBox.Location = new Point(15, 9);

            panelYellow.Width = 580;
            panelYellow.Height = 180;

            labelAdd.Text = "Добавить";
            labelAdd.Left = ( gBoxAdd.Width - labelAdd.Width ) / 2;

            labelDate.Visible = true;
            dateTimeP.Visible = true;

            bttnRollUp.Visible = false;
        }

        /*
         * Отменить внесение данных
         */
        private void bttnCancel_Click(object sender, EventArgs e)
        {
            gBox.Location = new Point(15, 50);

            panelYellow.Width = 225;
            panelYellow.Height = 180;

            bttnRollUp.Visible = true;
            if (labelAdd.Text == "Изменить") {
                panelYellow.Width = 185;
                panelYellow.Height = 55;
            }

            tbName.Text = default;
            tbSum.Text = default;

            radioBttnIncome = default;
            radioBttnOExpenses.Checked = default;
            radioBttnExpenses.Checked = default;
        }

        /*
         * Принять внесение данных в БД
         */
        private void bttnRollUp_Click(object sender, EventArgs e)
        {
            panelYellow.Width = 185;
            panelYellow.Height = 55;
        }

        /*
         * Принять внесение данных в БД
         */
        private void bttnConfirm_Click(object sender, EventArgs e)
        {
            if (labelAdd.Text == "Добавить") {
                if (radioBttnIncome.Checked == true) {
                    Income.ConditionIncome = "Добавить";
                    Income.NameIncome = tbName.Text;
                    Income.SumIncome = tbSum.Text;
                    Income.SQLRequestIncome();

                    panelYellow.Width = 185;
                    panelYellow.Height = 55;
                    gBox.Location = new Point(15, 50);

                    bttnReload_Click(sender, e);
                }
                else if (radioBttnOExpenses.Checked == true) {
                    OExpenses.ConditionOExpenses = "Добавить";
                    OExpenses.NameOExpenses = tbName.Text;
                    OExpenses.SumOExpenses = tbSum.Text;
                    OExpenses.SQLRequestOExpenses();

                    panelYellow.Width = 185;
                    panelYellow.Height = 55;
                    gBox.Location = new Point(15, 50);

                    bttnReload_Click(sender, e);
                }
                else if (radioBttnExpenses.Checked == true) {
                    Expenses.ConditionExpenses = "Добавить";
                    Expenses.NameExpenses = tbName.Text;
                    Expenses.SumExpenses = tbSum.Text;
                    Expenses.DateExpenses = dateTimeP.Text;
                    Expenses.SQLRequestExpenses();

                    panelYellow.Width = 185;
                    panelYellow.Height = 55;
                    gBox.Location = new Point(15, 50);

                    bttnReload_Click(sender, e);
                }
            }
            else if (labelAdd.Text == "Изменить") {
                if (dataTableIncome.SelectedRows.Count == 1) {
                    Income.IDIncome = dataTableIncome.SelectedRows[0].Cells[0].Value.ToString();
                    Income.NameIncome = tbName.Text;
                    Income.SumIncome = tbSum.Text;
                    Income.SQLRequestIncome();

                    panelYellow.Width = 185;
                    panelYellow.Height = 55;
                    gBox.Location = new Point(15, 50);

                    bttnReload_Click(sender, e);
                }
                else if (dataTableOExpenses.SelectedRows.Count == 1) {
                    OExpenses.IDOExpenses = dataTableOExpenses.SelectedRows[0].Cells[0].Value.ToString();
                    OExpenses.NameOExpenses = tbName.Text;
                    OExpenses.SumOExpenses = tbSum.Text;
                    OExpenses.SQLRequestOExpenses();

                    panelYellow.Width = 185;
                    panelYellow.Height = 55;
                    gBox.Location = new Point(15, 50);

                    bttnReload_Click(sender, e);
                }
                else if (dataTableExpenses.SelectedRows.Count == 1) {
                    Expenses.IDExpenses = dataTableExpenses.SelectedRows[0].Cells[0].Value.ToString();
                    Expenses.NameExpenses = tbName.Text;
                    Expenses.SumExpenses = tbSum.Text;
                    Expenses.DateExpenses = dateTimeP.Value.ToString("yyyy-MM-dd");
                    Expenses.SQLRequestExpenses();

                    panelYellow.Width = 185;
                    panelYellow.Height = 55;
                    gBox.Location = new Point(15, 50);

                    bttnReload_Click(sender, e);
                }
            }
        }

        /*
         * Выделение строк в таблице
         */
        private void dataTableIncome_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                dataTableIncome.Rows[e.RowIndex].Selected = true;
                dataTableOExpenses.Rows[e.RowIndex].Selected = false;
                dataTableExpenses.Rows[e.RowIndex].Selected = false;
            }
            catch { }
        }

        private void dataTableOExpenses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                dataTableIncome.Rows[e.RowIndex].Selected = false;
                dataTableOExpenses.Rows[e.RowIndex].Selected = true;
                dataTableExpenses.Rows[e.RowIndex].Selected = false;
            }
            catch { }
        }

        private void dataTableExpenses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                dataTableIncome.Rows[e.RowIndex].Selected = false;
                dataTableOExpenses.Rows[e.RowIndex].Selected = false;
                dataTableExpenses.Rows[e.RowIndex].Selected = true;
            }
            catch { }
        }
    }
}
