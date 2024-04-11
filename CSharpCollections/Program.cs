namespace CollectionTest;

class Program
{
    public static void Main(string[] args)
    {
        Person person = new Person();
        string input;
        string name;
        int age;
        int n;
        Console.Write("Total Number of Input : ");
        input = Console.ReadLine();
        n = int.Parse(input);
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter Name : ");
            name = Console.ReadLine();
            Console.Write("Enter Age : ");
            input = Console.ReadLine();
            age = int.Parse(input);
            person.storeValue(name,age);
            
        }

        
        person.getData();
    }
}