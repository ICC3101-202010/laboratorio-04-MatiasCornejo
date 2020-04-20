using System;
using System.Threading;
namespace p4lab4

{
    public class Recepcion : BaseMachine, IReset

    {

        public Recepcion(int num)

        {
            this.num = num;


            memoriaocupada += num;

        }



        public override void apagar()
        {

            Console.WriteLine("El modulo de recepcion se apagara");
        }

        public override void Encender()


        {


            Console.WriteLine("El modulo de recepcion se encendera\n");
            Thread.Sleep(2000);


        }

        public override void reiniciar()
        {
            memoriaocupada = 0;
            Console.WriteLine("La maquina de recepcion se reincio correctamente");


            Console.WriteLine("Memoria ocupada= " + memoriaocupada);


        }

        public void Reset()
        {





            Console.WriteLine("Capacidad: " + memoriaRecepcion);
            Thread.Sleep(1500);
            Console.WriteLine("\n\n");
            Console.WriteLine("Memoria de maquina de recepcion se lleno , a continuacion escoja una opcion \n");
            Thread.Sleep(1500);
            Console.WriteLine("1) REINICIAR MEMORIA Y MAQUINA");
            Console.WriteLine("2) APAGAR TODO");







        }
    }
}

