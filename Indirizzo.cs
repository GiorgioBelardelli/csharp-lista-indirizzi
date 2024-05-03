using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    public class Indirizzo
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Via { get; set; }
        public string Citta { get; set; }
        public string Provincia { get; set; }
        public int CAP { get; set; }



        public Indirizzo(string nome, string cognome, string via, string citta, string provincia, int cap)
        {
            this.Nome = nome;
            this.Cognome = cognome;
            this.Via = via;
            this.Citta = citta;
            this.Provincia = provincia;
            this.CAP = cap;

        }
        public override string ToString()
        {
            return $"{Nome}, {Cognome}, {Via}, {Citta}, {Provincia}, {CAP} ";
        }
    }
}
