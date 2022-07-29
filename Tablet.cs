using System;
namespace Prueba2_2
{
    public class Tablet : Dispositivos
    {
        public Tablet(int imei, string marca, string modelo, string sistema, string fabricacion, string hardware, string funcionalidad1, string funcionalidad2, string funcionalidad3) : base(imei, marca, modelo, sistema, fabricacion, hardware, funcionalidad1, funcionalidad2, funcionalidad3) { }

        public override void imprimir()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("Dispositivo a reparar:");
            Console.WriteLine("------------------");
            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("Modelo: " + modelo);
            Console.WriteLine("imei: " + imei);
            Console.WriteLine("Sistema operativo: " + sistemaoperativo);
            Console.WriteLine("Hardware adicional: " + hardware);
            Console.WriteLine("------------------");
        }

        public override void funcionalidades()
        {
            Console.WriteLine("------------");
            Console.WriteLine("Funcionalidades rotas para reparar: ");
            Console.WriteLine("1. " + funcionalidad1);
            Console.WriteLine("2. " + funcionalidad2);
            Console.WriteLine("3. " + funcionalidad3);
        }

        public void mostrarChip()
        {
            Console.WriteLine("chip: si");
        }
    }
}
