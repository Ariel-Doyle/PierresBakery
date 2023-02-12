using System;
using BakeryStoreFront.Models;

namespace BakeryStoreFront
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery! We sell bread and pastries and have sellout specials everyday so I can get home to watch my show double quick: For every two loaves of bread you get one loaf free, and for every three pastries you get one pastry free! Whether or not you want it!");

      Console.WriteLine("Would you like to purchase bread or pastry today?(Type <b> for bread, <p> for pastry, <v> to view your cart, or <no> to exit)");
      
      string userInput = (Console.ReadLine()).ToLower();
      while(true)
      {
        if (userInput == "b")
        {
          Console.WriteLine("Bread is $5 per loaf. How many loaves of bread would you like? Remember buy 2 and get 1 free!");
          int numberOfLoaves = int.Parse(Console.ReadLine());
          if (numberOfLoaves == 1)
          {
            Console.WriteLine("One loaf of bread? That's it? C'mon, I'm basically paying you to get another loaf.");
          } 
          else 
          {
            Console.WriteLine($"Your current selection of {numberOfLoaves} loaves of bread will total ${Bread.DetermineBreadPrice(numberOfLoaves)}");
          }
        }
        if (userInput == "p")
        {
          Console.WriteLine("Pastries are $2 per pastry. How many pastries would you like? Remember, buy 3 and get 1 free!");
          int numberOfPastries = int.Parse(Console.ReadLine());
          if (numberOfPastries < 3)
          {
            Console.WriteLine($"{numberOfPastries} pastry? That's it? C'mon, I'm basically paying you to get another pastry.");
          } 
          else
          {
            Console.WriteLine($"Your current selection of {numberOfPastries} pastries will total ${Pastry.DeterminePastryPrice(numberOfPastries)}");
          }
        }
        if (userInput == "no")
        {
          Console.WriteLine("Sorry to hear you don't want any of our pastries or bread today, at this rate I'll never get to my show in time!");
          System.Environment.Exit(0);
        }
        // {
        //   Console.WriteLine("I'm sorry, that input is not recognized, please enter <b> for bread prices, <p> for pastry prices, or <no> to exit.");
        // }        
      }      
    }
  }
}