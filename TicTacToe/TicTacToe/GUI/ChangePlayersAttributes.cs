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
  public partial class ChangePlayersAttributes : Form
  {
    #region member variables
    #endregion

    #region properties

    /// <summary>
    /// track the players within the game
    /// </summary>
    private string[] GamePlayersNames
    {
      get;
      set;
    }

    /// <summary>
    /// tracks the characters used by each player within the game
    /// </summary>
    private Label[] GamePlayersCharacters
    {
      get;
      set;
    }

    /// <summary>
    /// get the player 1 name
    /// </summary>
    public string Player1Attributes
    {
      get { return newAttributePlayer1Change.Text; }
    }

    /// <summary>
    /// get the player 2 name
    /// </summary>
    public string Player2Attributes
    {
      get { return newAttributePlayer2Change.Text; }
    }

    #endregion

    #region construction / destruction

    /// <summary>
    /// construct a new ChangePlayersNames form
    /// </summary>
    public ChangePlayersAttributes()
    {
      InitializeComponent();
    }

    #endregion

    #region methods

    /// <summary>
    /// initialize the state of the players names
    /// </summary>
    /// <param name="gamePlayersNames">the names used by each player</param>
    public void InitializePlayersNames(string[] gamePlayersNames)
    {
      GamePlayersNames = new string[2];
      GamePlayersNames = gamePlayersNames;
 
      oldAttributePlayer1.Text = GamePlayersNames[0];
      oldAttributePlayer2.Text = GamePlayersNames[1];

      newAttributePlayer1Change.Text = GamePlayersNames[0];
      newAttributePlayer2Change.Text = GamePlayersNames[1];
    }

    /// <summary>
    /// initialize the state of the playerrs characters displayed
    /// </summary>
    /// <param name="gamePlayersCharacters">the characters used by each player</param>
    public void InitializePlayersCharacters(Label[] gamePlayersCharacters)
    {
      GamePlayersCharacters = new Label[2];
      GamePlayersCharacters = gamePlayersCharacters;

      oldAttributeTitle.Text = "Old Character";
      newAttributeTitle.Text = "New Character";

      oldAttributePlayer1.Text = GamePlayersCharacters[0].Text;
      oldAttributePlayer2.Text = GamePlayersCharacters[1].Text;

      newAttributePlayer1Change.Text = GamePlayersCharacters[0].Text;
      newAttributePlayer2Change.Text = GamePlayersCharacters[1].Text;
    }

    /// <summary>
    /// validate the new character entered by the user so 1 character has been entered
    /// </summary>
    /// <param name="textboxToValidate"></param>
    private void ValidateNewCharacterEntry(TextBox textboxToValidate)
    {
      okBtn.Enabled = true;
      errorProvider.Clear();
      if (string.IsNullOrEmpty(textboxToValidate.Text) || (textboxToValidate.Text.Length > 1))
      {
        errorProvider.SetError(textboxToValidate, "Please enter a value 1 character long");
        errorProvider.SetIconAlignment(textboxToValidate, ErrorIconAlignment.MiddleLeft);
        textboxToValidate.Focus();
        okBtn.Enabled = false;
      }
    }

    #endregion

    #region event handlers

    /// <summary>
    /// validate the character entered by the user
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void newAttributePlayer1Change_Leave(object sender, EventArgs e)
    {
      if (GamePlayersCharacters != null)
      {
        ValidateNewCharacterEntry(newAttributePlayer1Change);
      }
    }

    /// <summary>
    /// validate the character entered by the user
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void newAttributePlayer2Change_Leave(object sender, EventArgs e)
    {
      if (GamePlayersCharacters != null)
      {
        ValidateNewCharacterEntry(newAttributePlayer2Change);
      }
    }

    #endregion
  }
}
