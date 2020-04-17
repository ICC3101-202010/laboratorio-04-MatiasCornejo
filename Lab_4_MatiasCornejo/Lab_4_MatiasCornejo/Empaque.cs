using System;
namespace Lab_4_MatiasCornejo
{
    public class Empaque : BaseMachine
    {
        public Empaque(int num)
        {
            this.num = num;

        }
        public override void apagar()
        {
            Console.WriteLine("el modulo de empaque se apagara");
        }

        public override void Encender()
        {
            Console.WriteLine("el modulo de empaque se encendera");
        }

        public override void reiniciar()
        {
            Console.WriteLine("el modulo de empaque se lleno por ende se reiniciara");
        }
    }
}
