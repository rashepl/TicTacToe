namespace TicTacToe.GUI
{
  partial class SetBoardSize
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        _previewBoardSizeTableLayoutPanel.Click -= previewBoardSizeTableLayoutPanel_Click;
        _previewBoardSizeTableLayoutPanel.Dispose();
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.setBoardSizeTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
      this.boardSize = new System.Windows.Forms.TextBox();
      this.notifyBoardSizeToEnter = new System.Windows.Forms.Label();
      this.okButton = new System.Windows.Forms.Button();
      this.cancelButton = new System.Windows.Forms.Button();
      this.displayCurrentBoardSizeLabel = new System.Windows.Forms.Label();
      this.setBoardSizeTableLayoutPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // setBoardSizeTableLayoutPanel
      // 
      this.setBoardSizeTableLayoutPanel.ColumnCount = 4;
      this.setBoardSizeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.setBoardSizeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.setBoardSizeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.setBoardSizeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.setBoardSizeTableLayoutPanel.Controls.Add(this.boardSize, 1, 0);
      this.setBoardSizeTableLayoutPanel.Controls.Add(this.notifyBoardSizeToEnter, 0, 0);
      this.setBoardSizeTableLayoutPanel.Controls.Add(this.okButton, 2, 2);
      this.setBoardSizeTableLayoutPanel.Controls.Add(this.cancelButton, 3, 2);
      this.setBoardSizeTableLayoutPanel.Controls.Add(this.displayCurrentBoardSizeLabel, 2, 0);
      this.setBoardSizeTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.setBoardSizeTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
      this.setBoardSizeTableLayoutPanel.Name = "setBoardSizeTableLayoutPanel";
      this.setBoardSizeTableLayoutPanel.RowCount = 3;
      this.setBoardSizeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.setBoardSizeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.setBoardSizeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.setBoardSizeTableLayoutPanel.Size = new System.Drawing.Size(528, 328);
      this.setBoardSizeTableLayoutPanel.TabIndex = 0;
      // 
      // boardSize
      // 
      this.boardSize.Dock = System.Windows.Forms.DockStyle.Fill;
      this.boardSize.Location = new System.Drawing.Point(307, 3);
      this.boardSize.Name = "boardSize";
      this.boardSize.Size = new System.Drawing.Size(32, 20);
      this.boardSize.TabIndex = 0;
      this.boardSize.Text = "3";
      this.boardSize.Leave += new System.EventHandler(this.boardSize_Leave);
      // 
      // notifyBoardSizeToEnter
      // 
      this.notifyBoardSizeToEnter.AutoSize = true;
      this.notifyBoardSizeToEnter.Dock = System.Windows.Forms.DockStyle.Fill;
      this.notifyBoardSizeToEnter.Location = new System.Drawing.Point(3, 0);
      this.notifyBoardSizeToEnter.Name = "notifyBoardSizeToEnter";
      this.notifyBoardSizeToEnter.Size = new System.Drawing.Size(298, 25);
      this.notifyBoardSizeToEnter.TabIndex = 1;
      this.notifyBoardSizeToEnter.Text = "Please enter the number of rows/columns on the game board:";
      this.notifyBoardSizeToEnter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // okButton
      // 
      this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.okButton.Dock = System.Windows.Forms.DockStyle.Right;
      this.okButton.Location = new System.Drawing.Point(369, 302);
      this.okButton.Name = "okButton";
      this.okButton.Size = new System.Drawing.Size(75, 23);
      this.okButton.TabIndex = 4;
      this.okButton.Text = "OK";
      this.okButton.UseVisualStyleBackColor = true;
      // 
      // cancelButton
      // 
      this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cancelButton.Dock = System.Windows.Forms.DockStyle.Right;
      this.cancelButton.Location = new System.Drawing.Point(450, 302);
      this.cancelButton.Name = "cancelButton";
      this.cancelButton.Size = new System.Drawing.Size(75, 23);
      this.cancelButton.TabIndex = 5;
      this.cancelButton.Text = "Cancel";
      this.cancelButton.UseVisualStyleBackColor = true;
      // 
      // displayCurrentBoardSizeLabel
      // 
      this.displayCurrentBoardSizeLabel.AutoSize = true;
      this.setBoardSizeTableLayoutPanel.SetColumnSpan(this.displayCurrentBoardSizeLabel, 2);
      this.displayCurrentBoardSizeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.displayCurrentBoardSizeLabel.Location = new System.Drawing.Point(345, 0);
      this.displayCurrentBoardSizeLabel.Name = "displayCurrentBoardSizeLabel";
      this.displayCurrentBoardSizeLabel.Size = new System.Drawing.Size(180, 25);
      this.displayCurrentBoardSizeLabel.TabIndex = 6;
      this.displayCurrentBoardSizeLabel.Text = "The current grid size is:";
      this.displayCurrentBoardSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // SetBoardSize
      // 
      this.AcceptButton = this.okButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.cancelButton;
      this.ClientSize = new System.Drawing.Size(528, 328);
      this.Controls.Add(this.setBoardSizeTableLayoutPanel);
      this.MinimumSize = new System.Drawing.Size(525, 300);
      this.Name = "SetBoardSize";
      this.Text = "Set Board Size";
      this.setBoardSizeTableLayoutPanel.ResumeLayout(false);
      this.setBoardSizeTableLayoutPanel.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel setBoardSizeTableLayoutPanel;
    private System.Windows.Forms.TextBox boardSize;
    private System.Windows.Forms.Label notifyBoardSizeToEnter;
    private System.Windows.Forms.Button okButton;
    private System.Windows.Forms.Button cancelButton;
    private System.Windows.Forms.Label displayCurrentBoardSizeLabel;
  }
}