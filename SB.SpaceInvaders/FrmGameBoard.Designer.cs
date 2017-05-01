namespace SB.SpaceInvaders
{
  partial class FrmGameBoard
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGameBoard));
      this.ctxGame = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.ctxGame_miReset = new System.Windows.Forms.ToolStripMenuItem();
      this.ctxGame_miPause = new System.Windows.Forms.ToolStripMenuItem();
      this.ctxGame_sep1 = new System.Windows.Forms.ToolStripSeparator();
      this.ctxGame_miQuit = new System.Windows.Forms.ToolStripMenuItem();
      this.ctxGame.SuspendLayout();
      this.SuspendLayout();
      // 
      // ctxGame
      // 
      this.ctxGame.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxGame_miReset,
            this.ctxGame_miPause,
            this.ctxGame_sep1,
            this.ctxGame_miQuit});
      this.ctxGame.Name = "ctxGame";
      this.ctxGame.Size = new System.Drawing.Size(153, 98);
      // 
      // ctxGame_miReset
      // 
      this.ctxGame_miReset.Name = "ctxGame_miReset";
      this.ctxGame_miReset.Size = new System.Drawing.Size(152, 22);
      this.ctxGame_miReset.Text = "Reset";
      this.ctxGame_miReset.Click += new System.EventHandler(this.ctxGame_miReset_Click);
      // 
      // ctxGame_miPause
      // 
      this.ctxGame_miPause.Name = "ctxGame_miPause";
      this.ctxGame_miPause.Size = new System.Drawing.Size(152, 22);
      this.ctxGame_miPause.Text = "Pause";
      this.ctxGame_miPause.Click += new System.EventHandler(this.ctxGame_miPause_Click);
      // 
      // ctxGame_sep1
      // 
      this.ctxGame_sep1.Name = "ctxGame_sep1";
      this.ctxGame_sep1.Size = new System.Drawing.Size(149, 6);
      // 
      // ctxGame_miQuit
      // 
      this.ctxGame_miQuit.Name = "ctxGame_miQuit";
      this.ctxGame_miQuit.Size = new System.Drawing.Size(152, 22);
      this.ctxGame_miQuit.Text = "Quit";
      this.ctxGame_miQuit.Click += new System.EventHandler(this.ctxGame_miQuit_Click);
      // 
      // FrmGameBoard
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 261);
      this.ContextMenuStrip = this.ctxGame;
      this.DoubleBuffered = true;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FrmGameBoard";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "SB.SpaceInvaders";
      this.Load += new System.EventHandler(this.FrmMain_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
      this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseDown);
      this.ctxGame.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ContextMenuStrip ctxGame;
    private System.Windows.Forms.ToolStripMenuItem ctxGame_miReset;
    private System.Windows.Forms.ToolStripMenuItem ctxGame_miQuit;
    private System.Windows.Forms.ToolStripMenuItem ctxGame_miPause;
    private System.Windows.Forms.ToolStripSeparator ctxGame_sep1;
  }
}

