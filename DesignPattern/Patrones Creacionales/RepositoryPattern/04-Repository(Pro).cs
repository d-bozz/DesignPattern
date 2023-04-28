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
     * PATRON DE DISEÑO DE TIPO ESTRUCTURAL
     * 
     * El patron Repository provee una capa entre la aplicacion y la fuente de datos
     * sin importar si esta viene de entity framework, API, etc.
     * 
     * **/

    // Defino que mi clase Repository implemente la interfaz IRepository
    // Especifico que TEntity, el generic que mando es una clase
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        // Declaro el contexto
        private DesignPatternsContext _context;

        // Declaro el DbSet que ya contiene el tipo de objeto que esta definido en el contexto
        private DbSet<TEntity> _dbSet;

        // Le paso el contexto en el constructor y el Dbset
        public Repository(DesignPatternsContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        // Implemento los metodos de la interfaz
        public void Add(TEntity data) => _dbSet.Add(data);

        public void Delete(int id)
        {
            var dataToDelete = _dbSet.Find(id);
            _dbSet.Remove(dataToDelete);
        }

        public IEnumerable<TEntity> Get() => _dbSet.ToList();

        public TEntity Get(int id) => _dbSet.Find(id);

        public void Save() => _context.SaveChanges();

        public void Update(TEntity data)
        {
            _dbSet.Attach(data);
            _context.Entry(data).State = EntityState.Modified;
        }
    }
}
