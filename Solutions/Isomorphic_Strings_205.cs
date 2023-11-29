namespace Solutions
{
    public class Isomorphic_Strings
    {
        public bool IsIsomorphic(string s, string t)
        {
            //First check both lenghts if != return false
            if (s.Length != t.Length)
            {
                return false;
            }
            // Create 2 dictionaries to store Mappings.
            // 1 to store the value of Char in s as Key and the value in T
            // 1 to store the value of Char in t as Key and the value in S

            Dictionary<char, char> sMap = new Dictionary<char, char>();
            Dictionary<char, char> tMap = new Dictionary<char, char>();

            //Loop through the strings and check if the value is present in the dictionaries

            for (int i = 0; i < s.Length; i++)
            {
                char sChar = s[i];
                char tChar = t[i];

                if (sMap.ContainsKey(sChar))
                {
                    if (sMap[sChar] != tChar)
                    {
                        return false;
                    }
                }
                else
                {
                    sMap.Add(sChar, tChar);
                }
                if (tMap.ContainsKey(tChar))
                {
                    if (tMap[tChar] != sChar)
                    {
                        return false;
                    }
                }
                else
                {
                    tMap.Add(tChar, sChar);
                }
            }
            return true;
        }
    }
}
/* Given two strings s and t, determine if they are isomorphic.

Two strings s and t are isomorphic if the characters in s can be replaced to get t.

All occurrences of a character must be replaced with another character while preserving the order of characters. No two characters may map to the same character, but a character may map to itself.

Example 1:

Input: s = "egg", t = "add"
Output: true
Example 2:

Input: s = "foo", t = "bar"
Output: false
Example 3:

Input: s = "paper", t = "title"
Output: true
 
Constraints:

1 <= s.length <= 5 * 104
t.length == s.length
s and t consist of any valid ascii character.
*/
