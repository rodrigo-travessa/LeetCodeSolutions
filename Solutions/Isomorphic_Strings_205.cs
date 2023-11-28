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
