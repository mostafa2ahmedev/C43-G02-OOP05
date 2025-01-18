using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    #region 1.Define 3D Point Class and the basic Constructors (use chaining in constructors).
    class Point3D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }


        public Point3D(int x)
        {
            this.X = x;
        }
        public Point3D(int x, int y) : this(x)
        {
            this.Y = y;
        }
        public Point3D(int x, int y, int z) : this(x, y)
        {
            this.Z = z;
        }
    } 
    #endregion
}
