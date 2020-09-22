using System;
using System.IO;

public class FileIO
{
    public void LearnFileHandling()
    {
        string fileName = "file.txt";
        if (File.Exists(fileName))
        {
            string fileContent = File.ReadAllText(fileName);
            Console.WriteLine(fileContent);
        }

        File.WriteAllText(fileName, "This is just a text file");


    }

    public void LearnFileInfo()
    {
        string fileName = "file.txt";
        FileInfo fileInfo = new FileInfo(fileName);
        var size = fileInfo.Length;
        var createdDate = fileInfo.CreationTime;
        Console.WriteLine($"File Size: {size} buyes");
         Console.WriteLine($"Created date: {createdDate}");


    }

    public void LearnDirectories(){
        string directoryName = "A";
        Directory.CreateDirectory(directoryName);

    }
}