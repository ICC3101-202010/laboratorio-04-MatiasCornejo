
using System;
using System.Threading;
using Lab_4_MatiasCornejo;

namespace Lab_04_MatiasCornejo
{
    class MainClass
    {



        public static void Main(string[] args)
        {
            //comienza el dia de las maquinas

            Console.WriteLine("buenos dias , comenzara el proceso de encendido de las maquinas \n");
            Thread.Sleep(2000);
            int x;
            x = 4;

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
            n1 = 0;

            int MR;
            int MA;
            int MEN;
            int MV;
            int MEM;  //cuanto en cuanto se iran llenando las maquinas , la idea es que cada maquina tenga una capacidad
            MR = 0;           //diferente para que se puedan reiniciar aleatoriamente
            MA = 0;
            MEN = 0;
            MV = 0;
            MEM = 0;
            while (n1 <= 8)



            {


                Recepcion r2 = new Recepcion(MR);

                Almacenamiento a2 = new Almacenamiento(n1);

                Ensamblaje e2 = new Ensamblaje(n1);

                Verificacion v2 = new Verificacion(n1);

                Empaque mm2 = new Empaque(n1);


                n1 += 1;

                Console.WriteLine("Emperzara el proceso del objeto nº" + n1 + "\n");
                Thread.Sleep(2000);
                Random rnd = new Random();  //creo un numero aleatorio 1
                int al1 = rnd.Next(100, 300);




                MR += al1;
                if (MR >= r2.memoriaRecepcion)
                {
                    Console.WriteLine("\n\n");
                    Thread.Sleep(2000);
                    r2.Reset();
                    Thread.Sleep(2000);
                    r2.reiniciar();
                    Thread.Sleep(2000);
                    MR = 0;
                }
                Thread.Sleep(2000); //funcion para que el programa pare unos segundos
                Console.WriteLine("La recepcion del producto n:" + n1 + " se completo correctamente ");




                Random frnd = new Random();  //creo un numero aleatorio 2
                int al2 = frnd.Next(100, 600);



                Thread.Sleep(4000);
                MA += al2;
                if (MA >= a2.memoriaAlmacenamiento)
                {
                    Console.WriteLine("\n\n");
                    Thread.Sleep(2000);
                    a2.Reset();
                    Thread.Sleep(2000);
                    a2.reiniciar();
                    Thread.Sleep(2000);
                    MA = 0;
                }
                Thread.Sleep(2000);
                Console.WriteLine("El almacenamiento del producto n:" + n1 + " se completo correctamente ");

                Thread.Sleep(4000);

                Random ffrnd = new Random();  //creo un numero aleatorio 2
                int al3 = ffrnd.Next(300, 900);

                MEN += al3;
                if (MA >= e2.memoriaEnsamblaje)
                {
                    e2.Reset();
                    Thread.Sleep(2000);
                    e2.reiniciar();
                    Thread.Sleep(2000);
                    MEN = 0;
                }
                Thread.Sleep(2000);
                Console.WriteLine("El ensamblaje del producto n:" + n1 + " se completo correctamente ");

                Thread.Sleep(4000);

                Random fffrnd = new Random();  //creo un numero aleatorio 2
                int al4 = fffrnd.Next(600, 800);
                MV += al4;
                if (MV >= v2.memoriaVerificacion)
                {
                    v2.Reset();
                    Thread.Sleep(2000);
                    v2.reiniciar();
                    Thread.Sleep(2000);
                    MV = 0;
                }
                Thread.Sleep(2000);
                Console.WriteLine("La verificacion del producto n:" + n1 + " se completo correctamente ");

                Thread.Sleep(4000);


                Random ffffrnd = new Random();  //creo un numero aleatorio 2
                int al5 = ffffrnd.Next(50, 400);


                MEM += al5;
                if (MEM >= mm2.memoriaEmpaque)
                {
                    a2.Reset();
                    Thread.Sleep(2000);
                    a2.reiniciar();
                    Thread.Sleep(2000);
                    MA = 0;
                }
                Thread.Sleep(2000);
                Console.WriteLine(" El empaque del producto n:" + n1 + " se completo correctamente \n\n");

                Thread.Sleep(4000);



                Console.WriteLine("El proceso del producto n: " + n1 + " se completo correctamente\n\n\n\n\n\n\n\n");
                Thread.Sleep(4000);

            }


            Console.WriteLine("Fue un dia excelente !!, acontinuacion se procedera a apagar las maquinas");

            Console.WriteLine("\n\n");
            r1.apagar();
            a1.apagar();
            e1.apagar();
            v1.apagar();
            mm1.apagar();


























        }





    }
}

