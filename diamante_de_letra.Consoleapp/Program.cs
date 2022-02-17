using System;

namespace diamante_de_letra.Consoleapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Variaveis
            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] letras = alfabeto.ToCharArray();
            int contadorLetras = 0, espacoInterno = 0;

            //declaração local
            char letrasDiamante = 'E';

            Console
            #endregion

            #region Contador para saber o tamanho do diamante
            for (int i = 0; i <= letras.Length; i++)
            {
                if (letrasDiamante == letras[i])
                {
                    contadorLetras++;
                    break;
                }
                else contadorLetras++;
            }
            #endregion

            #region Parte de Superior do Diamante
            for (int linha = 0; contadorLetras > 0; linha++)
            {

                //espaco de fora
                for (int i = 0; i < contadorLetras - 1; i++)
                {
                    Console.Write(" ");
                }

                //mostra a letra
                Console.Write(letras[linha]);

                //espaco de dentro
                for (int i = 1; i < espacoInterno; i++)
                {
                    Console.Write(" ");
                }

                //condição para não mostrar a letra a duas vezes na primeira linha
                if (linha != 0)
                    Console.Write(letras[linha]);

                contadorLetras--;
                espacoInterno += 2;
                Console.WriteLine();
                Console.WriteLine();
            }

            #endregion

            #region Parte Inferior do Diamante
            int letra = 3;//imprimir ao contrario
            contadorLetras = 1;
            espacoInterno = 7;

            for (int linha = 1; espacoInterno > 0; linha++)
            {
                //espaco de fora
                for (int i = 1; i <= contadorLetras; i++)
                {
                    Console.Write(" ");
                }

                Console.Write(letras[letra]);
                //espaco de dentro

                for (int i = 1; i <= espacoInterno - 2; i++)
                {
                    Console.Write(" ");
                }
               //condição para não mostrar a letra a duas vezes na primeira linha
                if (linha != 4)
                    Console.Write(letras[letra]);

                letra--;
                contadorLetras++;
                espacoInterno -= 2;
                Console.WriteLine();
                Console.WriteLine();
            }

            #endregion

            Console.ReadKey();
        }
    }




}
