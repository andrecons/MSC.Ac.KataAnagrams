using MSC.Ac.KataAnagrams.Client;
using MSC.Ac.KataAnagrams.Core;
using MSC.Ac.KataAnagrams.Core.Entities;

namespace MSC.Ac.Kata.Anagrams
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            /* Given a file containing one word per line, print out all the combinations
             * of words that are anagrams; each line in the output contains all the words
             * from the input that are anagrams of each other. For added programming pleasure,
             * find the longest words that are anagrams, and find the set of anagrams
             * containing the most words
             */

            // 0. Generare un menu
            // TODO: menu

            // 1. Importare il file .txt
            AnagramBL anagramBL = new AnagramBL(ConsoleUtils.FileImport());

            // 2. Ricercare gli anagrammi
            anagramBL.FindAnagrams();

            // 3. Stampare le parole che sono anagrammi
            ConsoleUtils.PrintAnagrams(anagramBL);

            // 4. Trovare le parole più lunghe che sono anagrammi

            // 5. Trovare il set più grande di anagrammi
        }
    }
}