using System;
using TrxParser.Models;
using TrxParser.Utils;

namespace TrxParser
{
    using Newtonsoft.Json;

    class Program
    {
        /// <summary>
        /// Consider passing two params [trx file path] and [output dir json result path] via concolse
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string trxLocation = "TestResults.trx";
            
    
            TestRun testRun = TrxFileDeserializer.Deserialize<TestRun>(trxLocation);

            string jsonResult = JsonConvert.SerializeObject(testRun);

            Console.WriteLine(testRun);
            Console.ReadKey();
        }

    }
}
