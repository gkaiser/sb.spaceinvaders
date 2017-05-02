using System;
using System.Linq;
using System.Drawing;

namespace SB.SpaceInvaders
{
  internal class Fighter
  {
    public const int WIDTH = 30;
    public const int HEIGHT = 20;
    public int X;
    public int Y;
    public int SpeedHoriz;

    public Fighter()
    {
      this.X = (Scene.WIDTH / 2) - (Fighter.WIDTH / 2);
      this.Y = Scene.HEIGHT - Fighter.HEIGHT;
    }

    public void Draw(Graphics gfx)
    {
      gfx.FillPolygon(Brushes.White,
        new[]
        {
          new Point(this.X + (Fighter.WIDTH / 2), this.Y),
          new Point(this.X, this.Y + Fighter.HEIGHT - 4),
          new Point(this.X + Fighter.WIDTH, this.Y + Fighter.HEIGHT - 4),
        });
      gfx.FillRectangle(Brushes.White, this.X, this.Y + (Fighter.HEIGHT / 2), Fighter.WIDTH, (Fighter.HEIGHT / 2) - 4);
    }

    public void UpdateLocation()
    {
      this.X = (this.X + this.SpeedHoriz).Constrain(0, Scene.WIDTH - Fighter.WIDTH);
    }

    public LaserBeam FireLaser()
    {
      return LaserBeam.Fire(this.X + (Fighter.WIDTH / 2));
    }

  }
}
