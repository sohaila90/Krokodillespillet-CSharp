namespace Krokodillespillet_CSharp;

public class Class1
{
    public void croc()
    {
        int points = 0;
        while (true)
        {
            Console.Clear();
            Random kake = new Random();
            int randomNumber = kake.Next(1, 12);
            int randomNumber2 = kake.Next(1, 12);
            Console.WriteLine($"Points: {points}");
            Console.WriteLine($"{randomNumber} _ {randomNumber2}");
            string guess = Console.ReadLine();
            
            if (randomNumber == randomNumber2 && guess == "=")
            {
                points++;
            }
            else if (randomNumber > randomNumber2 && guess == ">")
            {
               points++; 
            }
            else if (randomNumber < randomNumber2 && guess == "<")
            {
                points++;
            }
            else
            {
                points--;
            }
        }
        
       
    
    }
}