using Tyuiu.MerzhinskiyOO.Sprint3.Task3.V4.Lib;

namespace Tyuiu.MerzhinskiyOO.Sprint3.Task3.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            DataService ds = new DataService();
            string str = "plkjjdw cvjkl";
            char letter = 'j';
         
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach удалить из строки все буквы j в строке           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($" Искомая строка: {str}");
            Console.WriteLine($" Искомая буква, которую нужно удалить: {letter}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($" Строка в итоге: {ds.DeleteCharInString(str, letter)}");
            Console.ReadKey();
        }
    }
}
