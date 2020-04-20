
using System;
using System.Threading;
using Lab_04_MatiasCornejo;

namespace Lab_4_MatiasCornejo
{
    public class Ensamblaje : BaseMachine, IReset
    {
        public Ensamblaje(int num)
        {
            this.num = num;

        }
        public override void apagar()
        {
            Console.WriteLine("El modulo de ensamblaje se apagara");
        }

        public override void Encender()
        {
            Console.WriteLine("El modulo de ensamblaje se encendera\n");
            Thread.Sleep(2000);
        }

        public override void reiniciar()
        {
            Console.WriteLine("El modulo de ensamblaje se lleno por ende se reiniciara");
            Console.WriteLine("Memoria ocupada= " + memoriaocupada);
        }
        public void Reset()
        {


            Console.WriteLine("Memoria de maquina de ensamblaje se lleno , a continuacion se procedera a reiniciar la maquina y memoria");
            Thread.Sleep(1500);
            Console.WriteLine("Capacidad: " + memoriaEnsamblaje);
            Thread.Sleep(1500);
            Console.WriteLine("\n\n");


            memoriaocupada = 0;
        }
    }
}

