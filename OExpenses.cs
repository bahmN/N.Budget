/*
* Данные запрос служит для добавления/редактирования данных в "Обязательных тратах"
*/
using MySql.Data.MySqlClient;

namespace Tinkoff_Бюджет
{
    class OExpenses
    {

        static public string NameOExpenses { get; set; }
        static public string SumOExpenses { get; set; }
        public static void SQLRequestOExpenses()
        {
            MySqlCommand cAdd = new MySqlCommand("INSERT INTO траты(Наименование, Сумма, `Вид трат`) VALUES ('" + NameOExpenses + "', '" + SumOExpenses + "', 'Обязательные')",
                frmMainMenu.connection);
            cAdd.ExecuteNonQuery();
        }
    }
}
