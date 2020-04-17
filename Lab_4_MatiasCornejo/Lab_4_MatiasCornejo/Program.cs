using System;

namespace Lab_4_MatiasCornejo
{
    class MainClass
    {



        public static void Main(string[] args)
        {
            int x;
            x = 4; //aqui tengo que crear un numero ramdom 

            Recepcion r1 = new Recepcion(x);
            r1.Encender();
            Almacenamiento a1 = new Almacenamiento(x);
            a1.Encender();
            Ensamblaje e1 = new Ensamblaje(x);
            e1.Encender();
            Verificacion v1 = new Verificacion(x);
            v1.Encender();
            Empaque mm1 = new Empaque(x);
            mm1.Encender();



            int n1;
            n1 = 1;

            int s;
            s = 230;


            int m1;
            m1 = 1000;
            int m2;
            m2 = 1000;
            int m3;
            m3 = 1000;
            int m4;
            m4 = 1000;
            int m5;
            m5 = 1000;

            while (n1 <= 5)



            {


                Recepcion r2 = new Recepcion(s);

                Almacenamiento a2 = new Almacenamiento(n1);

                Ensamblaje e2 = new Ensamblaje(n1);

                Verificacion v2 = new Verificacion(n1);

                Empaque mm2 = new Empaque(n1);

                n1 += 1;
                s += 100;



                r2.Reset();

                Console.WriteLine("el proceso del producto n: " + n1 + " se completo correctamente");
            }







            int f;
            f = 0;


            // while (f <= 20)

            {
                int r;
                int n2;

                n2 = 1;

                r = 3;//importante que este r sea un numero ramdom








                Console.WriteLine(f);
                f += 3;
            }

        }





    }
}
