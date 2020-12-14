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
         * Param move form
         */
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);
        //Func. move form
        private void panelUp_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }



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
        }

        private void bttnReload_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter daIncome = new MySqlDataAdapter("SELECT * FROM доход", connection);
            DataTable dtIncome = new DataTable();
            daIncome.Fill(dtIncome);
            dataTableIncome.DataSource = dtIncome;
            dataTableIncome.RowHeadersVisible = false; // Hide the display of the left column
            dataTableIncome.AllowUserToAddRows = false; // Hide the display of the bottom column
            dataTableIncome.Columns[0].Visible = false;

            MySqlDataAdapter daOExpenses = new MySqlDataAdapter("SELECT * FROM траты WHERE `Вид трат`= 'Обязательные'", connection);
            DataTable dtOExpenses = new DataTable();
            daOExpenses.Fill(dtOExpenses);
            dataTableOExpenses.DataSource = dtOExpenses;
            dataTableOExpenses.RowHeadersVisible = false; // Hide the display of the left column
            dataTableOExpenses.AllowUserToAddRows = false; // Hide the display of the bottom column
            dataTableOExpenses.Columns[0].Visible = false;
            dataTableOExpenses.Columns[3].Visible = false;
            dataTableOExpenses.Columns[4].Visible = false;

            MySqlDataAdapter daIExpenses = new MySqlDataAdapter("SELECT * FROM траты WHERE `Вид трат`= 'Необязательные'", connection);
            DataTable dtExpenses = new DataTable();
            daIExpenses.Fill(dtExpenses);
            dataTableExpenses.DataSource = dtExpenses;
            dataTableExpenses.RowHeadersVisible = false; // Hide the display of the left column
            dataTableExpenses.AllowUserToAddRows = false; // Hide the display of the bottom column
            dataTableExpenses.Columns[0].Visible = false;
            dataTableOExpenses.Columns[3].Visible = false;
        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            panelYellow.Width = 225;
            panelYellow.Height = 165;            
        }

        /*
         *  Choose radioButton
         */
        private void radioBttnIncome_CheckedChanged(object sender, EventArgs e)
        {
            gBox.Width = 655;
            gBox.Height = 150;
            gBox.Text = "Добавить доход";
            gBox.Location = new Point(15, 9);

            panelYellow.Width = 675;
            panelYellow.Height = 165;
        }

        private void bttnOExpenses_CheckedChanged(object sender, EventArgs e)
        {
            gBox.Width = 655;
            gBox.Height = 150;
            gBox.Text = "Добавить обязательные расходы";
            gBox.Location = new Point(15, 9);

            panelYellow.Width = 675;
            panelYellow.Height = 165;
        }

        private void bttnExpenses_CheckedChanged(object sender, EventArgs e)
        {
            gBox.Width = 655;
            gBox.Height = 150;
            gBox.Text = "Добавить расходы";
            gBox.Location = new Point(15, 9);

            panelYellow.Width = 675;
            panelYellow.Height = 165;
        }
    }
}
