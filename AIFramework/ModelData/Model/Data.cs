using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AIFramework.ModelData.Model
{
    public class Data
    {
        //label and data rows
        private Dictionary<string, List<string>> dataSet = new Dictionary<string, List<string>>();
        private List<string> labels = new List<string>();

        public void AddData(string label, string newData)
        {
            var data = new List<string>();
            if (dataSet.TryGetValue(label, out data))
            {
                //add data to existing label
                data.Add(newData);
                dataSet[label] = data;
            }
            else
            {
                data!.Add(newData);
                dataSet.Add(label, data);
            }
            UpdateLabels();
        }

        public void AddLabel(string label)
        {
            if (!dataSet.TryGetValue(label, out _))
            {
                dataSet.Add(label, new List<string>());
            }
            UpdateLabels();
        }

        //public bool RemoveData(string label)
        //{
        //    if (dataSet.ContainsKey(label))
        //    {
        //        dataSet.Remove(label);
        //    }
        //    UpdateLabels();
        //}

        private void UpdateLabels()
        {
            //clearing because it would be faster to add new label data than check if
            //each label contains the label in the dataset
            labels.Clear();
            foreach (var data in dataSet.Keys)
            {
                labels.Add(data);
            }
        }

        public List<string> GetLabels()
        {
            return labels;
        }

        public int ElementCount()
        {
            int count = 0;
            foreach (var data in dataSet.Values)
            {
                foreach (var element in data)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
