using System;
using System.Linq;
using System.Drawing;
using System.Collections.Generic;

namespace SB.SpaceInvaders
{
  internal class Alien
  {
    public const int WIDTH = 30;
    public const int HEIGHT = 30;
    public int X;
    public int Y;
    public int SpeedHoriz;
    public int SpeedVert = 2;
    public int PointsReward;

    private Alien() { }

    public void Draw(Graphics gfx)
    {
      var img = SB.SpaceInvaders.Properties.Resources.StdImg_48_Alien_30;
      if (this.PointsReward == 20)
        img = SB.SpaceInvaders.Properties.Resources.StdImg_48_Alien_20;
      if (this.PointsReward == 10)
        img = SB.SpaceInvaders.Properties.Resources.StdImg_48_Alien_10;

      gfx.DrawImage(img, this.X, this.Y, Alien.WIDTH, Alien.HEIGHT);
    }

    public void UpdateLocation()
    {
      this.X += this.SpeedHoriz;
      this.Y += this.SpeedVert;
    }

    public static List<Alien> GenerateDefaultAlienSet(int totRows)
    {
      var aliens = new List<Alien>();

      for (int j = 0; j < totRows; j++)
      {
        for (int i = 0; ; i++)
        {
          var a = new Alien();
          a.Y = Alien.HEIGHT + (int)(j * (Alien.HEIGHT * 1.5m));

          if (i == 0)
            a.X = Alien.WIDTH / 2;
          else
            a.X = aliens[i - 1].X + (int)(Alien.WIDTH * 1.5m);

          if (a.X + Alien.WIDTH >= Scene.WIDTH)
            break;

          if (j == 0)
            a.PointsReward = 30;
          else if (j == (totRows - 1))
            a.PointsReward = 10;
          else
            a.PointsReward = 20;

          aliens.Add(a);
        }
      }

      return aliens;
    }

  }
}
