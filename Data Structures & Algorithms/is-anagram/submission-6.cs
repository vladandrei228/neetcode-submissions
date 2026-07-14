public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        char[] char1 = s.ToCharArray();
        char[] char2 = t.ToCharArray();

        Array.Sort(char1);
        Array.Sort(char2);

        string sorted1 = new string(char1);
        string sorted2 = new string(char2);

        bool isMatch = sorted1 == sorted2;
        
        return isMatch;
    }
}
