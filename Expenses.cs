/*
* Данные запрос служит для добавления/редактирования данных в "Необязательных тратах"
*/
using MySql.Data.MySqlClient;

namespace Tinkoff_Бюджет
{
    class Expenses
    {
        static public string IDExpenses { get; set; }
        static public string ConditionExpenses { get; set; }
        static public string NameExpenses { get; set; }
        static public string SumExpenses { get; set; }
        static public string DateExpenses { get; set; }
        static public string UserID { get; set; }
        public static void SQLRequestExpenses()
        {
            if (ConditionExpenses == "Добавить") {
                MySqlCommand cAdd = new MySqlCommand("INSERT INTO траты(Наименование, Сумма, `Вид трат`, Дата, `ID Пользователя`) VALUES " +
                    "('" + NameExpenses + "', '" + SumExpenses + "', 'Повседневные', '" + DateExpenses + "', '" + UserID + "')", frmStart.connection);
                cAdd.ExecuteNonQuery();
            }
            else {
                MySqlCommand cEdit = new MySqlCommand("UPDATE траты SET Наименование= '" + NameExpenses + "', Сумма= '" + SumExpenses + "', " +
                    "Дата= '" + DateExpenses + "' WHERE `ID трат`= '" + IDExpenses + "'", frmStart.connection);
                cEdit.ExecuteNonQuery();
            }
        }
    }
}
