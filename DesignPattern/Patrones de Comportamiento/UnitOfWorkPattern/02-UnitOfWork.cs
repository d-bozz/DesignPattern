using DesignPattern.Models;
using DesignPattern.RepositoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.UnitOfWorkPattern
{
    /**
     * Unit of Work me permite agrupar mis repository en una clase
     * **/

    // La clase hereda de la interfaz
    public class UnitOfWork : IUnitOfWork
    {
        // Properties
        private DesignPatternsContext _context;
        public IRepository<Beer> _beers;
        public IRepository<Brand> _brands;

        // Constructor
        public UnitOfWork(DesignPatternsContext context)
        {
            _context = context;
        }

        // Metodos de la interfaz
        public IRepository<Beer> Beers {
            get
            {
                return _beers == null ?
                    _beers = new Repository<Beer>(_context) :
                    _beers;
            }
        }

        public IRepository<Brand> Brands
        {
            get
            {
                return _brands == null ?
                    _brands = new Repository<Brand>(_context) :
                    _brands;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
