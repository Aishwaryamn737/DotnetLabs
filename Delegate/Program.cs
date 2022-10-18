using System;

class program
{
    //create a new delegate
    //Viz. DECLARATION OF delegate
    public delegate void Calculate(int n1, int n2);
    public delegate void BlackPink(string requirement);

    static void Main()
    {
        List<string> names = new List<string>();
        names.Add("Alex");
        names.Add("Maria");
        names.Add("Reena");
        names.Add("Meena");
        names.Add("Reena chakravarthy");


        names.ForEach((str) => {
            Console.WriteLine(str);
        });

        List<string> result = names.Where((str) =>
        {
            //return str.StartsWith("Re") && str.EndsWith("na");
            return str.StartsWith("Re") || str.EndsWith("na");

        }).ToList();
        Console.WriteLine("Search for 'Re' ");
        result.ForEach((str) =>
        {
            Console.WriteLine($"Found match for : {str}");
        });

        //LINQ => Lanaguage Integrated Query
        Console.WriteLine("----USING LINQ----");
        var queryOutput = (from str in names
                           where str.Contains("Reena") || str.Contains("chakravarthy")
                           select str)
                           .ToList();
        queryOutput.ForEach((str) =>
        {
            Console.WriteLine(str);
        });
    }

    private static void delegateCalci()
    {
        Calculate Cal = new((n1, n2) => { Console.WriteLine($"The addition of n1 and n2 is {n1 + n2}"); });
        Cal += (n1, n2) => { Console.WriteLine($"The addition of n1 and n2 is {n1 - n2}"); };
        Cal += (n1, n2) => { Console.WriteLine($"The addition of n1 and n2 is {n1 * n2}"); };
        Cal += (n1, n2) => { Console.WriteLine($"The addition of n1 and n2 is {n1 / n2}"); };
        Cal(10, 5);
    }

    private static void Division(int n1, int n2)
    {
        Console.WriteLine($"The division of n1 and n2 is {n1 / n2}");
    }
  
    private static void Multiply(int n1, int n2)
    {
        Console.WriteLine($"The division of n1 and n2 is {n1 * n2}");
    }
    private static void Subtract(int n1, int n2)
    {
        Console.WriteLine($"The division of n1 and n2 is {n1 - n2}");
    }
    private static void Add(int n1, int n2)
    {
        Console.WriteLine($"The division of n1 and n2 is {n1 + n2}");
    }

}

