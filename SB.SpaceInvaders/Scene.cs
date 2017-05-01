using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SB.SpaceInvaders
{
  public class Scene
  {
    public const decimal FRAMES_PER_SEC = 60m;
    public const int WIDTH = 600;
    public const int HEIGHT = 600;

    private Fighter Fighter;
    private List<LaserBeam> LaserBeams;

    public Scene()
    {
      this.Fighter = new Fighter();
      this.LaserBeams = new List<LaserBeam>();
    }


    public void Draw(Graphics gfx)
    {
      this.Fighter.Draw(gfx);
      this.LaserBeams.ForEach(l => l.Draw(gfx));
    }

    public void Update()
    {
      this.Fighter.UpdateLocation();

      foreach (var l in this.LaserBeams)
        l.UpdateLocation();

    }

    public void HandleKeyPress(KeyEventArgs kea)
    {
      if (kea.KeyCode == Keys.Oemtilde)
      {
        this.Fighter.FireLaser();
      }
      else if (kea.KeyCode == Keys.Left)
      {
        this.Fighter.SpeedHoriz = (this.Fighter.SpeedHoriz > 0 ? 0 : this.Fighter.SpeedHoriz - 1);
      }
      else if (kea.KeyCode == Keys.Right)
      {
        this.Fighter.SpeedHoriz = (this.Fighter.SpeedHoriz < 0 ? 0 : this.Fighter.SpeedHoriz + 1);
      }
    }

  }
}
