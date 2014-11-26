using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_array
{
    public interface IChessPiece
    {
        string Name();
        string Color { get; set; }
        void Move();   
    }
}
