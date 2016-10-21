using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
    public class StringManipulations
    {
        public static char FindFirstNonRepeatCharacter1(string s)
        {
            Dictionary<char, bool> searchedTable = new Dictionary<char, bool>();

            char[] chars = s.ToArray();
            char target = ' ';
            for (int i = 0; i < chars.Length; i++)
            {
                bool found = false;
                target = chars[i];

                if (searchedTable.ContainsKey(target))
                    continue;
                searchedTable.Add(target, true);

                for (int j = i+1; j < chars.Length; j++)
                {
                    if (chars[j] == target)
                    {
                        found = true;
                        //foundTable.Add(target, true);
                        break;
                    }
                }

                if(!found)
                return target;
            }

            return target;
        }

        public static char FindFirstNonRepeatCharacter2(string s)
        {
            Dictionary<char, int> searchedTable = new Dictionary<char, int>();
            char[] chars = s.ToArray();

            for (int i = 0; i < chars.Length; i++)
            { 
                char target = chars[i];
                if (searchedTable.ContainsKey(target))
                {
                    int count = searchedTable[target];
                    searchedTable[target] = target++;
                }
                else
                {
                    searchedTable[target] = 1;
                }
            }

            for (int i = 0; i < chars.Length; i++)
            { 
                char target = chars[i];
                int count = searchedTable[target];

                if (count == 1)
                    return target;
            }

            return ' ';
            
        }

        public static string RemoveChars(string target, string remove)
        {
            char[] targetStr = target.ToArray();
            char[] removeStr = remove.ToArray();
            string returnStr = string.Empty;
            
            for(int i = 0; i < targetStr.Length; i++)
            {
                bool isRemoved = false;
                for (int j = 0; j < removeStr.Length; j++)
                {
                    char ch = removeStr[j];

                    if (targetStr[i] == ch) {
                        isRemoved = true;
                    }
                }

                if(!isRemoved)
                returnStr += targetStr[i];
            }

            return returnStr;
        }

        //public static string ReverseWords(string words)
        //{
        //    string[] wordArr = words.Split(new char[] { ' ' });
        //    int index = wordArr.Length / 2;
        //    int length = wordArr.Length;

        //    for (int i = 0; i < index; i++)
        //    {
        //        string temp = wordArr[i];
        //        wordArr[i] = wordArr[--length];
        //        wordArr[length] = temp;
        //    }

        //    string retWords = string.Empty;
        //    for(int i = 0; i < wordArr.Length; i++)
        //    {
        //        retWords += wordArr[i] + " ";
        //    }
        //    retWords = retWords.TrimEnd();
        //    return retWords;
        //}

        //public static string ReverseWords(string words)
        //{
        //    int endIndex = words.Length-1;
        //    int startIndex = 0;
        //    for (int i = endIndex; i != 0; i--)
        //    {
          

        //        char ch = words[i];
        //        if (ch == ' ')
        //        { }
                
            
        //    }
        //}

        public static int StringToInt(string s)
        {
            char[] charArr = s.ToArray();
            int index = charArr.Length -1;
            int sum = 0;
            int loopCount = 0;
            int firstChar = 0;
            bool isNeg = false;

            if (charArr[0] == '-')
            {
                isNeg = true;
                firstChar = 1;
            }

            for (int i = index; i >= firstChar; i--)
            {
                char ch = charArr[i];
                int val = ch - '0';

                for (int j = 1; j <= loopCount; j++)
                {
                    val *= 10;
                }

                sum += val;
                loopCount++;
            }

            if(isNeg)
                sum *= -1;

            return sum;
        }

        public static string IntToString(int num)
        {
            int MAX_DIGITS = 10;
            int i = 0;
            bool isNeg = false;

            char[] temp = new char[MAX_DIGITS + 1];

            if (num < 0)
            {
                num = -num;
                isNeg = true;
            }

            do {
                temp[i++] = (char)((num % 10) + '0');
                num /= 10;
            } while (num != 0);

            StringBuilder b = new StringBuilder();

            if (isNeg)
                b.Append('-');

            while (i > 0)
                b.Append(temp[--i]);

            return b.ToString();
                
        }



        /////////////////////////////////
        public static bool IsRotate(string s1, string s2)
        {
            return true;
        }
    }


}
