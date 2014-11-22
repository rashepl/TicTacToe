using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Data;

namespace TicTacToe
{
  public class Rules
  {
    #region member variables

    /// <summary>
    /// track the number of player 2 wins
    /// </summary>
    private int firstPlayerWins = 0;

    /// <summary>
    /// track the number of player 1 wins
    /// </summary>
    private int secondPlayerWins = 0;

    #endregion

    #region properties

    /// <summary>
    /// gets the current state of the game
    /// </summary>
    private GameState State
    {
      get;
      set;
    }

    /// <summary>
    /// gets/sets the active player in the game
    /// </summary>
    public Players ActivePlayer
    {
      get { return State.ActivePlayer; }
      set { State.ActivePlayer = value; }
    }

    /// <summary>
    /// gets/sets the names of the players of the game
    /// </summary>
    public string[] GamePlayers
    {
      get { return State.GamePlayers; }
      set { State.GamePlayers = value; }
    }

    /// <summary>
    /// track the number of wins for player 1
    /// </summary>
    public int FirstPlayerWins
    {
      get { return firstPlayerWins; }
      set { firstPlayerWins = value; }
    }

    /// <summary>
    /// track the number of wins for player 2
    /// </summary>
    public int SecondPlayerWins
    {
      get { return secondPlayerWins; }
      set { secondPlayerWins = value; }
    }

    /// <summary>
    /// track the turn for each player
    /// </summary>
    public bool PlayerTurn
    {
      get;
      set;
    }

    /// <summary>
    /// gets the color of the board background
    /// </summary>
    public Color BoardBackgroundColor
    {
      get { return State.BoardBackgroundColor; }
    }

    /// <summary>
    /// gets the color of the selectable locations 
    /// </summary>
    public Color BoardSelectableLocationsColor
    {
      get { return State.BoardSelectableLocationsColor; }
    }

    /// <summary>
    /// gets the color of the player 1 character
    /// </summary>
    public Color Player1CharacterColor
    {
      get { return State.Player1CharacterColor; }
    }

    /// <summary>
    /// gets the color of the player 2 character
    /// </summary>
    public Color Player2CharacterColor
    {
      get { return State.Player2CharacterColor; }
    }

    /// <summary>
    /// gets/sets the player 1 character
    /// </summary>
    public string Player1Character
    {
      get { return State.Player1Character; }
      set { State.Player1Character = value; }
    }

    /// <summary>
    /// gets/sets the player 2 character
    /// </summary>
    public string Player2Character
    {
      get { return State.Player2Character; }
      set { State.Player2Character = value; }
    }

    /// <summary>
    /// gets/sets the custom colors for the game board
    /// </summary>
    public int[] BoardBackgroundCustomColors
    {
      get { return State.BoardBackgroundCustomColors; }
      set { State.BoardBackgroundCustomColors = value; }
    }

    /// <summary>
    /// gets/sets the custom colors for the selectable locations on the game board
    /// </summary>
    public int[] BoardSelectableLocationsCustomColors
    {
      get { return State.BoardSelectableLocationsCustomColors; }
      set { State.BoardSelectableLocationsCustomColors = value; }
    }

    /// <summary>
    /// gets/sets the custom colors representing character 1 board location selections
    /// </summary>
    public int[] Player1CharacterCustomColors
    {
      get { return State.Player1CharacterCustomColors; }
      set { State.Player1CharacterCustomColors = value; }
    }

    /// <summary>
    /// gets/sets the custom colors representing character 2 board location selections
    /// </summary>
    public int[] Player2CharacterCustomColors
    {
      get { return State.Player2CharacterCustomColors; }
      set { State.Player2CharacterCustomColors = value; }
    }

    /// <summary>
    /// gets/sets the directory the game is saved in
    /// </summary>
    public string FileSaveDirectory
    {
      get { return State.FileSaveDirectory; }
      set { State.FileSaveDirectory = value; }
    }

    /// <summary>
    /// gets/sets the path with which a game is saved
    /// </summary>
    public string SavePath
    {
      get;
      set;
    }

    #endregion

    #region construction / destruction

    /// <summary>
    /// create a new rules object
    /// </summary>
    public Rules()
    {
      State = new GameState();
    }

    #endregion

    #region methods

    /// <summary>
    /// retrieve the board locations text for the given row and column location on the game board
    /// </summary>
    /// <param name="row">row of the board location</param>
    /// <param name="column">column of the board location</param>
    /// <returns>character stored on the board location</returns>
    public string GetBoardLocationsText(int row, int column)
    {
      return State.BoardLocations.Location[row, column];
    }

