using CommandLine;

namespace JsBundler
{
    public class CommandLineOptions
    {
        [Option('c', Required = true, HelpText = "config file name")]
        public string ConfigFileName { get; set; }
    }
}