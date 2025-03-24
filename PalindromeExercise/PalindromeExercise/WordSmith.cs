using System.Linq;


namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
           
            return word.ToLower().SequenceEqual(word.ToLower().Reverse());
        }
    }
}
