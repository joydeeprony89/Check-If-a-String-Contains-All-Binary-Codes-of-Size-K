using System;

namespace Check_If_a_String_Contains_All_Binary_Codes_of_Size_K
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }

  public class Solution
  {
    public bool HasAllCodes(string s, int k)
    {
      // binary codes are 0,1 will have 2^k no of binary codes of length k.
      // when k = 2, 00, 11, 10, 01 are 4 possible codes of length 2
      // when k = 3, 000, 001, 010, 100, 011, 111, 110, 101

      // We just need to find all the subsets of length k from string s and if the length is matched with 2^k no of codes then we can return true.
      var total = Math.Pow(2, k);
      HashSet<string> visited = new HashSet<string>();
      for (int i = k; i <= s.Length; i++)
      {
        string subStr = s.Substring(i - k, k);
        if (!visited.Contains(subStr))
        {
          visited.Add(subStr);
          if (visited.Count == total) return true;
        }
      }

      return false;
    }
  }
}
