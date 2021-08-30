using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartEventTracker.Framework
{
    class Utils
    {
        public static Rectangle MakeRect(float x, float y, float width, float height)
        {
            return new Rectangle((int)x, (int)y, (int)width, (int)height);
        }
        public static Point Vector2ToPoint(Vector2 v2)
        {
            return new Point((int)v2.X, (int)v2.Y);
        }
    }
}
