using DesignPattern.Models;
using DesignPattern.StrategyPattern;
using DesignPattern.UnitOfWorkPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._05_UnitOfWorkPattern
{
    class CallUnitOfWork
    {
        static void Main(string[] args)
        {
            using (var context = new DesignPatternsContext())
            {
                var unitOfWork = new UnitOfWork(context);
                var beers = unitOfWork.Beers;
                var beer = new Beer()
                {
                    Name = "Fuller",
                    Style = "Porter"
                };

                beers.Add(beer);

                var brands = unitOfWork.Brands;
                var brand = new Brand()
                {
                    Name = "Fuller"
                };
                brands.Add(brand);

                unitOfWork.Save();
            }
        }
    }
}