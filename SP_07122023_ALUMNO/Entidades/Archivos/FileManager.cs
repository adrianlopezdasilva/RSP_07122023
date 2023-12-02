using Entidades.Exceptions;
using Entidades.Interfaces;
using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades.Files
{
    
    public static class FileManager
    {
        private static string path;

        static FileManager()
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\SP_07122023_ALUMNO\\";
        }

        private static void ValidaExistenciaDeDirectorio()
        {
            try
            { 
                if(Directory.Exists(path) == false) 
                { 
                   Directory.CreateDirectory(path);
                }

            }
            catch
            {
                throw new FileManagerException("Error al crear el directorio"); //double-check esto
            }
        }

        public static void Guardar(string data, string nombreArchivo, bool append)
        {

        }

        public static bool Serializar <T>(T elemento, string nombreArchivo)
        {

            return true;
        }
    }
}
