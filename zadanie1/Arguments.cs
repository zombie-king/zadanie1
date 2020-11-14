using CommandLine;

namespace zadanie1
{
    class Arguments
    {
        [Option('a', Required = true, HelpText = "a")]
        public double A { get; set; }

        [Option('b', Required = true, HelpText = "b")]
        public double B { get; set; }

        [Option('c', Required = true, HelpText = "c")]
        public double C { get; set; }
    }
}
