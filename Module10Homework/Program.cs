using System.Runtime.CompilerServices;

namespace Module10Homework
{
    public class Program
    {
        public static ILogger Logger {get;set;}

        static void Main(string[] args)
        {
            int firstnumber;
            int secondnumber;

            Logger = new Logger();

            Console.WriteLine("Введите первое число");
            firstnumber = GetValue();
            Console.WriteLine("Введите второе число");
            secondnumber = GetValue();

            var calculator = new Calculator(Logger);
            int result = calculator.Sum(firstnumber, secondnumber);
            Console.WriteLine("="+result);

        }

        public static int GetValue()
        {
            int number;
            while(true)
            {
                try
                {
                    number = int.Parse(Console.ReadLine());
                    break;
                }
                catch { Console.WriteLine("Не получается преобразовать в число"); }
            }
            return number;
        }
    }

    
}