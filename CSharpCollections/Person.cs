using System.Collections;

namespace CollectionTest;

public class Person
{
    
    Dictionary<string, int> person = new Dictionary<string, int>();

    public Person()
    {
        
    }
    

    public void storeValue(string name , int age)
    {
        person.Add(name,age);
    }

    public void getData()
    {
        foreach (KeyValuePair<string,int> value in person)
        {
            Console.WriteLine($"{value.Key} is {value.Value} years old.");
        }
    }
}