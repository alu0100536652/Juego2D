using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Juego2D
{
    class Game
    {
        private Map mapOfGame;
        private Bitmap[] tileset;
        private Bitmap gameView;
        private int widthResolution;
        private int heightResolution;
        private int resolucionTile = 32;

        public Game()
        {
            widthResolution = 20;
            heightResolution = 20;
            mapOfGame = new Map(widthResolution,heightResolution);
            tileset = new Bitmap[1];
            tileset[0] = Juego2D.Properties.Resources.GrassBackground;    
            gameView = new Bitmap(widthResolution * resolucionTile, heightResolution * resolucionTile);
        }

        public void setup()
        {
            
        }

        public void update()
        {

        }

        public Bitmap print()
        {
            for(int coordenadaX = 0; coordenadaX < widthResolution; coordenadaX++)
            {
                for (int coordenadaY = 0; coordenadaY < heightResolution; coordenadaY++)
                {
                    using (Graphics grafico = Graphics.FromImage(gameView))
                    {
                        grafico.DrawImage(tileset[mapOfGame.getMapId(coordenadaX,coordenadaY)], new Point(coordenadaX * resolucionTile, coordenadaY * resolucionTile));
                    }
                }
            }

            return gameView;
        }
    }
}
