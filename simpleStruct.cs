using System;
struct Magazines
{
    public string title;
    public string author;
    public string subject;
    public int mag_id;
};

public class simpleStruct
{
    public static void Main(string[] args)
    {

        Magazines Mag1;   //Creating two vars with Mag1 and Mag2 for magazines
        Magazines Mag2;   

        /* Mag 1 specification */
        Mag1.title = "Best Unicorns of 2016";
        Mag1.author = "Hollywood Jimbo";
        Mag1.subject = "Nothing in particular";
        Mag1.mag_id = 44656999;

        /* Mag 2 specification */
        Mag2.title = "Telecom Billing";
        Mag2.author = "Billy Maher";
        Mag2.subject = "Real Time";
        Mag2.mag_id = 7899955;

        /* print mag info */
        Console.WriteLine("Book 1 title : {0}", Mag1.title);
        Console.WriteLine("Book 1 author : {0}", Mag1.author);
        Console.WriteLine("Book 1 subject : {0}", Mag1.subject);
        Console.WriteLine("Book 1 magazine id :{0}", Mag1.mag_id);

        /* print mag2 info */
        Console.WriteLine("Book 2 title : {0}", Mag2.title);
        Console.WriteLine("Book 2 author : {0}", Mag2.author);
        Console.WriteLine("Book 2 subject : {0}", Mag2.subject);
        Console.WriteLine("Book 2 magazine id : {0}", Mag2.mag_id);

        Console.ReadKey();

    }
}
