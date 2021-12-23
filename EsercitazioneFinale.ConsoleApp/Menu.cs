using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week4.EsercitazioneFinale.Core.BusinessLayer;
using Week4.EsercitazioneFinale.Core.Interfaces;
using Week4.EsercitazioneFinaleEF.Repositories;

namespace EsercitazioneFinale.ConsoleApp
{
    public class Menu
    {
        private static readonly IBusinessLayer mainBL = new BusinessLayer(new EFCategorieRepository(), new EFSpeseRepository());

        static void Main()
        {
            bool uscita = false;
            do
            {
                Console.WriteLine($"============= Menu =============");
                Console.WriteLine();
                Console.WriteLine("[ 1 ] - Inserisci nuova spesa\n");
                Console.WriteLine("[ 2 ] - Approva una spesa esistente\n");
                Console.WriteLine("[ 3 ] - Elimina una spesa esistente\n");
                Console.WriteLine("[ Q ] - Esci\n");

                Console.Write("> ");
                string scelta = Console.ReadLine();
                Console.WriteLine();

                switch (scelta)
                {
                    case "1":
                        InserisciNuovaSpesa();
                        break;
                    case "2":
                        ApprovaSpesa();
                        break;
                    case "3":
                        RimuoviSpesa();
                        break;
                    case "Q":
                        uscita = true;
                        break;
                    default:
                        Console.WriteLine("Comando sconosciuto");
                        break;
                }

            } while (!uscita);
        }

        private static void RimuoviSpesa()
        {
            throw new NotImplementedException();
        }

        private static void ApprovaSpesa()
        {
            throw new NotImplementedException();
        }

        private static void InserisciNuovaSpesa()
        {
            Console.WriteLine("---- Inserire una nuova spesa ----");
            Console.Write("Data: ");
            DateTime data;
            while (!DateTime.TryParse(Console.ReadLine(), out data))
            {
                Console.WriteLine("Inserisci un formato corretto di data");
            }
            Console.Write("Descrizione: ");
            string descrizione = Console.ReadLine();
            Console.WriteLine("Categoria id: ");
            // ---------------- categoria
            List<int> categoriePossibili = mainBL.RecuperaIdCategorie();
            // ----------------
            Console.Write("Utente: ");
            string utente = Console.ReadLine();
            Console.Write("Importo: ");
            decimal importo;
            while (!decimal.TryParse(Console.ReadLine(), out importo))
            {
                Console.WriteLine("Inserisci un formato corretto di importo");
            }

        }
    }
}
