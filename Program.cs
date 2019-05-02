using System;

namespace nguess
{
  class Program
  {
    static void Main(string[] args)
    {
      //establish randome number from 1 to 999
      Random number = new Random();
      int rndNum = number.Next(1000);
      //initialize main variables
      int guessCT = 0;
      int guess = 0;
      Console.Clear();
      //CodeCrack is the intro splash screen
      void CodeCrack()
      {
        //Console.WriteLine("Welcome to,");
        Console.WriteLine("......######...#######..########..########.....");
        Console.WriteLine(".....##....##.##.....##.##.....##.##...........");
        Console.WriteLine(".....##.......##.....##.##.....##.##...........");
        Console.WriteLine(".....##.......##.....##.##.....##.######.......");
        Console.WriteLine(".....##.......##.....##.##.....##.##...........");
        Console.WriteLine(".....##....##.##.....##.##.....##.##...........");
        Console.WriteLine("......######...#######..########..########.....");
        //Console.WriteLine("                                     ....... ");
        Console.WriteLine("..######..########.....###.....######..##....##");
        Console.WriteLine(".##....##.##.....##...##.##...##....##.##...##.");
        Console.WriteLine(".##.......##.....##..##...##..##.......##..##..");
        Console.WriteLine(".##.......########..##.....##.##.......#####...");
        Console.WriteLine(".##.......##...##...#########.##.......##..##..");
        Console.WriteLine(".##....##.##....##..##.....##.##....##.##...##.");
        Console.WriteLine("..######..##.....##.##.....##..######..##....##");
        Console.WriteLine("Press Any Key");
        Console.ReadKey(false);
      }
      //instruct provides basic instructions
      void instruct()
      {
        Console.Clear();
        Console.WriteLine("You have only ten attempts to ");
        Console.WriteLine("Crack the Code.");
        Console.WriteLine("The number is between, and may include, 1 to 999");
      }
      //checkNum evaluates entered number against rnd to see if high, low or win
      void checkNum()
      {
        if (guess > rndNum)
        {
          Console.Clear();
          Console.WriteLine("Your Guess is HIGHER than the number...");
          System.Console.WriteLine("You have " + (10 - guessCT) + " tries left");
        }
        else if (guess < rndNum)
        {
          Console.Clear();
          System.Console.WriteLine("Your Guess is LOWER than the number...");
          System.Console.WriteLine("You have " + (10 - guessCT) + " tries left");
        }
        else if (guess == rndNum)
        {
          winner();
        }
      }
      //numTry checks user input to ensure appropriate number of 1 to 999
      //numTry increments the guess count after verifying valid input
      void numTry()
      {
        try
        {
          System.Console.WriteLine("Please Input Your Guess");
          string temp = Console.ReadLine();
          guess = Int32.Parse(temp);
        }
        catch
        {
          System.Console.WriteLine("Please input upto 3 numbers only");
          numTry();
        }
        if (guess > 999 || guess < 1)
        {
          System.Console.WriteLine("Please ensure number is from 1 to 999");
          numTry();
        }
        else
        {
          guessCT++;
        }
      }
      //loser is the lose splash screen
      void loser()
      {
        Console.Clear();
        System.Console.WriteLine(".##........#######...######..########.########.");
        System.Console.WriteLine(".##.......##.....##.##....##.##.......##.....##");
        System.Console.WriteLine(".##.......##.....##.##.......##.......##.....##");
        System.Console.WriteLine(".##.......##.....##..######..######...########.");
        System.Console.WriteLine(".##.......##.....##.......##.##.......##...##..");
        System.Console.WriteLine(".##.......##.....##.##....##.##.......##....##.");
        System.Console.WriteLine(".########..#######...######..########.##.....##");
      }
      //winner is the win splash
      void winner()
      {
        Console.Clear();
        System.Console.WriteLine(".##....##..#######..##.....##....##......##.####.##....##");
        System.Console.WriteLine("..##..##..##.....##.##.....##....##..##..##..##..###...##");
        System.Console.WriteLine("...####...##.....##.##.....##....##..##..##..##..####..##");
        System.Console.WriteLine("....##....##.....##.##.....##....##..##..##..##..##.##.##");
        System.Console.WriteLine("....##....##.....##.##.....##....##..##..##..##..##..####");
        System.Console.WriteLine("....##....##.....##.##.....##....##..##..##..##..##...###");
        System.Console.WriteLine("....##.....#######...#######......###..###..####.##....##");
        Environment.Exit(0);
      }
      //call splash and instructions
      CodeCrack();
      instruct();
      //whie loop evaluates for loss condition (10 tries) and adds taunts.
      //is the main logic loop
      while (guessCT < 10)
      {
        numTry();
        checkNum();
        if (guessCT == 5)
        {
          System.Console.WriteLine("You're not doing so hot at this...");
        }
        if (guessCT == 7)
        {
          System.Console.WriteLine("Well this game is almost over...");
        }
        if (guessCT == 9)
        {
          System.Console.WriteLine("One guess left loser.");
        }
        if (guessCT == 10)
        {
          loser();
        }
        else
        {
          System.Console.WriteLine("");
        }
      }
    }
  }
}