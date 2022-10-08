using AIFramework.FileParser;
using AIFramework.Exceptions.DataExceptions;
using AIFramework.ModelData.Model;

namespace AIFrameworkTests.ParserTest
{
    public class ParserTest
    {
        [Fact]
        public void CSVParser()
        {
            //not sure exactly how to test if csv is parsed properly
            var parser = new CSVParser(@"C:\Users\charl\Documents\Programming\C#\AI\AIFramework\AIFrameworkTests\testfiles\AAPL.csv");
            Data data = new Data();
            try
            {
                data = parser.Parse(7);
            }
            catch(Exception ex)
            {
                Assert.True(ex == null, "Data not parsed correctly");
            }
            Assert.True(data.ElementCount() == (253 * 7) - 7, "Data not parsed correctly");
        }
    }
}