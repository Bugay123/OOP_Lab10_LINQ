namespace Task5;

/*Створити у коді масив чисел {14,25,40,18,12, 35}. Знайти
найменше число.*/

class Program
{
    static void Main(string[] args)
    {
        int[] num = { 14, 25, 40, 18, 12, 35 };
        var min1 = num.Min();   //достатньо так
        Console.WriteLine(min1);
    }
}

