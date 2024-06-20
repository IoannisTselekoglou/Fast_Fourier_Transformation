using System.Runtime.InteropServices;
using FTT.Data;

class Program
{
public static void Main()
    {
        double[] bitch = {1.2, 530, 30, 3, 31};

        DataObject testobject = new DataObject(bitch);

        //Console.WriteLine("Length: " + testobject.GetLength());
        //Console.WriteLine("Mean: " + testobject.GetMean());
        bitch = new double[] {0.3, 0.1, 0.1, 0.3, 0.3};

        testobject.PrintData(); // Vector Addition by Vector

        testobject.Multi(bitch); // Vector Multiplication Vector 


    }
}

class Transformation
{

}
