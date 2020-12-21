/*
 * Выбор даты
 */
using System;

namespace Tinkoff_Бюджет
{
    class SqlStringDate
    {
        public string GetDate()
        {
            DateTime dtime = new DateTime();
            dtime = DateTime.Now;
            string mounth = dtime.ToString("MM");
            string year = dtime.ToString("yyyy");
            switch (mounth) {
                case "1":
                mounth = $"(Дата BETWEEN '{year}-01-01' AND '{year}-01-31')";
                break;
                case "2":
                mounth = $"(Дата BETWEEN '{year}-02-01' AND '{year}-02-29')";
                break;
                case "3":
                mounth = $"(Дата BETWEEN '{year}-03-01' AND '{year}-03-31')";
                break;
                case "4":
                mounth = $"(Дата BETWEEN '{year}-04-01' AND '{year}-04-30')";
                break;
                case "5":
                mounth = $"(Дата BETWEEN '{year}-05-01' AND '{year}-05-31')";
                break;
                case "6":
                mounth = $"(Дата BETWEEN '{year}-06-01' AND '{year}-06-30')";
                break;
                case "7":
                mounth = $"(Дата BETWEEN '{year}-07-01' AND '{year}-07-31')";
                break;
                case "8":
                mounth = $"(Дата BETWEEN '{year}-08-01' AND '{year}-08-31')";
                break;
                case "9":
                mounth = $"(Дата BETWEEN '{year}-09-01' AND '{year}-09-30')";
                break;
                case "10":
                mounth = $"(Дата BETWEEN '{year}-10-01' AND '{year}-10-31')";
                break;
                case "11":
                mounth = $"(Дата BETWEEN '{year}-11-01' AND '{year}-11-30')";
                break;
                case "12":
                mounth = $"(Дата BETWEEN '{year}-12-01' AND '{year}-12-31')";
                break;
            }
            return mounth;
        }
    }
}
