using System;
namespace Prueba2_2
{
	public abstract class Dispositivos{
        public int imei {get; set;}
        public string marca {get; set;}
        public string modelo {get; set;}
        public string sistemaoperativo {get; set;}
        public string paisdefabricacion {get; set;}
        public string hardware {get; set;}
        public string funcionalidad1 {get; set;}
        public string funcionalidad2 {get; set;}
        public string funcionalidad3 {get; set;}

        public Dispositivos(int imei, string marca, string modelo, string sistemaoperativo, string paisdefabricacion, string hardware, string funcionalidad1, string funcionalidad2, string funcionalidad3)
        {
        this.imei = imei;
        this.marca = marca;
        this.modelo = modelo;
        this.sistemaoperativo = sistemaoperativo;
        this.paisdefabricacion = paisdefabricacion;
        this.hardware = hardware;
        this.funcionalidad1 = funcionalidad1;
        this.funcionalidad2 = funcionalidad2;
        this.funcionalidad3 = funcionalidad3;
        }

        public abstract void imprimir();
        public  abstract void funcionalidades();
    }
}
