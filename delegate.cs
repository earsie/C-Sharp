using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void stringFunction(string Message);

class drill42
{
    public static void Main()
    {
        stringFunction del = new stringFunction(Hey);
        del("Hey there!"); //this is the value that is delegated to the Hey var
    }


    public static void Hey(string strMessage)
    {
        Console.WriteLine(strMessage); //note the relationship with the stringFunction var
    }
}
