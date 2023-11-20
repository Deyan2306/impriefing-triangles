using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marti_dm
{
    internal class Rectangle
    {
        private string id;
        public string Id { get; set; }

        private int width;
        public int Width { get; set; }

        private int height;
        public int Height { get; set; }

        private int leftCornerX;
        private int leftCornerY;
        public int LeftCornerX { get; set; }
        public int LeftCornerY { get; set; }

        public Rectangle(string id, int width, int height, int leftCornerX, int leftCornerY)
        {
            this.Id = id;
            this.Width = width;
            this.Height = height;
            this.LeftCornerX = leftCornerX;
            this.LeftCornerY = leftCornerY;
        }

        public bool impriefs(Rectangle rectangle) 
        {
            // all corner coordinates of this object
            int thisLeftX = this.LeftCornerX;
            int thisTopY = this.LeftCornerY;
            int thisRightX = this.LeftCornerX + this.Width;
            int thisBottomY = this.LeftCornerY + this.Height;
            
            // all corner coordinates of the other object
            int otherLeftX = rectangle.LeftCornerX;
            int otherTopY = rectangle.LeftCornerY;
            int otherRightX = rectangle.LeftCornerX + rectangle.Width;
            int otherBottomY = rectangle.LeftCornerY + rectangle.Height;

            // check if the two rectangles are on top of each other based on the top left coordeinate
            if ((thisLeftX <= otherLeftX) && (otherLeftX < thisRightX))     { return true; }
            else if ((thisTopY <= otherTopY) && (otherTopY < thisBottomY))  { return true; }

            return false;
        }
    }
}
