using DesignPattern.Models;
using DesignPattern.RepositoryPattern;
using DesignPattern.StrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._04_RepositoryPattern
{
    class CallRepository
    {
        static void Main(string[] args)
        {
            using (var context = new DesignPatternsContext())
            {
                var beerRepository = new Repository<Beer>(context);
                var beer = new Beer() { Name = "Fuller", Style = "Strong Ale" };
                beerRepository.Add(beer);
                beerRepository.Save();

                foreach (var b in beerRepository.Get())
                {
                    Console.WriteLine($"{b.BeerId} {b.Name}");
                }
            }
        }
    }
}