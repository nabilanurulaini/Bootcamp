using System;
using System.IO;
using MessagePack;

[MessagePackObject]
public class Person
{
	[Key(1)]
	public string Name { get; set; }
	[Key(2)]
	public int Age { get; set; }
	[Key(3)]
	public int Height { get; set; }
}

class Program
{
	static void Main(string[] args)
	{
		Person person = new Person
        {
            Name = "Johny",
            Age = 30,
            Height = 180
        };
        byte[] bytes = MessagePackSerializer.Serialize(person);
        File.WriteAllBytes("person.bin", bytes);
        //deserialize
        byte[] bytesFromFile = File.ReadAllBytes("person.bin");
        Person personDeserialized = MessagePackSerializer.Deserialize<Person>(bytesFromFile);
        Console.Write("Name : "+ personDeserialized.Name + ", Age: "+ personDeserialized.Age + ", Height:  " + personDeserialized.Height);
        
	}
}
