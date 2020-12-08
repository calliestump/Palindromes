using System;
using Palindromes;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Please enter a word: ");
    string word = Console.ReadLine();
    
    Palindrome newPalindrome = new Palindrome();
    Console.WriteLine(newPalindrome.IsPalindrome(word));
  }
}