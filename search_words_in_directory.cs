using System;
using System.IO;	
public class Program
{
	public static void Main()
	{
		   String[] words = File.ReadAllLines("words.txt");
            String[] fileNames = Directory.GetFiles("filesDirectory");
            Directory.CreateDirectory("CopiedFiles");
            foreach(String fileName in fileNames)
            {
            foreach(string word in words)
            {
            String file = Path.GetFileName(fileName);
            if (file.Contains(word))
            {
              File.Copy(fileName, "CopiedFiles//" + file);
            }
          }
       }
  	}
}
