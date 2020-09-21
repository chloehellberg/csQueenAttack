using System;
using Chess.Move;

namespace Chess {

  public class Program
  {
    public static void Main()
    {
      Queen moves = new Queen();
      // ask for queen coordinate 1
      Console.WriteLine("What is the Queen's vertical coordinate is (1-9)");
      string queenV = Console.ReadLine();
      // ask for queen coordinate 2
      Console.WriteLine("What is the Queen's horizontal coordinate is (a-h)");
      string queenH = Console.ReadLine();
      // ask for enemy coordinate 1
      Console.WriteLine("What is the Enemy's vertical coordinate is (1-9)");
      string enemyV = Console.ReadLine();
      // ask for enemy coordinate 2
      Console.WriteLine("What is the Enemy's horizontal coordinate is (a-h)");
      string enemyH = Console.ReadLine();

      string[] coordinates = {queenV, queenH, enemyV, enemyH};
      // send coordinates to business logic
      bool result = moves.GetMove(coordinates);
      // return true or false
      Console.WriteLine(result);

    }
  } 
}