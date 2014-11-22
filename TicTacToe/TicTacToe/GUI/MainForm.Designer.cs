namespace TicTacToe.GUI
{
    partial class MainForm
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
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.automaticallyCreateANewGameOnStartupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.optionsToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(717, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.openGameToolStripMenuItem,
            this.exitToolStripMenuItem});
      this.fileToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "&File";
      // 
      // newGameToolStripMenuItem
      // 
      this.newGameToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
      this.newGameToolStripMenuItem.MergeIndex = 0;
      this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
      this.newGameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.newGameToolStripMenuItem.Text = "&New Game";
      this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
      // 
      // openGameToolStripMenuItem
      // 
      this.openGameToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
      this.openGameToolStripMenuItem.MergeIndex = 1;
      this.openGameToolStripMenuItem.Name = "openGameToolStripMenuItem";
      this.openGameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.openGameToolStripMenuItem.Text = "&Open Game";
      this.openGameToolStripMenuItem.Click += new System.EventHandler(this.openGameToolStripMenuItem_Click);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.exitToolStripMenuItem.Text = "&Exit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
      // 
      // viewToolStripMenuItem
      // 
      this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
      this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
      this.viewToolStripMenuItem.Text = "&View";
      this.viewToolStripMenuItem.Visible = false;
      // 
      // optionsToolStripMenuItem
      // 
      this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.automaticallyCreateANewGameOnStartupToolStripMenuItem});
      this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
      this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
      this.optionsToolStripMenuItem.Text = "&Options";
      // 
      // automaticallyCreateANewGameOnStartupToolStripMenuItem
      // 
      this.automaticallyCreateANewGameOnStartupToolStripMenuItem.Checked = true;
      this.automaticallyCreateANewGameOnStartupToolStripMenuItem.CheckOnClick = true;
      this.automaticallyCreateANewGameOnStartupToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
      this.automaticallyCreateANewGameOnStartupToolStripMenuItem.Name = "automaticallyCreateANewGameOnStartupToolStripMenuItem";
      this.automaticallyCreateANewGameOnStartupToolStripMenuItem.Size = new System.Drawing.Size(317, 22);
      this.automaticallyCreateANewGameOnStartupToolStripMenuItem.Text = "&Automatically Create A New Game On Startup";
      this.automaticallyCreateANewGameOnStartupToolStripMenuItem.Click += new System.EventHandler(this.automaticallyCreateANewGameOnStartupToolStripMenuItem_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(717, 401);
      this.Controls.Add(this.menuStrip1);
      this.IsMdiContainer = true;
      this.MainMenuStrip = this.menuStrip1;
      this.MinimumSize = new System.Drawing.Size(503, 383);
      this.Name = "MainForm";
      this.Text = "TicTacToe";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem automaticallyCreateANewGameOnStartupToolStripMenuItem;
    }
}

