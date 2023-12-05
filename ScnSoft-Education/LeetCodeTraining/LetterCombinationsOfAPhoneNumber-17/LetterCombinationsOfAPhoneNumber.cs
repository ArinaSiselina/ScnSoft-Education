namespace LeetCodeTraining.LetterCombinationsOfAPhoneNumber
{
    //https://leetcode.com/problems/letter-combinations-of-a-phone-number/
    public class LetterCombinationsOfAPhoneNumberSolution
    {
        public IList<string> LetterCombinations(string digits)
        {
            if (string.IsNullOrEmpty(digits))
                return new List<string>();

            Dictionary<char, string> digitToLetters = new Dictionary<char, string>()
        {
            {'2', "abc"},
            {'3', "def"},
            {'4', "ghi"},
            {'5', "jkl"},
            {'6', "mno"},
            {'7', "pqrs"},
            {'8', "tuv"},
            {'9', "wxyz"}
        };

            IList<string> result = new List<string>();
            Backtrack("", digits, digitToLetters, result);

            return result;
        }

        private void Backtrack(string combination, string nextDigits, Dictionary<char, string> digitToLetters, IList<string> result)
        {
            if (nextDigits.Length == 0)
            {
                result.Add(combination);
            }
            else
            {
                char digit = nextDigits[0];
                string letters = digitToLetters[digit];
                for (int i = 0; i < letters.Length; i++)
                {
                    string letter = letters[i].ToString();
                    Backtrack(combination + letter, nextDigits.Substring(1), digitToLetters, result);
                }
            }
        }
    }
}
