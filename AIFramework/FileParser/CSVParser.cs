using Microsoft.VisualBasic.FileIO;
using AIFramework.Exceptions.DataExceptions;
using System.Data;
using AIFramework.ModelData.Model;

namespace AIFramework.FileParser
{
    public class CSVParser
    {
        private string? filePath;
        public CSVParser(string? filePath)
        {
            this.filePath = filePath;
        }

        public Data Parse(int numHeaders)
        {
            Data data = new Data();
            using (TextFieldParser parser = new TextFieldParser(filePath))
            {
                int headerCount = 0;
                int currentHeaderIndex = 0;
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    //Process row
                    string[] fields = parser.ReadFields();
                    foreach (string field in fields)
                    {
                        if(headerCount < numHeaders)
                        {
                            data.AddLabel(field);
                            ++headerCount;
                        }
                        else
                        {
                            if (currentHeaderIndex == numHeaders)
                            {
                                currentHeaderIndex = 0;
                            }
                            data.AddData(data.GetLabels().ElementAt(currentHeaderIndex), field);
                            ++currentHeaderIndex;
                        }
                    }
                }
            }
            //temp
            if (data != null)
            {
                return data;
            }
            else throw new ParserExecption("No data parsed");
        }
    }
}
