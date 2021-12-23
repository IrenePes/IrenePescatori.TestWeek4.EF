using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4.EsercitazioneFinale.Core.Entities
{
    public class Categoria
    { public int CategoriaId { get; set; }
        public string Nome { get; set; }
        public List<Spesa> Spese { get; set; } = new List<Spesa>();
    }
}
