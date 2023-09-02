using System.Linq;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;

namespace AspCourse
{
    }
    internal class Program
    {
    static void Main(string[] args)
    {

        // First exercise 

        Console.WriteLine("Первое задание \nНапишите слово");
        string myString = Console.ReadLine();
        myString = new string(myString.ToCharArray().Reverse().ToArray());
        Console.WriteLine(myString);

        // Second exercise

        void MyFunction (int repeats, string message)
        {
            for (int i = 0; i < repeats; i++)
            {
                Console.Write(message);
            }
        }

        Console.Write("Второе задание \nВведите число повторений"); 
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите слово");
        string word = Console.ReadLine();
        MyFunction(number, word);

        // Third exercise
        string first = "1 2 3 4 5";
        void HighAndLow (string str)
        {
            
        }
        HighAndLow(first);
    }
}
