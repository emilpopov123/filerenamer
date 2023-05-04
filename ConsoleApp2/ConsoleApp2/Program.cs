using System;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string directory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            DirectoryInfo dInfo = new DirectoryInfo(directory);

            foreach (var file in dInfo.GetFiles("*.jpg")) 
            {
                //Console.WriteLine(file);
                if (file.Name.Contains("Capture")) 
                {
                    System.IO.File.Move(file.FullName, directory + "\\" + file.Name.Replace("Capture", "img"));
                }
            }
        }
    }
}
