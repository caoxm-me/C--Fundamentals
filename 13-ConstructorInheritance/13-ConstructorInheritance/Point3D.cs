using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ConstructorInheritance
{
    class Point3D : Point
    {
        protected int z;
        // base()调用父类构造函数
        public Point3D(int x, int y, int z) : base(x, y)
        {
            this.z = z;
        }

        // 重写Object的ToString方法
        public override string ToString()
        {
            return string.Format("x: {0}, y: {1}, z: {2}", this.x, this.y, this.z);
        }
    }
}
