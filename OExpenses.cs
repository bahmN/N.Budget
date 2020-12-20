/*
* Данные запрос служит для добавления/редактирования данных в "Обязательных тратах"
*/
using MySql.Data.MySqlClient;

namespace Tinkoff_Бюджет
{
    class OExpenses
    {
        static public string IDOExpenses { get; set; }
        static public string ConditionOExpenses { get; set; }
        static public string NameOExpenses { get; set; }
        static public string SumOExpenses { get; set; }
        static public string UserID { get; set; }

        public static void SQLRequestOExpenses()
        {
            if (ConditionOExpenses == "Добавить") {
                MySqlCommand cAdd = new MySqlCommand("INSERT INTO траты(Наименование, Сумма, `Вид трат`, `ID пользователя`) VALUES ('" + NameOExpenses + "', '" + SumOExpenses + "', " +
                    "'Обязательные', '" + UserID + "')", frmStart.connection);
                cAdd.ExecuteNonQuery();
            }
            else {
                MySqlCommand cEdit = new MySqlCommand("UPDATE траты SET Наименование= '" + NameOExpenses + "', Сумма= '" + SumOExpenses + "' " +
                    "WHERE `ID трат`= '" + IDOExpenses + "'", frmStart.connection);
                cEdit.ExecuteNonQuery();
            }
        }
    }
}
