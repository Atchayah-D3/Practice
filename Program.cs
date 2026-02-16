//using System;
//using System.IO;

//class Program
//{
//    static void Mains()
//    {
//        string[] arrayString = new string[] {"hello","world!","Creating", "a new file","with","Array of strings." };
//        if (!Directory.Exists("MyFolder")) {
//            Directory.CreateDirectory("MyFolder"); }
//        string path = "MyFolder/practiceFile.txt";
//        using (FileStream file = new FileStream(path, FileMode.Append, FileAccess.Write))
//        {
//            using (StreamWriter writer = new StreamWriter(file, leaveOpen: true))
//            {
//                writer.WriteLine(String.Join(" ", arrayString));
//                string[] newElements = new string[] { "appending", "new words", "to", "the existing file" };
//                writer.WriteLine(string.Join(" ", newElements));
                
//            }
//                  }
//            using FileStream files = new FileStream(path, FileMode.Open, FileAccess.Read);
//            files.Position = 0;
//            using (
//                StreamReader reader = new StreamReader(files))
//            {
//                string res = reader.ReadToEnd();
//                Console.WriteLine(res);
//            }
//        if (File.Exists(path))
//        {
//            string destPath = @"MyFolder/dest.txt";
//            string newDestPath = @"New Folders/dest.txt";
//            FileInfo fileInfo = new FileInfo(path);
//            Console.WriteLine(fileInfo.Name);
//            File.Copy(path, destPath);
//            Directory.CreateDirectory("New Folders");
//            if (File.Exists(newDestPath))
//                File.Delete(newDestPath);
//            File.Move(destPath, newDestPath,overwrite:true);
//            File.Delete(destPath);
//        }
        
//    }
//}