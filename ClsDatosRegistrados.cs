using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Declaro libreia de escritura y lectura de archivos//
using System.IO;
using System.Windows.Forms;

namespace PryMendozaIntegrador
{
    internal class ClsDatosRegistrados
    {

        public string NombreArchivo = "D:\\Escritorio\\TpIntegrador-mendoza\\PryMendozaIntegrador\\bin\\Debug\\DatosClientes.csv";

        public void grabar(string numero, string apellido, string nombre, string dni, string email)
        {
            StreamWriter Archivo = new StreamWriter(NombreArchivo, true); //ABRIR ARCHIVO
            Archivo.Write(numero);
            Archivo.Write(";");
            Archivo.Write(apellido);
            Archivo.Write(";");
            Archivo.Write(nombre);
            Archivo.Write(";");
            Archivo.Write(dni);
            Archivo.Write(";");
            Archivo.Write(email);
            Archivo.WriteLine(numero); //WRITELINE PARA QUE SALTE LA LINEA SIGUIENTE 
            Archivo.Close(); //CIERRO ARCHIVO
            Archivo.Dispose();//Liberar Memoria 
        }
    }
}
