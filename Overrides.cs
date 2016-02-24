using System;

//This is a minor exercise on how to use overrides in C#
//Here, I create a class, Base
public class Base
{
    public virtual void ShowInfo()
    {
        Console.WriteLine("This is Base class");
    }

}

//Here, I create a second class that inherits from the first class, Base; note the :
public class SecondBase : Base
{

    public override void ShowInfo()

    {
        Console.WriteLine("This overrwrites the first class");
    }

}

//Here write a simple code to show their info.  Remember, Base class needs to be virtual type for the override.

public class ThirdBase
{
    static void Main()
    {
        Base bs = new Base();
        SecondBase sb = new SecondBase();
        bs.ShowInfo();
        sb.ShowInfo();
    }
}
