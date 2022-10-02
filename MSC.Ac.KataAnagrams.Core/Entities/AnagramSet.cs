using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSC.Ac.KataAnagrams.Core.Entities
{
    public class AnagramSet
    {
        public List<Word> WordList { get; set; }

        public AnagramSet()
        {
            WordList = new List<Word>();
        }

    }
}
