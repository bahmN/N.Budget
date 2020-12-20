using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Tinkoff_Бюджет
{
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }
        static public MySqlConnection connection;

        private void bttnConfirm_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection("server = 127.0.0.1; port = 3306; user = root; password = Vfhnvfhn23@; database = tinkoffbudget; sslmode = none");
            connection.Open();

            string Password = HashingPsw.HashPassword(tbPassword.Text);

            MySqlCommand cSelect = new MySqlCommand("SELECT Логин, Пароль FROM пользователи WHERE Логин= '" + tbLogin.Text + "' AND Пароль= '" + Password + "'", connection);
            MySqlDataAdapter daSelect = new MySqlDataAdapter(cSelect);
            DataTable dtSelect = new DataTable();
            daSelect.Fill(dtSelect);
            if (dtSelect.Rows.Count > 0) {
                //Active user
                MySqlCommand cUserID = new MySqlCommand("SELECT `ID пользователя` FROM пользователи WHERE Логин = '" + tbLogin.Text + "'", connection);
                object userIDObj = cUserID.ExecuteScalar();
                string userID = userIDObj.ToString();

                frmMainMenu FMA = new frmMainMenu(userID);
                FMA.ShowDialog();
            }
            else {
                MessageBox.Show("Пожалуйста, проверьте правильность написания логина и пароля.");
                connection.Close();
            }
        }

        private void bttnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        #region Кнопка регистрации
        /*
         * Смена цвета кнопки регистрации
         */
        private void bttnRegistration_MouseEnter(object sender, EventArgs e)
        {
            
            bttnRegistration.BackColor = ColorTranslator.FromHtml("#333333");
            bttnRegistration.ForeColor = ColorTranslator.FromHtml("#f5f5f6");
        }
        private void bttnRegistration_MouseLeave(object sender, EventArgs e)
        {
            bttnRegistration.BackColor = default;
            bttnRegistration.ForeColor = default;
        }
               
        private void bttnRegistration_Click(object sender, EventArgs e)
        {
            frmRegistration fR = new frmRegistration();
            fR.Show();
        }
        #endregion
    }
}
