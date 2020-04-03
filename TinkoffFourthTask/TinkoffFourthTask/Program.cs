using System;

namespace TinkoffFourthTask {
  class Program {
    static void Main(string[] args) {
      var maxCabinets = int.Parse(Console.ReadLine());
      var allCabinets = int.Parse(Console.ReadLine());
      int[] cabinets = new int[allCabinets];

      for (int i = 0; i < allCabinets; i++) {
        cabinets[i] = int.Parse(Console.ReadLine());
      }

      var curCabinet = 0;
      var groups = 0;
      while (curCabinet < allCabinets) {
        if (cabinets[curCabinet] == 1) {
          curCabinet += maxCabinets;
          groups++;
        } else {
          curCabinet++;
        }
      }

      Console.WriteLine(groups);
    }
  }
}