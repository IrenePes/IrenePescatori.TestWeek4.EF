using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week4.EsercitazioneFinale.Core.Interfaces;

namespace Week4.EsercitazioneFinale.Core.BusinessLayer
{
    public class BusinessLayer : IBusinessLayer
    {

        private readonly ICategorieRepository categorieRepo;
        private readonly ISpeseRepository speseRepo;


        public BusinessLayer(ICategorieRepository categorie,
                             ISpeseRepository spese)
        {
            categorieRepo = categorie;
            speseRepo = spese;
        }

        public List<int> RecuperaIdCategorie()
        {
            List<int> idCategorie = categorieRepo.RecuperaIdCategorie();
            List<int> lista = null;
            return lista;
        }
    }
}
