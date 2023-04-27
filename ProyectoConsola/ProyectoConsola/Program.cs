using System;

namespace ProyectoConsola
{
    public class Program
    {
        #region Main
        static void Main(string[] args)
        {
            //Recorro del 1 al 100 y voy sumando de a uno.
            for (int i = 1; i <= 100; i++)
            {
                //Seteo los string para devolver en el output.
                string keep = "Keep";
                string calm = "Calm";
                string keepCalm = "KeepCalm";
                string output = i.ToString();

                //Pregunto si es multipo de 3 y 5.
                if (i % 3 == 0 && i % 5 == 0)
                {
                    output = keepCalm;
                }
                //Pregunto si es multipo de 3.
                else if (i % 3 == 0)
                {
                    output = keep;
                }
                //Pregunto si es multipo 5.
                else if (i % 5 == 0)
                {
                    output = calm;
                }

                //Devuelvo mi output segun lo establecido.
                Console.WriteLine(output);
            }
        }
        #endregion
    }
}
