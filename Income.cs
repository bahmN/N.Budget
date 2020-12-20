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
        static public string UserID { get; set; }
        public static void SQLRequestIncome()
        {
            if (ConditionIncome == "Добавить") {
                MySqlCommand cAdd = new MySqlCommand("INSERT INTO доход(Наименование, Сумма, `ID Пользователя`) VALUES ('" + NameIncome + "', '" + SumIncome + "', '" + UserID + "')", frmStart.connection);
                cAdd.ExecuteNonQuery();
            }
            else {
                MySqlCommand cEdit = new MySqlCommand("UPDATE доход SET Наименование= '" + NameIncome + "', Сумма= '" + SumIncome + "' " +
                    "WHERE `ID дохода`= '" + IDIncome + "'", frmStart.connection);
                cEdit.ExecuteNonQuery();
            }
        }
    }
}
