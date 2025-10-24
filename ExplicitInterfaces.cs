namespace LearningNotes
{
    public static class ExplicitInterfaces
    {
        public static void GetCuadrado()
        {
            Cuadrado cuadrado = new(30.0f, 30.0f);
            iMedidasInglesas eDimension = cuadrado;
            iMedidasMetricas mDimension = cuadrado;

            Console.WriteLine("largo(in):{0}", eDimension.Largo());
            Console.WriteLine("Ancho(in):{0}", eDimension.Ancho());

            Console.WriteLine("Largo(cm): {0}:", mDimension.Largo());
            Console.WriteLine("Ancho(cm): {0}", mDimension.Ancho());

        }
    }

    interface iMedidasInglesas
    {
        float Largo();
        float Ancho();
    }

    interface iMedidasMetricas
    {
        float Largo();
        float Ancho();
    }

    public class Cuadrado : iMedidasInglesas, iMedidasMetricas
    {
        public float largoPulgadas;
        public float anchoPulgadas;

        public Cuadrado(float largoPulgadas, float anchoPulgadas)
        {
            this.largoPulgadas = largoPulgadas;
            this.anchoPulgadas = anchoPulgadas;
        }

        float iMedidasInglesas.Largo() { return largoPulgadas; }
        float iMedidasInglesas.Ancho() { return anchoPulgadas; }
        float iMedidasMetricas.Ancho() { return anchoPulgadas * 2.54f; }
        float iMedidasMetricas.Largo() { return largoPulgadas * 2.54f; }
    }
}