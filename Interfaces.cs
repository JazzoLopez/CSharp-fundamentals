namespace LearningNotes
{
    interface iVehiculo
    {
        void Conducir();
        void Frenar();
        void Girar();
    }

    interface iArmaDeGuerra
    {
        void Disparar();
        void Recargar();
    }

    public class Tanque : iVehiculo, iArmaDeGuerra
    {
        public void Conducir()
        {
            // Implementación de la conducción del tanque
        }

        public void Frenar()
        {
            // Implementación del frenado del tanque
        }

        public void Girar()
        {
            // Implementación del giro del tanque
        }

        public void Disparar()
        {
            // Implementación del disparo del tanque
        }

        public void Recargar()
        {
            // Implementación de la recarga del tanque
        }
    }

    //IMPLEMENTACION EXPLICITA
    interface iControl
    {
        void Pintar();
    }

    interface iSuperficie
    {
        void Pintar();
    }

    public class Ejemplo : iControl, iSuperficie
    {
        void iControl.Pintar()
        {
            Console.WriteLine("iControl.Pintar");
        }

        void iSuperficie.Pintar()
        {
            Console.WriteLine("iSuperficie.Pintar");
        }
    }

    public static class Interfaces
    {
        public static void Ejecutar()
        {
            Tanque miTanque = new Tanque();
            Validar1(miTanque);
            Validar2(miTanque);
            miTanque.Conducir();
            miTanque.Disparar();
        }

        static void Validar1(iVehiculo i)
        {
            Console.WriteLine("Validación de vehículo exitosa.");
        }

        static void Validar2(iArmaDeGuerra i)
        {
            Console.WriteLine("Validación de arma de guerra exitosa.");
        }

    }
}