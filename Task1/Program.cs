namespace Task1;

/*Створити масив з 25 додатніх чисел в діапазоні від 150 до 200
(дані зросту). Сформувати і виконати запит LINQ для вибору чисел
більше 170. Обчислити середнє значення вибірки.*/

class Program
{
    static void Main(string[] args)
    {
        int[] hight = new int[25];
        Random rnd = new Random();
        for (int i = 0; i < hight.Length; i++)
        {
            hight[i] = rnd.Next(150, 200);
        }
        var criteria = from n in hight
                       where n > 170
                       select n;

     
        double avg = criteria.Average();  //Є метод розширення для обчислення середнього
        Console.WriteLine($"Середнє = {avg}");

        //друга форма запиту. Джерело даних те  саме
        double avg1 = criteria.Where(p => p > 170).Average();
        Console.WriteLine($"Середнє = {avg1}");
    }
}

