using System;
namespace Lab_4_MatiasCornejo
{
    public class Verificacion : BaseMachine
    {
        public Verificacion(int num)
        {
            this.num = num;

        }
        public override void apagar()
        {
            Console.WriteLine("el modulo de verificacion se apagara");
        }

        public override void Encender()
        {
            Console.WriteLine("el modulo de verificacion se encendera");
        }

        public override void reiniciar()
        {
            Console.WriteLine("el modulo de verificacion se lleno por ende se reiniciara");
        }
    }
}
