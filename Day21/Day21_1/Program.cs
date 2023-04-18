using System;
using System.IO;
using System.Xml.Serialization;
using System.Text.Json; 

public class Person{
    public string? Name { get; set; }
    public int? Age { get; set; }
    public int? Height { get; set; }
}

class Program{
    static void Main(string[] args){
        Person person = new Person{
            Name = "Ayam",
            Age = 30,
            Height = 180
        };
        
        Console.WriteLine("Choose an option: XML (1) or JSON (2)");
        string option = Console.ReadLine();
        switch (option){
            case "1":
                SerializeToXml(person);
                break;
            case "2":
                SerializeToJson(person);
                break;
            default:
                Console.WriteLine("Invalid option");
                break;
        }

    }
    static void SerializeToXml(Person person){
        XmlSerializer serializer = new XmlSerializer(typeof(Person));
        using (FileStream stream = new FileStream("person.xml", FileMode.Create)){
            serializer.Serialize(stream, person); 
        }
        using (StreamReader stream = new StreamReader("person.xml")){
            Person reader = (Person)serializer.Deserialize(stream);
            Console.Write("Name : "+ reader.Name + ", Age: "+ reader.Age + ", Height:  " + reader.Height);
        }
        

    }
    static void SerializeToJson(Person person){
        string json = System.Text.Json.JsonSerializer.Serialize(person);
        File.WriteAllText("person.json", json);
        //deserialize 
        string jsonFromFile = File.ReadAllText("person.json");
        Person PersonDeserialized = System.Text.Json.JsonSerializer.Deserialize<Person>(jsonFromFile);
        Console.Write("Name : "+ PersonDeserialized.Name + ", Age: "+ PersonDeserialized.Age + ", Height:  " + PersonDeserialized.Height);
    }
}

