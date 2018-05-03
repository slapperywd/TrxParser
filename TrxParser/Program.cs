using System;
using TrxParser.Models;
using TrxParser.Utils;

namespace TrxParser
{
    class Program
    {
        static void Main(string[] args)
        {
            string trxLocation = "TestResults.trx";
    
            TestRun testRun = TrxFileDeserializer.Deserialize<TestRun>(trxLocation);

            Console.WriteLine(testRun);
            Console.ReadKey();
        }

    }
}
