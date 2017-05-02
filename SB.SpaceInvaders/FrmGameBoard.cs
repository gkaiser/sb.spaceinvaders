using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace SB.SpaceInvaders
{
  public partial class FrmGameBoard : Form
  {
    private Scene Scene;
    private Timer RedrawTimer;

    public FrmGameBoard()
    {
      InitializeComponent();

      this.Scene = new Scene();

      this.ClientSize = new Size(Scene.WIDTH, Scene.HEIGHT);

      this.RedrawTimer = new Timer();
      this.RedrawTimer.Interval = (int)((1 / Scene.FRAMES_PER_SEC) * 1000m);
      this.RedrawTimer.Tick += (s, ea) => this.Invalidate();
    }

    private void FrmMain_Load(object sender, EventArgs e)
    {
      this.Visible = true;
      Application.DoEvents();

      this.RedrawTimer.Start();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      base.OnPaint(e);

      var gfx = e.Graphics;

      this.Scene.Draw(gfx);
      this.Scene.Update();

      if (!this.DoubleBuffered) { gfx.Dispose(); }
    }

    private void FrmMain_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        Win32.ReleaseCapture();
        Win32.SendMessage(this.Handle, Win32.WM_NCLBUTTONDOWN, Win32.HT_CAPTION, 0);
      }
    }

    private void FrmMain_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Escape)
        this.ctxGame_miReset_Click(sender, e);
      else
        this.Scene.HandleKeyPress(e.KeyCode);
    }

    private void ctxGame_miReset_Click(object sender, EventArgs e)
    {

    }

    private void ctxGame_miPause_Click(object sender, EventArgs e)
    {

    }

    private void ctxGame_miQuit_Click(object sender, EventArgs e)
    {
      this.Close();
    }

  }
}
