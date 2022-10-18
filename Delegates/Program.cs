using System;
using System.Threading;
using oops;

class program
{
    //create a new delegate
    //Viz. DECLARATION OF delegate

    public delegate void BlackPink(string requirement);

    static void Main()
    {
        Thread t1 = new Thread(() =>
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"Hand movement animation : y-co-ordinate = {i}");
            }
        });
        t1.Name = "Hand animation";
        Thread t2 = new Thread(() =>
        {
            for (int i = 100; i > 0; i--)
            {
                Console.WriteLine($"Ball movement animation : y-co-ordinate = {i}");
            }
        });
        t1.Name = "Ball animation";
        t1.Start();
        t2.Start();

    }

    private static void LinqLamda2()
    {
        //Collection of Recatangles
        List<Rectangle> rectangles = new List<Rectangle>();
        rectangles.Add(new Rectangle(10, 5));
        rectangles.Add(new Rectangle(10, 3));
        rectangles.Add(new Rectangle(20, 7));
        rectangles.Add(new Rectangle(25, 5));

        //Query: Get all rectangles whose length = 10
        rectangles
            .Where((r) => { return r.Length == 10; })
            .ToList()
            .ForEach((r) =>
            {
                Console.WriteLine($"Length: {r.Length} | Breadth : {r.Breadth}");
            });
        //Using LINQ  ~ SQL in .net
        var searchedRectangles = from r in rectangles
                                 where r.Length == 10
                                 select r;
        //Display
        searchedRectangles
            .ToList()
            .ForEach((r) =>
            {
                Console.WriteLine($"Output from LINQ: Rectangle Length x Breadth :: {r.Length} x {r.Breadth}");
            });

        //Lab 15
        //Write Lamba & Linq query for
        //Query: Get all recatngles whose breadth = 3
        rectangles
           .Where((r) => { return r.Breadth == 3; })
           .ToList()
           .ForEach((r) =>
           {
               Console.WriteLine($"Length: {r.Length} | Breadth : {r.Breadth}");
           });
        //Using LINQ  ~ SQL in .net
        var searchedRectangles1 = from r in rectangles
                                  where r.Breadth == 3
                                  select r;
        //Display
        searchedRectangles1
            .ToList()
            .ForEach((r) =>
            {
                Console.WriteLine($"Output from LINQ: Rectangle Length x Breadth :: {r.Length} x {r.Breadth}");
            });

        //Query: Get all recatngles whose length = 10 and  breadth = 3
        rectangles
           .Where((r) => { return r.Length == 10 && r.Breadth == 5; })
           .ToList()
           .ForEach((r) =>
           {
               Console.WriteLine($"Length: {r.Length} | Breadth : {r.Breadth}");
           });
        //Using LINQ  ~ SQL in .net
        var searchedRectangles2 = from r in rectangles
                                  where r.Length == 10 && r.Breadth == 5
                                  select r;
        //Display
        searchedRectangles2
            .ToList()
            .ForEach((r) =>
            {
                Console.WriteLine($"Output from LINQ: Rectangle Length x Breadth :: {r.Length} x {r.Breadth}");
            });

        //Query: Get all rectangle whose area > 50
    }

    private static void SimpleLinq()
    {
        List<string> names = new List<string>();
        names.Add("Meena");
        names.Add("Teena");
        names.Add("Reena");
        names.Add("Reena chakravarthy");


        names.ForEach((str) =>
        {
            Console.WriteLine(str);
        });

        List<string> result = names.Where((str) =>
        {
            return str == "Reena";
        }).ToList();
        Console.WriteLine("Search for 'Reena' ");
        result.ForEach((str) =>
        {
            Console.WriteLine($"Found match for : {str}");
        });


        //LINQ => Lanaguage Integrated Query
        Console.WriteLine("----USING LINQ----");
        var queryOutput = (from str in names
                           where str.Contains("Reena") && str.Contains("chakravarthy")
                           select str)
                           .ToList();
        queryOutput.ForEach((str) =>
        {
            Console.WriteLine(str);
        });
    }
}
