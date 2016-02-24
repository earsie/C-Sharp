using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void SampleD();

    class Program

    {
        static void Main(string[] args)
    {
        SampleD del1, del2, del3, del4; //Here we define the four delegates
        del1 = new SampleD(SampleD1);
        del2 = new SampleD(SampleD2);
        del3 = new SampleD(SampleD3);
        del4 = del1 + del2 + del3; //As you can see, del4 is the multicast delegate

        del4(); //this function is run

    }

    public static void SampleD1()
    {
        Console.WriteLine("Counting One, ");
    }

    public static void SampleD2()
    {
        Console.WriteLine("Counting Two, ");
    }

    public static void SampleD3()
    {
        Console.WriteLine("Counting Three.");
    }

}
