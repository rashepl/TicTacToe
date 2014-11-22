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
  public partial class SetBoardSize : Form
  {
    #region member variables

    /// <summary>
    /// track the preview board
    /// </summary>
    private TableLayoutPanel _previewBoardSizeTableLayoutPanel;

    /// <summary>
    /// store the color of the background of the game board
    /// </summary>
    private Color _boardBackgroundColor;

    /// <summary>
    /// store the color of the game board selectable locations
    /// </summary>
    private Color _selectableLocationColor;

    #endregion

    #region properties

    /// <summary>
    /// track the size of the game board
    /// </summary>
    public int BoardSize
    {
      get;
      set;
    }

    #endregion

    #region construction / destruction

    /// <summary>
    /// construct the class
    /// </summary>
    private SetBoardSize()
    {
      InitializeComponent();
      _previewBoardSizeTableLayoutPanel = new TableLayoutPanel();
      _previewBoardSizeTableLayoutPanel.BackColor = Color.DodgerBlue;
      _previewBoardSizeTableLayoutPanel.Click += previewBoardSizeTableLayoutPanel_Click;
    }

    /// <summary>
    /// construct the class with the provided TableLayoutPanel depicting the current state of the grid
    /// </summary>
    /// <param name="size">size of the game board</param>
    public SetBoardSize(int size, Color boardBackgroundColor, Color selectableLocationColor)
    : this()
    {
      _boardBackgroundColor = boardBackgroundColor;
      _selectableLocationColor = selectableLocationColor;
      boardSize.Text =  Convert.ToInt32(Math.Sqrt(size * 1.0)).ToString();
      SetBoardPreviewSize();
    }

    #endregion

    #region methods

    /// <summary>
    /// set the size of the board based upon input from the user
    /// </summary>
    private void SetBoardPreviewSize()
    {
      // do not allow non-numeric data to be accepted into this textbox
      int sizeSelected = 0;
      if (int.TryParse(boardSize.Text, out sizeSelected))
      {
        _previewBoardSizeTableLayoutPanel.BackColor = _boardBackgroundColor;

        // build the game board
        for (int controlIndex = 0; controlIndex < _previewBoardSizeTableLayoutPanel.Controls.Count; controlIndex++)
        {
          _previewBoardSizeTableLayoutPanel.Controls[controlIndex].Click -= previewBoardSizeTableLayoutPanel_Click;
        }

        _previewBoardSizeTableLayoutPanel.Controls.Clear();
        _previewBoardSizeTableLayoutPanel.RowStyles.Clear();
        _previewBoardSizeTableLayoutPanel.ColumnStyles.Clear();

        setBoardSizeTableLayoutPanel.Controls.Add(_previewBoardSizeTableLayoutPanel, 0, 1);
        setBoardSizeTableLayoutPanel.SetColumnSpan(_previewBoardSizeTableLayoutPanel, 4);
        _previewBoardSizeTableLayoutPanel.Dock = DockStyle.Fill;

        SuspendLayout();
        _previewBoardSizeTableLayoutPanel.SuspendLayout();

        sizeSelected = Convert.ToInt32(boardSize.Text);
        Label selectableBoardLocation;

        _previewBoardSizeTableLayoutPanel.ColumnCount = sizeSelected;
        _previewBoardSizeTableLayoutPanel.RowCount = sizeSelected;

        for (int rowsColumnCount = 0; rowsColumnCount < sizeSelected; rowsColumnCount++)
        {
          _previewBoardSizeTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
          _previewBoardSizeTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
        }

        int locationCount = 0;

        for (int rowCount = 0; rowCount < sizeSelected; rowCount++)
        {
          for (int columnCount = 0; columnCount < sizeSelected; columnCount++)
          {
            selectableBoardLocation = new Label();
            selectableBoardLocation.BackColor = _selectableLocationColor;
            selectableBoardLocation.Text = string.Empty;
            _previewBoardSizeTableLayoutPanel.Controls.Add(selectableBoardLocation, columnCount, rowCount);
            selectableBoardLocation.Dock = DockStyle.Fill;
            selectableBoardLocation.Margin = new System.Windows.Forms.Padding(3);
            selectableBoardLocation.TextAlign = ContentAlignment.MiddleCenter;
            selectableBoardLocation.AutoSize = true;
            selectableBoardLocation.Click += previewBoardSizeTableLayoutPanel_Click;

            locationCount++;
          }
        }

        _previewBoardSizeTableLayoutPanel.ResumeLayout();
        ResumeLayout(false);

        BoardSize = sizeSelected;
        displayCurrentBoardSizeLabel.Text = string.Format("The current grid size is: {0} X {0}", sizeSelected);
      }
      else
      {
        MessageBox.Show("Please enter a number for the board size", "Please Enter Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
    }

    #endregion

    #region event handlers

    /// <summary>
    /// handle the leave event and perform an update of the preview grid
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void boardSize_Leave(object sender, EventArgs e)
    {
      SetBoardPreviewSize();
    }

    /// <summary>
    /// let the user know the preview grid is read only
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void previewBoardSizeTableLayoutPanel_Click(object sender, EventArgs e)
    {
      MessageBox.Show("This board is a preview of the grid size selected.\r\n\r\n Update the size of the grid by entering a number in the textbox above the grid.", "Preview Grid", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    #endregion
  }
}
