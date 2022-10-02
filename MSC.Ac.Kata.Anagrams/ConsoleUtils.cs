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
        public static void FileImport()
        {
            System.IO.StreamReader streamReader;

            try
            {
                streamReader = System.IO.File.OpenText(@"..\..\..\InputFile\wordlist.txt");

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
                return;
            }

            // DOMANDA: la pre elaborazione di una stringa
            // andrebbe fatta nel metodo che la importa
            // oppure seguendo il "Single Responsibility
            // Principle" deve essere contenuta in un metodo
            // a parte? Vedi dopo.

            string singleLine;

            while((singleLine = streamReader.ReadLine()) != null)
            {
                string rawString = singleLine;

                // Pulizia stringa andrebbe separata
                rawString = rawString.Replace("'", "");
                rawString = rawString.ToLower();
                // TODO: sostituire accenti


                
            }

        }
    }
}
