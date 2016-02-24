using System;
using System.Runtime.Serialization;
using System.IO;

//This is the serialization tag needed to be added at different parts.  
    [DataContract]
    class Person
    {
        [DataMember] //another serialization section
        public string FirstName { get; set; }
        [DataMember]  //another serialization section
        public string LastName { get; set; }
        [DataMember] //another serialization section
        public int Age { get; set; }
    }

    class MainClass 
    {
    static void Main()
    {
        var me = new Person
        {
            FirstName = "Brook",
            LastName = "H.",
            Age = 39
        };
        
        //This is what system.IO is reading from the program as it communicates with the parser.
        var serializer = new DataContractSerializer(me.GetType());  
        var someRam = new MemoryStream();
        someRam.WriteObject(someRam, me);
        someRam.Seek(0, SeekOrigin.Begin);
        Console.WriteLine(XElement.Parse(Encoding.ASCII.GetString(someRam.GetBuffer()).Replace("\0", "")));
        }
    }
