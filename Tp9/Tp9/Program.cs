using System;
using System.IO;

namespace Tp9
{
    class Program
    {
        static void Main(string[] args)
        {
            string ruta = Directory.GetCurrentDirectory();
            SoporteParaConfiguracion.CrearArchivoDeConfiguracion(ruta);
            string Directorio = SoporteParaConfiguracion.LeerConfiguracion(ruta);
            if (Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta + @"morse\");
            }
            Console.WriteLine("se creo el archivo" + Directorio + "datos guardados");
            Console.Write("ingrese una oracion");
            string aTra = Console.ReadLine();
            //texto a morse
            string TextToMorse = ConversorDeMorse.TextoAMorse(aTra, ToUpper());
            Console.WriteLine("\nLa traduccion se guardo"+ );
        }


    }
}
