using System;

namespace Palindromes
{
  public class Palindrome
  {
    public string Reverse(string myString)
    {
      char[] userArray = myString.ToCharArray();
      Array.Reverse(userArray);
      return new string(userArray);
    }

    public bool IsPalindrome(string myString)
    {
      string ReverseString = Reverse(myString);

      if (ReverseString != myString){
        return false;
      }
      else
      {
        return true;
      }
    }
  }
}