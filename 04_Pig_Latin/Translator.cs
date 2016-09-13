using System;
using System.Linq;

namespace _04_Pig_Latin
{
    public class Translator
    {
        public Translator()
        {
        }

        internal string Translate(string input)
        {
            return Piglatin(ref input);
        }

        private static string Piglatin(ref string input)
        {
            const string vowels = "aeioAEIO";
            int index = 1;
            int length = input.Length;
            char first = input[0];
            if (vowels.Contains(first))
                return input + "ay";
            input = input.ToLower();
            for (; index < length; index++)
            {
                if (vowels.Contains(input[index]))
                {
                    break;
                }
            }
            string firstpart = "";
            string lastpart = input.Substring(0, index) + "ay";
            if (char.IsUpper(first))
                firstpart = char.ToUpper(input[index++]) + input.Substring(index, length - index);
            else
                firstpart = input.Substring(index, length - index);
            return firstpart + lastpart;
        }
    }
}