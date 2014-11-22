namespace TicTacToe.GUI
{
    partial class TicTacToeForm
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
                components.Dispose();
                GamePlayersCharacters[0].Dispose();
                GamePlayersCharacters[1].Dispose();
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
      this.ticTacToeMenuStrip = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.changePlayersNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.changePlayersCharactersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.changeGameColorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.undoLastMoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.setBoardSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.playerTurnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.playerWinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.gameStatusStrip = new System.Windows.Forms.StatusStrip();
      this.playerTurnToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.gameTitleToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.player1WinsToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.player2WinsToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.ticTacToeMenuStrip.SuspendLayout();
      this.gameStatusStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // ticTacToeMenuStrip
      // 
      this.ticTacToeMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
      this.ticTacToeMenuStrip.Location = new System.Drawing.Point(0, 0);
      this.ticTacToeMenuStrip.Name = "ticTacToeMenuStrip";
      this.ticTacToeMenuStrip.Size = new System.Drawing.Size(467, 24);
      this.ticTacToeMenuStrip.TabIndex = 1;
      this.ticTacToeMenuStrip.Text = "menuStrip1";
      this.ticTacToeMenuStrip.Visible = false;
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveGameToolStripMenuItem,
            this.saveAsToolStripMenuItem});
      this.fileToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "&File";
      // 
      // saveGameToolStripMenuItem
      // 
      this.saveGameToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
      this.saveGameToolStripMenuItem.MergeIndex = 2;
      this.saveGameToolStripMenuItem.Name = "saveGameToolStripMenuItem";
      this.saveGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      this.saveGameToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
      this.saveGameToolStripMenuItem.Text = "&Save";
      this.saveGameToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
      // 
      // saveAsToolStripMenuItem
      // 
      this.saveAsToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
      this.saveAsToolStripMenuItem.MergeIndex = 3;
      this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
      this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
      this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
      this.saveAsToolStripMenuItem.Text = "Save &As";
      this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
      // 
      // editToolStripMenuItem
      // 
      this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePlayersNameToolStripMenuItem,
            this.changePlayersCharactersToolStripMenuItem,
            this.changeGameColorsToolStripMenuItem,
            this.undoLastMoveToolStripMenuItem,
            this.setBoardSizeToolStripMenuItem});
      this.editToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
      this.editToolStripMenuItem.MergeIndex = 1;
      this.editToolStripMenuItem.Name = "editToolStripMenuItem";
      this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
      this.editToolStripMenuItem.Text = "&Edit";
      // 
      // changePlayersNameToolStripMenuItem
      // 
      this.changePlayersNameToolStripMenuItem.Name = "changePlayersNameToolStripMenuItem";
      this.changePlayersNameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
      this.changePlayersNameToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
      this.changePlayersNameToolStripMenuItem.Text = "Change Players &Name";
      this.changePlayersNameToolStripMenuItem.Click += new System.EventHandler(this.changePlayersNameToolStripMenuItem_Click);
      // 
      // changePlayersCharactersToolStripMenuItem
      // 
      this.changePlayersCharactersToolStripMenuItem.Name = "changePlayersCharactersToolStripMenuItem";
      this.changePlayersCharactersToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
      this.changePlayersCharactersToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
      this.changePlayersCharactersToolStripMenuItem.Text = "Change Players C&haracters";
      this.changePlayersCharactersToolStripMenuItem.Click += new System.EventHandler(this.changePlayersCharactersToolStripMenuItem_Click);
      // 
      // changeGameColorsToolStripMenuItem
      // 
      this.changeGameColorsToolStripMenuItem.Name = "changeGameColorsToolStripMenuItem";
      this.changeGameColorsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
      this.changeGameColorsToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
      this.changeGameColorsToolStripMenuItem.Text = "Change Game &Colors";
      this.changeGameColorsToolStripMenuItem.Click += new System.EventHandler(this.changeGameColorsToolStripMenuItem_Click);
      // 
      // undoLastMoveToolStripMenuItem
      // 
      this.undoLastMoveToolStripMenuItem.Name = "undoLastMoveToolStripMenuItem";
      this.undoLastMoveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
      this.undoLastMoveToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
      this.undoLastMoveToolStripMenuItem.Text = "&Undo Last Move";
      this.undoLastMoveToolStripMenuItem.Click += new System.EventHandler(this.undoLastMoveToolStripMenuItem_Click);
      // 
      // setBoardSizeToolStripMenuItem
      // 
      this.setBoardSizeToolStripMenuItem.Name = "setBoardSizeToolStripMenuItem";
      this.setBoardSizeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
      this.setBoardSizeToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
      this.setBoardSizeToolStripMenuItem.Text = "Set &Board Size";
      this.setBoardSizeToolStripMenuItem.Click += new System.EventHandler(this.setBoardSizeToolStripMenuItem_Click);
      // 
      // viewToolStripMenuItem
      // 
      this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerTurnToolStripMenuItem,
            this.playerWinsToolStripMenuItem});
      this.viewToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Replace;
      this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
      this.viewToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
      this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
      this.viewToolStripMenuItem.Text = "&View";
      // 
      // playerTurnToolStripMenuItem
      // 
      this.playerTurnToolStripMenuItem.Checked = true;
      this.playerTurnToolStripMenuItem.CheckOnClick = true;
      this.playerTurnToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
      this.playerTurnToolStripMenuItem.Name = "playerTurnToolStripMenuItem";
      this.playerTurnToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
      this.playerTurnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.playerTurnToolStripMenuItem.Text = "Player &Turn";
      this.playerTurnToolStripMenuItem.Click += new System.EventHandler(this.playerTurnToolStripMenuItem_Click);
      // 
      // playerWinsToolStripMenuItem
      // 
      this.playerWinsToolStripMenuItem.Checked = true;
      this.playerWinsToolStripMenuItem.CheckOnClick = true;
      this.playerWinsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
      this.playerWinsToolStripMenuItem.Name = "playerWinsToolStripMenuItem";
      this.playerWinsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
      this.playerWinsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.playerWinsToolStripMenuItem.Text = "Player &Wins";
      this.playerWinsToolStripMenuItem.Click += new System.EventHandler(this.playerWinsToolStripMenuItem_Click);
      // 
      // gameStatusStrip
      // 
      this.gameStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerTurnToolStripStatusLabel,
            this.gameTitleToolStripStatusLabel,
            this.player1WinsToolStripStatusLabel,
            this.player2WinsToolStripStatusLabel});
      this.gameStatusStrip.Location = new System.Drawing.Point(0, 252);
      this.gameStatusStrip.Name = "gameStatusStrip";
      this.gameStatusStrip.Size = new System.Drawing.Size(467, 24);
      this.gameStatusStrip.TabIndex = 3;
      this.gameStatusStrip.Text = "statusStrip1";
      this.gameStatusStrip.Visible = false;
      // 
      // playerTurnToolStripStatusLabel
      // 
      this.playerTurnToolStripStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
      this.playerTurnToolStripStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
      this.playerTurnToolStripStatusLabel.Name = "playerTurnToolStripStatusLabel";
      this.playerTurnToolStripStatusLabel.Size = new System.Drawing.Size(65, 19);
      this.playerTurnToolStripStatusLabel.Text = "Player 1: X";
      // 
      // gameTitleToolStripStatusLabel
      // 
      this.gameTitleToolStripStatusLabel.Name = "gameTitleToolStripStatusLabel";
      this.gameTitleToolStripStatusLabel.Size = new System.Drawing.Size(219, 19);
      this.gameTitleToolStripStatusLabel.Spring = true;
      this.gameTitleToolStripStatusLabel.Text = "Unsaved Game";
      // 
      // player1WinsToolStripStatusLabel
      // 
      this.player1WinsToolStripStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
      this.player1WinsToolStripStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
      this.player1WinsToolStripStatusLabel.ForeColor = System.Drawing.SystemColors.ControlText;
      this.player1WinsToolStripStatusLabel.Name = "player1WinsToolStripStatusLabel";
      this.player1WinsToolStripStatusLabel.Size = new System.Drawing.Size(84, 19);
      this.player1WinsToolStripStatusLabel.Text = "Player 1 Wins:";
      // 
      // player2WinsToolStripStatusLabel
      // 
      this.player2WinsToolStripStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
      this.player2WinsToolStripStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
      this.player2WinsToolStripStatusLabel.ForeColor = System.Drawing.SystemColors.ControlText;
      this.player2WinsToolStripStatusLabel.Name = "player2WinsToolStripStatusLabel";
      this.player2WinsToolStripStatusLabel.Size = new System.Drawing.Size(84, 19);
      this.player2WinsToolStripStatusLabel.Text = "Player 2 Wins:";
      // 
      // TicTacToeForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.ClientSize = new System.Drawing.Size(467, 276);
      this.Controls.Add(this.gameStatusStrip);
      this.Controls.Add(this.ticTacToeMenuStrip);
      this.MainMenuStrip = this.ticTacToeMenuStrip;
      this.MinimumSize = new System.Drawing.Size(483, 315);
      this.Name = "TicTacToeForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Unsaved Game";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TicTacToeForm_FormClosing);
      this.Load += new System.EventHandler(this.TicTacToeForm_Load);
      this.Enter += new System.EventHandler(this.TicTacToeForm_Enter);
      this.Leave += new System.EventHandler(this.TicTacToeForm_Leave);
      this.Resize += new System.EventHandler(this.TicTacToeForm_Resize);
      this.ticTacToeMenuStrip.ResumeLayout(false);
      this.ticTacToeMenuStrip.PerformLayout();
      this.gameStatusStrip.ResumeLayout(false);
      this.gameStatusStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ticTacToeMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerTurnToolStripMenuItem;
        private System.Windows.Forms.StatusStrip gameStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel gameTitleToolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePlayersNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel playerTurnToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel player1WinsToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel player2WinsToolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem playerWinsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeGameColorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePlayersCharactersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoLastMoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setBoardSizeToolStripMenuItem;
    }
}