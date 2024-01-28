using System;
using System.IO;

namespace NFS.Unpacker
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Need for Speed ZDIR Unpacker");
            Console.WriteLine("(c) 2021 Ekey (h4x0r) / v{0}\n", Utils.iGetApplicationVersion());
            Console.ResetColor();

            if (args.Length != 2)
            {
                ShowUsage();
                return;
            }

            string m_BinFile = args[0];
            string m_Output = args[1];

            if (!File.Exists(m_BinFile))
            {
                Utils.iSetError($"[ERROR]: Input file '{m_BinFile}' does not exist.");
                return;
            }

            if (Path.GetFileName(m_BinFile).ToLower() != "zdir.bin")
            {
                Utils.iSetError("[ERROR]: You must specify ZDIR.BIN file for extracting files!");
                return;
            }

            BinUnpack.iDoIt(m_BinFile, m_Output);
        }

        static void ShowUsage()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("[Usage]");
            Console.WriteLine("    NFS.Unpacker <m_File> <m_Directory>\n");
            Console.WriteLine("    m_File - Source ZDIR.BIN index file");
            Console.WriteLine("    m_Directory - Destination directory\n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[Examples]");
            Console.WriteLine("    RS.Unpacker E:\\Games\\NFS\\ZDIR.BIN D:\\Unpacked");
            Console.ResetColor();
        }
    }
}
