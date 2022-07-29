using System;
namespace Prueba2_2
{
    public class Cliente
    {
        public string nombre {get; set;}
        public string dispositivo2 {get; set;}
        public string funcionalidadr {get; set;}

        public Cliente(string nombre, string dispositivo2, string funcionalidadr)
        {
            this.nombre = nombre;
            this.dispositivo2 = dispositivo2;
            this.funcionalidadr = funcionalidadr;
        }

        public void ordenReparacion()
        {
            Console.WriteLine("Nombre del cliente: " + nombre);
            Console.WriteLine("Dispositivo a reparar: " + dispositivo2);
            Console.WriteLine("Funcionalidad a reparar: " + funcionalidadr);
        }
    }
}