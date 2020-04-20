using System;
using System.Threading;
using Lab_4_MatiasCornejo;

namespace Lab_04_MatiasCornejo
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
            Console.WriteLine("La maquina de recepcion se reincio correctamente");


            Console.WriteLine("Memoria ocupada= " + memoriaocupada);


        }

        public void Reset()
        {



            Console.WriteLine("Memoria de maquina de recepcion se lleno , a continuacion se procedera a reiniciar la maquina y memoria\n");
            Thread.Sleep(1500);
            Console.WriteLine("Capacidad: " + memoriaRecepcion);
            Thread.Sleep(1500);
            Console.WriteLine("\n\n");



            memoriaocupada = 0;


        }
    }
}



