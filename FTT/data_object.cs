using System;
using System.Linq;
namespace FTT.Data
{
    public class DataObject
    {
       public double[] Data { get; set;}
       public DataObject(double[] data)
       {
           if (data == null)
           {
               throw new ArgumentException("Data cannot be null or empty");
           }

            Data = data;
       }

       public double GetMean()
       {
           return Data.Average();
       }

       public double GetLength()
       {
           return Data.Length;
       }

       public double[] Add(double[] a)
       {

            if (a.Length != this.Data.Length)
            { 
                throw new ArgumentException("Arrays must be of the same length.");
            }

            if (a == null)
            {
                throw new ArgumentException(nameof(a), "Input cannot be null. ");
            }

            if(a.OfType(int) || a.OfType(double))
            {
                for(int i = 0; i < a.Length; i++)
                {
                    this.Data[i] += a;

                }
                return this.Data;
            }

            for (int i = 0; i < a.Length; i++)
            {
                this.Data[i] = a[i] + this.Data[i];
            }
            return this.Data; 
       }
       public double[] Multi(double[] a)
       {

            if (a.Length != this.Data.Length)
            { 
                throw new ArgumentException("Arrays must be of the same length.");
            }
            
            if (a == null)
            {
                throw new ArgumentException(nameof(a), "Input cannot be null. ");
            }

            for (int i = 0; i < a.Length; i++)
            {
                this.Data[i] = a[i] * this.Data[i];
            }
            return this.Data; 
       }
       public void PrintData()
       {
           Console.WriteLine("[" + string.Join(", ", Data) + "]");
       }
    }


}