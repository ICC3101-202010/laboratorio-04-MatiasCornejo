using System;
using System.Threading;
namespace p4lab4
{
    public class Verificacion : BaseMachine, IReset
    {
        public Verificacion(int num)
        {
            this.num = num;
            memoriaocupada += num;

        }
        public override void apagar()
        {
            Console.WriteLine("El modulo de verificacion se apagara");
        }

        public override void Encender()
        {
            Console.WriteLine("El modulo de verificacion se encendera\n");
            Thread.Sleep(2000);
        }

        public override void reiniciar()
        {
            Console.WriteLine("El modulo de verificacion se lleno por ende se reiniciara");
            Console.WriteLine("Memoria ocupada= " + memoriaocupada);
            memoriaocupada = 0;
        }

        public void Reset()
        {



            Console.WriteLine("Capacidad: " + memoriaVerificacion);
            Thread.Sleep(1500);
            Console.WriteLine("\n\n");
            Console.WriteLine("Memoria de maquina de Verificacion se lleno , a continuacion escoja una opcion \n");
            Thread.Sleep(1500);
            Console.WriteLine("1) REINICIAR MEMORIA Y MAQUINA");
            Console.WriteLine("2) APAGAR TODO");


        }
    }
}
