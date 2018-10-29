using System;
using BundlerMinifier;
using CommandLine;

namespace JsBundler
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Parser.Default.ParseArguments<CommandLineOptions>(args)
                .WithParsed(Execute)
                .WithNotParsed(errors => PrintUsage());
        }

        private static void PrintUsage()
        {
            Console.WriteLine("使用方式: JsBundler -c 設定檔名");
            Console.WriteLine("");
            Console.WriteLine("設定檔範例:");
            Console.WriteLine("[");
            Console.WriteLine("  {");
            Console.WriteLine("    \"outputFileName\": \"Scripts/app/plugins/shark/shark.core.js\",");
            Console.WriteLine("    \"inputFiles\": [");
            Console.WriteLine("      \"Source/Namespace.js\",");
            Console.WriteLine("      \"Source/Exceptions/AssertException.js\",");
            Console.WriteLine("      \"Source/Exceptions/ElementDoesNotExistsException.js\",");
            Console.WriteLine("      \"Source/Exceptions/IndexOutOfRangeException.js\",");
            Console.WriteLine("      \"Source/String.js\",");
            Console.WriteLine("      \"Source/System.js\",");
            Console.WriteLine("      \"Source/Assert.js\",");
            Console.WriteLine("      \"Source/HttpMethods.js\",");
            Console.WriteLine("      \"Source/SimpleStorage.js\"");
            Console.WriteLine("    ]");
            Console.WriteLine("  }");
            Console.WriteLine("]");
        }

        private static void Execute(CommandLineOptions options)
        {
            var processor = new BundleFileProcessor();
            processor.Process(options.ConfigFileName);
        }
    }
}