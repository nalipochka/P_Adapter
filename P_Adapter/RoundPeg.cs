using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Adapter
{
    public abstract class RoundPeg
    {
        //private int radius;
        //public RoundPeg(int radius)
        //{
        //    this.radius = radius;
        //}
        public abstract int GetRadius();
        //{
        //    return radius;
        //}
    }

    public class RoundHole
    {
        private int radius;

        public RoundHole(int radius)
        {
            this.radius = radius;
        }

        public int GetRadius()
        {
            return radius;
        }
        public bool Fits(RoundPeg peg)
        {
            if (peg.GetRadius() <= radius)
                return true;
            else
                return false;
        }
    }

    public class SquarePeg
    {
        private int width;
        public SquarePeg(int width)
        {
            this.width = width;
        }   
        public int GetWidth()
        {
            return width;
        }
    }
}
