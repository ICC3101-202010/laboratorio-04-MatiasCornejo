using System;
namespace Lab_4_MatiasCornejo
{
    public class Recepcion : BaseMachine, IReset

    {

        public Recepcion(int num)

        {
            this.num = num;


            ocupado = +num;

            memoriaRecepcion = 1000;
            if (ocupado >= 300)
            {
                memoriaRecepcion += 1000;
            }




        }





        public override void apagar()
        {

            Console.WriteLine("el modulo de recepcion se apagara");
        }

        public override void Encender()


        {


            Console.WriteLine("el modulo de recepcion se encendera" + num);

        }

        public override void reiniciar()
        {
            Console.WriteLine("el modulo de recepcion se lleno por ende se reiniciara");
        }

        public void Reset()
        {
            if (ocupado >= 300)
            {

                Console.WriteLine("jjjjjj jjjjjjj" + memoriaRecepcion);
            }
        }
    }
}
