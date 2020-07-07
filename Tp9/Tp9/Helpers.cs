using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Tp9
{
    static class SoporteParaConfiguracion
    {
        static public void CrearArchivoDeConfiguracion(string archivo)
        {
            if (!File.Exists(archivo))
            {
                string NuevoArchivo = "ruta.dat";
                if (!File.Exists(NuevoArchivo))
                {
                    File.Create(NuevoArchivo);
                }
                File.WriteAllText(NuevoArchivo, archivo);
            }
            else
            {
                Console.WriteLine("el archivo ya a sido creado");
            }
        }
        public static string LeerConfiguracion(string Ruta)
        {
            BinaryReader LeerBinary = new BinaryReader(File.Open(Ruta + @"\ruta.dat", FileMode.Open));
            string contenido = LeerBinary.ReadString();
            LeerBinary.Close();
            return contenido;
        }
        public static class ConversorDeMorse
        {
            public static Dictionary<char, string> Diccionario = new Dictionary<char, string>
            {
                {'a', ".-"},
                {'b', "-..."},
                {'c', "-.-."},
                {'d', "-.."},
                {'e', "."},
                {'f', "..-."},
                {'g', "--."},
                {'h', "...."},
                {'i', ".."},
                {'j', ".---"},
                {'k', "-.-"},
                {'l', ".-.."},
                {'m', "--"},
                {'n', "-."},
                {'o', "---"},
                {'p', ".--."},
                {'q', "--.-"},
                {'r', ".-."},
                {'s', "..."},
                {'t', "-"},
                {'u', "..-"},
                {'v', "...-"},
                {'w', ".--"},
                {'x', "-..-"},
                {'y', "-.--"},
                {'z', "--.."},
                {'0', "-----"},
                {'1', ".----"},
                {'2', "..---"},
                {'3', "...--"},
                {'4', "....-"},
                {'5', "....."},
                {'6', "-...."},
                {'7', "--..."},
                {'8', "---.."},
                {'9', "----."},
                {' ', "\\" },
            };

            static public string TextoAMorse(string cadena)
            {
                string traduc = "";
                cadena = cadena.ToLower();
                foreach (char letra in cadena)
                {
                    foreach (KeyValuePair<char, string> elemento in Diccionario)
                    {
                        if (Convert.ToChar(elemento.Key) == letra)
                        {
                            traduc = traduc + elemento.Value;
                            break;
                        }
                    }
                }
                Console.WriteLine("salida: ");
                Console.WriteLine(traduc);
                return traduc;
            }
        }
    }
}
