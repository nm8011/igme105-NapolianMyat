using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/// <summary>
/// Napolian Myat
/// Professor Warren
/// 04/18/2022
/// Project: PE19
/// </summary>
namespace NM_PE19
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Get a listing of all files in a specific directory. (Hint: use one of the classes we discussed at the start of lecture.)
            Console.WriteLine("Current Directory: " + Directory.GetCurrentDirectory());
            string[] files = Directory.GetFiles(".");
            foreach (string file in files)
            {
                Console.WriteLine("File name: " + file);
            }
            Console.WriteLine();

            //CREATE FILE READWRITE FILE - DISPLAY DATA
            //•	Read only the “plane” files back in and display the data for each one.
            Plane fokkerPlane = new Plane("fokkerPlane.dat", "Fokker DR 1", 
                "Germany", 'D', 'A', 1000.00, 13);
            fokkerPlane.WriteBinary();
            fokkerPlane.ReadBinary();
            Console.WriteLine();

            Plane spadPlane = new Plane("spadPlane.dat", "SPAD XIII", 
                "France", 'A', 'A', 1250.50, 16);
            spadPlane.WriteBinary();
            spadPlane.ReadBinary();
            Console.WriteLine();

            Plane sopwithPlane = new Plane("sopwithPlane.dat", "Sopwith Camel", 
                "England", 'C', 'A', 890.00, 15);
            sopwithPlane.WriteBinary();
            sopwithPlane.ReadBinary();
            Console.WriteLine();

            Plane albatrosPlane = new Plane("albatrosPlane.dat", "Albatros D", 
                "Germany", 'B', 'A', 1575.75, 15);
            albatrosPlane.WriteBinary();
            albatrosPlane.ReadBinary();
            Console.WriteLine();

            

        }
    }
}
