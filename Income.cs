/*
 * Данные запрос служит для добавления/редактирования данных в "Доходах"
 */
using MySql.Data.MySqlClient;

namespace Tinkoff_Бюджет
{
    class Income
    {
        static public string NameIncome { get; set; }
        static public string SumIncome { get; set; }
        public static void SQLRequestIncome()
        {
            MySqlCommand cAdd = new MySqlCommand("INSERT INTO доход(Наименование, Сумма) VALUES ('"+NameIncome+"', '"+SumIncome+ "')",
                frmMainMenu.connection);
            cAdd.ExecuteNonQuery();
        }
    }
}
