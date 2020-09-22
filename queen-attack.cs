using System;

namespace Chess.Move {

  public class Queen
  {
    public bool GetMove(int[] coor) // {queenV, queenH, enemyV, enemyH}
    {
      if ( coor[0] == coor[2] || coor[1] == coor[3] )
      {
        return true;
      }
      else if (((coor[0] - coor[2]) / (coor[1] - coor[3])) == 1 || ((coor[0] - coor[2]) / (coor[1] - coor[3])) == -1)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}