using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week4.EsercitazioneFinale.Core.Entities;

namespace Week4.EsercitazioneFinale.Core.Interfaces
{
    public interface ICategorieRepository : IRepository<Categoria>
    {
        List<int> RecuperaIdCategorie();
    }
}
