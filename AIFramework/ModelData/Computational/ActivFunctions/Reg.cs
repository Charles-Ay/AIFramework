using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIFramework.ModelData.Computational.ActivFunctions
{
    public class Reg
    {
        private double meanX = 0;
        private double meanY = 0;
        private double standardDevX = 0;
        private double standardDevY = 0;
        private double correlation = 0;

        public double slope { get; private set; }
    }
}
