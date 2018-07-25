using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PairProgram
{
    [TestFixture]
    class SurfAndVolTest
    {
        // THIS TEST FAILS (likely because of decimals)
        [Test]
        public void Volume_CalculateRadius_returnVolumeOfSphere()
        {
            SurfAndVol getVol = new SurfAndVol();

            var result = getVol.CalcVolume(2);

            Assert.That(result, Is.EqualTo(33.51));
        }

        // THIS TEST FAILS (likely because of decimals)
        [Test]
        public void SurFace_CalculateRadius_ReturnSurfaceOfSphere()
        {
            SurfAndVol getSurf = new SurfAndVol();

            var result = getSurf.CalcSurface(1);

            Assert.That(result, Is.EqualTo(12.7));
        }
    }
}
