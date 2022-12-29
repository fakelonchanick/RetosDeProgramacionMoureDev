using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetosDeProgramacionMoureDev.Retos
{
    internal class RetoNum2
    {
        /*
         * Reto #1
         * ¿ES UN ANAGRAMA?
         * Fecha publicación enunciado: 03/01/22
         * Fecha publicación resolución: 10/01/22
         * Dificultad: MEDIA
         *
         * Enunciado: Escribe una función que reciba dos palabras (String) y retorne verdadero o falso (Boolean) según sean o no anagramas.
         * Un Anagrama consiste en formar una palabra reordenando TODAS las letras de otra palabra inicial.
         * NO hace falta comprobar que ambas palabras existan.
         * Dos palabras exactamente iguales no son anagrama.
         *
         * Información adicional:
         * - Usa el canal de nuestro discord (https://mouredev.com/discord) "🔁reto-semanal" para preguntas, dudas o prestar ayuda a la acomunidad.
         * - Puedes hacer un Fork del repo y una Pull Request al repo original para que veamos tu solución aportada.
         * - Revisaré el ejercicio en directo desde Twitch el lunes siguiente al de su publicación.
         * - Subiré una posible solución al ejercicio el lunes siguiente al de su publicación.
         *
         */

        /*public bool EachLetterExist(string a, string b)
        {
            int sizeStringA = a.Length;
            for(int i = 0; i<sizeStringA; i++) 
            {
                a[i]
            }

        }*/

        public static string OrderString(string str)
        {
            str = str.ToLower();
            char[] charArray = str.ToCharArray();
            Array.Sort(charArray);
            string aux = new string(charArray);
            return aux;
        }
        public static bool Sol(string original, string posibleAnagrama)
        {
            int sizeOriginal = original.Length;
            int sizePosibleAnagrama = posibleAnagrama.Length;
            
            if(!(sizeOriginal == sizePosibleAnagrama))
            {
                Console.Write("No es posible un anagrama en palabras de diferente logitud");
                return false;
            }else if(original.Equals(posibleAnagrama))
            {
                Console.Write("Las palabra son identicas");
                return false;
            }else
            {
                original = OrderString(original);
                posibleAnagrama = OrderString(posibleAnagrama);
                for (int i = 0; i < sizeOriginal; i++)
                {
                    if (!(original[i] == posibleAnagrama[i]))
                    {
                        Console.WriteLine("Esto no es un anagrama chucha");
                        return false;
                    }

                }
                Console.WriteLine("Anagrama detected");
                return true;
            }
        }

    }
}
