using AIFramework.ModelData.Computational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIFramework.Layers.NumericalLayers
{
    public class DenseLayer : Layers
    {
        DenseLayer(int neurons, ActivationFunction.FunctionTypes activationFunction):base(neurons, activationFunction)
        {
        }
    }
}
