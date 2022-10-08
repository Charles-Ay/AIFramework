using AIFramework.ModelData.Computational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIFramework.Layers
{
    public class Layers
    {
        protected ActivationFunction.FunctionTypes activationFunction;
        protected List<Neuron> Neurons;
        public Layers(int neurons, ActivationFunction.FunctionTypes activationFunction)
        {
            int numNeurons = neurons;
            this.activationFunction = activationFunction;
        }
        public void CreateNeurons(int numNeurons)
        {
            for(int i = 0; i < numNeurons; ++i)
            {
                Neurons.Add(new Neuron());
            }
        }
    }
}
