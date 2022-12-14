using MSC.Ac.KataAnagrams.Core;
using MSC.Ac.KataAnagrams.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSC.Ac.KataAnagrams.Client
{
    public static class ConsoleUtils
    {
        // DOMANDA: corretto importare un file da ConsoleUtils?

        /// <summary>
        /// Imports the file containing the words
        /// </summary>
        public static List<Word> FileImport()
        {
            // Domanda: E' lecito aggiungengere la dipendenza ad una
            // classe del Core all'interno di ConsoleUtils?

            List<Word> wordList = new List<Word>();
            System.IO.StreamReader streamReader;


            try
            {

                streamReader = new StreamReader(@"..\..\..\InputFiles\wordlist.txt");

            }
            catch (Exception FileProblem)
            {
                // DOMANDA: la stampa di una eccezione scatenata
                // in fase di importazione, in quale classe
                // deve essere inserita?

                Console.WriteLine(FileProblem.Message);

                // Senza return potrei potenzialmente arrivare alla
                // successiva while, la cui condizione potrebbe
                // dare errore in caso di streamReader nullo.
                return wordList;
            }

            // DOMANDA: la pre elaborazione di una stringa
            // andrebbe fatta nel metodo che la importa
            // oppure seguendo il "Single Responsibility
            // Principle" deve essere contenuta in un metodo
            // a parte? Vedi dopo.

            string singleLine;

            while ((singleLine = streamReader.ReadLine()) != null)
            {
                string rawString = singleLine;

                // Pulizia stringa andrebbe separata?
                // TODO: aggiungere sostituzione accenti?

                rawString = rawString.Replace("'", "");
                rawString = rawString.ToLower();

                char[] rawCharArray = rawString.ToCharArray();
                var normalizedArray = rawString.Normalize(NormalizationForm.FormC).ToCharArray();
                rawString = new string(normalizedArray);


                Word word = new Word(rawString);
                wordList.Add(word);


            }

            return wordList;

        }

        internal static void PrintBiggerAnagramsSet(AnagramBL anagramBL)
        {

            List<AnagramSet> anagramSetsList = anagramBL.anagramsSetsList;

            int maxSize = 0;
            foreach (AnagramSet singleAnagramSet in anagramSetsList)
            {
                if (singleAnagramSet.WordList.Count > maxSize)
                {
                    maxSize = singleAnagramSet.WordList.Count;
                }
            }
            Console.WriteLine("#### Bigger set of anagrams ####");
            foreach (AnagramSet singleAnagramSet in anagramSetsList)
            {
                if (singleAnagramSet.WordList.Count == maxSize)
                {
                    foreach(Word word in singleAnagramSet.WordList)
                    {
                        Console.Write(word.ToString() + " ");
                    }
                }
            }


        }

        public static void PrintLongestAnagramsSet(AnagramBL anagramBL)
        {
            // Attenzione: in questo modo stampo solo un set!
            // TODO: correggere stampa di un solo set

            Console.WriteLine("##### Set with longest word ####");
            AnagramSet maxAnagramSet = anagramBL.anagramsSetsList[anagramBL.indexMaxLenght];
            foreach (Word word in maxAnagramSet.WordList)
            {
                Console.WriteLine(word + " ");
            }
        }

        /// <summary>
        /// Prints all the anagrams
        /// </summary>
        /// <param name="anagramBL">The business logic from which to print the anagrams</param>
        public static void PrintAnagrams(AnagramBL anagramBL)
        {
            Console.WriteLine("Sto stampando gli anagrammi.");
            foreach (AnagramSet singleSet in anagramBL.anagramsSetsList)
            {
                foreach (Word word in singleSet.WordList)
                {
                    System.Console.Write(word.ToString() + " ");
                }
                Console.WriteLine("");
            }
        }

    }
}
