using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB.SpaceInvaders
{
  internal class LaserBeam
  {
    public const int SPEED_VERT = 4;
    public const int WIDTH = 2;
    public const int HEIGHT = 15;
    public readonly int X = 0;
    public int Y { get; }

    private LaserBeam(int x)
    {
      this.X = x;
      this.Y = Scene.HEIGHT - (Fighter.HEIGHT + 4);
    }

    public static LaserBeam Fire(int x)
    {
      return new LaserBeam(x);
    }

    public void UpdateLocation()
    {
      this.Y -= LaserBeam.SPEED_VERT;
    }

    public void Draw(Graphics gfx)
    {
      foreach (var b in this.FiredBeams)
        gfx.DrawLine(new Pen(Brushes.Aqua, LaserBeam.WIDTH), b.X, b.Y, b.X, b.Y - LaserBeam.HEIGHT);

    }
  }
}
