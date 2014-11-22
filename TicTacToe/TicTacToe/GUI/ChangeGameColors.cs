using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe.GUI
{
  public partial class ChangeGameColors : Form
  {
    #region member variables

    /// <summary>
    /// store the game board displayed to the user
    /// </summary>
    private TableLayoutPanel _boardColorPreviewTableLayoutPanel;

    #endregion

    #region properties

    /// <summary>
    /// gets the game board background color
    /// </summary>
    public Color BoardBackgroundColor
    {
      get { return _boardColorPreviewTableLayoutPanel.BackColor; }
    }

    /// <summary>
    /// gets/set the values identifying the custom colors of the board background selected by the user
    /// </summary>
    public int[] BoardBackgroundCustomColors
    {
      get;
      set;
    }

    /// <summary>
    /// gets the board selection location color
    /// </summary>
    public Color BoardSelectionLocationsColor
    {
      get { return _boardColorPreviewTableLayoutPanel.Controls[0].BackColor; }
    }

    /// <summary>
    /// gets/sets the values identifying the custom colors selected by the user for the selectable locations on the board grid
    /// </summary>
    public int[] BoardSelectableLocationsCustomColors
    {
      get;
      set;
    }

    /// <summary>
    /// gets the player 1 character color
    /// </summary>
    public Color Player1CharacterColor
    {
      get;
      set;
    }

    /// <summary>
    /// gets/sets the values identifying the custom colors applicable to the player 1 character
    /// </summary>
    public int[] Player1CharacterCustomColors
    {
      get;
      set;
    }

    /// <summary>
    /// gets the player 2 character color
    /// </summary>
    public Color Player2CharacterColor
    {
      get;
      set;
    }

    /// <summary>
    /// gets/sets the values identifying the custom colors applicable to the player 2 character
    /// </summary>
    public int[] Player2CharacterCustomColors
    {
      get;
      set;
    }

    /// <summary>
    /// gets/sets the character labels used during gameplay
    /// </summary>
    public Label[] GamePlayerCharacters
    {
      get;
      set;
    }

    /// <summary>
    /// gets/sets the player moves
    /// </summary>
    public Label[] GamePlayerMoves
    {
      get;
      set;
    }

    #endregion

    #region construction / destruction

    /// <summary>
    /// construct a new ChangeGameColors object
    /// </summary>
    private ChangeGameColors()
    {
      InitializeComponent();
    }

    /// <summary>
    /// display the colors passed in from the game board layout grid
    /// </summary>
    /// <param name="gamePlayers">array of players associated with the game</param>
    /// <param name="gamePlayerCharacters">array of labels identifying user moves within the game</param>
    /// <param name="gamePlayerMoves">moves made by the players</param>
    public ChangeGameColors(string[] gamePlayers, Label[] gamePlayerCharacters, Label[] gamePlayerMoves, Color boardBackgroundColor)
      : this()
    {
      player1CharacterColorBtn.Text = string.Format("Change {0}'s Character (\"{1}\") Color", gamePlayers[0], gamePlayerCharacters[0].Text);
      player2CharacterColorBtn.Text = string.Format("Change {0}'s Character (\"{1}\") Color", gamePlayers[1], gamePlayerCharacters[1].Text);
      GamePlayerCharacters = gamePlayerCharacters;
      GamePlayerMoves = gamePlayerMoves;
      Player1CharacterColor = gamePlayerCharacters[0].ForeColor;
      Player2CharacterColor = gamePlayerCharacters[1].ForeColor;
      SetGameBoard(gamePlayerMoves.Length, boardBackgroundColor);
    }

    #endregion

    #region methods

    /// <summary>
    /// set up the game board preview
    /// </summary>
    /// <param name="boardSize">number of rows and columns on the game board</param>
    private void SetGameBoard(int boardSize, Color boardBackgroundColor)
    {
      _boardColorPreviewTableLayoutPanel = new TableLayoutPanel();

      // build the game board
      _boardColorPreviewTableLayoutPanel.Controls.Clear();
      _boardColorPreviewTableLayoutPanel.RowStyles.Clear();
      _boardColorPreviewTableLayoutPanel.ColumnStyles.Clear();
      _boardColorPreviewTableLayoutPanel.Dock = DockStyle.Fill;
      _boardColorPreviewTableLayoutPanel.SuspendLayout();

      Label selectableBoardLocation;

      int rowColumnCount = Convert.ToInt32(Math.Sqrt(boardSize * 1.0));
      _boardColorPreviewTableLayoutPanel.ColumnCount = rowColumnCount;
      _boardColorPreviewTableLayoutPanel.RowCount = rowColumnCount;
      _boardColorPreviewTableLayoutPanel.BackColor = boardBackgroundColor; 

      for (int rowsColumnCount = 0; rowsColumnCount < boardSize; rowsColumnCount++)
      {
        _boardColorPreviewTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
        _boardColorPreviewTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
      }

      int locationCount = 0;

      for (int rowCount = 0; rowCount < rowColumnCount; rowCount++)
      {
        for (int columnCount = 0; columnCount < rowColumnCount; columnCount++)
        {
          selectableBoardLocation = new Label();
          _boardColorPreviewTableLayoutPanel.Controls.Add(selectableBoardLocation, columnCount, rowCount);

          selectableBoardLocation.BackColor = GamePlayerMoves[locationCount].BackColor;
          selectableBoardLocation.Dock = DockStyle.Fill;
          selectableBoardLocation.Margin = new System.Windows.Forms.Padding(3);
          selectableBoardLocation.Text = GamePlayerMoves[locationCount].Text;
          selectableBoardLocation.Font = new Font(GamePlayerMoves[locationCount].Font.FontFamily.Name, ((selectableBoardLocation.Size.Width + selectableBoardLocation.Size.Height) / 5));
          selectableBoardLocation.ForeColor = GamePlayerMoves[locationCount].ForeColor;
          selectableBoardLocation.TextAlign = ContentAlignment.MiddleCenter;
          selectableBoardLocation.AutoSize = true;
          selectableBoardLocation.Click += boardColorPreview_Click;

          locationCount++;
        }
      }

      _boardColorPreviewTableLayoutPanel.ResumeLayout();
      changeColorsTableLayoutPanel.Controls.Add(_boardColorPreviewTableLayoutPanel, 0, 4);
      changeColorsTableLayoutPanel.SetColumnSpan(_boardColorPreviewTableLayoutPanel, 3);
    }

    #endregion

    #region event handlers

    /// <summary>
    /// allow custom color choice for the grid cells
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void cellColorPreviewBtn_Click(object sender, EventArgs e)
    {
      using (ColorDialog dialog = new ColorDialog())
      {
        dialog.CustomColors = BoardSelectableLocationsCustomColors;

        if (dialog.ShowDialog() == DialogResult.OK)
        {
          BoardSelectableLocationsCustomColors = dialog.CustomColors;
          foreach (Control control in _boardColorPreviewTableLayoutPanel.Controls)
          {
            if (control is Label)
            {
              (control as Label).BackColor = dialog.Color;
            }
          }
        }
      }
    }

    /// <summary>
    /// allow custom background color choice
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void backgroundColorPreviewBtn_Click(object sender, EventArgs e)
    {
      using (ColorDialog dialog = new ColorDialog())
      {
        dialog.CustomColors = BoardBackgroundCustomColors;

        if (dialog.ShowDialog() == DialogResult.OK)
        {
          _boardColorPreviewTableLayoutPanel.BackColor = dialog.Color;
          BoardBackgroundCustomColors = dialog.CustomColors;
        }
      }
    }

    /// <summary>
    /// allow custom color for player 1 character
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void player1CharacterColorBtn_Click(object sender, EventArgs e)
    {
      using (ColorDialog dialog = new ColorDialog())
      {
        dialog.CustomColors = Player1CharacterCustomColors;

        if (dialog.ShowDialog() == DialogResult.OK)
        {
         Player1CharacterColor = dialog.Color;
         Player1CharacterCustomColors = dialog.CustomColors;

         foreach (Control control in _boardColorPreviewTableLayoutPanel.Controls)
         {
           if (control is Label)
           {
             Label boardLabel = control as Label;
             boardLabel.ForeColor = boardLabel.Text == GamePlayerCharacters[0].Text ? dialog.Color : boardLabel.ForeColor;
           }
         }
        }
      }
    }

    /// <summary>
    /// allow custom color for player 2 character
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void player2CharacterColorBtn_Click(object sender, EventArgs e)
    {
      using (ColorDialog dialog = new ColorDialog())
      {
        dialog.CustomColors = Player2CharacterCustomColors;

        if (dialog.ShowDialog() == DialogResult.OK)
        {
          Player2CharacterColor = dialog.Color;
          Player2CharacterCustomColors = dialog.CustomColors;

          foreach (Control control in _boardColorPreviewTableLayoutPanel.Controls)
          {
            if (control is Label)
            {
              Label boardLabel = control as Label;
              boardLabel.ForeColor = boardLabel.Text == GamePlayerCharacters[1].Text ? dialog.Color : boardLabel.ForeColor;
            }
          }
        }
      }
    }

    /// <summary>
    /// notify users this is a preview grid if anyone clicks
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void boardColorPreview_Click(object sender, EventArgs e)
    {
      MessageBox.Show("This board is a preview of the colors selected.\r\n\r\nSelect colors by using the button above the preview grid and click OK to apply.\r\nTo cancel applying selected colors, click Cancel.", "Preview Grid", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    /// <summary>
    /// resize the font indicating user moves by updating the font size when the user resizes the form window
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ChangeGameColors_Resize(object sender, EventArgs e)
    {
      Label gameBoardLocation;

      foreach (Control control in _boardColorPreviewTableLayoutPanel.Controls)
      {
        if (control is Label)
        {
          gameBoardLocation = control as Label;
          gameBoardLocation.Font = new Font(gameBoardLocation.Font.FontFamily.Name, ((gameBoardLocation.Size.Width + gameBoardLocation.Size.Height) / 5));
        }
      }
    }

    #endregion
  }
}
