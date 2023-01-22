using System;
using System.IO;

namespace NoCheatsGD_WriteFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"please indicate the path to the GD folder where your GDbot example is stored: ...\GeometryDash\.GDHM\dll");
            Console.WriteLine("please write the name of the bot you are using example: GDBot.dll");
            Console.WriteLine(@"and to the folder where mods are stored example: ...\GeometryDash\.GDHM\mod");
            string sy = "stop";
            Console.WriteLine($"to stop recording pls enter {sy}");

            string txtprogramddata = @"C:\ProgramData\NoCheatsGD-Alpha\path.txt";

            using (var txt = new StreamWriter(txtprogramddata))
            {

                while (true)
                {
                    var line = Console.ReadLine();

                    if (line == "stop")
                        break;

                    txt.WriteLine(line);
                }

            }



        }
    }
}
