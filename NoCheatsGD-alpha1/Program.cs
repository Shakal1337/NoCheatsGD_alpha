using System;
using System.IO;
using System.Linq;
namespace NoCheatsGD_alpha1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcom");
            Console.WriteLine("to NoCheatsGD alpha");

            string programdatafloderCreateSetings = @"C:\ProgramData\NoCheatsGD-Alpha";
            string ProgramDataFloderResultCreateSetings = @"C:\ProgramData\NoCheatsGD-Alpha\result";
            string txtprogramddataCreateSetings = @"C:\ProgramData\NoCheatsGD-Alpha\path.txt";
            string gdbotname = File.ReadLines(txtprogramddataCreateSetings).ElementAtOrDefault(1);

            string ProgramDataFloderResultBotMoveSetings = @"C:\ProgramData\NoCheatsGD-Alpha\result\" + gdbotname;

            string ProgramDataFloderResultGDHMMoveSetingsMod1 = @"C:\ProgramData\NoCheatsGD-Alpha\result\bypass.json";
            string ProgramDataFloderResultGDHMMoveSetingsMod2 = @"C:\ProgramData\NoCheatsGD-Alpha\result\player.json";
            string ProgramDataFloderResultGDHMMoveSetingsMod3 = @"C:\ProgramData\NoCheatsGD-Alpha\result\global.json";
            string ProgramDataFloderResultGDHMMoveSetingsMod4 = @"C:\ProgramData\NoCheatsGD-Alpha\result\core.json";
            string ProgramDataFloderResultGDHMMoveSetingsMod5 = @"C:\ProgramData\NoCheatsGD-Alpha\result\creator.json";
            string ProgramDataFloderResultGDHMMoveSetingsMod6 = @"C:\ProgramData\NoCheatsGD-Alpha\result\variables.json";


            string ModBypass = "bypass.json";
            string ModPlayer = "player.json";
            string ModGlobal = "global.json";
            string ModCore = "core.json";
            string ModCreator = "creator.json";
            string ModVB = "variables.json";

            bool filesearch = File.Exists(programdatafloderCreateSetings);
            bool filesearchresult = File.Exists(ProgramDataFloderResultCreateSetings);
            bool txtsearch = File.Exists(txtprogramddataCreateSetings);
            bool gdhmmodsearch = File.Exists(ProgramDataFloderResultGDHMMoveSetingsMod4);
            bool gdbotsearch = File.Exists(ProgramDataFloderResultBotMoveSetings);


            if (txtsearch)
            {

                Console.WriteLine("\nwhat .dll files is going to disable");
                Console.WriteLine("bot:GDbot. core:Core gdhm. res: restore all.");
                string MainCoreEngine = Console.ReadLine();
                try
                {
                    switch (MainCoreEngine)
                    {
                        case "bot":
                            {
                                string gdbotsource = File.ReadLines(txtprogramddataCreateSetings).ElementAtOrDefault(0);
                                string gdbotsourcename = File.ReadLines(txtprogramddataCreateSetings).ElementAtOrDefault(1);
                                File.Move(gdbotsource + gdbotsourcename, ProgramDataFloderResultBotMoveSetings);
                                Console.WriteLine("Copmlete!");
                                Console.WriteLine("Press any key to close");
                                Console.ReadKey();


                            }
                            break;

                        case "core":
                            {
                                string gdhmsource = File.ReadLines(txtprogramddataCreateSetings).ElementAtOrDefault(2);
                                File.Move(gdhmsource + ModBypass , ProgramDataFloderResultGDHMMoveSetingsMod1);
                                File.Move(gdhmsource + ModPlayer, ProgramDataFloderResultGDHMMoveSetingsMod2);
                                File.Move(gdhmsource + ModGlobal, ProgramDataFloderResultGDHMMoveSetingsMod3);
                                File.Move(gdhmsource + ModCore, ProgramDataFloderResultGDHMMoveSetingsMod4);
                                File.Move(gdhmsource + ModCreator, ProgramDataFloderResultGDHMMoveSetingsMod5);
                                File.Move(gdhmsource + ModVB, ProgramDataFloderResultGDHMMoveSetingsMod6);
                                Console.WriteLine("Copmlete!");
                                Console.WriteLine("\nPress any key to close");
                                Console.ReadKey();



                            }
                            break;

                        case "res":
                            {
                                string gdbotsourceres = File.ReadLines(txtprogramddataCreateSetings).ElementAtOrDefault(0);
                                string gdbotsourcename = File.ReadLines(txtprogramddataCreateSetings).ElementAtOrDefault(1);
                                string gdhmsource = File.ReadLines(txtprogramddataCreateSetings).ElementAtOrDefault(2);

                                if (gdhmmodsearch)
                                {
                                    File.Move(ProgramDataFloderResultBotMoveSetings, gdbotsourceres + gdbotsourcename);
                                    File.Move(ProgramDataFloderResultGDHMMoveSetingsMod1, gdhmsource + ModBypass);
                                    File.Move(ProgramDataFloderResultGDHMMoveSetingsMod2, gdhmsource + ModPlayer);
                                    File.Move(ProgramDataFloderResultGDHMMoveSetingsMod3, gdhmsource + ModGlobal);
                                    File.Move(ProgramDataFloderResultGDHMMoveSetingsMod4, gdhmsource + ModCore);
                                    File.Move(ProgramDataFloderResultGDHMMoveSetingsMod5, gdhmsource + ModCreator);
                                    File.Move(ProgramDataFloderResultGDHMMoveSetingsMod6, gdhmsource + ModVB);
                                    Console.WriteLine("Restore gdhm copmlete!");
                                    Console.WriteLine("\nPress any key to continue...");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("\nGDHM files not found.");
                                    Console.WriteLine("\nPress any key to continue...");
                                    Console.ReadKey();
                                }
                                if (gdbotsearch)
                                {
                                    File.Move(ProgramDataFloderResultBotMoveSetings, gdbotsourceres + gdbotsourcename);
                                    Console.WriteLine("\nRestore bot copmlete !");
                                    Console.WriteLine("\nPress any key to continue...");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("\nGDbot not found ");
                                    Console.WriteLine("\nPress any key to continue...");
                                    Console.ReadKey();
                                }

                            }
                            break;




                        default:
                            {
                              Console.WriteLine("error comand.");
                            }
                            break;
                    }
                }

                catch (Exception e)
                {
                    Console.WriteLine($"\n{e.Message}");
                    Console.WriteLine("Press any key to close...");
                    Console.ReadKey();
                }

            }

            else   ////
            {
                Console.WriteLine("floder not found , and create again.");
                if (filesearch)
                {
                    File.Create(txtprogramddataCreateSetings);
                    Console.ReadKey();
                    if (filesearchresult)
                    {
                        Console.WriteLine("\npls any key to restart...");
                        Console.ReadKey();
                    }
                    else
                    {

                        Directory.CreateDirectory(ProgramDataFloderResultCreateSetings);
                        Console.WriteLine("\npls any key to restart...");
                        Console.ReadKey();
                    }

                }
                else
                {

                    Directory.CreateDirectory(programdatafloderCreateSetings);
                    Directory.CreateDirectory(ProgramDataFloderResultCreateSetings);
                    File.Create(txtprogramddataCreateSetings);
                    Console.WriteLine("\npls any key to restart...    ");
                    Console.ReadKey();
                }


            }

        }
    }
}
