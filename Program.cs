using System;
namespace Prueba2_2{
    public class Program{
        public static void Main(string[] args){

            Celular celular = new Celular(10926894,"huawei", "y9", "Android", "Taiwan","auriculares","Pantalla", "Reproductor de musica", "Camara de fotos");
            Tablet tablet = new Tablet(64901758,"Samsung", "S7+", "Android", "Japon","Cargador","Pantalla", "Reproductor de musica", "Camara de fotos");
            Cliente cliente = new Cliente("Josue Cedeño", "Tablet", "Parlantes");
            Cliente cliente2 = new Cliente("Carla Piguave", "Tablet", "Conector USB");
            
            List<Cliente> lista3 = new List<Cliente>();
            lista3.Add(cliente);
            lista3.Add(cliente2);

            foreach(Cliente lista4 in lista3){
                lista4.ordenReparacion();
            }

            List<Dispositivos> lista1 = new List<Dispositivos>();
            lista1.Add(celular);
            lista1.Add(tablet);

            foreach(Dispositivos lista2 in lista1){
                lista2.imprimir();
                lista2.funcionalidades();
            }

            foreach(Ichip lista5 in lista1){
                lista5.mostrarChip();
            }
        }
    }
}