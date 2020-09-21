using System;

namespace Chess.Move {

  public class Queen
  {
    public bool GetMove(string[] coor) // {queenV, queenH, enemyV, enemyH}
    {
      string[] vert = {"1","2","3","4","5","6","7","8"};
      string[] horz = {"a","b","c","d","e","f","g","h"};
      if ( coor[0] == coor[2] || coor[1] == coor[3] )
      {
        return true;
      }
      int keyIndexV = Array.FindIndex(vert, queenV => queenV.IsKey);
      int keyIndexH = Array.FindIndex(horz, queenH => queenH.IsKey);
      // N W equals pos V neg H
      for (int index = 0; index < ())
      {
        if ( vert[keyIndexV++] == enemyV )
        {
          for (int index2 = 0;)
          {
            if ( horz[keyIndexH--] == enemyH )
          }
        }
      }
      // N E equals pos V pos H
      // S E equals neg V pos H
      // S W equals neg V neg H
      {
        return true;
      }
    }
  }
}