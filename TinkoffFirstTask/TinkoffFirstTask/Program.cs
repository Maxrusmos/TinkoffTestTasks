using System;

namespace TinkoffFirstTask {
  class Program {
    static void Main(string[] args) {
      var nums = Console.ReadLine().Split(' ');

      if (int.Parse(nums[0]) * int.Parse(nums[1]) > int.Parse(nums[2]) * int.Parse(nums[3])) {
        Console.WriteLine("M");
      } else if (int.Parse(nums[0]) * int.Parse(nums[1]) < int.Parse(nums[2]) * int.Parse(nums[3])) {
        Console.WriteLine("P");
      } else {
        Console.WriteLine("E");
      }
    }
  }
}