namespace IVT_Vyuka_Rekurze.Recursion;

public class Database
{
    //Key = key, Value = parentKey
    private Dictionary<string, string> entries;

    public void SeedDatabase()
    {
        entries = new()
        {
            { "Milan" ,  "root"   },
            { "Eva"    ,  "Milan"  },
            { "Martina",  "Milan"  },
            { "Martin" ,  "Martina"},
            { "Standa" ,  "Martina"},

            { "Lacko"  ,  "root"   },
            { "Alan"   ,  "Lacko"  },
            { "Karina"   ,  "Lacko"  }
        };
    }

    private void PrintBranch(string root, int depth)
    {
        //Vypíše root s depth mezerníky zleva
        Console.WriteLine($"{new string(' ', depth)}{root}");

        //Všichni, kdo mají 'parentKey' = root
        var children = entries.Where(x => x.Value == root);
        foreach (var child in children)
        {
            PrintBranch(child.Key, depth + 5);
        }
    }

    public void PrintDatabase()
    {
        //Všichni, kdo mají 'parentKey' = "root"
        var roots = entries.Where(x => x.Value == "root");
        foreach (var root in roots)
        {
            PrintBranch(root.Key, 0);
        }
    }
}