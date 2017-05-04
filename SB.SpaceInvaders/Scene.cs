using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace SB.SpaceInvaders
{
  public class Scene
  {
    public const decimal FRAMES_PER_SEC = 60m;
    public const int WIDTH = 600;
    public const int HEIGHT = 600;

    public int Score;
    private int FramesDrawn;
    private Fighter Fighter;
    private List<LaserBeam> LaserBeams;
    private List<Alien> Aliens;

    public Scene()
    {
      this.Fighter = new Fighter();
      this.LaserBeams = new List<LaserBeam>();
      this.Aliens = Alien.GenerateDefaultAlienSet(5);
    }

    public void CheckAlienLaserCollisions()
    {
      var remAliens = new List<Alien>();
      var remLasers = new List<LaserBeam>();

      foreach (var l in this.LaserBeams)
      {
        foreach (var a in this.Aliens)
        {
          if (l.X >= a.X && l.X <= a.X + Alien.WIDTH && l.Y >= a.Y && l.Y <= a.Y + Alien.HEIGHT)
          {
            this.Score += a.PointsReward;

            remAliens.Add(a);
            remLasers.Add(l);

            break;
          }
        }
      }

      remAliens.ForEach(a => this.Aliens.Remove(a));
      remLasers.ForEach(l => this.LaserBeams.Remove(l));
    }

    public void Draw(Graphics gfx)
    {
      gfx.FillRectangle(new SolidBrush(Color.FromArgb(51, 51, 51)), 0, 0, Scene.WIDTH, Scene.HEIGHT);
      gfx.DrawString($"Score: {this.Score}", new Font("Sans Serif", 10f, FontStyle.Bold), Brushes.CornflowerBlue, 8, 8);

      this.Fighter.Draw(gfx);
      this.LaserBeams.ForEach(l => l.Draw(gfx));
      this.Aliens.ForEach(a => a.Draw(gfx));

      this.FramesDrawn++;
    }

    public void Update()
    {
      this.Fighter.UpdateLocation();
      this.LaserBeams.ForEach(l => l.UpdateLocation());

      if (this.FramesDrawn % 8 == 0)
      {
        this.FramesDrawn = 0;
        this.Aliens.ForEach(a => a.UpdateLocation());
      }
    }

    public void HandleKeyPress(Keys key)
    {
      if (key == Keys.Space)
      {
        this.LaserBeams.Add(this.Fighter.FireLaser());
      }
      else if (key == Keys.Left)
      {
        this.Fighter.SpeedHoriz = (this.Fighter.SpeedHoriz > 0 ? 0 : this.Fighter.SpeedHoriz - 1);
      }
      else if (key == Keys.Right)
      {
        this.Fighter.SpeedHoriz = (this.Fighter.SpeedHoriz < 0 ? 0 : this.Fighter.SpeedHoriz + 1);
      }
    }

    public void Reset()
    {
      this.Fighter = new Fighter();
      this.LaserBeams = new List<LaserBeam>();
      this.Aliens = Alien.GenerateDefaultAlienSet(1);
    }

  }
}
