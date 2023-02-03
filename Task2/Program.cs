namespace Task2;

/*Реалізувати функцію пошуку слова у тексті. Слово вводиться з
консолі. Текст знаходиться в масиві.*/

class Program
{
    static void Main(string[] args)
    {
        string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
            "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
            "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. " +
            "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. " +
            "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
        Console.WriteLine("Введіть слово, яке потрібно знайти");   
        string find = Console.ReadLine();
        char[] separators = new char[] { ',', '.', ' ' };
        var found = from part in text.Split(separators, StringSplitOptions.RemoveEmptyEntries)
                    where part == find
                    select part;
        if (found.Count() >= 1)
            foreach (string i in found)
                Console.WriteLine(i);
        else
            Console.WriteLine("Слово не знайдено!");
 
        int found1 = text.Split(separators, StringSplitOptions.RemoveEmptyEntries)
            .Where(p => p == find).Count();
        Console.WriteLine($"Count = {found1}");

        //Або, якщо дотриматися умови завдання, то текст знаходиться в масиві.
        string[] array = { "dolor", "dolor", "ipsum", "cupidatat" };
        int countwords=array.Where(p=>p==find).Count(); //коротко і красиво
        Console.WriteLine($"Count From Array = {countwords}");
    }
}

