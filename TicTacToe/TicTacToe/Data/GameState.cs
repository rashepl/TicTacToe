using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Data
{
  /// <summary>
  /// track the state of the game
  /// </summary>
  [Serializable]
  public class GameState
  {
    #region member variables

    /// <summary>
    /// tracks the locations the users have selected when making moves during the game
    /// </summary>
    private BoardLocationData boardLocations;

    #endregion

    #region properties

    /// <summary>
    /// gets/sets the directory the game is saved in
    /// </summary>
    public string FileSaveDirectory
    {
      get;
      set;
    }

    /// <summary>
    /// track the players names within this game
    /// </summary>
    public string[] GamePlayers
    {
      get;
      set;
    }

    /// <summary>
    /// track the characters used by player 1
    /// </summary>
    public string Player1Character
    {
      get;
      set;
    }

    /// <summary>
    /// track the characters used by player 2
    /// </summary>
    public string Player2Character
    {
      get;
      set;
    }

    /// <summary>
    /// gets/sets the backcolor for the board
    /// </summary>
    public Color BoardBackgroundColor
    {
      get;
      set;
    }

    /// <summary>
    /// gets/sets the custom color identifiers for the color of the back of the game board
    /// </summary>
    public int[] BoardBackgroundCustomColors
    {
      get;
      set;
    }

    /// <summary>
    /// gets/sets the backcolor for the board locations
    /// </summary>
    public Color BoardSelectableLocationsColor
    {
      get;
      set;
    }

    /// <summary>
    /// gets/sets the custom color identifiers for the selectable locations on the game grid
    /// </summary>
    public int[] BoardSelectableLocationsCustomColors
    {
      get;
      set;
    }

    /// <summary>
    /// gets/sets the player 1 character color
    /// </summary>
    public Color Player1CharacterColor
    {
      get;
      set;
    }

    /// <summary>
    /// gets/sets the custom set colors for the player 1 character
    /// </summary>
    public int[] Player1CharacterCustomColors
    {
      get;
      set;
    }

    /// <summary>
    /// gets/sets the player 2 character color
    /// </summary>
    public Color Player2CharacterColor
    {
      get;
      set;
    }

    /// <summary>
    /// gets/sets the custom set colors for the player 2 character
    /// </summary>
    public int[] Player2CharacterCustomColors
    {
      get;
      set;
    }

    /// <summary>
    /// track the number of first player wins throughout the game
    /// </summary>
    public int FirstPlayerWins
    {
      get;
      set;
    }

    /// <summary>
    /// track the number of second player wins throughout the game
    /// </summary>
    public int SecondPlayerWins
    {
      get;
      set;
    }

    /// <summary>
    /// gets/sets the active player
    /// </summary>
    public Players ActivePlayer
    {
      get;
      set;
    }

    /// <summary>
    /// gets/sets the user selected locations of tictactoe entries
    /// </summary>
    public BoardLocationData BoardLocations
    {
      get { return boardLocations; }
      set { boardLocations = value; }
    }

    /// <summary>
    /// track the locations on the game board where the player has made a move
    /// </summary>
    public Stack<int> PlayerMoves
    {
      get;
      set;
    }

    #endregion

    #region construction / destruction

    public GameState()
    {
      InitializeGameState();
    }

    #endregion

    #region methods

    /// <summary>
    /// initialize the state of the game
    /// </summary>
    private void InitializeGameState()
    {
      boardLocations = new BoardLocationData();
      PlayerMoves = new Stack<int>();
    }

    /// <summary>
    /// updates the current state of the game
    /// </summary>
    /// <param name="boardLocationSelected">location on the game board a user wants to make a move</param>
    /// <param name="characterUsed">character user is using to identify a move on the game board</param>
    /// <param name="activePlayer">the currently active player in the game</param>
    public void UpdateGameState(int boardLocationSelected, string characterUsed, Players activePlayer)
    {
      BoardLocations.StoreBoardLocation(boardLocationSelected, characterUsed);
      PlayerMoves.Push(boardLocationSelected);
      ActivePlayer = activePlayer == Players.FirstPlayer ? Players.SecondPlayer : Players.FirstPlayer;
    }

    /// <summary>
    /// remove the last move from the game board by marking the location as empty
    /// </summary>
    /// <param name="boardLocationSelected">location on the game board to remove a player move</param>
    public void RemoveLastMove(int boardLocationSelected)
    {
      BoardLocations.StoreBoardLocation(boardLocationSelected, string.Empty);
    }

    #endregion

    #region event handlers
    #endregion
  }
}
