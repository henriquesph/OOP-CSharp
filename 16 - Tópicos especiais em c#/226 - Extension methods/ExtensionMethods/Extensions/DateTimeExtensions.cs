using System.Globalization;

namespace System; // colocar a classe no mesto tipo que ela extende

static class DateTimeExtensions
{
    // Extension method - criou uma funcionalidade que não existia
    public static string ElapsedTime(this DateTime thisObj) // Extensão do DateTime - parâmetro é uma referência ao próprio objeto
        // não precisa ser chamado na hora da instanciação
    {
        TimeSpan duration = DateTime.Now.Subtract(thisObj);

        if(duration.TotalHours < 24.0)
        {
            return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";
        }
        else
        {
            return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days";
        }
    }
}