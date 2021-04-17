using System;

namespace MatrizExercicioFixacao {
    class Program {
        static void Main(string[] args) {

            string[] matriz = Console.ReadLine().Split(' ');
            int m = int.Parse(matriz[0]);
            int n = int.Parse(matriz[1]);

            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(vet[j]);
                }
            }

            int referen = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    if (mat[i, j] == referen) {
                        Console.WriteLine("Position " + i + ", " + j);
                        if (i > 0) {
                            Console.WriteLine("Position Up: " + mat[i - 1, j]);
                        }
                        if (j > 0) {
                            Console.WriteLine("Position Left: " + mat[i, j - 1]);
                        }
                        if (j < n - 1) {
                            Console.WriteLine("Position Right: " + mat[i, j + 1]);
                        }
                        if (i < m - 1) {
                            Console.WriteLine("Position Down: " + mat[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}
