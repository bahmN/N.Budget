﻿using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Tinkoff_Бюджет
{
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void bttnConfirm_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server = 127.0.0.1; port = 3306; user = root; password = Vfhnvfhn23@; database = tinkoffbudget; sslmode = none");
            connection.Open();

            string password = HashingPsw.HashPassword(tbPassword.Text);
            MySqlCommand cAdd = new MySqlCommand("INSERT INTO пользователи(Логин, Пароль) VALUES ('" + tbName.Text + "', '" + password + "')", connection);
            cAdd.ExecuteNonQuery();
            connection.Close();
        }

        private void bttnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}