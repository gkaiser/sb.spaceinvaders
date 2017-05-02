using System;
using System.Linq;
using System.Drawing;

namespace SB.SpaceInvaders
{
  internal class LaserBeam
  {
    public const int SPEED_VERT = 4;
    public const int WIDTH = 2;
    public const int HEIGHT = 15;
    public readonly int X = 0;
    private int Y;

    private LaserBeam(int x)
    {
      this.X = x;
      this.Y = Scene.HEIGHT - (Fighter.HEIGHT + 4 + LaserBeam.HEIGHT);
    }

    public void UpdateLocation()
    {
      this.Y -= LaserBeam.SPEED_VERT;
    }

    public void Draw(Graphics gfx)
    {
      gfx.DrawLine(new Pen(Brushes.Aqua, LaserBeam.WIDTH), this.X, this.Y, this.X, this.Y + LaserBeam.HEIGHT);
    }

    public static LaserBeam Fire(int x)
    {
      return new LaserBeam(x);
    }

  }
}
