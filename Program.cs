using System;
class Program
{
    static void Main()
    {
        int[,] matriz = new int[3, 2];
        //Asignamos valores a la matriz
        matriz[0, 0] = 1;
        matriz[0, 1] = 2;
        matriz[1, 0] = 3;
        matriz[1, 1] = 4;
        matriz[2, 0] = 5;
        matriz[2, 1] = 6;
        //Imprimimos valores de la matriz
        for(int i = 0; i < 3; i++)
        {
            
            for(int j = 0; j < 2; j++)
            {
                /*Console.WriteLine($"El elemento en la posicion[{0}, {1}]: {2}", i, j, matriz[i,j]);
                 El error se encontraba en esta línea de código que imprime los datos de forma incorrecta
                 */
                Console.WriteLine($"El elemento en la posicion[{i}, {j}]: "+matriz[i, j]);
            }
        }
    }
}