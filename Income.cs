/*
 * Данные запрос служит для добавления/редактирования данных в "Доходах"
 */
using MySql.Data.MySqlClient;

namespace Tinkoff_Бюджет
{
    class Income
    {
        static public string IDIncome { get; set; }
        static public string ConditionIncome { get; set; }
        static public string NameIncome { get; set; }
        static public string SumIncome { get; set; }
        public static void SQLRequestIncome()
        {
            if (ConditionIncome == "Добавить") {
                MySqlCommand cAdd = new MySqlCommand("INSERT INTO доход(Наименование, Сумма) VALUES ('" + NameIncome + "', '" + SumIncome + "')",
                    frmMainMenu.connection);
                cAdd.ExecuteNonQuery();
            }
            else {
                MySqlCommand cEdit = new MySqlCommand("UPDATE доход SET Наименование= '"+NameIncome + "', Сумма= '"+SumIncome+"' " +
                    "WHERE `ID дохода`= '"+IDIncome+"'",frmMainMenu.connection);
                cEdit.ExecuteNonQuery();
            }
        }
    }
}
