using System;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoConsola2
{
    public class Program
    {
        #region Datos
        //Seteo los datos del vector en una variable global.
        private static byte[] _vector = new byte[] { 170, 170, 170, 187, 187, 187, 187, 187, 204, 11, 11, 55, 55, 1, 9 };
        #endregion

        #region 8zip
        static void Main(string[] args)
        {
            //Creo una lista para guardar mis vectores en orden, podria usar tambien un vector y un contador de index para ordenarlos.
            List<byte> vectorComprimido = new List<byte>();
            //Seteo el valor actual del vector que estoy leyendo.
            byte valorActual = _vector[0];
            //Seteo mi contador de repeteciones.
            byte contador = 1;

            //Recorro el vector con los datos.
            for (int i = 1; i < _vector.Length; i++)
            {
                //Comparo el valor del vector global segun posicion index que estoy utilizando con el valor ya almacenado.
                if (_vector[i] == valorActual)
                {
                    //Sumo contador en caso de ser un true
                    contador++;
                }
                //En caso de ser false agrego cuantas veces se repitio, y luego el valor que se repitio.
                else
                {
                    vectorComprimido.Add(contador);
                    vectorComprimido.Add(valorActual);
                    //Seteo nuevamente el valorActual con el ultimo obtenido.
                    valorActual = _vector[i];
                    //Reseteo contador a 1.
                    contador = 1;
                }
            }

            //Agrego el ultimo valor actual y el contador a la lista vectorComprimido.
            vectorComprimido.Add(contador);
            vectorComprimido.Add(valorActual);

            //Creo una cadena de texto que representa el vector comprimido en formato de lista de bytes.
            string vectorString = "[" + String.Join(", ", vectorComprimido.Select(b => b.ToString())) + "]";

            Console.WriteLine(vectorString);
            //Convierto la lista de bytes en una cadena de texto en formato hexadecimal.
            Console.WriteLine(BitConverter.ToString(vectorComprimido.ToArray()));
        }
        #endregion
    }
}
