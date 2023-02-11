using System;
using BakeryStoreFront.Models;
using System.Linq;

namespace BakeryStoreFront
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery! We sell bread and pastries and have a special today so I can get home to watch my shows double quick: For every two loaves of bread, you get one free, and for every three pastries, you get one pastry free! Whether or not you want it!";
      while(true)
      {
        Console.WriteLine("Would you like to purchase bread or pastry today?(Type <b> for bread or <p> for pastry or <No> to go back to main)");
        string userInput = Console.ReadLine();

        if (userInput == "b")
        {
          Console.WriteLine("How many loaves of bread would you like? Remember buy 2 and get 1 free!");
          int numberOfLoaves = int.Parse(Console.ReadLine());
          //method to add bread
        }
        if (userInput == "p")
        {
          Console.WriteLine("How many pastries would you like? Remember, buy 3 and get 1 free!");
          int numberOfPastries = int.Parse(Console.ReadLine());
          //method to add pastries
        }
        if (userInput == "No")
        {
          Console.WriteLine("Sorry to hear you don't want any of our pastries or bread today, at this rate I'll never get to my show in time!");
          //method to exit;
        }

      }      
    }
  }
}