using System;
using Chess.Move;

namespace Chess {

  public class Program
  {
    public static void Main()
    {
      Queen moves = new Queen();
      // ask for queen coordinate 1
      Console.WriteLine("What is the Queen's vertical coordinate is (1-8)");
      string stringQueenV = Console.ReadLine();
      int queenV = int.Parse(stringQueenV);
      // ask for queen coordinate 2
      Console.WriteLine("What is the Queen's horizontal coordinate is (1-8)");
      string stringQueenH = Console.ReadLine();
      int queenH = int.Parse(stringQueenH);
      // ask for enemy coordinate 1
      Console.WriteLine("What is the Enemy's vertical coordinate is (1-8)");
      string stringEnemyV = Console.ReadLine();
      int enemyV = int.Parse(stringEnemyV);
      // ask for enemy coordinate 2
      Console.WriteLine("What is the Enemy's horizontal coordinate is (1-8)");
      string stringEnemyH = Console.ReadLine();
      int enemyH = int.Parse(stringEnemyH);

      int[] coordinates = {queenV, queenH, enemyV, enemyH};
      // send coordinates to business logic
      bool result = moves.GetMove(coordinates);
      // return true or false
      Console.WriteLine(result);

    }
  } 
}