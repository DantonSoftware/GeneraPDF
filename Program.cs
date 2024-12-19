using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Loader;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "wkhtmltopdf.exe";

            ProcessStartInfo oProcessStarInfo = new ProcessStartInfo();
            oProcessStarInfo.UseShellExecute = false;
            oProcessStarInfo.FileName = path;
            oProcessStarInfo.Arguments = "mihtml.html mipdf.pdf";

            using (Process oProcess = Process.Start(oProcessStarInfo))
            {
                oProcess.WaitForExit();
            }

            Console.WriteLine("PDF Creado");
            Console.Read();
        }
        catch (Exception ex){ 
            Console.WriteLine(ex.Message); 
        }
        
    }
}

