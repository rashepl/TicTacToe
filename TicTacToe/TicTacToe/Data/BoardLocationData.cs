using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
  /// <summary>
  /// store the data pertaining to the location of a user selection on the game board and which user made the selection
  /// </summary>
  [Serializable]
  public class BoardLocationData
  {
    #region member variables
    #endregion

    #region properties

    /// <summary>
    /// store the location of the user selection on the game grid
    /// Ex: for a 3X3 grid:
    /// row 1 = 0, 1, 2
    /// row 2 = 3, 4, 5
    /// row 3 = 6, 7, 8
    /// </summary>
    public string[,] Location
    {
      get;
      set;
    }

    #endregion

    #region construction / destruction

    /// <summary>
    /// construct a new BoardLocationData object
    /// </summary>
    public BoardLocationData()
    {
    }

    #endregion

    #region methods

    /// <summary>
    /// set the size of the game board used to track user moves
    /// </summary>
    /// <param name="boardSize">size of the game board</param>
    public void SetBoardLocations(int boardSize)
    {
      Location = new string[boardSize, boardSize];

      for (int row = 0; row < boardSize; row++)
      {
        for (int column = 0; column < boardSize; column++)
        {
          Location[row, column] = string.Empty;
        }
      }
    }

    /// <summary>
    /// set the location and the character played to the correct location on the game board
    /// </summary>
    /// <param name="location">location the user has selected to make a move on the game board</param>
    /// <param name="characterPlayed">character to represent the user selection on the game board</param>
    public void StoreBoardLocation(int location, string characterPlayed)
    {
      int locationCounter = 0;
      int rowsColumnsCount = Convert.ToInt32(Math.Sqrt(Location.Length));
      for (int rowCount = 0; rowCount < rowsColumnsCount; rowCount++)
      {
        for (int columnCount = 0; columnCount < rowsColumnsCount; columnCount++)
        {
          if (location == locationCounter++)
          {
            Location[rowCount, columnCount] = characterPlayed;
          }
        }
      }
    }

    /// <summary>
    /// clear the game board by setting each location value to an empty string value
    /// </summary>
    public void ClearBoard()
    {
      int totalRowsAndColumns = (int)Math.Sqrt(Location.Length * 1.0);

      for (int row = 0; row < totalRowsAndColumns; row++)
      {
        for (int column = 0; column < totalRowsAndColumns; column++)
        {
          Location[row, column] = string.Empty;
        }
      }
    }

    #endregion

    #region event handlers
    #endregion
  }
}
