using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace subTask2.Classes
{
    class MyMatrix
    {
        int[,] arr;
        Random r = new Random();
        public MyMatrix(int x, int y)
        {
            arr = new int[x, y];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = r.Next(0, 100);
                }
            }
        }
        public void AddRow(int count)
        {
            int[,] mas = new int[arr.GetLength(0), arr.GetLength(1) + count];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    mas[i, j] = arr[i,j];
                }
            }
            arr = mas;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == 0)
                        arr[i, j] = r.Next(0, 100);
                }
            }
        }
        public void AddLevel(int count)
        {
            int[,] mas = new int[arr.GetLength(0) + count, arr.GetLength(1)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    mas[i, j] = arr[i, j];
                }
            }
            arr = mas;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == 0)
                        arr[i, j] = r.Next(0, 100);
                }
            }
        }
        public int GetLength(int dimention)
        {
            return arr.GetLength(dimention);
        }
        public int[,] GetSpecial(int x, int y)
        {
            int[,] mas = new int[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    try
                    {
                        mas[i, j] = arr[i, j];
                    }
                    catch { }
                }
            }
            return mas;
        }
        public int this[int i, int j]
        {
            get { return arr[i, j]; }
            set { arr[i, j] = value; }
        }
        public int[] this[int i]
        {
            get 
            {
                int[] mas = new int[arr.GetLength(0) - 1];
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    mas[j] = arr[i-1, j];
                }
                return mas;
            }
        }
        public IEnumerator GetEnumerator()
        {
            return arr.GetEnumerator();
        }
    }
}
