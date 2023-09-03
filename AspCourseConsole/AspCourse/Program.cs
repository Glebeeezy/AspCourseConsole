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
            Console.WriteLine("");
        }

        Console.Write("Второе задание \nВведите число повторений\n"); 
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите слово");
        string word = Console.ReadLine();
        MyFunction(number, word);

        // Third exercise
        string first = "1 2 3 4 5";
        string second = "1 2 -3 4 5";
        string third = "1 9 3 4 -5";
        void HighAndLow (string str)
        {
            int[] array = str.Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine($"{array.Max()} {array.Min()}");
        }
        Console.WriteLine("Третье задание");
        HighAndLow(first);
        HighAndLow(second);
        HighAndLow(third);
        Console.WriteLine("Введите набор чисел через пробел и узнайте большее и меньшее из них");
        HighAndLow(Console.ReadLine());
        // Fourth exercise
        Console.WriteLine("Четвёртое задание");
        bool isIsogram (string str)
        {
            if (str == null)
            {
                return true;
            }
            else
            {               
                str = str.ToLower();
                int len = str.Length;

                char[] arr = str.ToCharArray();

                Array.Sort(arr);
                for (int i = 0; i < len - 1; i++)
                {
                    if (arr[i] == arr[i + 1])
                        return false;
                }
                return true;
            }
        }

        string firstIso = "Dermatoglyphics";
        string secondIso = "moose";
        string thirdIso = "aba";
        Console.Write($"{isIsogram(firstIso)}\n{isIsogram(secondIso)}\n{isIsogram(thirdIso)}\n");
        Console.WriteLine("Введите слово что бы узнать является ли оно изограммой");
        Console.WriteLine(isIsogram(Console.ReadLine()));


        // Fifth exercise
        Console.WriteLine("Пятое задание");
        void accum(string str)
        {
            char [] arrayHigh = str.ToUpper().ToCharArray();
            char [] arrayLow = str.ToLower().ToCharArray();

            for (int i = 0; i < arrayHigh.Length; i++)
            {
                if (i > 0 & i < arrayHigh.Length)
                {
                    Console.Write("-");
                }
                    Console.Write($"{arrayHigh[i]}");
                for (int x = 1; x <= i; x++)
                {
                    Console.Write(arrayLow[i]);
                }                           
            }
            Console.WriteLine();
        }
        string accum1 = "abcd";
        string accum2 = "RqaEzty";
        string accum3 = "cwAt";
        accum(accum1);
        accum(accum2);
        accum(accum3);
        Console.WriteLine("Введите слово");
        accum(Console.ReadLine());

    }
}
