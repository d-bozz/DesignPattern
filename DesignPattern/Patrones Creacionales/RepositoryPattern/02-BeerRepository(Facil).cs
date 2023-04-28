using DesignPattern.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.RepositoryPattern
{

    /**
 * 
 * Esta es una forma de hacerlo, donde se especifica la clase para cada entidad
 * 
 * **/


    // Implementamos la interfaz generando los metodos
    class BeerRepository : IBeerRepository
    {
        // Defino un contexto de Entity Framework
        private DesignPatternsContext _context;

        // Le paso el contexto en el constructor
        public BeerRepository(DesignPatternsContext context)
        {
            _context = context;
        }

        // Implemento los metodos de la interfaz
        public void Add(Beer data) => _context.Beers.Add(data);

        public void Delete(int id)
        {
            var beer = _context.Beers.Find(id);
            _context.Beers.Remove(beer);
        }

        public IEnumerable<Beer> Get() => _context.Beers.ToList();

        public Beer Get(int id) => _context.Beers.Find(id);

        public void Update(Beer data) =>
            _context.Entry(data).State = EntityState.Modified;

        public void Save() =>  _context.SaveChanges();
        
    }
}
