using System;
namespace Lab_4_MatiasCornejo
{
    public abstract class BaseMachine

    {
        protected int num;
        protected int memoriaRecepcion;//creo la memoria que tendra cada proceso
        protected int memoriaAlmacenamiento;
        protected int memoriaEnsamblaje;
        protected int memoriaVerificacion;
        protected int memoriaEmpaque;





        protected int ocupado;


        public abstract void Encender(); //void porque no lo implemento aca en la clase abstracta , lo implemento despues en cada clase
        abstract public void reiniciar();
        abstract public void apagar();


        public BaseMachine()
        {


            memoriaAlmacenamiento = 1000;   //guardo la capacidad de cada 
            memoriaEnsamblaje = 1000;
            memoriaVerificacion = 1000;
            memoriaEmpaque = 1000;

        }


    }
}
