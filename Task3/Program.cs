namespace Task3;

/*Створити клас Model з полями Name, LastName, Age, Height,
Weight. Створити колекцію з 10 об’єктів цього класу. Запитом
LINQ відібрати екземпляри до модельного агенства за
параметрами: Age<=25, 175<=Height>=180,Weight<=55. Результати
запиту впорядкувати за прізвищем.Обчислити середній вік
відібраних моделей.*/

class Model
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public int Height { get; set; }
    public double Weight { get; set; }
    public Model(string name, string lastName, int age, int height, double weight)
    {
        Name = name;
        LastName = lastName;
        Age = age;
        Height = height;
        Weight = weight;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Model[] models = new Model[]
        {
        new Model("Kate", "Heaven", 20, 178, 47),
        new Model("Ann","Cat",18, 180, 56),
        new Model("Nat","Rain",22, 170, 47),
        new Model("Julia","Ocean",23, 176, 50),
        new Model("Sharon","Kent",20, 179, 49),
        new Model("Grace","Hunt",18, 174, 55),
        new Model("Angely","Guns", 21, 175,54),
        new Model("Monika","Sofi", 21, 180, 48),
        new Model("Jessy","Harper",22, 177, 46),
        new Model("Jane","Jackson",24, 179, 45)
        };
        var modQuery = from e in models
                       where e.Age <= 25 && e.Height >= 175 && e.Height <= 180 && e.Weight <= 55
                       orderby e.LastName
                       select e;

        var avgAge = models.Average(n => n.Age);
        foreach (var a in modQuery)
        {
            Console.WriteLine(a.LastName);
        }
        Console.WriteLine($"Середній вік в виборці -  {avgAge}");
//Або
        var modQ2=models.Where(p=>p.Age<=25 && p.Height >=175 && p.Weight<=55)
            .OrderBy(p=>p.LastName);
        foreach (var a in modQ2)
        {
            Console.WriteLine(a.LastName);
        }

    }
}

