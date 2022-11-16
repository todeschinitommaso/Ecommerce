using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    internal class carrello
    {

        private string _id;

        string[] prodotto = new string[100];

        private int counter;

        public carrello(string id)
        {
            Id = id;

        }

        public string Id
        {
            get { return _id; }
            set { _id = value; }

        }
        
        public void Aggiungi(prodotto p)
        {
            p.Id = prodotto[counter];
            counter++;

        }

        public void Rimuovi(prodotto p)
        {
            p.Id = prodotto[counter];
            counter--;

        }

        public int getProdotti()
        {
            return counter;

        }

        public void Svuota()
        {
            counter = 0;

        }

    }
}
