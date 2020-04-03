using System;
using System.Text;

namespace TinkoffSecondTask {
  class Program {
    static void Main(string[] args) {
      StringBuilder mainStr = new StringBuilder(Console.ReadLine());
      var counter = 0;
      var flag = false;

      for (int i = 0; i < mainStr.Length; i++) {
        if (char.IsLetter(mainStr[i]) && !flag) {
          counter++;
          flag = true;
        }
        if (!char.IsLetter(mainStr[i]) && mainStr[i] != '-' && flag) {
          flag = false;
        }
      }
      Console.WriteLine(counter);
    }
  }
}
