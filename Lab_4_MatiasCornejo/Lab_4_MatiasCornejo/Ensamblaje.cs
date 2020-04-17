using System;
namespace Lab_4_MatiasCornejo
{
    public class Ensamblaje : BaseMachine
    {
        public Ensamblaje(int num)
        {
            this.num = num;

        }
        public override void apagar()
        {
            Console.WriteLine("el modulo de ensamblaje se apagara");
        }

        public override void Encender()
        {
            Console.WriteLine("el modulo de ensamblaje se encendera");
        }

        public override void reiniciar()
        {
            Console.WriteLine("el modulo de ensamblaje se lleno por ende se reiniciara");
        }
    }
}
