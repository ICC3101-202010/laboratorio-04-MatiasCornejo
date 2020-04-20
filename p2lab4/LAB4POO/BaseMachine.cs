using System;
namespace Lab_04_MatiasCornejo
{
    public abstract class BaseMachine

    {
        protected int num;
        public int memoriaRecepcion;//creo la memoria que tendra cada proceso
        public int memoriaAlmacenamiento;
        public int memoriaEnsamblaje;
        public int memoriaVerificacion;
        public int memoriaEmpaque;
        public int memoriaocupada;





        protected int ocupado;


        public abstract void Encender(); //void porque no lo implemento aca en la clase abstracta , lo implemento despues en cada clase
        abstract public void reiniciar();
        abstract public void apagar();


        public BaseMachine()
        {

            memoriaRecepcion = 1000;

            memoriaAlmacenamiento = 2000;   //guardo la capacidad de cada 
            memoriaEnsamblaje = 3000;
            memoriaVerificacion = 2500;
            memoriaEmpaque = 2000;

        }


    }
}
