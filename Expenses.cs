/*
* Данные запрос служит для добавления/редактирования данных в "Необязательных тратах"
*/
using MySql.Data.MySqlClient;

namespace Tinkoff_Бюджет
{
    class Expenses
    {

        static public string NameExpenses { get; set; }
        static public string SumExpenses { get; set; }
        static public string DateExpenses { get; set; }
        public static void SQLRequestExpenses()
        {
            MySqlCommand cAdd = new MySqlCommand("INSERT INTO траты(Наименование, Сумма, `Вид трат`, Дата) VALUES " +
                "('" + NameExpenses + "', '" + SumExpenses + "₽', 'Необязательные', '" + DateExpenses + "')", frmMainMenu.connection);
            cAdd.ExecuteNonQuery();
        }
    }
}
