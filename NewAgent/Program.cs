using System;
using System.IO;

namespace NewAgent
{
    class Program
    {
        static void Main(string[] args)
        {
            FileSystemWatcher fsw = new FileSystemWatcher("C:\\Users\\sait.gul\\Desktop\\yeni");
            fsw.EnableRaisingEvents = true;
            fsw.IncludeSubdirectories = true;
            fsw.Renamed += new RenamedEventHandler(fsw_Renamed);
            fsw.Deleted += new FileSystemEventHandler(fsw_Deleted);
            fsw.Changed += new FileSystemEventHandler(fsw_Changed);
            fsw.Created += new FileSystemEventHandler(fsw_Created);
            fsw.WaitForChanged(WatcherChangeTypes.All);
            Console.Read();
        }

        private static void fsw_Created(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Oluşturuldu");
        }

        private static void fsw_Changed(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Değiştirildi");
        }

        private static void fsw_Deleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Silindi");
        }

        private static void fsw_Renamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine("Yeniden Adlandırıldı");
        }
    }
}
