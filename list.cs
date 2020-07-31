using System;
using System.Collections.Generic;
namespace list
{
    class list{
    static void Main(string [] args){
      var l=new List<int>();
      l.Add(45);
      String v = l.ToString();
      foreach (var i in l)
      {
              Console.WriteLine(v); 
      }
    }
    }
}