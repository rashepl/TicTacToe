using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe.GUI
{
  public partial class TicTacToeForm : Form
  {
    #region member variables
    #endregion

    #region properties

    /// <summary>
    /// game board TableLayoutPanel used for displaying gameplay
    /// </summary>
    private TableLayoutPanel TicTacToeLayoutPanel
    {
      get;
      set;
    }

    /// <summary>
    /// track the locations on the game board where players can make moves
    /// </summary>
    private List<Label> GameBoardLocations
    {
      get;
      set;
    }

    /// <summary>
    /// track the players names within this game
    /// </summary>
    private string[] GamePlayers
    {
      get;
      set;
    }

    /// <summary>
    /// track the characters used by the players within this game
    /// </summary>
    private Label[] GamePlayersCharacters
    {
      get;
      set;
    }

    /// <summary>
    /// gets/sets the active player
    /// </summary>
    private Players ActivePlayer
    {
      get;
      set;
    }

    /// <summary>
    /// store the rules for the game
    /// </summary>
    private Rules GameRules
    {
      get;
      set;
    }

    /// <summary>
    /// gets/sets indication if a change has happened within the game
    /// </summary>
    private bool IsDirty
    {
      get;
      set;
    }

    #endregion

    #region construction / destruction

    /// <summary>
    /// create a new tictactoe form
    /// </summary>
    public TicTacToeForm()
    {
      InitializeComponent();
      InitializeRules();

      GameBoardLocations = new List<Label>();

      MarkAsDirty();
      GamePlayers = new string[2];
      GamePlayers[0] = "Player 1";
      GamePlayers[1] = "Player 2";

      GameRules.GamePlayers = GamePlayers;

      GamePlayersCharacters = new Label[2];
      GamePlayersCharacters[0] = new Label();
      GamePlayersCharacters[1] = new Label();
      GamePlayersCharacters[0].Text = "X";
      GamePlayersCharacters[1].Text = "O";
      GameRules.Player1Character = GamePlayersCharacters[0].Text;
      GameRules.Player2Character = GamePlayersCharacters[1].Text;
      GameRules.UpdateBoardLocationSize(3);

      UpdatePlayerWinsNames();
      SetGridPanelLayout(3);
    }

    /// <summary>
    /// create a new tictactoe form with the data from the given file
    /// </summary>
    /// <param name="ticTacToeFileName">name of the tictactoe file</param>
    public TicTacToeForm(string ticTacToeFileName)
      : this()
    {
      ApplySavedTicTacToeData(ticTacToeFileName);
      MarkAsNotDirty();
    }

    #endregion

    #region methods

    /// <summary>
    /// initialize the rules used for this game
    /// </summary>
    private void InitializeRules()
    {
      GameRules = new Rules();
    }

    /// <summary>
    /// set the layout of the tictactoe grid
    /// </summary>
    private void SetGridPanelLayout(int size)
    {
      if (TicTacToeLayoutPanel != null && Controls.Contains(TicTacToeLayoutPanel))
      {
        Controls.Remove(TicTacToeLayoutPanel);
        TicTacToeLayoutPanel.Dispose();
      }

      TicTacToeLayoutPanel = new TableLayoutPanel();
      TicTacToeLayoutPanel.BackColor = GameRules.BoardBackgroundColor.IsEmpty ? Color.DodgerBlue : GameRules.BoardBackgroundColor;
      TicTacToeLayoutPanel.Controls.Clear();
      TicTacToeLayoutPanel.RowStyles.Clear();
      TicTacToeLayoutPanel.ColumnStyles.Clear();

      SuspendLayout();
      TicTacToeLayoutPanel.SuspendLayout();

      Label selectableBoardLocation;

      TicTacToeLayoutPanel.ColumnCount = size;
      TicTacToeLayoutPanel.RowCount = size;
      TicTacToeLayoutPanel.Dock = DockStyle.Fill;

      for (int rowsColumnCount = 0; rowsColumnCount < size; rowsColumnCount++)
      {
        TicTacToeLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
        TicTacToeLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
      }

      GameBoardLocations.Clear();

      int locationCount = 0;
      for (int rowCount = 0; rowCount < size; rowCount++)
      {
        for (int columnCount = 0; columnCount < size; columnCount++)
        {
          selectableBoardLocation = new Label();

          selectableBoardLocation.BackColor = GameRules.BoardSelectableLocationsColor.IsEmpty ? Color.SkyBlue : GameRules.BoardSelectableLocationsColor;
          TicTacToeLayoutPanel.Controls.Add(selectableBoardLocation, columnCount, rowCount);

          selectableBoardLocation.Dock = DockStyle.Fill;
          selectableBoardLocation.Margin = new System.Windows.Forms.Padding(3);
          selectableBoardLocation.TextAlign = ContentAlignment.MiddleCenter;
          selectableBoardLocation.Font = new Font(selectableBoardLocation.Font.FontFamily.Name, ((selectableBoardLocation.Size.Width + selectableBoardLocation.Size.Height) / 5));
          selectableBoardLocation.Text = string.IsNullOrEmpty(GameRules.GetBoardLocationsText(rowCount, columnCount)) ? string.Empty : GameRules.GetBoardLocationsText(rowCount, columnCount);
          selectableBoardLocation.ForeColor = selectableBoardLocation.Text == GameRules.Player1Character ? GameRules.Player1CharacterColor : selectableBoardLocation.Text == GameRules.Player2Character ? GameRules.Player2CharacterColor : selectableBoardLocation.ForeColor;
          selectableBoardLocation.AutoSize = true;
          selectableBoardLocation.Tag = locationCount;
          selectableBoardLocation.Click += UserSelection_Click;

          GameBoardLocations.Add(selectableBoardLocation);

          locationCount++;
        }
      }

      TicTacToeLayoutPanel.ResumeLayout();
      ResumeLayout(false);
      ResizeForm();
      Controls.Add(TicTacToeLayoutPanel);
    }

    /// <summary>
    /// restart the game, resetting the gameplay
    /// </summary>
    private void ResetGame()
    {
      foreach (Label userSelectionLocation in GameBoardLocations)
      {
        userSelectionLocation.Text = string.Empty;
      }

      GameRules.ClearGameState();
    }

    /// <summary>
    /// apply the data from the given file to the tictactoe form
    /// </summary>
    /// <param name="ticTacToeFileName"></param>
    private void ApplySavedTicTacToeData(string ticTacToeFileName)
    {
      IFormatter formatter = new BinaryFormatter();
      using (Stream stream = new FileStream(ticTacToeFileName, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
      {
        GameRules.LoadSavedGameState(formatter.Deserialize(stream));

        GamePlayers = GameRules.GamePlayers;
        ActivePlayer = GameRules.ActivePlayer;

        // create the game board based upon the size of the saved game
        //int locationIndex = 0;
        int rowColumnCount = Convert.ToInt32(Math.Sqrt(GameRules.GetBoardLocationSize() * 1.0));
        SetGridPanelLayout(rowColumnCount);

        GamePlayersCharacters[0].Text = GameRules.Player1Character;
        GamePlayersCharacters[1].Text = GameRules.Player2Character;
        GamePlayersCharacters[0].ForeColor = GameRules.Player1CharacterColor;
        GamePlayersCharacters[1].ForeColor = GameRules.Player2CharacterColor;

        Text = Path.GetFileName(ticTacToeFileName);
        gameTitleToolStripStatusLabel.Text = Text;
        UpdateStatusLabel();
      }
    }

    /// <summary>
    /// update the data within the status label
    /// </summary>
    private void UpdateStatusLabel()
    {
      playerTurnToolStripStatusLabel.Text = ActivePlayer == Players.FirstPlayer ? string.Format("{0}: {1}", GamePlayers[0], GamePlayersCharacters[0].Text) : string.Format("{0}: {1}", GamePlayers[1], GamePlayersCharacters[1].Text);
      UpdatePlayerWinsNames();
      gameStatusStrip.Invalidate(true);
    }

    /// <summary>
    /// update the names of the players on the number of wins displays
    /// </summary>
    private void UpdatePlayerWinsNames()
    {
      player1WinsToolStripStatusLabel.Text = string.Format("{0} wins: {1}", GamePlayers[0], GameRules.FirstPlayerWins);
      player2WinsToolStripStatusLabel.Text = string.Format("{0} wins: {1}", GamePlayers[1], GameRules.SecondPlayerWins);

      if (GameRules.FirstPlayerWins > GameRules.SecondPlayerWins)
      {
        player1WinsToolStripStatusLabel.ForeColor = Color.Green;
        player2WinsToolStripStatusLabel.ForeColor = Color.Red;
      }
      else
      {
        if (GameRules.FirstPlayerWins == GameRules.SecondPlayerWins)
        {
          player1WinsToolStripStatusLabel.ForeColor = player2WinsToolStripStatusLabel.ForeColor = Color.Black;
        }
        else
        {
          player1WinsToolStripStatusLabel.ForeColor = Color.Red;
          player2WinsToolStripStatusLabel.ForeColor = Color.Green;
        }
      }
    }

    /// <summary>
    /// update the state of the labels used for user board selections
    /// </summary>
    private void UpdatePlayerLabels()
    {
      Label boardLocation;
      foreach (Control control in TicTacToeLayoutPanel.Controls)
      {
        if (control is Label)
        {
          boardLocation = control as Label;
          boardLocation.ForeColor = boardLocation.Text == GamePlayersCharacters[0].Text ? GamePlayersCharacters[0].ForeColor : GamePlayersCharacters[1].ForeColor;
        }
      }
    }

    /// <summary>
    /// save the game
    /// </summary>
    private void SaveGame(bool saveAsEnabled)
    {
      // save the game in a separate thread
      Thread saveThread = new Thread(new ThreadStart(GameRules.SaveGameViaThread));

      using (SaveFileDialog dialog = new SaveFileDialog())
      {
        string fileName = string.Format("{0}{1}", Text, Text.Contains(".TicTacToe") ? string.Empty : ".TicTacToe");
        dialog.FileName = string.Format("{0}", fileName.Contains("*") ? fileName.Replace("*", string.Empty) : fileName);
        dialog.Filter = "TicTacToe Files|*.TicTacToe|All Files|*.*";
        dialog.Title = "Save TicTacToe Game";
        dialog.InitialDirectory = string.IsNullOrEmpty(GameRules.FileSaveDirectory) ? dialog.InitialDirectory : GameRules.FileSaveDirectory;

        if (saveAsEnabled)
        {
          if (dialog.ShowDialog() == DialogResult.OK)
          {
            MarkAsNotDirty();
            GameRules.FileSaveDirectory = Path.GetDirectoryName(dialog.FileName);
            Text = Path.GetFileName(dialog.FileName);
            GameRules.SavePath = dialog.FileName;

            saveThread.Start();
          }
        }
        else
        {
          MarkAsNotDirty();
          GameRules.SavePath = string.Format("{0}\\{1}", string.IsNullOrEmpty(GameRules.FileSaveDirectory) ? Directory.GetCurrentDirectory() : GameRules.FileSaveDirectory, Text);

          saveThread.Start();
        }

        gameTitleToolStripStatusLabel.Text = Text;
      }
    }

    /// <summary>
    /// mark the form as dirty because an edit has been made
    /// </summary>
    private void MarkAsDirty()
    {
      IsDirty = true;

      if (!Text.Contains("*"))
      {
        Text = string.Format("{0}*", Text);
        gameTitleToolStripStatusLabel.Text = Text;
      }
    }

    /// <summary>
    /// mark the form as not dirty (clean) because edits have been saved
    /// </summary>
    private void MarkAsNotDirty()
    {
      IsDirty = false;

      if (Text.Contains("*"))
      {
        Text = Text.Replace("*", string.Empty);
        gameTitleToolStripStatusLabel.Text = Text;
      }
    }

    /// <summary>
    /// handle the resizing of the form
    /// </summary>
    private void ResizeForm()
    {
      foreach (Label gameBoardLocation in GameBoardLocations)
      {
        gameBoardLocation.Font = new Font(gameBoardLocation.Font.FontFamily.Name, ((gameBoardLocation.Size.Width + gameBoardLocation.Size.Height) / 5));
      }
    }

    #endregion

    #region event handlers

    /// <summary>
    /// handle the click event for the tic tac toe location selection
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void UserSelection_Click(object sender, EventArgs e)
    {
      Label selectedLabel = sender as Label;

      selectedLabel.Font = new Font(selectedLabel.Font.FontFamily.Name, ((selectedLabel.Size.Width + selectedLabel.Size.Height) / 5));

      if (selectedLabel.Text == string.Empty)
      {
        if (ActivePlayer == Players.FirstPlayer)
        {
          selectedLabel.Text = GamePlayersCharacters[0].Text;
          selectedLabel.ForeColor = GamePlayersCharacters[0].ForeColor;
        }
        else if (ActivePlayer == Players.SecondPlayer)
        {
          selectedLabel.Text = GamePlayersCharacters[1].Text;
          selectedLabel.ForeColor = GamePlayersCharacters[1].ForeColor;
        }

        // 1 if game is won, 0 if game is tied, -1 if another move can be made
        int userSelectionResult = GameRules.TrackMove(Convert.ToInt32(selectedLabel.Tag), selectedLabel.Text, ActivePlayer);
        switch (userSelectionResult)
        {
          case 1:
            {
              if (MessageBox.Show(string.Format("{0} is the winner\r\n\r\nWould you like to play again?", ActivePlayer == Players.FirstPlayer ? GamePlayers[0] : GamePlayers[1]), "Winner", MessageBoxButtons.YesNo) == DialogResult.Yes)
              {
                ResetGame();
              }
              else
              {
                Close();
              }
            }
            break;

          case 0:
            {
              if (MessageBox.Show(string.Format("Tie Game\r\n\r\nWould you like to play again?"), "Tie Game", MessageBoxButtons.YesNo) == DialogResult.Yes)
              {
                ResetGame();
              }
              else
              {
                Close();
              }
            }
            break;
        }

        ActivePlayer = ActivePlayer == Players.FirstPlayer ? Players.SecondPlayer : Players.FirstPlayer;
        UpdateStatusLabel();
        MarkAsDirty();
      }
    }

    /// <summary>
    /// save the game status to a file
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
      // if the game is unsaved, allow the user to change the file name and location to save
      if (IsDirty)
      {
        SaveGame(false);
      }
    }

    /// <summary>
    /// save the game status to a file, allow user to change the game name as
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SaveGame(true);
    }

    /// <summary>
    /// dispose of the form
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void TicTacToeForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (IsDirty && MessageBox.Show(string.Format("Do you want to save \"{0}\"?", Text.Contains("*") ? Text.Replace("*", string.Empty) : Text), "Save Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        // if the game has been updated, allow the user to change the name of the file and the location to save
        SaveGame(true);
      }

      Dispose();
    }

    /// <summary>
    /// perform functionality after loading the form
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void TicTacToeForm_Load(object sender, EventArgs e)
    {
      gameStatusStrip.Parent = ParentForm;
      gameStatusStrip.Dock = DockStyle.Bottom;
      gameStatusStrip.Visible = true;

      ResizeForm();
    }

    /// <summary>
    /// toggle the view of the player's turn
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void playerTurnToolStripMenuItem_Click(object sender, EventArgs e)
    {
      playerTurnToolStripStatusLabel.Visible = !playerTurnToolStripStatusLabel.Visible;
    }

    /// <summary>
    /// perform actions when entering the form
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void TicTacToeForm_Enter(object sender, EventArgs e)
    {
      gameStatusStrip.Visible = true;
    }

    /// <summary>
    /// perform actions when leaving the form
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void TicTacToeForm_Leave(object sender, EventArgs e)
    {
      gameStatusStrip.Visible = false;
    }

    /// <summary>
    /// allow the user to change the names of players
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void changePlayersNameToolStripMenuItem_Click(object sender, EventArgs e)
    {
      using (ChangePlayersAttributes dialog = new ChangePlayersAttributes())
      {
        dialog.Text = "Change Players Names";
        dialog.InitializePlayersNames(GamePlayers);
        if (dialog.ShowDialog() == DialogResult.OK && MessageBox.Show(string.Format("Confirm the following: \r\n\r\n Rename {0} to {1} \r\n Rename {2} to {3}", GamePlayers[0], dialog.Player1Attributes, GamePlayers[1], dialog.Player2Attributes), "Confirm Name Change(s)", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
        {
          GamePlayers[0] = dialog.Player1Attributes;
          GamePlayers[1] = dialog.Player2Attributes;
          GameRules.GamePlayers = GamePlayers;
          UpdateStatusLabel();

          MarkAsDirty();
        }
      }
    }

    /// <summary>
    /// allow the user to change the characters used by each player
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void changePlayersCharactersToolStripMenuItem_Click(object sender, EventArgs e)
    {
      using (ChangePlayersAttributes dialog = new ChangePlayersAttributes())
      {
        dialog.Text = "Change Players Characters";
        dialog.InitializePlayersCharacters(GamePlayersCharacters);
        if (dialog.ShowDialog() == DialogResult.OK && MessageBox.Show(string.Format("Confirm the following: \r\n\r\n Rename {0} to {1} \r\n Rename {2} to {3}", GamePlayersCharacters[0].Text, dialog.Player1Attributes, GamePlayersCharacters[1].Text, dialog.Player2Attributes), "Confirm Character Change(s)", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
        {
          string oldPlayer1Character = GamePlayersCharacters[0].Text;
          string oldPlayer2Character = GamePlayersCharacters[1].Text;

          GameRules.Player1Character = dialog.Player1Attributes;
          GameRules.Player2Character = dialog.Player2Attributes;

          GamePlayersCharacters[0].Text = dialog.Player1Attributes;
          GamePlayersCharacters[1].Text = dialog.Player2Attributes;
          UpdateStatusLabel();

          List<string> boardLocationsCharacters = new List<string>();
          foreach (Label userSelectionLocation in GameBoardLocations)
          {
            userSelectionLocation.Text = userSelectionLocation.Text == oldPlayer1Character ? dialog.Player1Attributes : userSelectionLocation.Text == oldPlayer2Character ? dialog.Player2Attributes : userSelectionLocation.Text;
            boardLocationsCharacters.Add(userSelectionLocation.Text);
          }

          GameRules.UpdateExistingCharactersOnBoard(boardLocationsCharacters.ToArray());
          MarkAsDirty();
        }
      }
    }

    /// <summary>
    /// toggle the view of number of player wins
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void playerWinsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      player1WinsToolStripStatusLabel.Visible = !player1WinsToolStripStatusLabel.Visible;
      player2WinsToolStripStatusLabel.Visible = !player2WinsToolStripStatusLabel.Visible;
      playerWinsToolStripMenuItem.Checked = !playerWinsToolStripMenuItem.Checked;
    }

    /// <summary>
    /// allow the user to change the colors of the game
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void changeGameColorsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      using (ChangeGameColors dialog = new ChangeGameColors(GamePlayers, GamePlayersCharacters, GameBoardLocations.ToArray(), TicTacToeLayoutPanel.BackColor))
      {
        dialog.BoardBackgroundCustomColors = GameRules.BoardBackgroundCustomColors;
        dialog.BoardSelectableLocationsCustomColors = GameRules.BoardSelectableLocationsCustomColors;
        dialog.Player1CharacterCustomColors = GameRules.Player1CharacterCustomColors;
        dialog.Player2CharacterCustomColors = GameRules.Player2CharacterCustomColors;

        if (dialog.ShowDialog() == DialogResult.OK)
        {
          TicTacToeLayoutPanel.BackColor = dialog.BoardBackgroundColor;

          foreach (Control control in TicTacToeLayoutPanel.Controls)
          {
            if (control is Label)
            {
              (control as Label).BackColor = dialog.BoardSelectionLocationsColor;
            }
          }

          GamePlayersCharacters[0].ForeColor = dialog.Player1CharacterColor;
          GamePlayersCharacters[1].ForeColor = dialog.Player2CharacterColor;

          UpdatePlayerLabels();
          GameRules.StoreColorsState(TicTacToeLayoutPanel.BackColor, GameBoardLocations[0].BackColor, GamePlayersCharacters[0].ForeColor, GamePlayersCharacters[1].ForeColor, dialog.BoardBackgroundCustomColors, dialog.BoardSelectableLocationsCustomColors, dialog.Player1CharacterCustomColors, dialog.Player2CharacterCustomColors);
          MarkAsDirty();
        }
      }
    }

    /// <summary>
    /// undo the last move made
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void undoLastMoveToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int lastMoveLocation = GameRules.UndoLastMove();

      foreach (Label userSelectionLocation in GameBoardLocations)
      {
        if (Convert.ToInt32(userSelectionLocation.Tag) == lastMoveLocation)
        {
          userSelectionLocation.Text = string.Empty;
          userSelectionLocation.ForeColor = SystemColors.ControlText;
        }
      }

      ActivePlayer = ActivePlayer == Players.FirstPlayer ? Players.SecondPlayer : Players.FirstPlayer;
      UpdateStatusLabel();
    }

    /// <summary>
    /// allow the size of the board to be set
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void setBoardSizeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Resetting the game board size will clear the current selections on the game board. Do you still want to resize the game board?", "Resize Game Board", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        using (SetBoardSize dialog = new SetBoardSize(GameBoardLocations.Count, TicTacToeLayoutPanel.BackColor, GameBoardLocations[0].BackColor))
        {
          if (dialog.ShowDialog() == DialogResult.OK)
          {
            if (Controls.Contains(TicTacToeLayoutPanel))
            {
              Controls.Remove(TicTacToeLayoutPanel);
            }

            GameRules.UpdateBoardLocationSize(dialog.BoardSize);
            SetGridPanelLayout(dialog.BoardSize);
          }
        }
      }
    }

    /// <summary>
    /// when handling the form resize event, resize the font indicating user selections as well
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void TicTacToeForm_Resize(object sender, EventArgs e)
    {
      ResizeForm();
    }

    #endregion
  }
}
