namespace TicTacToe.GUI
{
  partial class ChangePlayersAttributes
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
      this.components = new System.ComponentModel.Container();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.oldAttributeTitle = new System.Windows.Forms.Label();
      this.newAttributeTitle = new System.Windows.Forms.Label();
      this.oldAttributePlayer1 = new System.Windows.Forms.Label();
      this.oldAttributePlayer2 = new System.Windows.Forms.Label();
      this.newAttributePlayer1Change = new System.Windows.Forms.TextBox();
      this.newAttributePlayer2Change = new System.Windows.Forms.TextBox();
      this.okBtn = new System.Windows.Forms.Button();
      this.cancelBtn = new System.Windows.Forms.Button();
      this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 3;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.Controls.Add(this.oldAttributeTitle, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.newAttributeTitle, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.oldAttributePlayer1, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.oldAttributePlayer2, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.newAttributePlayer1Change, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.newAttributePlayer2Change, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.okBtn, 1, 4);
      this.tableLayoutPanel1.Controls.Add(this.cancelBtn, 2, 4);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 5;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(300, 150);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // oldAttributeTitle
      // 
      this.oldAttributeTitle.AutoSize = true;
      this.oldAttributeTitle.Dock = System.Windows.Forms.DockStyle.Fill;
      this.oldAttributeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.oldAttributeTitle.Location = new System.Drawing.Point(3, 0);
      this.oldAttributeTitle.Name = "oldAttributeTitle";
      this.oldAttributeTitle.Size = new System.Drawing.Size(63, 15);
      this.oldAttributeTitle.TabIndex = 0;
      this.oldAttributeTitle.Text = "Old Name";
      this.oldAttributeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // newAttributeTitle
      // 
      this.newAttributeTitle.AutoSize = true;
      this.tableLayoutPanel1.SetColumnSpan(this.newAttributeTitle, 2);
      this.newAttributeTitle.Dock = System.Windows.Forms.DockStyle.Fill;
      this.newAttributeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.newAttributeTitle.Location = new System.Drawing.Point(72, 0);
      this.newAttributeTitle.Name = "newAttributeTitle";
      this.newAttributeTitle.Size = new System.Drawing.Size(225, 15);
      this.newAttributeTitle.TabIndex = 1;
      this.newAttributeTitle.Text = "New Name";
      this.newAttributeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // oldAttributePlayer1
      // 
      this.oldAttributePlayer1.AutoSize = true;
      this.oldAttributePlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.oldAttributePlayer1.Location = new System.Drawing.Point(3, 15);
      this.oldAttributePlayer1.Name = "oldAttributePlayer1";
      this.oldAttributePlayer1.Size = new System.Drawing.Size(63, 26);
      this.oldAttributePlayer1.TabIndex = 2;
      this.oldAttributePlayer1.Text = "old name";
      this.oldAttributePlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // oldAttributePlayer2
      // 
      this.oldAttributePlayer2.AutoSize = true;
      this.oldAttributePlayer2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.oldAttributePlayer2.Location = new System.Drawing.Point(3, 41);
      this.oldAttributePlayer2.Name = "oldAttributePlayer2";
      this.oldAttributePlayer2.Size = new System.Drawing.Size(63, 26);
      this.oldAttributePlayer2.TabIndex = 3;
      this.oldAttributePlayer2.Text = "old name";
      this.oldAttributePlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // newAttributePlayer1Change
      // 
      this.tableLayoutPanel1.SetColumnSpan(this.newAttributePlayer1Change, 2);
      this.newAttributePlayer1Change.Dock = System.Windows.Forms.DockStyle.Fill;
      this.newAttributePlayer1Change.Location = new System.Drawing.Point(72, 18);
      this.newAttributePlayer1Change.Name = "newAttributePlayer1Change";
      this.newAttributePlayer1Change.Size = new System.Drawing.Size(225, 20);
      this.newAttributePlayer1Change.TabIndex = 4;
      this.newAttributePlayer1Change.Leave += new System.EventHandler(this.newAttributePlayer1Change_Leave);
      // 
      // newAttributePlayer2Change
      // 
      this.tableLayoutPanel1.SetColumnSpan(this.newAttributePlayer2Change, 2);
      this.newAttributePlayer2Change.Dock = System.Windows.Forms.DockStyle.Fill;
      this.newAttributePlayer2Change.Location = new System.Drawing.Point(72, 44);
      this.newAttributePlayer2Change.Name = "newAttributePlayer2Change";
      this.newAttributePlayer2Change.Size = new System.Drawing.Size(225, 20);
      this.newAttributePlayer2Change.TabIndex = 5;
      this.newAttributePlayer2Change.Leave += new System.EventHandler(this.newAttributePlayer2Change_Leave);
      // 
      // okBtn
      // 
      this.okBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.okBtn.Dock = System.Windows.Forms.DockStyle.Right;
      this.okBtn.Location = new System.Drawing.Point(141, 123);
      this.okBtn.Name = "okBtn";
      this.okBtn.Size = new System.Drawing.Size(75, 24);
      this.okBtn.TabIndex = 6;
      this.okBtn.Text = "OK";
      this.okBtn.UseVisualStyleBackColor = true;
      // 
      // cancelBtn
      // 
      this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cancelBtn.Dock = System.Windows.Forms.DockStyle.Right;
      this.cancelBtn.Location = new System.Drawing.Point(222, 123);
      this.cancelBtn.Name = "cancelBtn";
      this.cancelBtn.Size = new System.Drawing.Size(75, 24);
      this.cancelBtn.TabIndex = 7;
      this.cancelBtn.Text = "Cancel";
      this.cancelBtn.UseVisualStyleBackColor = true;
      // 
      // errorProvider
      // 
      this.errorProvider.ContainerControl = this;
      // 
      // ChangePlayersAttributes
      // 
      this.AcceptButton = this.okBtn;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.cancelBtn;
      this.ClientSize = new System.Drawing.Size(300, 150);
      this.Controls.Add(this.tableLayoutPanel1);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.MinimumSize = new System.Drawing.Size(316, 189);
      this.Name = "ChangePlayersAttributes";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Change Players Attributes";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label oldAttributeTitle;
    private System.Windows.Forms.Label newAttributeTitle;
    private System.Windows.Forms.Label oldAttributePlayer1;
    private System.Windows.Forms.Label oldAttributePlayer2;
    private System.Windows.Forms.TextBox newAttributePlayer1Change;
    private System.Windows.Forms.TextBox newAttributePlayer2Change;
    private System.Windows.Forms.Button okBtn;
    private System.Windows.Forms.Button cancelBtn;
    private System.Windows.Forms.ErrorProvider errorProvider;
   
  }
}