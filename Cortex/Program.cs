using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Veylib.ICLI;

namespace Cortex
{
    internal class Program
    {

        public static string dir = @"";

        static void Main(string[] args)
        {

            var props = new CLI.StartupProperties
            {
                Author = new CLI.StartupAuthorProperties
                {
                    Name = "CORSEC",
                    Url = "https://wwwsins.uk/"
                },
                Logo = new CLI.StartupLogoProperties()
                {
                    AutoCenter = true,
                    Text = config.Logo,
                },
            };


            CLI.Start(props);
            CLI.WriteLine("Example Usage:");
            CLI.WriteLine("Directory To Clone Into ›› C:\\Desktop\\Example");
            CLI.WriteLine("Git Repository To Clone ›› user/repo");
            CLI.WriteLine("This Will Clear In 3 Seconds.");

            CLI.Delay(3500);
            CLI.Clear();

            var TargetDirectory = CLI.ReadLine("Directory To Clone Into ›› ");
            var TargetRepo = CLI.ReadLine("Git Repository To Clone ›› ");

            CLI.WriteLine("Attempted To Clone The Repo: Closing In 3 Seconds.");
            CLI.Delay(3000);
            Environment.Exit(0);
        }
    }
}
