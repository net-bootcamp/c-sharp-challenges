using System;
using System.IO;

namespace FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // You need a path in directory creation
            string path = "C:/Users/HP/Desktop";
            string folderName = "/CCCC#";
            // string fileName = "/chapter1.txt"; // file extension needed

            // 1- Folder creation & for best design check if the folder exists or not

            /*if (!Directory.Exists (path +folderName ))
            {
                Directory.CreateDirectory(path + folderName);
                Console.WriteLine("Folder' " + folderName + " 'created");
            }
            else
            {
                Console.WriteLine("Folder' " + folderName + " 'exists");
            }*/
            //To make it easy you can do it like this 
            /* string path = "C:/Users/HP/Desktop/CCCC#";
             //folder creation
             Directory.CreateDirectory(path );*/

            /* 2- to delete an exist folder
             if (Directory.Exists(path+folderName))
             {
                 Directory.Delete(path + folderName);
             }*/

            //3- To create folder conain a file or just crete file in existing folder 

            /* Directory.CreateDirectory(path + folderName);
             File.Create(path + folderName + fileName);
 */

            //4- To write into txt file (many function for writing process "find & more") & read from file

            /* File.WriteAllText(path + folderName + fileName , "Hello in c# world!!");
             string message = File.ReadAllText(path + folderName + fileName);
             Console.WriteLine(message);*/

            //5- delete file but if there

            /* if (File.Exists(path + folderName + fileName))
             {
                 File.Delete(path + folderName + fileName);
             }
             else
             {
                 Console.WriteLine("File '" + fileName + " 'deleted");

             }*/

            // create folder with 4 files at once with different name

            // 6- create folder
            if (!Directory.Exists(path + folderName))
            {
                Directory.CreateDirectory(path + folderName);
                Console.WriteLine("Folder' " + folderName + " 'created");
            }
            else
            {
                Console.WriteLine("Folder' " + folderName + " 'exists");
            }
            // create files
            string[] copies = {"/one.txt", "/two.txt","/third.txt", "/fourth.txt"};
            foreach (var copy in copies)
            {
                File.Create(path + folderName + copy);
            }
            
        }
    }
}
