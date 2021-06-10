using System;
using System.IO;
using System.Globalization;

namespace P8_DiaryEntry
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            CultureInfo culture = new CultureInfo("es-MX");
            string todayAsStr = today.ToString(culture);
            string[] fechaHora = todayAsStr.Split(" ");
            string fechaDeHoy = fechaHora[0];
            string fechaFinal = fechaDeHoy.Replace("/", "-");

            try
            {
                Console.WriteLine("¡Bienvenido a tu diario! Porfavor, introduce la entrada del día de hoy:");
                string entrada = Console.ReadLine();

                using (StreamWriter sw = new StreamWriter(fechaFinal))
                {
                    sw.WriteLine(entrada);
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Error, por favor introduce carácteres válidos");
            }
            finally
            {
                Console.WriteLine("");
            }
        }
    }
}
