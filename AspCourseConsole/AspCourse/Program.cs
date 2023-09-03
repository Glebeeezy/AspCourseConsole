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

        void MyFunction(int repeats, string message)
        {
            for (int i = 0; i < repeats; i++)
            {
                Console.Write(message);
            }
            Console.WriteLine("");
        }
        Console.WriteLine("Второе задание");
        for (int i = 0; i < 2; i++)
        {
            Console.Write("Введите число повторений\n");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите слово");
            string word = Console.ReadLine();
            MyFunction(number, word);
        }
        // Third exercise
        void HighAndLow(string str)
        {
            int[] array = str.Trim().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine($"{array.Max()} {array.Min()}");
        }
        Console.WriteLine("Третье задание");
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("Введите набор чисел через пробел и узнайте большее и меньшее из них");
            HighAndLow(Console.ReadLine());
        }

        // Fourth exercise
        Console.WriteLine("Четвёртое задание");
        bool isIsogram(string str)
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
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("Введите слово что бы узнать является ли оно изограммой");
            Console.WriteLine(isIsogram(Console.ReadLine()));
        }



        // Fifth exercise
        Console.WriteLine("Пятое задание");
        void accum(string str)
        {
            char[] arrayHigh = str.ToUpper().ToCharArray();
            char[] arrayLow = str.ToLower().ToCharArray();

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
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("Введите слово");
            accum(Console.ReadLine());
        }
    }
}
