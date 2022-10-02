using MSC.Ac.KataAnagrams.Core.Entities;

namespace MSC.Ac.KataAnagrams.Core
{
    public class AnagramBL
    {
        public List<Word> wordList { get; set; }

        public AnagramBL(List<Word> inputList)
        {
            wordList = inputList;
        }

        public void FindAnagrams()
        {
            foreach (Word mainWord in wordList)
            {
                Console.Write("\nLooking for " + mainWord.ToString() + " anagrams:");
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

                        if (firstSortedString.Equals(secondSortedString))
                        {
                            
                                Console.Write($" {comparativeWord.ToString()}");
                                //Console.WriteLine("\n");

                            
                        }

                    }


                }

            }
        }
    }
}