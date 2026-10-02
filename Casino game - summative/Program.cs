using Making_Classes;
int money, option, dieTotal, bet;
bool done;
done = false;

money = 100;

Console.WriteLine($"Welcome to the Casino!, This is your starting money:{money}.");

while (done == false)
{
    Console.WriteLine($"Your current money is:{money}, Do you want to play? 1 - yes, 2 - no");
    option = Convert.ToInt32( Console.ReadLine());

    if (option == 1)
    {
        Console.WriteLine("Okay nice! Now what is your bet?");
        bet = Convert.ToInt32( Console.ReadLine());

        if(bet > money)
        {
            Console.WriteLine("No no no!! you dont have enough money!");
        }

        if (bet < money)
        {
            Console.WriteLine("Okay, calculating roll..");


            Die die1 = new Die();
            die1.Color = ConsoleColor.Red;
            die1.RollDie();

            Die die2 = new Die();
            die2.RollDie();
            die1.DrawRoll();
            die2.DrawRoll();
            dieTotal = (die1.Roll + die2.Roll);

            if (die1 == die2)
            {
                Console.WriteLine("DOUBLES!!, YOU WIN!");
                money = (money + bet);
            }
        }
    }
    if (option == 2)
    {
        Console.WriteLine($"Okaay, your total is ${money}");
        done = true;
    }
    else
    {
        Console.WriteLine("NOT VAILID AWNSER");
    }
}
