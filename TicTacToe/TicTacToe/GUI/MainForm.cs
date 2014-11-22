using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe.GUI
{
  public partial class MainForm : Form
  {
    #region member variables

    /// <summary>
    /// the game object
    /// </summary>
    TicTacToeForm ticTacToeForm;

    #endregion

    #region properties
    #endregion

    #region construction / destruction

    /// <summary>
    /// create a new mainform
    /// </summary>
    public MainForm()
    {
      InitializeComponent();

      automaticallyCreateANewGameOnStartupToolStripMenuItem.Checked = Properties.Settings.Default.CreateNewGameUponStartup;
      if (Properties.Settings.Default.CreateNewGameUponStartup)
      {
        CreateNewGame();
      }
    }

    #endregion

    #region methods

    /// <summary>
    /// create a new tictactoe game
    /// </summary>
    private void CreateNewGame()
    {
      ticTacToeForm = new TicTacToeForm();
      ticTacToeForm.MdiParent = this;
      ticTacToeForm.Show();
    }

    #endregion

    #region event handlers

    /// <summary>
    /// create a new tictactoe game
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
    {
      CreateNewGame();
    }

    /// <summary>
    /// open an existing tictactoe game
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void openGameToolStripMenuItem_Click(object sender, EventArgs e)
    {
      using (OpenFileDialog dialog = new OpenFileDialog())
      {
        dialog.InitialDirectory = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
        if (dialog.ShowDialog() == DialogResult.OK && dialog.CheckPathExists)
        {
          ticTacToeForm = new TicTacToeForm(dialog.FileName);
          ticTacToeForm.Text = Path.GetFileName(dialog.FileName);
          ticTacToeForm.MdiParent = this;
          ticTacToeForm.Show();
        }
      }
    }

    /// <summary>
    /// exit the tictactoe game
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Close();
    }

    /// <summary>
    /// toggle the ability for a new game to automatically open upon startup
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void automaticallyCreateANewGameOnStartupToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Properties.Settings.Default.CreateNewGameUponStartup = !Properties.Settings.Default.CreateNewGameUponStartup;
    }

    /// <summary>
    /// perform actions while closing the form
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      Properties.Settings.Default.Save();
    }

    #endregion
  }
}
