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

        if (bet < money && bet > 1)
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
            Console.WriteLine($"Your total is {dieTotal}!");

            if (die1 == die2)
            {
                Console.WriteLine("DOUBLES!!, YOU WIN!");
                money = (money + bet + bet);
            }
            if (dieTotal == 2)
            {
                Console.WriteLine("Even sum, you win!");
                money = (money + bet);
            }
            if (dieTotal == 4)
            {
                Console.WriteLine("Even sum, you win!");
                money = (money + bet);
            }
            if (dieTotal == 6)
            {
                Console.WriteLine("Even sum, you win!");
                money = (money + bet);
            }
            if (dieTotal == 8)
            {
                Console.WriteLine("Even sum, you win!");
                money = (money + bet);
            }
            if (dieTotal == 10)
            {
                Console.WriteLine("Even sum, you win!");
                money = (money + bet);
            }
            if (dieTotal == 12)
            {
                Console.WriteLine("Even sum, you win!");
                money = (money + bet);
            }
            if (dieTotal == 3)
            {
                Console.WriteLine("Yikes you lost!");
                money = (money - bet);
            }
            if (dieTotal == 5)
            {
                Console.WriteLine("Yikes you lost!");
                money = (money - bet);
            }
            if (dieTotal == 7)
            {
                Console.WriteLine("Yikes you lost!");
                money = (money - bet);
            }
            if (dieTotal == 9)
            {
                Console.WriteLine("Yikes you lost!");
                money = (money - bet);
            }
            if (dieTotal == 11)
            {
                Console.WriteLine("Yikes you lost!");
                money = (money - bet);
            }
        }
        if (bet < 1)
        {
            Console.WriteLine("Dont try and beat the system you...");
        }
    }
    if (option == 2)
    {
        Console.WriteLine($"Okaay, your total is ${money}");
        done = true;
    }
    if (option != 1 && option != 2)
    {
        Console.WriteLine("NOT VAILID AWNSER");
    }
}
