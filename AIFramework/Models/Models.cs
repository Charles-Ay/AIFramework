using AIFramework.Layers;
using AIFramework.ModelData.Model;

namespace AIFramework.Models
{
    public class Models
    {
        protected static Models? model;
        public static List<Layers.Layers>? layers { get; private set; }
        public string? trainingDataPath { get; private set; }
        public string? testingDataPath { get; private set; }
        public Data? data { get; private set; }

        public virtual void CreateInstance(Models mod, string trainingDataPath, string testingDataPath) 
        {
            throw new NotImplementedException();
        }
        protected void UpdateInstancePaths(string trainingDataPath, string testingDataPath) 
        {
            this.trainingDataPath = trainingDataPath;
            this.testingDataPath = testingDataPath;
        }
        public virtual Models GetInstance() 
        {
            throw new NotImplementedException();
        }

        public void AddLayer(Layers.Layers layer) 
        {
            layers.Add(layer);
        }
    }
}