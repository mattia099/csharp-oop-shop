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
        private int iva;

      
        public Prodotto( string nome, string descrizione, float prezzo, int iva )
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
        public int Iva { get => iva; set => iva = value; }

        public string RandomCode()
        {
            Random rnd = new Random();
            string codice = rnd.Next(99999999).ToString();
            while(codice.Length != 9)
            {
                codice = "0"+codice; 
            }
            return codice;
        }

        public void stampa()
        {
            Console.WriteLine($"Codice: {this.codice}");
            Console.WriteLine($"Nome: {this.nome}");
            Console.WriteLine($"Descrizione: {this.descrizione}");
            Console.WriteLine($"Prezzo: {this.prezzo}\u20AC");
            Console.WriteLine($"IVA: {this.iva}");
            Console.WriteLine($"Prezzo con IVA applicata: {this.prezzoIva()}\u20AC");
        }
        public float prezzoIva()
        {
            float prezzoIva = (this.prezzo/100 * this.Iva)+this.prezzo;

            return prezzoIva;
        }
    }
}
