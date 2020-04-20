using System;
using System.Threading;
namespace p4lab4
{
    public class Almacenamiento : BaseMachine, IReset
    {
        public Almacenamiento(int num)
        {
            this.num = num;
            memoriaocupada += num;

        }
        public override void apagar()
        {
            Console.WriteLine("El modulo de almacenamiento se apagara\n");
        }

        public override void Encender()
        {
            Console.WriteLine("El modulo de almacenamiento se encendera\n");
            Thread.Sleep(2000);
        }

        public override void reiniciar()
        {
            memoriaocupada = 0;
            Console.WriteLine("El modulo de almacenamiento se lleno por ende se reiniciara");

            Console.WriteLine("Memoria ocupada= " + memoriaocupada);




        }


        public void Reset()
        {


            Thread.Sleep(1500);
            Console.WriteLine("Capacidad: " + memoriaAlmacenamiento);
            Thread.Sleep(1500);
            Console.WriteLine("Memoria de maquina de Almacenamiento se lleno , a continuacion escoja una opcion \n");
            Thread.Sleep(1500);
            Console.WriteLine("1) REINICIAR MEMORIA Y MAQUINA");
            Console.WriteLine("2) APAGAR TODO");


        }

    }
}
