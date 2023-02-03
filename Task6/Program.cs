namespace Task6;

/*З масиву завд.5 вибрати 3 числа, починаючи з третього (40).*/

class Program
{
    static void Main(string[] args)
    {
        int[] num = { 14, 25, 40, 18, 12, 35 };
        var take = num.Skip(2).Take(3);
        foreach(var i in take)
        {
            Console.WriteLine(i);
        }
    }
}

