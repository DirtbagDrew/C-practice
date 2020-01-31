using System;
using System.Collections.Generic;
using System.Linq;
class MainClass {
  public static void Main (string[] args) {
    var list = new List<bool>{true};
    var result = list.Aggregate(false,(acc,curr)=>{
      return acc||curr;
    });
    Console.Write(result);
  }
}