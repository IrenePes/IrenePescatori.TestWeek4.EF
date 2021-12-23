using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4.EsercitazioneFinale.Core.Entities
{
    public class Spesa
    {
        public int SpesaId { get; set; }
        public DateTime Data { get; set; }
        public string Descrizione { get; set; }
        public string Utente { get; set; }
        public decimal Importo { get; set; }
        public Boolean Approvato { get; set; }

        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
