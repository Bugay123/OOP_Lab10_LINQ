namespace Task4;

/*Створити у коді колекцію List<T> з 6 різних доменних імен
сайтів. Відібрати сайти “.com” та “.ua”.*/

class Program
{
    static void Main(string[] args)
    {
        List<string> sites = new List<string>();
        sites.Add("google.com");
        sites.Add("google.ua");
        sites.Add("google.eu");
        sites.Add("google.us");
        sites.Add("google1.com");
        sites.Add("google1.ua");

        var domain = from i in sites
                     where i.EndsWith(".com", StringComparison.Ordinal) || i.EndsWith(".ua", StringComparison.Ordinal)
                     select i;
        foreach (var a in domain)
        {
            Console.WriteLine(a);
        }
        Console.WriteLine();    
        //запит у формі лямбда виразу і методів розширення
        var netAddrs1 = sites.Where(addr => addr.EndsWith(".com", StringComparison.Ordinal)|| addr.EndsWith(".ua", StringComparison.Ordinal));
        foreach (var str in netAddrs1) Console.WriteLine(str);

    }
}

