using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AIFramework.Models
{
    public class SequentialModel : Models
    {
        public override void CreateInstance(Models mod, string trainingData, string testingData)
        {
            if(mod == null)
            {
                model = mod;
                UpdateInstancePaths(trainingData, testingData);
            }
        }

        public override Models GetInstance()
        {
            if (model == null)
            {
                model = new SequentialModel();
                return model;
            }
            else return model;
        }
    }
}
