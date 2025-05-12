namespace Krokodillespillet_CSharp;

public class Class1
{
    public void croc()
    {
        Random kake = new Random();
        int randomNumber = kake.Next(1, 11);
        string space = kake.Next().ToString();
        int anotherNumber = kake.Next(3_5);
        
        Console.WriteLine(randomNumber);
       string input = Console.ReadLine();
        //if (randomNumber > input)
        {
            Console.WriteLine();
        }
    
    }
}