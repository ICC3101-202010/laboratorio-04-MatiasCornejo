﻿using System;
using System.Threading;
namespace p4lab4
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
            memoriaocupada = 0;
            Console.WriteLine("El modulo de ensamblaje se lleno por ende se reiniciara");
            Console.WriteLine("Memoria ocupada= " + memoriaocupada);
        }
        public void Reset()
        {



            Thread.Sleep(1500);
            Console.WriteLine("Capacidad: " + memoriaEnsamblaje);
            Thread.Sleep(1500);
            Console.WriteLine("\n\n");
            Console.WriteLine("Memoria de maquina de Verificacion se lleno , a continuacion escoja una opcion \n");
            Thread.Sleep(1500);
            Console.WriteLine("1) REINICIAR MEMORIA Y MAQUINA");
            Console.WriteLine("2) APAGAR TODO");




        }
    }

}
