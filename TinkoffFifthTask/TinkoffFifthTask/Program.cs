using System;
using System.Text;

namespace TinkoffFifthTask {
  class Program {
    static void Main(string[] args) {
      var str = Console.ReadLine();
      var strBuild = new StringBuilder();
      var maxPalLenght = 0;
      for (int i = 0; i < str.Length; i++) {
        strBuild.Append(str[i]);
        if (Palindrom(strBuild.ToString())) {
          maxPalLenght = strBuild.Length;
        }
      }
      var tmpStrBuild = new StringBuilder(maxPalLenght);
      for (int i = 0; i < maxPalLenght; i++) {
        tmpStrBuild.Append(strBuild[i]);
      }
      Console.WriteLine(maxPalLenght);
      Console.WriteLine(tmpStrBuild.ToString());
    }

    public static bool Palindrom(string s) {
      for (int i = 0; i < s.Length / 2; i++)
        if (s[i] != s[s.Length - i - 1]) {
          return false;
        }
      return true;
    }
  }
}
