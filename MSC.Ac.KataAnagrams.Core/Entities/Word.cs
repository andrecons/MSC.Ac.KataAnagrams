using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSC.Ac.KataAnagrams.Core.Entities
{
    public class Word
    {
        /* Questa entità è chiaramente superflua perchè
         * è caratterizzata da una sola stringa.
         * Creata solo per esercitarmi con get/set/costruttori.
         */
        string WordString { get; set; }

        public Word(string wordString)
        {
            this.WordString = wordString;
        }
    }
}
