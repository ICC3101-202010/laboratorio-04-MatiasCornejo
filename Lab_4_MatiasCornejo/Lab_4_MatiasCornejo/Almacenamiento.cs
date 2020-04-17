using System;
namespace Lab_4_MatiasCornejo
{
    public class Almacenamiento : BaseMachine
    {
        public Almacenamiento(int num)
        {
            this.num = num;

        }
        public override void apagar()
        {
            Console.WriteLine("el modulo de almacenamiento se apagara");
        }

        public override void Encender()
        {
            Console.WriteLine("el modulo de almacenamiento se encendera");
        }

        public override void reiniciar()
        {
            Console.WriteLine("el modulo de almacenamiento se lleno por ende se reiniciara");
        }
    }
}
