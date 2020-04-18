using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreArchivo = "", ubicacion = "", cadena = "";
            byte[] buffer = new byte[50];

            Console.Write("Escriba el nombre del archivo que desea crear: ");
            nombreArchivo = Console.ReadLine();

            Console.Write("Escriba la ubicacion donde va a crear el archivo: ");
            ubicacion = Console.ReadLine();

            // Creacion de archivo

            FileStream archivo = new FileStream(ubicacion + "\\" + nombreArchivo + ".txt", FileMode.Create);

            Console.WriteLine("Su archivo fue creado en: {0}\\{1}.txt", ubicacion, nombreArchivo);

          
            // Llenando el archivo con texto
            Console.WriteLine("Escriba texto en el archivo:");

            do
            {
                cadena = Console.ReadLine();

                archivo.Write(ASCIIEncoding.ASCII.GetBytes(cadena), 0, cadena.Length);

            } while (cadena != "");

                         


            archivo.Close();
           
            Console.ReadKey();






            
       
        }
    }
}
