string s = "pwwkew";

int result = LengthOfLongestSubstring(s);
Console.WriteLine(result);

int LengthOfLongestSubstring(string s)
{
    int maxLength = 0;

    for (int i = 0; i < s.Length; i++)
    {
        HashSet<char> charSet = new HashSet<char>();
        for (int j = i; j < s.Length; j++)
        {
            if (charSet.Contains(s[j]))
            {
                break;
            }
            charSet.Add(s[j]);
            maxLength = Math.Max(maxLength, charSet.Count);
        }
    }
    return maxLength;
}