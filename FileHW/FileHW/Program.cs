using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHW
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = string.Empty;
            Console.WriteLine("Choose number of drive");
            DriveInfo[] drives = DriveInfo.GetDrives();
            for (int i = 0; i < drives.Length; i++)
            {
                if (drives[i].IsReady)
                {
                    Console.WriteLine($"{i},{ drives[i].Name}");
                }
            }
            var position = int.Parse(Console.ReadLine());
            path += drives[position].Name;
            foreach (var directory in drives[position].RootDirectory.EnumerateDirectories())
            {
                Console.WriteLine(directory.Name);
            }
            Console.WriteLine("Enter Name of Folder which have file INPUT.txt");
            path += Console.ReadLine();
            var neededFolder = path;
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            Console.WriteLine("enter File Name");
            path += @"\INPUT.txt";
            if (!File.Exists(path))
            {
                using (File.Create(path));
                using (var writer = new StreamWriter(path))
                {
                    string data = "5 8";
                    writer.Write(data);
                }

            }
            int a, b,sum;
            int numberFibonacci;
            using (var reader = new StreamReader(path))
            {
                string result = reader.ReadToEnd();
                result.Trim(' ');
                a=(int)result.First();
                b = (int)result.Last();
                sum = a + b;
                numberFibonacci = b + sum;
            }
            neededFolder += @"\OUTPUT.txt";
            if (!File.Exists(neededFolder))
            {
                using (File.Create(neededFolder)) ;
                using (var writer = new StreamWriter(neededFolder))
                {
                    string data = sum.ToString();
                    writer.Write(data);
                }
            }
            using (var writer = new StreamWriter(path))
            {
                string data = sum.ToString()+" "+numberFibonacci.ToString();
                writer.Write(data);
            }
        }
    }
}
