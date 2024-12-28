using Tyuiu.MerzhinskiyOO.Sprint3.Task6.V4.Lib;

namespace Tyuiu.MerzhinskiyOO.Sprint3.Task6.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            DataService ds = new DataService();
            int result = ds.GetSumTheDivisors(14, 20);
            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
