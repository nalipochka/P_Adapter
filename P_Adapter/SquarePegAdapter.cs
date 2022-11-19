using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Adapter
{
    public class SquarePegAdapter : RoundPeg
    {
        private SquarePeg squarePeg;

        public SquarePegAdapter(SquarePeg squarePeg)/*:base(radius)*/
        {
            this.squarePeg = squarePeg;
        }

        public override int GetRadius()
        {
            double halfWidth = squarePeg.GetWidth() / 2;
            return (int)(Math.Sqrt(Math.Pow(halfWidth, 2) * 2));
        }
    }
}