    /// <summary>
    /// retrieve the current number of selectable locations on the game board
    /// </summary>
    /// <returns>number of selectable locations on the game board</returns>
    public int GetBoardLocationSize()
    {
      return State.BoardLocations.Location.Length;
    }

    /// <summary>
    /// update the size of the game board based upon the given size
    /// </summary>
    /// <param name="boardSize">size of the game board</param>
    public void UpdateBoardLocationSize(int boardSize)
    {
      State.BoardLocations.SetBoardLocations(boardSize);
    }

    /// <summary>
    /// track the move made by a player
    /// </summary>
    /// <param name="boardLocationSelected">location of user selected entry</param>
    /// <param name="characterUsed">the string used to identify a user selection on the game board</param>
    /// <param name="currentPlayer">player currently active in the game</param>
    /// <returns>1 if game is won, 0 if game is tied, -1 if another move can be made</returns>
    public int TrackMove(int boardLocationSelected, string characterUsed, Players activePlayer)
    {
      State.UpdateGameState(boardLocationSelected, characterUsed, activePlayer);
      int result = CalculateMove(activePlayer, characterUsed);

      if (result == 1)
      {
        if (activePlayer == Players.FirstPlayer)
        {
          FirstPlayerWins++;
          State.FirstPlayerWins = FirstPlayerWins;
        }
        else
        {
          SecondPlayerWins++;
          State.SecondPlayerWins = SecondPlayerWins;
        }
      }

      return result;
    }

    /// <summary>
    /// determines if there is a winning game
    /// </summary>
    /// <param name="currentPlayer">player currently active in the game</param>
    /// <param name="characterUsed">the character used to represent user selections on the board</param>
    /// <returns>1 if game is won, 0 if game is tied, -1 if another move can be made</returns>
    public int CalculateMove(Players currentPlayer, string characterUsed)
    {
      // check all rows
      int totalRowAndColumnCount = (int)Math.Sqrt(State.BoardLocations.Location.Length * 1.0);

      // track the number of matches found for each row/column/diagonal
      int matches = 0;

      // store the matching token if a win is found
      string winningMatch = string.Empty;

      // track a tie game
      bool tieGame = true;

      // search the rows within the game board
      for (int rows = 0; rows < totalRowAndColumnCount; rows++)
      {
        for (int columns = 0; columns < totalRowAndColumnCount - 1; columns++)
        {
          if (State.BoardLocations.Location[rows, columns] == State.BoardLocations.Location[rows, columns + 1] &&
            State.BoardLocations.Location[rows, columns] != string.Empty &&
            State.BoardLocations.Location[rows, columns + 1] != string.Empty)
          {
            //if (++matches == 2)
            if (++matches == totalRowAndColumnCount - 1)
            {
              winningMatch = State.BoardLocations.Location[rows, columns];
              break;
            }
          }
        }
        matches = 0;
      }

      if (winningMatch == string.Empty)
      {
        // search the columns within the game board
        for (int columns = 0; columns < totalRowAndColumnCount; columns++)
        {
          for (int rows = 0; rows < totalRowAndColumnCount - 1; rows++)
          {
            if (State.BoardLocations.Location[rows, columns] == State.BoardLocations.Location[rows + 1, columns] &&
              State.BoardLocations.Location[rows, columns] != string.Empty &&
              State.BoardLocations.Location[rows + 1, columns] != string.Empty)
            {
              //if (++matches == 2)
              if (++matches == totalRowAndColumnCount - 1)
              {
                winningMatch = State.BoardLocations.Location[rows, columns];
                break;
              }
            }
          }
          matches = 0;
        }
      }

      // search the left to right diagonal within the game board
      for (int diagonalCounter = 0; diagonalCounter < totalRowAndColumnCount - 1; diagonalCounter++)
      {
        if (State.BoardLocations.Location[diagonalCounter, diagonalCounter] == State.BoardLocations.Location[diagonalCounter + 1, diagonalCounter + 1] &&
          State.BoardLocations.Location[diagonalCounter, diagonalCounter] != string.Empty &&
            State.BoardLocations.Location[diagonalCounter + 1, diagonalCounter + 1] != string.Empty)
        {
          if (++matches == totalRowAndColumnCount - 1)
          {
            winningMatch = State.BoardLocations.Location[diagonalCounter, diagonalCounter];
          }
        }
      }

      matches = 0;


      // search the right to left diagonal within the game board
      int columnCounter = totalRowAndColumnCount - 1;
      for (int rowCounter = 0; rowCounter < totalRowAndColumnCount - 1; rowCounter++)
      {
        if (State.BoardLocations.Location[rowCounter, columnCounter] == State.BoardLocations.Location[rowCounter + 1, columnCounter - 1] &&
          State.BoardLocations.Location[rowCounter, columnCounter] != string.Empty &&
          State.BoardLocations.Location[rowCounter + 1, columnCounter - 1] != string.Empty)
        {
          if (++matches == totalRowAndColumnCount - 1)
          {
            winningMatch = State.BoardLocations.Location[rowCounter, columnCounter];
          }
        }
        columnCounter--;
      }

      matches = 0;


      if (winningMatch == string.Empty)
      {
        // determine if the game is tied
        for (int rows = 0; rows < totalRowAndColumnCount; rows++)
        {
          for (int columns = 0; columns < totalRowAndColumnCount; columns++)
          {
            if (State.BoardLocations.Location[rows, columns] == string.Empty)
            {
              tieGame = false;
              break;
            }
          }
        }
      }

      if (tieGame && winningMatch == string.Empty)
      {
        return 0;
      }
      
      return winningMatch == string.Empty ? -1 : 1;
    }

