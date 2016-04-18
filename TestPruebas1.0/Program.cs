using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPruebas1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //CalculaDiagonales();
            VeryBigSum();
        }

        #region REGRESA LA DIFERENCIA DE LA SUMA DE LAS DIAGONALES DE UNA MATRIZ
        /// <summary>
        /// diferencia de la sumas de las diagonales de una matris
        /// </summary>
        public static void CalculaDiagonales()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int diagonal1 = 0;
            int diagonal2 = 0;


            int[][] a = new int[n][];

            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            }

            for (int x = 0; x <= a.Length - 1; x++)
            {
                for (int y = 0; y <= a.Length - 1; y++)
                {
                    if (x == y) { diagonal1 += a[x][y]; }
                    if (x + y == a.Length - 1) { diagonal2 += a[x][y]; }
                }
            }

            Console.WriteLine((diagonal2 - diagonal1).ToString());
            Console.ReadKey();
        } 
        #endregion

        public static void VeryBigSum()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int suma = 0;
            string[] arr_tmp = Console.ReadLine().Split(' ');
            //test

            int[] arr = Array.ConvertAll(arr_tmp, Int32.Parse);

            for (int cont = 0; cont <= arr.Length -1; cont++ )
            {
                suma += arr[cont];
            }

            Console.WriteLine(suma.ToString());
            Console.ReadKey();
        }
    }
}
