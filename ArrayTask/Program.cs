using System;
using System.ComponentModel;
using System.Xml.Schema;

namespace ArrayTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //Console.Write("Array olcu sayi:");
            //int olcuSayi = int.Parse(Console.ReadLine());
            //int[] a = new int[olcuSayi];
            //Console.Write("C:");
            //int c = Convert.ToInt32(Console.ReadLine());



            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.Write($"A{i}:");

            //    a[i] = int.Parse(Console.ReadLine());


            //}
            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (c > a[i])
            //    {
            //        Console.WriteLine(a[i]);


            //    }

            //}
            #endregion
            #region Task 2
            //Console.Write("Array olcu sayi:");
            //int olcuSayi = int.Parse(Console.ReadLine());
            //int[] a = new int[olcuSayi];
            //Console.Write("C:");
            //int c = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //int count = 0;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.Write($"A{i}:");
            //    a[i] = int.Parse(Console.ReadLine());
            //}
            //for(int i= 0; i < a.Length; i++)
            //{
            //    if (c > a[i])
            //    {
            //        sum = sum + a[i];
            //        count++;
            //    }
            //}
            //Console.WriteLine((double)sum/count);
            #endregion
            #region Task 3
            //Console.Write("Array olcu sayi:");
            //int olcuSayi = int.Parse(Console.ReadLine());
            //int[] a = new int[olcuSayi];
            //Console.Write("C:");
            //int c = Convert.ToInt32(Console.ReadLine());
            //int hasil = 1;
            //int count = 0;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.Write($"A{i}:");
            //    a[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (c < a[i])
            //    {

            //        hasil = hasil * a[i];
            //        count++;
            //    }
            //}
            //Console.WriteLine((double)hasil / count);
            #endregion
            #region Task 4
            //Console.Write("Array olcu sayi:");
            //int olcuSayi = int.Parse(Console.ReadLine());
            //int[] a = new int[olcuSayi];

            //Console.Write("C:");
            //int c = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.Write($"A{i}:");

            //    a[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (c < a[i])
            //    {
            //        Console.WriteLine(a[i]);
            //        Array.Sort(a);
            //        Array.Reverse(a);
            //    }
                
            //}
            //Console.WriteLine();
            
            #endregion
            #region task6
            //int say = Convert.ToInt32(Console.ReadLine());

            //int[] a = new int[say];
            //int[] b = new int[say];
            //for(int i=0; i<a.Length; i++) 
            //{
            //    Console.Write($"A[{i}]=");
            //    a[i]=Convert.ToInt32(Console.ReadLine());

            //}
            //for(int i=0;i<a.Length; i++)
            //{
            //    b[i] = a[i] * a[i];
            //}
            //foreach(var item in b)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region task 7 
            //int say= Convert.ToInt32(Console.ReadLine());
            //int[] a = new int[say];
            //int sum = 0;
            //double total = 1;

            //for(int i = 0; i < a.Length; i++)
            //{
            //    Console.Write($"A[{i}]=");
            //    a[i]=Convert.ToInt32(Console.ReadLine());
            //}
            //Array.Sort(a);
            //sum = a[0] + a[a.Length-1];
            //total = a[0] * a[a.Length-1];
            //total = Math.Sqrt(total);
            //Console.WriteLine((double)sum / 2);
            //Console.WriteLine(total);

            #endregion
            #region task 8
            //Random arr= new Random();

            //int[] a = new int [14];
            //int[] b = new int[14];
            //int[] d= new int[14];
            //for(int i=0;i<a.Length;i++)
            //{
            //    int c = arr.Next(1, 10);
            //    a[i] = c;
            //}
            //for (int i = 0; i < a.Length; i++)
            //{
            //    int c = arr.Next(1, 10);
            //    b[i] = c;
            //}
            //foreach(var anin in a)
            //{
            //    Console.Write($"{anin} ");
            //}
            //Console.WriteLine();
            //foreach (var bnin in b)
            //{
            //    Console.Write($"{bnin} ");

            //}
            //for(int i = 0; i < d.Length; i++)
            //{
            //    d[i] = a[i] * b[i];
            //}
            //Console.WriteLine();
            //foreach(var dnin in d)
            //{
            //    Console.Write($"{dnin} ");
            //}
            #endregion
            #region task 9
            //Random arr1= new Random();
            //int[] a = new int[25];
            //int[] b = new int[8];
            //double[] c = new double[17];
            //for(int i=0;i<a.Length;i++)
            //{
            //    int d=arr1.Next(1, 25);
            //    a[i]=d;

            //}
            //foreach(var anin in a)
            //{
            //    Console.Write($"{anin} ");
            //}
            //Console.WriteLine();
            //for(int i=0;i<8;i++)
            //{
            //    b[i] = a[i] * a[i];
            //}
            //for(int i = 0; i < 17; i++)
            //{
            //    c[i] = (double)a[i+8] / 4;
            //}
            //foreach(var bnin in b)
            //{
            //    Console.Write($"{bnin} ");
            //}
            //Console.WriteLine();
            //foreach (var cnin in c)
            //{
            //    Console.Write($"{cnin} ");
            //}
            #endregion
            #region task 10
            //int olcu=Convert.ToInt32(Console.ReadLine());
            //int[]arr1= new int[olcu];
            //int[] menfiler = new int [olcu];
            //for(int i=0;i<arr1.Length;i++)
            //{
            //    Console.WriteLine($"A[{i}]=");
            //    arr1[i]=Convert.ToInt32(Console.ReadLine());
            //}
            //for(int i = 0; i < arr1.Length; i++)
            //{
            //    if (arr1[i]<0)
            //    {
            //        menfiler[i] += arr1[i];
            //    }
            //}
            //foreach(var menfi in menfiler)
            //{
            //    Console.Write($"{menfi} ");
            //}
            //Array.Sort( menfiler );
            //Console.WriteLine(menfiler.Length-1);
            #endregion
            #region task 11
            //Random arr1 = new Random();
            //int olcu= Convert.ToInt32(Console.ReadLine());
            //int[]a= new int[olcu];
            //for(int i = 0; i < a.Length; i++)
            //{
            //    int d= arr1.Next(0,100);
            //    a[i] = d;
            //}

            //Array.Sort(a);
            //Array.Reverse(a);
            //foreach (var anin in a)
            //{
            //    Console.WriteLine(anin);
            //}
            #endregion
            #region task 12
            //Random arr1= new Random();
            //int[] a = new int[20];
            //double sum = 0;
            //int hasil = 1;
            //for(int i = 0; i <a.Length; i++)
            //{
            //    int d = arr1.Next(1, 25);
            //    a[i] = d;

            //}
            //foreach(var anin in a)
            //{
            //    Console.WriteLine(anin);
            //}
            //Console.WriteLine();
            //for(int i = 0; i < 10; i++)
            //{
            //    sum = sum + a[i];

            //}
            //for(int i = 10; i < 19; i++)
            //{
            //    hasil = hasil * a[i];
            //}
            //Console.WriteLine(sum / 10);
            //Console.WriteLine(hasil/10);
            #endregion
        }
    }


   
}