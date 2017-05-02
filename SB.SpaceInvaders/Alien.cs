using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB.SpaceInvaders
{
  internal class Alien
  {
    public const int WIDTH = 30;
    public const int HEIGHT = 30;
    public int X;
    public int Y;

    public Alien() { }

    public void Draw(Graphics gfx)
    {
      gfx.DrawImage(SB.SpaceInvaders.Properties.Resources.StdImg_48_Alien_30, this.X, this.Y, Alien.WIDTH, Alien.HEIGHT);
    }

    public static List<Alien> GenerateDefaultAlienSet(int totRows)
    {
      var aliens = new List<Alien>();
      var totWidth = (Scene.WIDTH - Alien.WIDTH) / 11;

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

          aliens.Add(a);
        }
      }

      return aliens;
    }

    public void UpdateLocation()
    {

    }

  }
}