    /// <summary>
    /// clear the state of the game board
    /// </summary>
    public void ClearGameState()
    {
      State.BoardLocations.ClearBoard();
    }

    /// <summary>
    /// save the game as a stream within a separate thread
    /// </summary>
    public void SaveGameViaThread()
    {
      IFormatter formatter = new BinaryFormatter();
      Stream stream = new FileStream(SavePath, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
      formatter.Serialize(stream, State);
    }

    /// <summary>
    /// set the state of the game
    /// </summary>
    /// <param name="state">state of the board game, including active player and locations set on the grid</param>
    public void LoadSavedGameState(object state)
    {
      State = (GameState)state;
      FirstPlayerWins = State.FirstPlayerWins;
      SecondPlayerWins = State.SecondPlayerWins;
    }

    /// <summary>
    /// store the user selected game colors
    /// </summary>
    /// <param name="boardBackColor">game board background color</param>
    /// <param name="boardSelectableLocationsColor">background color of selectable locations on the board</param>
    /// <param name="player1CharacterColor">color of the player 1 character</param>
    /// <param name="player2CharacterColor">color of the player 2 character</param>
    public void StoreColorsState(Color boardBackColor, Color boardSelectableLocationsColor, Color player1CharacterColor, Color player2CharacterColor, int[] boardBackgroundSelectableLocationsCustomColors, int[] boardSelectableLocationsCustomColors, int[] player1CharacterCustomColors, int[] player2CharacterCustomColors)
    {
      State.BoardBackgroundColor = boardBackColor;
      State.BoardSelectableLocationsColor = boardSelectableLocationsColor;
      State.Player1CharacterColor = player1CharacterColor;
      State.Player2CharacterColor = player2CharacterColor;

      State.BoardBackgroundCustomColors = boardBackgroundSelectableLocationsCustomColors;
      State.BoardSelectableLocationsCustomColors = boardSelectableLocationsCustomColors;
      State.Player1CharacterCustomColors = player1CharacterCustomColors;
      State.Player2CharacterCustomColors = player2CharacterCustomColors;
    }

    /// <summary>
    /// retrieve the location of the last move made by a game player
    /// </summary>
    /// <returns></returns>
    public int UndoLastMove()
    {
      int lastMove = State.PlayerMoves.Count > 0 ? State.PlayerMoves.Pop() : -1;
      State.RemoveLastMove(lastMove);
      return lastMove; 
    }

    /// <summary>
    /// update the state of the board characters
    /// </summary>
    /// <param name="boardLocationsCharacters">array of characters used to represent user selections on the game board</param>
    public void UpdateExistingCharactersOnBoard(string[] boardLocationsCharacters)
    {
      int rowsColumnsCount = Convert.ToInt32(Math.Sqrt(State.BoardLocations.Location.Length * 1.0));
      int boardLocationCount = 0;
      for (int rows = 0; rows < rowsColumnsCount; rows++)
      {
        for (int columns = 0; columns < rowsColumnsCount; columns++)
        {
          State.BoardLocations.Location[rows, columns] = boardLocationsCharacters[boardLocationCount++];
        }
      }
    }

    #endregion

    #region event handlers
    #endregion
  }
}
