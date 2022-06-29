using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    internal class Prodotto
    {
        private string codice;
        private string nome;
        private string descrizione;
        private float prezzo;
        private string iva;

      
        public Prodotto( string nome, string descrizione, float prezzo, string iva)
        {
            this.codice = this.RandomCode();
            this.Nome = nome;
            this.Descrizione = descrizione;
            this.Prezzo = prezzo;
            this.Iva = iva;
        }

        public string Codice { get => codice; }
        public string Nome { get => nome; set => nome = value; }
        public string Descrizione { get => descrizione; set => descrizione = value; }
        public float Prezzo { get => prezzo; set => prezzo = value; }
        public string Iva { get => iva; set => iva = value; }

        public string RandomCode()
        {
            Random rnd = new Random();
            
            return rnd.Next(99999999).ToString(); ;
        }

        public void stampa()
        {
            Console.WriteLine($"Codice :{this.codice}");
            Console.WriteLine($"Nome :{this.nome}");
            Console.WriteLine($"Descrizione :{this.descrizione}");
            Console.WriteLine($"Prezzo :{this.prezzo}");
            Console.WriteLine($"IVA :{this.iva}");
        }
    }
}
