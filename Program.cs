using System;

namespace Reto4
{
    class VotacionesConfech
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n-------------------------------");
            Console.WriteLine("Bienvenido a Votaciones con CONFECH".ToUpper());
            Console.WriteLine("-------------------------------\n");

            Console.Write("Ingrese la cantidad de universidades que participaran: ");
            int nInput = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Cantidad de universidades que registraste: {nInput}");

            string uInput = "";

            for (int i = 0; i < nInput; i++)
            {
                Console.Write("\nIngrese el nombre de la universidad: ");
                uInput = Console.ReadLine();
            }

            Console.WriteLine("Universidades que participan: \n" + uInput);

            int[] votos = new int[nInput];

            for (int i = 0; i < nInput; i++)
            {
                Console.Write("\n¿Que opcion de voto escojes?" +
                "\nA) Aceptar" +
                "\nR) Rechazar" +
                "\nN) Nulo" +
                "\nB) Voto en blanco");

                Console.Write("\nIngrese el voto para la universidad " + (i + 1) + ": \n");

                char cVoto = Char.Parse(Console.ReadKey().KeyChar.ToString());
                int votacion = 0;

                switch (cVoto)
                {
                    case 'a':
                        votacion = 1;
                        break;
                    case 'r':
                        votacion = 2;
                        break;
                    case 'n':
                        votacion = 3;
                        break;
                    case 'b':
                        votacion = 4;
                        break;
                    default:
                        Console.Clear();
                        goto case 'a';
                }

                votos[i] = votacion;
            }

            int aceptan = 0, rechazan = 0, nulo = 0, blanco = 0, empatan = 0;

            for (int i = 0; i < nInput; i++)
            {
                switch (votos[i])
                {
                    case 1:
                        aceptan++;
                        break;
                    case 2:
                        rechazan++;
                        break;
                    case 3:
                        nulo++;
                        break;
                    case 4:
                        blanco++;
                        break;
                }
            }

            Console.WriteLine("\nResultado de votaciones:".ToUpper());

            Console.WriteLine($"Cantidad de universidades participantes: {nInput}" +
            $"\nUniversidades: {uInput}" +
            $"\nConteo total: Aceptan: {aceptan}, Rechazan: {rechazan}, Nulo: {nulo} y Blanco: {blanco}");


            Console.WriteLine($"\nUniversidades que aceptan: {aceptan}" +
            $"\nUniversidades que rechazan: {rechazan}" +
            $"\nUniversidades con empate {empatan}");
        }
    }
}