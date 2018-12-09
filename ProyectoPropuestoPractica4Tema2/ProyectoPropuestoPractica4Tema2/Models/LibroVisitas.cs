using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace ProyectoPropuestoPractica4Tema2.Models
{
    public class LibroVisitas
    {
        public void Grabar(string nombre, string cedula, string telefono, string correo, string comentarios)
        {
            StreamWriter archivo = new StreamWriter(HostingEnvironment.MapPath("~") + "/App_Data/datos2.txt", true);
            archivo.WriteLine("Nombre: "+nombre+"Cedula: "+cedula+"Telefono: "+telefono+"Correo: "+correo+"<br>Comentarios: " + comentarios + "<hr>");
            archivo.Close();
        }
        public string Leer()
        {
            StreamReader archivo = new StreamReader(HostingEnvironment.MapPath("~") + "/App_Data/datos2.txt");
            string todo = archivo.ReadToEnd();
            archivo.Close();
            return todo;
        }
    }
}