using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using System.Globalization; дабы работал NumberFormatInfo

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "1.9";
            /*
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = "."
            };

            * -> Метод изменения разделителя дробного числа
            */ 
            double a = Convert.ToDouble(str); //  numberFormatInfo - надо добавить для работы класса выше

            Console.WriteLine(a + 12);
        }
    }
}
