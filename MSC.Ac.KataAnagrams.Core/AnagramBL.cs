using MSC.Ac.KataAnagrams.Core.Entities;

namespace MSC.Ac.KataAnagrams.Core
{
    public class AnagramBL
    {
        public List<Word> wordList { get; set; }
        public List<AnagramSet> anagramsSetsList { get; set; }

        public AnagramBL(List<Word> inputList)
        {
            wordList = inputList;
            anagramsSetsList = new List<AnagramSet>();
        }

        /// <summary>
        /// Find the words that are anagrams
        /// </summary>
        public void FindAnagrams()
        {
            foreach (Word mainWord in wordList)
            {
                AnagramSet singleAnagramSet = new AnagramSet();

                // Aggiungo la prima parola in esame
                // ad un nuovo set di anagrammi
                singleAnagramSet.WordList.Add(mainWord);

                char[] firstWordArray = mainWord.ToString().ToCharArray();

                foreach (Word comparativeWord in wordList)
                {
                    if (comparativeWord.ToString().Equals(mainWord.ToString()))
                    {
                        continue;

                    }

                    char[] secondWordArray = comparativeWord.ToString().ToCharArray();

                    if (firstWordArray.Length == secondWordArray.Length)
                    {
                        List<char> firstWordToList = firstWordArray.ToList();
                        List<char> secondWordToList = secondWordArray.ToList();

                        firstWordToList.Sort();
                        secondWordToList.Sort();

                        string firstSortedString = "";
                        string secondSortedString = "";

                        for (int i = 0; i < firstWordArray.Length; i++)
                        {
                            firstSortedString = firstSortedString + firstWordToList[i];
                            secondSortedString = secondSortedString + secondWordToList[i];
                        }

                        // Arrivo qui se e solo se le parole:
                        // - Sono diverse
                        // - Hanno la stessa lunghezza
                        // - I caretteri, ordinati, sono equivalenti
                        // * E quindi sono Anagrammi *
                        if (firstSortedString.Equals(secondSortedString))
                        {
                            //Console.Write($" {comparativeWord.ToString()}");
                            singleAnagramSet.WordList.Add(comparativeWord);

                        }
                    }
                }
                anagramsSetsList.Add(singleAnagramSet);
            }
        }
    }
}