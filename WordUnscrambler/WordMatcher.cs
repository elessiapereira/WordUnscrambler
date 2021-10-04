using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordUnscrambler
{
    class WordMatcher
    {
        public List<MatchedWord> Match(string[] scrambledWords, string[] wordList)
        {
            List<MatchedWord> matchedWords = new List<MatchedWord>();

            foreach (var scrambledWord in scrambledWords)
            {
                foreach (var word in wordList)
                {
                    //scrambledWord already matches word
                    if (scrambledWord.Equals(word, StringComparison.OrdinalIgnoreCase)) {
                        matchedWords.Add(BuildMatchedWord(scrambledWord, word));
                    }
                    else //Change one being completed
                    {
                        var scrambledWordArray = scrambledWord.ToCharArray();
                            Array.Sort(scrambledWordArray);
                                var sortScrambledWord = new string(scrambledWordArray);

                        var wordArray = word.ToCharArray();
                            Array.Sort(wordArray);
                                var sortWord = new string(wordArray);

                        if (sortScrambledWord.Equals(sortWord, StringComparison.OrdinalIgnoreCase))
                        {
                            matchedWords.Add(BuildMatchedWord(scrambledWord, word));
                        }
                    }
                }
                return matchedWords;
            }

            MatchedWord BuildMatchedWord(string scrambledWord, string word)
            {
                MatchedWord matchedWord = new MatchedWord
                {
                    ScrambledWord = scrambledWord,
                    Word = word
                };

                return matchedWord;
            }

            return matchedWords;
        } 
    }

}
