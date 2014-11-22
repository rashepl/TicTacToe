namespace TicTacToe.GUI
{
  partial class ChangeGameColors
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
      this.cancelBtn = new System.Windows.Forms.Button();
      this.okBtn = new System.Windows.Forms.Button();
      this.changeColorsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
      this.cellColorPreviewBtn = new System.Windows.Forms.Button();
      this.backgroundColorPreviewBtn = new System.Windows.Forms.Button();
      this.player1CharacterColorBtn = new System.Windows.Forms.Button();
      this.player2CharacterColorBtn = new System.Windows.Forms.Button();
      this.changeColorsTableLayoutPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // cancelBtn
      // 
      this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cancelBtn.Location = new System.Drawing.Point(404, 382);
      this.cancelBtn.Name = "cancelBtn";
      this.cancelBtn.Size = new System.Drawing.Size(75, 23);
      this.cancelBtn.TabIndex = 3;
      this.cancelBtn.Text = "Cancel";
      this.cancelBtn.UseVisualStyleBackColor = true;
      // 
      // okBtn
      // 
      this.okBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.okBtn.Location = new System.Drawing.Point(323, 382);
      this.okBtn.Name = "okBtn";
      this.okBtn.Size = new System.Drawing.Size(75, 23);
      this.okBtn.TabIndex = 2;
      this.okBtn.Text = "OK";
      this.okBtn.UseVisualStyleBackColor = true;
      // 
      // changeColorsTableLayoutPanel
      // 
      this.changeColorsTableLayoutPanel.ColumnCount = 3;
      this.changeColorsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.changeColorsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.changeColorsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.changeColorsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.changeColorsTableLayoutPanel.Controls.Add(this.cellColorPreviewBtn, 0, 0);
      this.changeColorsTableLayoutPanel.Controls.Add(this.backgroundColorPreviewBtn, 0, 1);
      this.changeColorsTableLayoutPanel.Controls.Add(this.okBtn, 1, 5);
      this.changeColorsTableLayoutPanel.Controls.Add(this.cancelBtn, 2, 5);
      this.changeColorsTableLayoutPanel.Controls.Add(this.player1CharacterColorBtn, 0, 2);
      this.changeColorsTableLayoutPanel.Controls.Add(this.player2CharacterColorBtn, 0, 3);
      this.changeColorsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.changeColorsTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
      this.changeColorsTableLayoutPanel.Name = "changeColorsTableLayoutPanel";
      this.changeColorsTableLayoutPanel.RowCount = 6;
      this.changeColorsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.changeColorsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.changeColorsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.changeColorsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.changeColorsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.changeColorsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.changeColorsTableLayoutPanel.Size = new System.Drawing.Size(482, 408);
      this.changeColorsTableLayoutPanel.TabIndex = 0;
      // 
      // cellColorPreviewBtn
      // 
      this.changeColorsTableLayoutPanel.SetColumnSpan(this.cellColorPreviewBtn, 3);
      this.cellColorPreviewBtn.Dock = System.Windows.Forms.DockStyle.Fill;
      this.cellColorPreviewBtn.Location = new System.Drawing.Point(3, 3);
      this.cellColorPreviewBtn.Name = "cellColorPreviewBtn";
      this.cellColorPreviewBtn.Size = new System.Drawing.Size(476, 23);
      this.cellColorPreviewBtn.TabIndex = 5;
      this.cellColorPreviewBtn.Text = "Change Grid Cell Color";
      this.cellColorPreviewBtn.UseVisualStyleBackColor = true;
      this.cellColorPreviewBtn.Click += new System.EventHandler(this.cellColorPreviewBtn_Click);
      // 
      // backgroundColorPreviewBtn
      // 
      this.changeColorsTableLayoutPanel.SetColumnSpan(this.backgroundColorPreviewBtn, 3);
      this.backgroundColorPreviewBtn.Dock = System.Windows.Forms.DockStyle.Fill;
      this.backgroundColorPreviewBtn.Location = new System.Drawing.Point(3, 32);
      this.backgroundColorPreviewBtn.Name = "backgroundColorPreviewBtn";
      this.backgroundColorPreviewBtn.Size = new System.Drawing.Size(476, 23);
      this.backgroundColorPreviewBtn.TabIndex = 6;
      this.backgroundColorPreviewBtn.Text = "Change Grid Background Color";
      this.backgroundColorPreviewBtn.UseVisualStyleBackColor = true;
      this.backgroundColorPreviewBtn.Click += new System.EventHandler(this.backgroundColorPreviewBtn_Click);
      // 
      // player1CharacterColorBtn
      // 
      this.changeColorsTableLayoutPanel.SetColumnSpan(this.player1CharacterColorBtn, 3);
      this.player1CharacterColorBtn.Dock = System.Windows.Forms.DockStyle.Top;
      this.player1CharacterColorBtn.Location = new System.Drawing.Point(3, 61);
      this.player1CharacterColorBtn.Name = "player1CharacterColorBtn";
      this.player1CharacterColorBtn.Size = new System.Drawing.Size(476, 23);
      this.player1CharacterColorBtn.TabIndex = 8;
      this.player1CharacterColorBtn.Text = "Change Player 1 Character (\"X\") Color";
      this.player1CharacterColorBtn.UseVisualStyleBackColor = true;
      this.player1CharacterColorBtn.Click += new System.EventHandler(this.player1CharacterColorBtn_Click);
      // 
      // player2CharacterColorBtn
      // 
      this.changeColorsTableLayoutPanel.SetColumnSpan(this.player2CharacterColorBtn, 3);
      this.player2CharacterColorBtn.Dock = System.Windows.Forms.DockStyle.Top;
      this.player2CharacterColorBtn.Location = new System.Drawing.Point(3, 90);
      this.player2CharacterColorBtn.Name = "player2CharacterColorBtn";
      this.player2CharacterColorBtn.Size = new System.Drawing.Size(476, 23);
      this.player2CharacterColorBtn.TabIndex = 9;
      this.player2CharacterColorBtn.Text = "Change Player 2 Character (\"O\") Color";
      this.player2CharacterColorBtn.UseVisualStyleBackColor = true;
      this.player2CharacterColorBtn.Click += new System.EventHandler(this.player2CharacterColorBtn_Click);
      // 
      // ChangeGameColors
      // 
      this.AcceptButton = this.okBtn;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.cancelBtn;
      this.ClientSize = new System.Drawing.Size(482, 408);
      this.Controls.Add(this.changeColorsTableLayoutPanel);
      this.Name = "ChangeGameColors";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Change Game Colors";
      this.Resize += new System.EventHandler(this.ChangeGameColors_Resize);
      this.changeColorsTableLayoutPanel.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel changeColorsTableLayoutPanel;
    private System.Windows.Forms.Button okBtn;
    private System.Windows.Forms.Button cancelBtn;
    private System.Windows.Forms.Button cellColorPreviewBtn;
    private System.Windows.Forms.Button backgroundColorPreviewBtn;
    private System.Windows.Forms.Button player1CharacterColorBtn;
    private System.Windows.Forms.Button player2CharacterColorBtn;
  }
}