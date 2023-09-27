using System.Diagnostics.CodeAnalysis;
//Namn: Mojtaba Mobasheri
//Klass: NET23
namespace BasicCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int guesses = 0; //creating a varible called guesses with the value 0
            Random random = new Random(); //random variable with name random
            int randomNumber = random.Next(1, 21); //randomNumber variable that gives random number between 1-20

            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");

            while (guesses < 5) //while loop runs as long as guesses are less than 5
            {
                

                try //to catch any errors/formatExceptions in this case.
                {
                    int guess = int.Parse(Console.ReadLine());

                    if (CheckGuess(guess, randomNumber)) //if sats with checkGuess method to check if the guess is correct.
                    {
                        guesses++; //increasing the amount of guesses
                        Console.WriteLine("Wohoo! Du klarade det!");
                        Console.WriteLine($"På {guesses} försök"); //prints out the current amount of guesses
                        break;

                    }
                    else if (guess > randomNumber) //if guess is bigger than the randomNumber it prints out the code block
                    {
                        guesses++;
                        Console.WriteLine("Tyvärr, du gissade för högt");
                        
                        Console.WriteLine($"Try number {guesses}"); //prints out the current amount of guesses
                    }
                    else if (guess < randomNumber) //if guess is smaller than the randomNumber it prints out the code block
                    {
                        guesses++;
                        Console.WriteLine("Tyvärr, du gissade för lågt!");
                        
                        Console.WriteLine($"Try number {guesses}");//prints out the current amount of guesses
                    }
                }
                catch (FormatException e)//to catch any errors/formatExceptions in this case
                {
                    Console.WriteLine("Ogiltig inmatning! Endast siffror!"); //this message prints out if there is any formatExceptions
                }
                if (guesses >= 5)//this message prints out if player didnt succeed with 5 tries.
                {
                    Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök!");
                }
            }
            
        }
        public static bool CheckGuess(int guess, int randomNumber) //the method to check if guess is equal to the randomNumber
        {
            return guess == randomNumber; //returning this calculation to the main method.

        }
    }
}