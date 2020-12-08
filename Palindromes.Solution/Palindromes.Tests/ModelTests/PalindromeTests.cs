using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindromes;

namespace Palindromes.Tests
{
  [TestClass]
  public class PalindromeTests
  {
    [TestMethod]
    public void IsPalindrome_ReverseInput_ReturnString()
    {
      Palindrome testPalindrome = new Palindrome();
      Assert.AreEqual("olleh", testPalindrome.IsPalindrome("hello"));
    }
  }
}