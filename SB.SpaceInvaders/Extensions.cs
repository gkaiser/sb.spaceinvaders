using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB.SpaceInvaders
{
    public static class Extensions
    {
      public static int Constrain(this int value, int min, int max)
      {
        return (value < min) ? min : (value > max) ? max : value;
      }
    }
}
