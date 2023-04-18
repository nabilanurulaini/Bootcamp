using System;
using System.IO;
using ProtoBuf;
[ProtoContract]
public class Person
{
    [ProtoMember(1)]
    public string Name { get; set; }
    [ProtoMember(2)]
    public int Age { get; set; }
    [ProtoMember(3)]
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
            Height = 200
        };
        using (FileStream stream = new FileStream("person.bin", FileMode.Create))
        {
            Serializer.Serialize(stream, person);
        }
        //deserialize
        using (FileStream stream = new FileStream("person.bin", FileMode.Open))
        {
            Person personDeserialized = Serializer.Deserialize<Person>(stream);
            Console.Write("Name : " + personDeserialized.Name + ", Age: " + personDeserialized.Age + ", Height:  " + personDeserialized.Height);
        }
    }
}