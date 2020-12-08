using System;

namespace Palindromes
{
  public class Palindrome
  {
    public string IsPalindrome(string myString)
    {
      char[] userArray = myString.ToCharArray();
      Array.Reverse(userArray);
      return new string(userArray);
    }
  }
}