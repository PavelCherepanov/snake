using System;
using System.Collections.Generic;
using System.Text;

namespace snake
{
    class FoodCreator
    {
        int mapWidth;
        int mapWeight;
        char sym;

        Random random = new Random();
        
        public FoodCreator(int mapWidth, int mapWeight, char sym)
        {
            this.mapWidth = mapWidth;
            this.mapWeight = mapWeight;
            this.sym = sym;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, mapWidth - 2);
            int y = random.Next(2, mapWeight - 2);
            return new Point(x, y, sym);
        }
    }
}
