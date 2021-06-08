using System;
using System.IO;
using System.Linq;

namespace Week10.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceDirectory = @"C:\test\test1.txt";
            //string archiveDirectory = @"C:\test1";
            //string filterFiles = "*.txt";
            //string[] a = Directory.GetFiles(sourceDirectory);
            //foreach (var item in a)
            //{
            //    Console.WriteLine(item);
            //}
            // FileStream a =  File.OpenWrite(sourceDirectory);
            //if (!File.Exists(sourceDirectory))
            //{
            //    // Create a file to write to.
            //    using (StreamWriter sw = File.CreateText(sourceDirectory))
            //    {
            //        sw.WriteLine("Hello");
            //        sw.WriteLine("And");
            //        sw.WriteLine("Welcome");
            //    }
            //}
            //using (StreamWriter sw = File.AppendText(sourceDirectory))
            //{
            //    sw.WriteLine("This");
            //    sw.WriteLine("is Extra");
            //    sw.WriteLine("Text");
            //}

            //// Open the file to read from.
            //using (StreamReader sr = File.OpenText(sourceDirectory))
            //{
            //    string s = "";
            //    while ((s = sr.ReadLine()) != null)
            //    {
            //        Console.WriteLine(s);
            //    }
            //}
            //string yol = @"C:\test\test.txt";
            //string[] a = { "Ferid", "Mehmed", "salam", "Gedes" };
            //File.WriteAllLines(yol, a);
            //File.WriteAllText(yol, "sdf");

            //using (StreamWriter streamWriter = new StreamWriter(yol, true))
            //{
            //    foreach (var item in a)
            //    {
            //        if (item.Contains("salam"))
            //        {
            //            streamWriter.WriteLine(item);
            //        }
            //    }
            //}
            //using (StreamWriter streamWriter = new StreamWriter(yol))
            //{
            //    foreach (var item in a)
            //    {
            //        if (item.Contains("salam"))
            //        {
            //            streamWriter.WriteLine(item);
            //        }
            //    }
            //}

            FileAppend(sourceDirectory, "asdasdas");
            FileAppend(sourceDirectory, "a332");
        }
        static void FilterFolderFileMove(string sourceDirectory, string archiveDirectory, string filterFiles)
        {
            try
            {
                var txtFiles = Directory.EnumerateFiles(sourceDirectory, filterFiles);

                foreach (string currentFile in txtFiles)
                {
                    string fileName = currentFile.Substring(sourceDirectory.Length + 1);
                    Directory.Move(currentFile, Path.Combine(archiveDirectory, fileName));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void FolderFileMove(string sourceDirectory, string destinationDirectory)
        {
            try
            {
                Directory.Move(sourceDirectory, destinationDirectory);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void CreateNewFolder(string path)
        {
            Directory.CreateDirectory(path);
        }
        static bool HaveFolder(string path)
        {
            return Directory.Exists(path);
        }
        static void DeleteDir(string path)
        {
            if (HaveFolder(path))
            {
                Directory.Delete(path, true);
            }
        }
        static void CreateNewFile(string path)
        {
            FileStream fileStream = File.Create(path);
            fileStream.Close();
        }
        static bool HaveFile(string path)
        {
            return File.Exists(path);
        }
        static void FileAppend(string path, string data)
        {
            File.AppendAllText(path, data);
        }
        static string FileRead(string path)
        {
            return File.ReadAllText(path);
        }
    }
}
