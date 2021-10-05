using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Les_Fichiers
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string folder = path + @"\Fichiers";

            bool DirExiste = false;

            DirExiste = Directory.Exists(folder);

            if (!DirExiste)
            {
                Console.WriteLine("Sorry Folder not existe");
                Directory.CreateDirectory(folder);
            }
            else
            {
                Console.WriteLine("Folder Existe");
            }
                
            DirectoryInfo Di = new DirectoryInfo(folder);

            Console.WriteLine(Di.LastAccessTime);

             foreach(DriveInfo d in DriveInfo.GetDrives())
            {
                if (d.DriveType == DriveType.Fixed)
                {
                    Console.WriteLine(d.Name);
                    Console.WriteLine(d.TotalFreeSpace);
                }
            }

            Console.ReadLine();
        }
    }
}
