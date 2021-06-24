using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProgrammingLanguages
{
    class Program
    {
        static void Main()
        {
            List<Language> languages = File.ReadAllLines("./languages.tsv")
              .Skip(1)
              .Select(line => Language.FromTsv(line))
              .ToList();

            /*var stringed = languages.Select(l => $"{l.Year.ToString()}, {l.Name.ToString()}, {l.ChiefDeveloper.ToString()}");
            foreach(var s in stringed)
            {
              Console.WriteLine(s);
            }*/

            /*var cList = from l in languages
            where l.Name == "C#"
            select l;
            foreach(var c in cList)
            {
              Console.WriteLine(c.Prettify());
            }*/

            /*var cList = from l in languages
            where l.Name.Contains("Script")
            select l.Name;
            foreach(var c in cList)
            {
              Console.WriteLine(c);
            }*/

            //Console.WriteLine(languages.Count);

            var listYear = from l in languages
                           where l.Year >= 1995 && l.Year <= 2005
                           select l;

            foreach (var l in listYear)
            {
                Console.WriteLine($"{l.Name} was invented in {l.Year}");
            }

        }
    }
}