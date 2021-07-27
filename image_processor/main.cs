using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string[] filenames;

        if (args.Length > 1)
            filenames = args;
        else
            filenames = Directory.GetFiles("images/", "*.jpg");

        //ImageProcessor.Inverse(filenames);
        //ImageProcessor.Grayscale(filenames);
        //ImageProcessor.BlackWhite(filenames, 100);
        ImageProcessor.Thumbnail(filenames, 120);
    }
}
class Program : System
{
    static void Main(string[] args)
    {
        if (filenames)
        {
            for (int i = 0; i <0;){
                filename = args;
            }
        }
    }
}