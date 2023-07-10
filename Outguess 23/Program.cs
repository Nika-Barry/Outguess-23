Outguess();
static void Outguess()
{
    int user_Guess;
    int num_Enteries = 7;
    Random rnd = new Random();
    int LuckyNum = rnd.Next(1,101);


    Console.WriteLine("Welcome to Outguess! \n I've chosen a secret number, now guess it");
    user_Guess = int.Parse(Console.ReadLine());



    for (int i = 1; i <= 7; i--)
    {
        LuckyNum = rnd.Next(1, 101);
        if (user_Guess == LuckyNum)
        {
            Console.Write("Congratulations! You've guess the correct number!", LuckyNum);
            break;
        }



        else if (user_Guess < LuckyNum)
        {
            Console.Write("Sorry your guess is too low! Please try again", user_Guess);
            user_Guess = int.Parse(Console.ReadLine());

            

        }
        else if (user_Guess > LuckyNum)
        {
            Console.WriteLine("Yikes! Your guess is too high! Please try again");
            user_Guess = int.Parse(Console.ReadLine());
            
            
        

        }
    }
}
