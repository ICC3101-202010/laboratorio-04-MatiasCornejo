using System;
using System.Threading;
using Lab_4_MatiasCornejo;

namespace Lab_04_MatiasCornejo
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
            Console.WriteLine("El modulo de almacenamiento se lleno por ende se reiniciara");

            Console.WriteLine("Memoria ocupada= " + memoriaocupada);




        }


        public void Reset()
        {


            Console.WriteLine("Memoria de maquina de almacenamiento se lleno , a continuacion se procedera a reiniciar la maquina y memoria\n");
            Thread.Sleep(1500);
            Console.WriteLine("Capacidad: " + memoriaAlmacenamiento);
            Thread.Sleep(1500);
            Console.WriteLine("\n\n");

            memoriaocupada = 0;
        }

    }
}

