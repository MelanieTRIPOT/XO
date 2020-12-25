using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XO
{
    class Plate
    {
        int[,] Myplate; 

        Plate(int x , int y)
        {
            Myplate = new int[x, y];
        }
    }
}
