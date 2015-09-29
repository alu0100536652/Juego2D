using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego2D
{
    class Map
    {
        private int width;
        private int height;
        private int[,] map;

        public Map(int width, int height)
        {
            this.width = width;
            this.height = height;
            map = new int[width,height];
        }
    }
}
