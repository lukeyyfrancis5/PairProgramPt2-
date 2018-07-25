using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace PairProgram
{
    class SurfAndVol
    {
        private const double pie = 3.14;
        
        public double CalcVolume(int number)
        {
            const double div = 4 / 3;

            var radius = Math.Pow(number, 3);

            var vol = div * (pie * radius);

            return vol;
        }

        public double CalcSurface(int number)
        {
            var radius = Math.Pow(number, 2);

            var surf = 4 * (pie * radius);

            return surf;
        }
    }
}
