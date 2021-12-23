using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week4.EsercitazioneFinale.Core.Interfaces;

namespace Week4.EsercitazioneFinaleEF.Repositories
{
    public class EFCategorieRepository : ICategorieRepository

    {
        private readonly Context _context;

        public EFCategorieRepository()
        {
            _context = new Context();
        }
        public List<int> RecuperaIdCategorie()
        {
            return _context.Categorie.Include(c => c.CategoriaId).ToList();
        }
    }
}
