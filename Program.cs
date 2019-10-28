using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            string name = DateTime.Now.ToString("y-M-d");
            Stopwatch watch = new Stopwatch();
            int[] array;
            #region BubbleSort I
            Console.WriteLine("====== Bubble Sort I - Aleatório ======");
            writeLog("====== Bubble Sort I - Aleatório ======", name);
            watch = new Stopwatch();
            array = new int[1000];
            for (int i = 0; i < 1000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }
            
            watch.Start();
            BubbleSort(array, 1000);
            watch.Stop();            
            Console.WriteLine("Bubble Sort [1000]: " + watch.Elapsed);
            writeLog("Bubble Sort [1000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = new int[5000];
            for (int i = 0; i < 5000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }

            watch.Start();
            BubbleSort(array, 5000);
            watch.Stop();
            Console.WriteLine("Bubble Sort [5000]: " + watch.Elapsed);
            writeLog("Bubble Sort [5000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = new int[10000];
            for (int i = 0; i < 10000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }

            watch.Start();
            BubbleSort(array, 10000);
            watch.Stop();
            Console.WriteLine("Bubble Sort [10000]: " + watch.Elapsed);
            writeLog("Bubble Sort [10000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = new int[15000];
            for (int i = 0; i < 15000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }

            watch.Start();
            BubbleSort(array, 15000);
            watch.Stop();
            Console.WriteLine("Bubble Sort [15000]: " + watch.Elapsed);
            writeLog("Bubble Sort [15000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = new int[20000];
            for (int i = 0; i < 20000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }

            watch.Start();
            BubbleSort(array, 20000);
            watch.Stop();
            Console.WriteLine("Bubble Sort [20000]: " + watch.Elapsed);
            writeLog("Bubble Sort [20000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = new int[25000];
            for (int i = 0; i < 25000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }

            watch.Start();
            BubbleSort(array, 25000);
            watch.Stop();
            Console.WriteLine("Bubble Sort [25000]: " + watch.Elapsed);
            writeLog("Bubble Sort [25000]: " + watch.Elapsed, name);
            Console.WriteLine();


            Console.WriteLine("====== Bubble Sort I - Ordenado ======");
            writeLog("====== Bubble Sort I - Ordenado ======", name);

            watch = new Stopwatch();
            array = insereOrdenado(1000);
            watch.Start();
            BubbleSort(array, 1000);
            watch.Stop();
            Console.WriteLine("Bubble Sort [1000]: " + watch.Elapsed);
            writeLog("Bubble Sort [1000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenado(5000);
            watch.Start();
            BubbleSort(array, 5000);
            watch.Stop();
            Console.WriteLine("Bubble Sort [5000]: " + watch.Elapsed);
            writeLog("Bubble Sort [5000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenado(10000);
            watch.Start();
            BubbleSort(array, 10000);
            watch.Stop();
            Console.WriteLine("Bubble Sort [10000]: " + watch.Elapsed);
            writeLog("Bubble Sort [10000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenado(15000);
            watch.Start();
            BubbleSort(array, 15000);
            watch.Stop();
            Console.WriteLine("Bubble Sort [15000]: " + watch.Elapsed);
            writeLog("Bubble Sort [15000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenado(20000);
            watch.Start();
            BubbleSort(array, 20000);
            watch.Stop();
            Console.WriteLine("Bubble Sort [20000]: " + watch.Elapsed);
            writeLog("Bubble Sort [20000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenado(25000);
            watch.Start();
            BubbleSort(array, 25000);
            watch.Stop();
            Console.WriteLine("Bubble Sort [25000]: " + watch.Elapsed);
            writeLog("Bubble Sort [25000]: " + watch.Elapsed, name);
            Console.WriteLine("");
            writeLog("", name);



            Console.WriteLine("====== Bubble Sort I - Ordenado  Decrescente ======");
            writeLog("====== Bubble Sort I - Ordenado  Decrescente ======", name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(1000);
            watch.Start();
            BubbleSort(array, 1000);
            watch.Stop();
            Console.WriteLine("Bubble Sort [1000]: " + watch.Elapsed);
            writeLog("Bubble Sort [1000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(5000);
            watch.Start();
            BubbleSort(array, 5000);
            watch.Stop();
            Console.WriteLine("Bubble Sort [5000]: " + watch.Elapsed);
            writeLog("Bubble Sort [5000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(10000);
            watch.Start();
            BubbleSort(array, 10000);
            watch.Stop();
            Console.WriteLine("Bubble Sort [10000]: " + watch.Elapsed);
            writeLog("Bubble Sort [10000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(15000);
            watch.Start();
            BubbleSort(array, 15000);
            watch.Stop();
            Console.WriteLine("Bubble Sort [15000]: " + watch.Elapsed);
            writeLog("Bubble Sort [15000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(20000);
            watch.Start();
            BubbleSort(array, 20000);
            watch.Stop();
            Console.WriteLine("Bubble Sort [20000]: " + watch.Elapsed);
            writeLog("Bubble Sort [20000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(25000);
            watch.Start();
            BubbleSort(array, 25000);
            watch.Stop();
            Console.WriteLine("Bubble Sort [25000]: " + watch.Elapsed);
            writeLog("Bubble Sort [25000]: " + watch.Elapsed, name);
            #endregion

            Console.WriteLine("");
            writeLog("", name);

            #region BubbleSort II
            Console.WriteLine("====== Bubble Sort II - Aleatório ======");
            writeLog("====== Bubble Sort II - Aleatório ======", name);
            watch = new Stopwatch();
            array = new int[1000];
            for (int i = 0; i < 1000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }            
            watch.Start();
            BubbleSortII(array, 1000);
            watch.Stop();            
            Console.WriteLine("Bubble Sort II [1000]: " + watch.Elapsed);
            writeLog("Bubble Sort II [1000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = new int[5000];
            for (int i = 0; i < 5000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }

            watch.Start();
            BubbleSortII(array, 5000);
            watch.Stop();
            Console.WriteLine("Bubble Sort II [5000]: " + watch.Elapsed);
            writeLog("Bubble Sort II [5000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = new int[10000];
            for (int i = 0; i < 10000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }

            watch.Start();
            BubbleSortII(array, 10000);
            watch.Stop();
            Console.WriteLine("Bubble Sort II [10000]: " + watch.Elapsed);
            writeLog("Bubble Sort II [10000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = new int[15000];
            for (int i = 0; i < 15000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }

            watch.Start();
            BubbleSortII(array, 15000);
            watch.Stop();
            Console.WriteLine("Bubble Sort II [15000]: " + watch.Elapsed);
            writeLog("Bubble Sort II [15000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = new int[20000];
            for (int i = 0; i < 20000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }

            watch.Start();
            BubbleSortII(array, 20000);
            watch.Stop();
            Console.WriteLine("Bubble Sort II [20000]: " + watch.Elapsed);
            writeLog("Bubble Sort II [20000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = new int[25000];
            for (int i = 0; i < 25000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }

            watch.Start();
            BubbleSortII(array, 25000);
            watch.Stop();
            Console.WriteLine("Bubble Sort II [25000]: " + watch.Elapsed);
            writeLog("Bubble Sort II [25000]: " + watch.Elapsed, name);

            Console.WriteLine("");
            writeLog("", name);

            Console.WriteLine("====== Bubble Sort II - Ordenado ======");
            writeLog("====== Bubble Sort II - Ordenado ======", name);

            watch = new Stopwatch();
            array = insereOrdenado(1000);
            watch.Start();
            BubbleSortII(array, 1000);
            watch.Stop();
            Console.WriteLine("Bubble Sort II [1000]: " + watch.Elapsed);
            writeLog("Bubble Sort II [1000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenado(5000);
            watch.Start();
            BubbleSortII(array, 5000);
            watch.Stop();
            Console.WriteLine("Bubble Sort II [5000]: " + watch.Elapsed);
            writeLog("Bubble Sort II [5000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenado(10000);
            watch.Start();
            BubbleSortII(array, 10000);
            watch.Stop();
            Console.WriteLine("Bubble Sort II [10000]: " + watch.Elapsed);
            writeLog("Bubble Sort II [10000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenado(15000);
            watch.Start();
            BubbleSortII(array, 15000);
            watch.Stop();
            Console.WriteLine("Bubble Sort II [15000]: " + watch.Elapsed);
            writeLog("Bubble Sort II [15000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenado(20000);
            watch.Start();
            BubbleSortII(array, 20000);
            watch.Stop();
            Console.WriteLine("Bubble Sort II [20000]: " + watch.Elapsed);
            writeLog("Bubble Sort II [20000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenado(25000);
            watch.Start();
            BubbleSortII(array, 25000);
            watch.Stop();
            Console.WriteLine("Bubble Sort II [25000]: " + watch.Elapsed);
            writeLog("Bubble Sort II [25000]: " + watch.Elapsed, name);
            Console.WriteLine("");
            writeLog("", name);

            Console.WriteLine("====== Bubble Sort II - Ordenado  Decrescente ======");
            writeLog("====== Bubble Sort II - Ordenado  Decrescente ======", name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(1000);
            watch.Start();
            BubbleSortII(array, 1000);
            watch.Stop();
            Console.WriteLine("Bubble Sort II [1000]: " + watch.Elapsed);
            writeLog("Bubble Sort II [1000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(5000);
            watch.Start();
            BubbleSortII(array, 5000);
            watch.Stop();
            Console.WriteLine("Bubble Sort II [5000]: " + watch.Elapsed);
            writeLog("Bubble Sort II [5000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(10000);
            watch.Start();
            BubbleSortII(array, 10000);
            watch.Stop();
            Console.WriteLine("Bubble Sort II [10000]: " + watch.Elapsed);
            writeLog("Bubble Sort II [10000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(15000);
            watch.Start();
            BubbleSortII(array, 15000);
            watch.Stop();
            Console.WriteLine("Bubble Sort II [15000]: " + watch.Elapsed);
            writeLog("Bubble Sort II [15000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(20000);
            watch.Start();
            BubbleSortII(array, 20000);
            watch.Stop();
            Console.WriteLine("Bubble Sort II [20000]: " + watch.Elapsed);
            writeLog("Bubble Sort II [20000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(25000);
            watch.Start();
            BubbleSortII(array, 25000);
            watch.Stop();
            Console.WriteLine("Bubble Sort II [25000]: " + watch.Elapsed);
            writeLog("Bubble Sort II [25000]: " + watch.Elapsed, name);
            #endregion

            Console.WriteLine("");
            writeLog("", name);

            #region QuickSort - Meio
            Console.WriteLine("====== QuickSort - Meio - Aleatório ======");
            writeLog("====== QuickSort - Meio - Aleatório ======", name);
            watch = new Stopwatch();
            array = new int[1000];
            for (int i = 0; i < 1000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }
            
            watch.Start();
            QuickSort(array, 0, 1000-1);
            watch.Stop();
            Console.WriteLine(EstaOrdenado(array, 1000));
            Console.WriteLine("QuickSort - Meio [1000]: " + watch.Elapsed);
            writeLog("QuickSort - Meio [1000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = new int[5000];
            for (int i = 0; i < 5000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }

            watch.Start();
            QuickSort(array, 0, 5000 - 1);
            watch.Stop();
            Console.WriteLine("QuickSort - Meio [5000]: " + watch.Elapsed);
            writeLog("QuickSort - Meio [5000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = new int[10000];
            for (int i = 0; i < 10000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }

            watch.Start();
            QuickSort(array, 0, 10000 - 1);
            watch.Stop();
            Console.WriteLine("QuickSort - Meio [10000]: " + watch.Elapsed);
            writeLog("QuickSort - Meio [10000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = new int[15000];
            for (int i = 0; i < 15000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }

            watch.Start();
            QuickSort(array, 0, 15000 - 1);
            watch.Stop();
            Console.WriteLine("QuickSort - Meio [15000]: " + watch.Elapsed);
            writeLog("QuickSort - Meio [15000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = new int[20000];
            for (int i = 0; i < 20000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }

            watch.Start();
            QuickSort(array, 0, 20000 - 1);
            watch.Stop();
            Console.WriteLine("QuickSort - Meio [20000]: " + watch.Elapsed);
            writeLog("QuickSort - Meio [20000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = new int[25000];
            for (int i = 0; i < 25000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }

            watch.Start();
            QuickSort(array, 0, 25000 - 1);
            watch.Stop();
            Console.WriteLine("QuickSort - Meio [25000]: " + watch.Elapsed);
            writeLog("QuickSort - Meio [25000]: " + watch.Elapsed, name);

            Console.WriteLine("");
            writeLog("", name);

            Console.WriteLine("====== QuickSort - Meio - Ordenado ======");
            writeLog("====== QuickSort - Meio - Ordenado ======", name);

            watch = new Stopwatch();
            array = insereOrdenado(1000);
            watch.Start();
            QuickSort(array, 0, 1000 - 1);
            watch.Stop();
            Console.WriteLine("QuickSort - Meio [1000]: " + watch.Elapsed);
            writeLog("QuickSort - Meio [1000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenado(5000);
            watch.Start();
            QuickSort(array, 0, 5000 - 1);
            watch.Stop();
            Console.WriteLine("QuickSort - Meio [5000]: " + watch.Elapsed);
            writeLog("QuickSort - Meio [5000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenado(10000);
            watch.Start();
            QuickSort(array, 0, 10000 - 1);
            watch.Stop();
            Console.WriteLine("QuickSort - Meio [10000]: " + watch.Elapsed);
            writeLog("QuickSort - Meio [10000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenado(15000);
            watch.Start();
            QuickSort(array, 0, 15000 - 1);
            watch.Stop();
            Console.WriteLine("QuickSort - Meio [15000]: " + watch.Elapsed);
            writeLog("QuickSort - Meio [15000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenado(20000);
            watch.Start();
            QuickSort(array, 0, 20000 - 1);
            watch.Stop();
            Console.WriteLine("QuickSort - Meio [20000]: " + watch.Elapsed);
            writeLog("QuickSort - Meio [20000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenado(25000);
            watch.Start();
            QuickSort(array, 0, 25000 - 1);
            watch.Stop();
            Console.WriteLine("QuickSort - Meio [25000]: " + watch.Elapsed);
            writeLog("QuickSort - Meio [25000]: " + watch.Elapsed, name);
            Console.WriteLine("");
            writeLog("", name);

            Console.WriteLine("====== QuickSort - Meio - Ordenado  Decrescente ======");
            writeLog("====== QuickSort - Meio - Ordenado  Decrescente ======", name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(1000);
            watch.Start();
            QuickSort(array, 0, 1000 - 1);
            watch.Stop();
            Console.WriteLine("QuickSort - Meio [1000]: " + watch.Elapsed);
            writeLog("QuickSort - Meio [1000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(5000);
            watch.Start();
            QuickSort(array, 0, 5000 - 1);
            watch.Stop();
            Console.WriteLine("QuickSort - Meio [5000]: " + watch.Elapsed);
            writeLog("QuickSort - Meio [5000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(10000);
            watch.Start();
            QuickSort(array, 0, 10000 - 1);
            watch.Stop();
            Console.WriteLine("QuickSort - Meio [10000]: " + watch.Elapsed);
            writeLog("QuickSort - Meio [10000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(15000);
            watch.Start();
            QuickSort(array, 0, 15000 - 1);
            watch.Stop();
            Console.WriteLine("QuickSort - Meio [15000]: " + watch.Elapsed);
            writeLog("QuickSort - Meio [15000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(20000);
            watch.Start();
            QuickSort(array, 0, 20000 - 1);
            watch.Stop();
            Console.WriteLine("QuickSort - Meio [20000]: " + watch.Elapsed);
            writeLog("QuickSort - Meio [20000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(25000);
            watch.Start();
            QuickSort(array, 0, 25000 - 1);
            watch.Stop();
            Console.WriteLine("QuickSort - Meio [25000]: " + watch.Elapsed);
            writeLog("QuickSort - Meio [25000]: " + watch.Elapsed, name);
            #endregion

            Console.WriteLine("");
            writeLog("", name);

            #region QuickSort - Início
            Console.WriteLine("====== QuickSort - Início - Aleatório ======");
            writeLog("====== QuickSort - Início - Aleatório ======", name);
            watch = new Stopwatch();
            array = new int[1000];
            for (int i = 0; i < 1000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }
            
            watch.Start();
            QuickSortI(array, 0, 1000 - 1);
            watch.Stop();
            Console.WriteLine("QuickSort - Início [1000]: " + watch.Elapsed);
            writeLog("QuickSort - Início [1000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = new int[5000];
            for (int i = 0; i < 5000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }

            watch.Start();
            QuickSortI(array, 0, 5000 - 1);
            watch.Stop();
            Console.WriteLine("QuickSort - Início [5000]: " + watch.Elapsed);
            writeLog("QuickSort - Início [5000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = new int[10000];
            for (int i = 0; i < 10000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }

            watch.Start();
            QuickSortI(array, 0, 10000 - 1);
            watch.Stop();
            Console.WriteLine("QuickSort - Início [10000]: " + watch.Elapsed);
            writeLog("QuickSort - Início [10000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = new int[15000];
            for (int i = 0; i < 15000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }

            watch.Start();
            QuickSortI(array, 0, 15000 - 1);
            watch.Stop();
            Console.WriteLine("QuickSort - Início [15000]: " + watch.Elapsed);
            writeLog("QuickSort - Início [15000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = new int[20000];
            for (int i = 0; i < 20000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }

            watch.Start();
            QuickSortI(array, 0, 20000 - 1);
            watch.Stop();
            Console.WriteLine("QuickSort - Início [20000]: " + watch.Elapsed);
            writeLog("QuickSort - Início [20000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = new int[25000];
            for (int i = 0; i < 25000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }

            watch.Start();
            QuickSortI(array, 0, 25000 - 1);
            watch.Stop();
            Console.WriteLine("QuickSort - Início [25000]: " + watch.Elapsed);
            writeLog("QuickSort - Início [25000]: " + watch.Elapsed, name);

            Console.WriteLine("");
            writeLog("", name);

            Console.WriteLine("====== QuickSort - Início - Ordenado ======");
            writeLog("====== QuickSort - Início - Ordenado ======", name);

            watch = new Stopwatch();
            array = insereOrdenado(1000);
            watch.Start();
            QuickSortI(array, 0, 1000 - 1);
            watch.Stop();
            Console.WriteLine("QuickSort - Início [1000]: " + watch.Elapsed);
            writeLog("QuickSort - Início [1000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenado(5000);
            watch.Start();
            QuickSortI(array, 0, 5000 - 1);
            watch.Stop();
            Console.WriteLine("QuickSort - Início [5000]: " + watch.Elapsed);
            writeLog("QuickSort - Início [5000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenado(10000);
            watch.Start();
            QuickSortI(array, 0, 10000 - 1);
            watch.Stop();
            Console.WriteLine("QuickSort - Início [10000]: " + watch.Elapsed);
            writeLog("QuickSort - Início [10000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenado(15000);
            watch.Start();
            QuickSortI(array, 0, 15000 - 1);
            watch.Stop();
            Console.WriteLine("QuickSort - Início [15000]: " + watch.Elapsed);
            writeLog("QuickSort - Início [15000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenado(20000);
            watch.Start();
            QuickSortI(array, 0, 20000 - 1);
            watch.Stop();
            Console.WriteLine("QuickSort - Início [20000]: " + watch.Elapsed);
            writeLog("QuickSort - Início [20000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenado(25000);
            watch.Start();
            QuickSortI(array, 0, 25000 - 1);
            watch.Stop();
            Console.WriteLine("QuickSort - Início [25000]: " + watch.Elapsed);
            writeLog("QuickSort - Início [25000]: " + watch.Elapsed, name);
            Console.WriteLine("");
            writeLog("", name);

            Console.WriteLine("====== QuickSort - Início - Ordenado  Decrescente ======");
            writeLog("====== QuickSort - Início - Ordenado  Decrescente ======", name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(1000);
            watch.Start();
            QuickSortI(array, 0, 1000 - 1);
            watch.Stop();
            Console.WriteLine("QuickSort - Início [1000]: " + watch.Elapsed);
            writeLog("QuickSort - Início [1000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(5000);
            watch.Start();
            QuickSortI(array, 0, 5000 - 1);
            watch.Stop();
            Console.WriteLine("QuickSort - Início [5000]: " + watch.Elapsed);
            writeLog("QuickSort - Início [5000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(10000);
            watch.Start();
            QuickSortI(array, 0, 10000 - 1);
            watch.Stop();
            Console.WriteLine("QuickSort - Início [10000]: " + watch.Elapsed);
            writeLog("QuickSort - Início [10000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(15000);
            watch.Start();
            QuickSortI(array, 0, 15000 - 1);
            watch.Stop();
            Console.WriteLine("QuickSort - Início [15000]: " + watch.Elapsed);
            writeLog("QuickSort - Início [15000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(20000);
            watch.Start();
            QuickSortI(array, 0, 20000 - 1);
            watch.Stop();
            Console.WriteLine("QuickSort - Início [20000]: " + watch.Elapsed);
            writeLog("QuickSort - Início [20000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(25000);
            watch.Start();
            QuickSortI(array, 0, 25000 - 1);
            watch.Stop();
            Console.WriteLine("QuickSort - Início [25000]: " + watch.Elapsed);
            writeLog("QuickSort - Início [25000]: " + watch.Elapsed, name);
            #endregion

            Console.WriteLine("");
            writeLog("", name);

            #region Insertion Sort
            Console.WriteLine("====== Insertion Sort - Aleatório ======");
            writeLog("====== Insertion Sort - Aleatório ======", name);
            watch = new Stopwatch();
            array = new int[1000];
            for (int i = 0; i < 1000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }
            
            watch.Start();
            InsertionSort(array, 1000);
            watch.Stop();
            Console.WriteLine("Insertion Sort [1000]: " + watch.Elapsed);
            writeLog("Insertion Sort [1000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = new int[5000];
            for (int i = 0; i < 5000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }

            watch.Start();
            InsertionSort(array, 5000);
            watch.Stop();
            Console.WriteLine("Insertion Sort [5000]: " + watch.Elapsed);
            writeLog("Insertion Sort [5000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = new int[10000];
            for (int i = 0; i < 10000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }

            watch.Start();
            InsertionSort(array, 10000);
            watch.Stop();
            Console.WriteLine("Insertion Sort [10000]: " + watch.Elapsed);
            writeLog("Insertion Sort [10000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = new int[15000];
            for (int i = 0; i < 15000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }

            watch.Start();
            InsertionSort(array, 15000);
            watch.Stop();
            Console.WriteLine("Insertion Sort [15000]: " + watch.Elapsed);
            writeLog("Insertion Sort [15000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = new int[20000];
            for (int i = 0; i < 20000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }

            watch.Start();
            InsertionSort(array, 20000);
            watch.Stop();
            Console.WriteLine("Insertion Sort [20000]: " + watch.Elapsed);
            writeLog("Insertion Sort [20000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = new int[25000];
            for (int i = 0; i < 25000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }

            watch.Start();
            InsertionSort(array, 25000);
            watch.Stop();
            Console.WriteLine("Insertion Sort [25000]: " + watch.Elapsed);
            writeLog("Insertion Sort [25000]: " + watch.Elapsed, name);

            Console.WriteLine("");
            writeLog("", name);

            Console.WriteLine("====== Insertion Sort - Ordenado ======");
            writeLog("====== Insertion Sort - Ordenado ======", name);

            watch = new Stopwatch();
            array = insereOrdenado(1000);
            watch.Start();
            InsertionSort(array, 1000);
            watch.Stop();
            Console.WriteLine("Insertion Sort [1000]: " + watch.Elapsed);
            writeLog("Insertion Sort [1000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenado(5000);
            watch.Start();
            InsertionSort(array, 5000);
            watch.Stop();
            Console.WriteLine("Insertion Sort [5000]: " + watch.Elapsed);
            writeLog("Insertion Sort [5000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenado(10000);
            watch.Start();
            InsertionSort(array, 10000);
            watch.Stop();
            Console.WriteLine("Insertion Sort [10000]: " + watch.Elapsed);
            writeLog("Insertion Sort [10000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenado(15000);
            watch.Start();
            InsertionSort(array, 15000);
            watch.Stop();
            Console.WriteLine("Insertion Sort [15000]: " + watch.Elapsed);
            writeLog("Insertion Sort [15000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenado(20000);
            watch.Start();
            InsertionSort(array, 20000);
            watch.Stop();
            Console.WriteLine("Insertion Sort [20000]: " + watch.Elapsed);
            writeLog("Insertion Sort [20000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenado(25000);
            watch.Start();
            InsertionSort(array, 25000);
            watch.Stop();
            Console.WriteLine("Insertion Sort [25000]: " + watch.Elapsed);
            writeLog("Insertion Sort [25000]: " + watch.Elapsed, name);
            Console.WriteLine("");
            writeLog("", name);

            Console.WriteLine("====== Insertion Sort - Decrescente ======");
            writeLog("====== Insertion Sort - Decrescente ======", name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(1000);
            watch.Start();
            InsertionSort(array, 1000);
            watch.Stop();
            Console.WriteLine("Insertion Sort [1000]: " + watch.Elapsed);
            writeLog("Insertion Sort [1000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(5000);
            watch.Start();
            InsertionSort(array, 5000);
            watch.Stop();
            Console.WriteLine("Insertion Sort [5000]: " + watch.Elapsed);
            writeLog("Insertion Sort [5000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(10000);
            watch.Start();
            InsertionSort(array, 10000);
            watch.Stop();
            Console.WriteLine("Insertion Sort [10000]: " + watch.Elapsed);
            writeLog("Insertion Sort [10000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(15000);
            watch.Start();
            InsertionSort(array, 15000);
            watch.Stop();
            Console.WriteLine("Insertion Sort [15000]: " + watch.Elapsed);
            writeLog("Insertion Sort [15000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(20000);
            watch.Start();
            InsertionSort(array, 20000);
            watch.Stop();
            Console.WriteLine("Insertion Sort [20000]: " + watch.Elapsed);
            writeLog("Insertion Sort [20000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(25000);
            watch.Start();
            InsertionSort(array, 25000);
            watch.Stop();
            Console.WriteLine("Insertion Sort [25000]: " + watch.Elapsed);
            writeLog("Insertion Sort [25000]: " + watch.Elapsed, name);
            #endregion

            Console.WriteLine("");
            writeLog("", name);

            #region Shell Sort
            Console.WriteLine("====== Shell Sort - Aleatório ======");
            writeLog("====== Shell Sort - Aleatório ======", name);
            watch = new Stopwatch();
            array = new int[1000];
            for (int i = 0; i < 1000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }
            
            watch.Start();
            ShellSort(array, 1000);
            watch.Stop();            
            Console.WriteLine("Shell Sort [1000]: " + watch.Elapsed);
            writeLog("Shell Sort [1000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = new int[5000];
            for (int i = 0; i < 5000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }

            watch.Start();
            ShellSort(array, 5000);
            watch.Stop();
            Console.WriteLine("Shell Sort [5000]: " + watch.Elapsed);
            writeLog("Shell Sort [5000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = new int[10000];
            for (int i = 0; i < 10000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }

            watch.Start();
            ShellSort(array, 10000);
            watch.Stop();
            Console.WriteLine("Shell Sort [10000]: " + watch.Elapsed);
            writeLog("Shell Sort [10000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = new int[15000];
            for (int i = 0; i < 15000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }

            watch.Start();
            ShellSort(array, 15000);
            watch.Stop();
            Console.WriteLine("Shell Sort [15000]: " + watch.Elapsed);
            writeLog("Shell Sort [15000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = new int[20000];
            for (int i = 0; i < 20000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }

            watch.Start();
            ShellSort(array, 20000);
            watch.Stop();
            Console.WriteLine("Shell Sort [20000]: " + watch.Elapsed);
            writeLog("Shell Sort [20000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = new int[25000];
            for (int i = 0; i < 25000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }

            watch.Start();
            ShellSort(array, 25000);
            watch.Stop();
            Console.WriteLine("Shell Sort [25000]: " + watch.Elapsed);
            writeLog("Shell Sort [25000]: " + watch.Elapsed, name);

            Console.WriteLine("");
            writeLog("", name);

            Console.WriteLine("====== Shell Sort - Ordenado ======");
            writeLog("====== Shell Sort - Ordenado ======", name);

            watch = new Stopwatch();
            array = insereOrdenado(1000);
            watch.Start();
            ShellSort(array, 1000);
            watch.Stop();
            Console.WriteLine("Shell Sort [1000]: " + watch.Elapsed);
            writeLog("Shell Sort [1000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenado(5000);
            watch.Start();
            ShellSort(array, 5000);
            watch.Stop();
            Console.WriteLine("Shell Sort [5000]: " + watch.Elapsed);
            writeLog("Shell Sort [5000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenado(10000);
            watch.Start();
            ShellSort(array, 10000);
            watch.Stop();
            Console.WriteLine("Shell Sort [10000]: " + watch.Elapsed);
            writeLog("Shell Sort [10000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenado(15000);
            watch.Start();
            ShellSort(array, 15000);
            watch.Stop();
            Console.WriteLine("Shell Sort [15000]: " + watch.Elapsed);
            writeLog("Shell Sort [15000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenado(20000);
            watch.Start();
            ShellSort(array, 20000);
            watch.Stop();
            Console.WriteLine("Shell Sort [20000]: " + watch.Elapsed);
            writeLog("Shell Sort [20000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenado(25000);
            watch.Start();
            ShellSort(array, 25000);
            watch.Stop();
            Console.WriteLine("Shell Sort [25000]: " + watch.Elapsed);
            writeLog("Shell Sort [25000]: " + watch.Elapsed, name);
            Console.WriteLine("");
            writeLog("", name);

            Console.WriteLine("====== Shell Sort - Decrescente ======");
            writeLog("====== Shell Sort - Decrescente ======", name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(1000);
            watch.Start();
            ShellSort(array, 1000);
            watch.Stop();
            Console.WriteLine("Shell Sort [1000]: " + watch.Elapsed);
            writeLog("Shell Sort [1000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(5000);
            watch.Start();
            ShellSort(array, 5000);
            watch.Stop();
            Console.WriteLine("Shell Sort [5000]: " + watch.Elapsed);
            writeLog("Shell Sort [5000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(10000);
            watch.Start();
            ShellSort(array, 10000);
            watch.Stop();
            Console.WriteLine("Shell Sort [10000]: " + watch.Elapsed);
            writeLog("Shell Sort [10000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(15000);
            watch.Start();
            ShellSort(array, 15000);
            watch.Stop();
            Console.WriteLine("Shell Sort [15000]: " + watch.Elapsed);
            writeLog("Shell Sort [15000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(20000);
            watch.Start();
            ShellSort(array, 20000);
            watch.Stop();
            Console.WriteLine("Shell Sort [20000]: " + watch.Elapsed);
            writeLog("Shell Sort [20000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(25000);
            watch.Start();
            ShellSort(array, 25000);
            watch.Stop();
            Console.WriteLine("Shell Sort [25000]: " + watch.Elapsed);
            writeLog("Shell Sort [25000]: " + watch.Elapsed, name);
            #endregion

            Console.WriteLine("");
            writeLog("", name);

            #region Selection Sort
            Console.WriteLine("====== Selection Sort - Aleatório ======");
            writeLog("====== Selection Sort - Aleatório ======", name);
            watch = new Stopwatch();
            array = new int[1000];
            for (int i = 0; i < 1000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }
            
            watch.Start();
            SelectionSort(array, 1000);
            watch.Stop();            
            Console.WriteLine("Selection Sort [1000]: " + watch.Elapsed);
            writeLog("Selection Sort [1000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = new int[5000];
            for (int i = 0; i < 5000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }

            watch.Start();
            SelectionSort(array, 5000);
            watch.Stop();
            Console.WriteLine("Selection Sort [5000]: " + watch.Elapsed);
            writeLog("Selection Sort [5000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = new int[10000];
            for (int i = 0; i < 10000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }

            watch.Start();
            SelectionSort(array, 10000);
            watch.Stop();
            Console.WriteLine("Selection Sort [10000]: " + watch.Elapsed);
            writeLog("Selection Sort [10000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = new int[15000];
            for (int i = 0; i < 15000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }

            watch.Start();
            SelectionSort(array, 15000);
            watch.Stop();
            Console.WriteLine("Selection Sort [15000]: " + watch.Elapsed);
            writeLog("Selection Sort [15000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = new int[20000];
            for (int i = 0; i < 20000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }

            watch.Start();
            SelectionSort(array, 20000);
            watch.Stop();
            Console.WriteLine("Selection Sort [20000]: " + watch.Elapsed);
            writeLog("Selection Sort [20000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = new int[25000];
            for (int i = 0; i < 25000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }

            watch.Start();
            SelectionSort(array, 25000);
            watch.Stop();
            Console.WriteLine("Selection Sort [25000]: " + watch.Elapsed);
            writeLog("Selection Sort [25000]: " + watch.Elapsed, name);

            Console.WriteLine("");
            writeLog("", name);

            Console.WriteLine("====== Selection Sort - Ordenado ======");
            writeLog("====== Selection Sort - Ordenado ======", name);

            watch = new Stopwatch();
            array = insereOrdenado(1000);
            watch.Start();
            SelectionSort(array, 1000);
            watch.Stop();
            Console.WriteLine("Selection Sort [1000]: " + watch.Elapsed);
            writeLog("Selection Sort [1000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenado(5000);
            watch.Start();
            SelectionSort(array, 5000);
            watch.Stop();
            Console.WriteLine("Selection Sort [5000]: " + watch.Elapsed);
            writeLog("Selection Sort [5000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenado(10000);
            watch.Start();
            SelectionSort(array, 10000);
            watch.Stop();
            Console.WriteLine("Selection Sort [10000]: " + watch.Elapsed);
            writeLog("Selection Sort [10000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenado(15000);
            watch.Start();
            SelectionSort(array, 15000);
            watch.Stop();
            Console.WriteLine("Selection Sort [15000]: " + watch.Elapsed);
            writeLog("Selection Sort [15000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenado(20000);
            watch.Start();
            SelectionSort(array, 20000);
            watch.Stop();
            Console.WriteLine("Selection Sort [20000]: " + watch.Elapsed);
            writeLog("Selection Sort [20000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenado(25000);
            watch.Start();
            SelectionSort(array, 25000);
            watch.Stop();
            Console.WriteLine("Selection Sort [25000]: " + watch.Elapsed);
            writeLog("Selection Sort [25000]: " + watch.Elapsed, name);
            Console.WriteLine("");
            writeLog("", name);

            Console.WriteLine("====== Selection Sort - Decrescente ======");
            writeLog("====== Selection Sort - Decrescente ======", name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(1000);
            watch.Start();
            SelectionSort(array, 1000);
            watch.Stop();
            Console.WriteLine("Selection Sort [1000]: " + watch.Elapsed);
            writeLog("Selection Sort [1000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(5000);
            watch.Start();
            SelectionSort(array, 5000);
            watch.Stop();
            Console.WriteLine("Selection Sort [5000]: " + watch.Elapsed);
            writeLog("Selection Sort [5000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(10000);
            watch.Start();
            SelectionSort(array, 10000);
            watch.Stop();
            Console.WriteLine("Selection Sort [10000]: " + watch.Elapsed);
            writeLog("Selection Sort [10000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(15000);
            watch.Start();
            SelectionSort(array, 15000);
            watch.Stop();
            Console.WriteLine("Selection Sort [15000]: " + watch.Elapsed);
            writeLog("Selection Sort [15000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(20000);
            watch.Start();
            SelectionSort(array, 20000);
            watch.Stop();
            Console.WriteLine("Selection Sort [20000]: " + watch.Elapsed);
            writeLog("Selection Sort [20000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(25000);
            watch.Start();
            SelectionSort(array, 25000);
            watch.Stop();
            Console.WriteLine("Selection Sort [25000]: " + watch.Elapsed);
            writeLog("Selection Sort [25000]: " + watch.Elapsed, name);
            #endregion

            Console.WriteLine("");
            writeLog("", name);

            #region Heap Sort
            Console.WriteLine("====== Heap Sort - Aleatório ======");
            writeLog("====== Heap Sort - Aleatório ======", name);
            watch = new Stopwatch();
            array = new int[1000];
            for (int i = 0; i < 1000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }
            
            watch.Start();
            HeapSort(array, 1000);
            watch.Stop();
            Console.WriteLine("Heap Sort [1000]: " + watch.Elapsed);
            writeLog("Heap Sort [1000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = new int[5000];
            for (int i = 0; i < 5000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }

            watch.Start();
            HeapSort(array, 5000);
            watch.Stop();
            Console.WriteLine("Heap Sort [5000]: " + watch.Elapsed);
            writeLog("Heap Sort [5000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = new int[10000];
            for (int i = 0; i < 10000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }

            watch.Start();
            HeapSort(array, 10000);
            watch.Stop();
            Console.WriteLine("Heap Sort [10000]: " + watch.Elapsed);
            writeLog("Heap Sort [10000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = new int[15000];
            for (int i = 0; i < 15000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }

            watch.Start();
            HeapSort(array, 15000);
            watch.Stop();
            Console.WriteLine("Heap Sort [15000]: " + watch.Elapsed);
            writeLog("Heap Sort [15000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = new int[20000];
            for (int i = 0; i < 20000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }

            watch.Start();
            HeapSort(array, 20000);
            watch.Stop();
            Console.WriteLine("Heap Sort [20000]: " + watch.Elapsed);
            writeLog("Heap Sort [20000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = new int[25000];
            for (int i = 0; i < 25000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }

            watch.Start();
            HeapSort(array, 25000);
            watch.Stop();
            Console.WriteLine("Heap Sort [25000]: " + watch.Elapsed);
            writeLog("Heap Sort [25000]: " + watch.Elapsed, name);

            Console.WriteLine("");
            writeLog("", name);

            Console.WriteLine("====== Heap Sort - Ordenado ======");
            writeLog("====== Heap Sort - Ordenado ======", name);

            watch = new Stopwatch();
            array = insereOrdenado(1000);
            watch.Start();
            HeapSort(array, 1000);
            watch.Stop();
            Console.WriteLine("Heap Sort [1000]: " + watch.Elapsed);
            writeLog("Heap Sort [1000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenado(5000);
            watch.Start();
            HeapSort(array, 5000);
            watch.Stop();
            Console.WriteLine("Heap Sort [5000]: " + watch.Elapsed);
            writeLog("Heap Sort [5000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenado(10000);
            watch.Start();
            HeapSort(array, 10000);
            watch.Stop();
            Console.WriteLine("Heap Sort [10000]: " + watch.Elapsed);
            writeLog("Heap Sort [10000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenado(15000);
            watch.Start();
            HeapSort(array, 15000);
            watch.Stop();
            Console.WriteLine("Heap Sort [15000]: " + watch.Elapsed);
            writeLog("Heap Sort [15000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenado(20000);
            watch.Start();
            HeapSort(array, 20000);
            watch.Stop();
            Console.WriteLine("Heap Sort [20000]: " + watch.Elapsed);
            writeLog("Heap Sort [20000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenado(25000);
            watch.Start();
            HeapSort(array, 25000);
            watch.Stop();
            Console.WriteLine("Heap Sort [25000]: " + watch.Elapsed);
            writeLog("Heap Sort [25000]: " + watch.Elapsed, name);
            Console.WriteLine("");
            writeLog("", name);

            Console.WriteLine("====== Heap Sort - Decrescente ======");
            writeLog("====== Heap Sort - Decrescente ======", name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(1000);
            watch.Start();
            HeapSort(array, 1000);
            watch.Stop();
            Console.WriteLine("Heap Sort [1000]: " + watch.Elapsed);
            writeLog("Heap Sort [1000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(5000);
            watch.Start();
            HeapSort(array, 5000);
            watch.Stop();
            Console.WriteLine("Heap Sort [5000]: " + watch.Elapsed);
            writeLog("Heap Sort [5000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(10000);
            watch.Start();
            HeapSort(array, 10000);
            watch.Stop();
            Console.WriteLine("Heap Sort [10000]: " + watch.Elapsed);
            writeLog("Heap Sort [10000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(15000);
            watch.Start();
            HeapSort(array, 15000);
            watch.Stop();
            Console.WriteLine("Heap Sort [15000]: " + watch.Elapsed);
            writeLog("Heap Sort [15000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(20000);
            watch.Start();
            HeapSort(array, 20000);
            watch.Stop();
            Console.WriteLine("Heap Sort [20000]: " + watch.Elapsed);
            writeLog("Heap Sort [20000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(25000);
            watch.Start();
            HeapSort(array, 25000);
            watch.Stop();
            Console.WriteLine("Heap Sort [25000]: " + watch.Elapsed);
            writeLog("Heap Sort [25000]: " + watch.Elapsed, name);
            #endregion

            Console.WriteLine("");
            writeLog("", name);

            #region Merge Sort
            Console.WriteLine("====== Merge Sort - Aleatório ======");
            writeLog("====== Merge Sort - Aleatório ======", name);
            watch = new Stopwatch();
            array = new int[1000];
            for (int i = 0; i < 1000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }
            
            watch.Start();
            MergeSort(array, 0, 999);
            watch.Stop();
            Console.WriteLine("Merge Sort [1000]: " + watch.Elapsed);
            writeLog("Merge Sort [1000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = new int[5000];
            for (int i = 0; i < 5000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }

            watch.Start();
            MergeSort(array, 0, 4999);
            watch.Stop();
            Console.WriteLine("Merge Sort [5000]: " + watch.Elapsed);
            writeLog("Merge Sort [5000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = new int[10000];
            for (int i = 0; i < 10000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }

            watch.Start();
            MergeSort(array, 0, 9999);
            watch.Stop();
            Console.WriteLine("Merge Sort [10000]: " + watch.Elapsed);
            writeLog("Merge Sort [10000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = new int[15000];
            for (int i = 0; i < 15000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }

            watch.Start();
            MergeSort(array, 0, 14999);
            watch.Stop();
            Console.WriteLine("Merge Sort [15000]: " + watch.Elapsed);
            writeLog("Merge Sort [15000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = new int[20000];
            for (int i = 0; i < 20000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }

            watch.Start();
            MergeSort(array, 0, 19999);
            watch.Stop();
            Console.WriteLine("Merge Sort [20000]: " + watch.Elapsed);
            writeLog("Merge Sort [20000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = new int[25000];
            for (int i = 0; i < 25000; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }

            watch.Start();
            MergeSort(array, 0, 24999);
            watch.Stop();
            Console.WriteLine("Merge Sort [25000]: " + watch.Elapsed);
            writeLog("Merge Sort [25000]: " + watch.Elapsed, name);

            Console.WriteLine("");
            writeLog("", name);

            Console.WriteLine("====== Merge Sort - Ordenado ======");
            writeLog("====== Merge Sort - Ordenado ======", name);

            watch = new Stopwatch();
            array = insereOrdenado(1000);
            watch.Start();
            MergeSort(array, 0, 999);
            watch.Stop();
            Console.WriteLine("Merge Sort [1000]: " + watch.Elapsed);
            writeLog("Merge Sort [1000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenado(5000);
            watch.Start();
            MergeSort(array, 0, 4999);
            watch.Stop();
            Console.WriteLine("Merge Sort [5000]: " + watch.Elapsed);
            writeLog("Merge Sort [5000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenado(10000);
            watch.Start();
            MergeSort(array, 0, 9999);
            watch.Stop();
            Console.WriteLine("Merge Sort [10000]: " + watch.Elapsed);
            writeLog("Merge Sort [10000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenado(15000);
            watch.Start();
            MergeSort(array, 0, 14999);
            watch.Stop();
            Console.WriteLine("Merge Sort [15000]: " + watch.Elapsed);
            writeLog("Merge Sort [15000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenado(20000);
            watch.Start();
            MergeSort(array, 0, 19999);
            watch.Stop();
            Console.WriteLine("Merge Sort [20000]: " + watch.Elapsed);
            writeLog("Merge Sort [20000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenado(25000);
            watch.Start();
            MergeSort(array, 0, 24999);
            watch.Stop();
            Console.WriteLine("Merge Sort [25000]: " + watch.Elapsed);
            writeLog("Merge Sort [25000]: " + watch.Elapsed, name);
            Console.WriteLine("");
            writeLog("", name);

            Console.WriteLine("====== Merge Sort - Decrescente ======");
            writeLog("====== Merge Sort - Decrescente ======", name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(1000);
            watch.Start();
            MergeSort(array, 0, 999);
            watch.Stop();
            Console.WriteLine("Merge Sort [1000]: " + watch.Elapsed);
            writeLog("Merge Sort [1000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(5000);
            watch.Start();
            MergeSort(array, 0, 4999);
            watch.Stop();
            Console.WriteLine("Merge Sort [5000]: " + watch.Elapsed);
            writeLog("Merge Sort [5000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(10000);
            watch.Start();
            MergeSort(array, 0, 9999);
            watch.Stop();
            Console.WriteLine("Merge Sort [10000]: " + watch.Elapsed);
            writeLog("Merge Sort [10000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(15000);
            watch.Start();
            MergeSort(array, 0, 14999);
            watch.Stop();
            Console.WriteLine("Merge Sort [15000]: " + watch.Elapsed);
            writeLog("Merge Sort [15000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(20000);
            watch.Start();
            MergeSort(array, 0, 19999);
            watch.Stop();
            Console.WriteLine("Merge Sort [20000]: " + watch.Elapsed);
            writeLog("Merge Sort [20000]: " + watch.Elapsed, name);

            watch = new Stopwatch();
            array = insereOrdenadoDecrescente(25000);
            watch.Start();
            MergeSort(array, 0, 24999);
            watch.Stop();
            Console.WriteLine("Merge Sort [25000]: " + watch.Elapsed);
            writeLog("Merge Sort [25000]: " + watch.Elapsed, name);
            #endregion

            Console.ReadKey();
        }

        static int[] insereOrdenado(int tam)
        {
            int[] vet = new int[tam];
            for (int i = 0; i < tam; i++)
            {
                vet[i] = i;
            }

            return vet;
        }

        static int[] insereOrdenadoDecrescente(int tam)
        {
            int[] vet = new int[tam];
            int j = 0;
            for (int i = tam - 1; i >= 0; i--)
            {
                vet[j] = i;
                j++;
            }

            return vet;
        }

        static void BubbleSort(int[] vet, int tam)
        {
            for (int i = 1; i < tam; i++)
            {
                for (int j = 0; j < tam - 1; j++)
                {
                    if (vet[j] > vet[j + 1])
                    {
                        int aux = vet[j + 1];
                        vet[j + 1] = vet[j];
                        vet[j] = aux;
                    }
                }
            }
        }

        static void BubbleSortII(int[] vet, int tam)
        {
            bool desordenado = true;
            for (int i = 0; (i < tam - 1) && desordenado; i++)
            {
                desordenado = false;
                for (int j = 0; j < tam - i - 1; j++)
                {
                    if (vet[j] > vet[j + 1])
                    {
                        int aux = vet[j + 1];
                        vet[j + 1] = vet[j];
                        vet[j] = aux;
                        desordenado = true;
                    }
                }
            }
        }

        static int Particao(int[] vet, int min, int max, int modo)
        {
            int i = min;
            int j = max;            
            int pivot;

            if (modo == 0)
                pivot = vet[(min + max) / 2];
            else
                pivot = vet[min];            
            while (i <= j)
            {
                while (vet[i] < pivot)
                    i++;
                while (vet[j] > pivot)
                    j--;
                if (i <= j)
                {
                    int aux = vet[i];
                    vet[i] = vet[j];
                    vet[j] = aux;
                    i++;
                    j--;
                }
            };

            return i;
        }

        static void QuickSort(int[] vet, int ini, int fim)
        {
            int pivo = Particao(vet, ini, fim, 0);

            if (ini < pivo - 1)
                QuickSort(vet, ini, pivo - 1);
            if (pivo < fim)
                QuickSort(vet, pivo, fim);            

        }

        static void QuickSortI(int[] vet, int ini, int fim)
        {
            int pivo = Particao(vet, ini, fim, 1);

            if (ini < pivo - 1)
                QuickSort(vet, ini, pivo - 1);
            if (pivo < fim)
                QuickSort(vet, pivo, fim);

        }

        static void InsertionSort(int[] vet, int tam)
        {
            for (int i = 1; i < tam; i++)
            {
                int atual = vet[i];
                int j = i - 1;
                while (j >= 0 && vet[j] > atual)
                {
                    vet[j + 1] = vet[j];
                    j--;
                }
                vet[j + 1] = atual;
            }
        }

        static bool EstaOrdenado(int[] vetor, int tamanho)
        {
            for (int i = 1; i < tamanho; i++)
                if (vetor[i - 1] > vetor[i])
                {                  
                    return false;
                }
            return true;
        }


        //Utilizando a sequência de Knuth
        static void ShellSort(int[] vet, int tam)
        {
            int i, j, aux;
            int salto = 1;
            while (salto < tam)
            {
                salto = 3 * salto + 1;
            }
            while (salto > 0)
            {
                for (i = salto; i < tam; i++)
                {
                    aux = vet[i];
                    j = i;
                    while (j > salto - 1 && aux <= vet[j - salto])
                    {
                        vet[j] = vet[j - salto];
                        j = j - salto;
                    }
                    vet[j] = aux;
                }
                salto /= 3;
            }
        }

        static void SelectionSort(int[] vet, int tam)
        {
            int menor, aux;
            for (int i = 0; i < (tam - 1); i++)
            {
                menor = i;
                for (int j = (i + 1); j < tam; j++)
                {
                    if (vet[j] < vet[menor])
                        menor = j;
                }
                if (vet[i] != vet[menor])
                {
                    aux = vet[i];
                    vet[i] = vet[menor];
                    vet[menor] = aux;
                }
            }
        }

        static void BuildHeap(int[] vet, int tam, int iraiz)
        {
            int ramo, valor;

            valor = vet[iraiz];

            while (iraiz < tam / 2)
            {
                ramo = 2 * iraiz;
                if (ramo < tam && vet[ramo] < vet[ramo + 1])
                    ramo++;
                if (valor >= vet[ramo])
                    break;

                vet[iraiz] = vet[ramo];
                iraiz = ramo;
            }

            vet[iraiz] = valor;
        }
        //Árvore binária
        static void HeapSort(int[] vet, int tam)
        {
            for (int i = tam / 2; i >= 0; i--)
            {
                BuildHeap(vet, tam, i);
            }

            while (tam > 0)
            {
                int aux = vet[0];
                vet[0] = vet[tam - 1];
                vet[tam - 1] = aux;
                tam--;
                BuildHeap(vet, tam, 0);
            }
        }

        static void Merge(int[] vet, int ini, int meio, int fim)
        {
            int i, j, k;
            int tam1 = meio - ini + 1;
            int tam2 = fim - meio;
            int[] vetE = new int[tam1];
            int[] vetD = new int[tam2];
            for (i = 0; i < tam1; i++)
            {
                vetE[i] = vet[ini + i];
            }
            for (j = 0; j < tam2; j++)
            {
                vetD[j] = vet[meio + 1 + j];
            }
            i = 0;
            j = 0;
            k = ini;
            while (i < tam1 && j < tam2)
            {
                if (vetE[i] <= vetD[j])
                {
                    vet[k] = vetE[i];
                    i++;
                }
                else
                {
                    vet[k] = vetD[j];
                    j++;
                }
                k++;
            }
            while (i < tam1)
            {
                vet[k] = vetE[i];
                i++;
                k++;
            }
            while (j < tam2)
            {
                vet[k] = vetD[j];
                j++;
                k++;
            }
        }

        static void MergeSort(int[] vet, int ini, int fim)
        {
            if (ini < fim)
            {
                int m = (ini + fim) / 2;
                MergeSort(vet, ini, m);
                MergeSort(vet, m + 1, fim);
                Merge(vet, ini, m, fim);
            }
        }

        static string imprimeVetor(int[] vet, int tam)
        {
            string array = "[";
            for (int i = 0; i < tam; i++)
            {
                array += vet[i] + ", ";
            }
            array = array.Remove(array.Length - 2, 1) + "]";
            return array;
        }

        static void writeLog(string log, string name)
        {
            File.AppendAllText("log" + name + ".txt",
                   log + Environment.NewLine);
        }


    }
}
