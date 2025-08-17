Random Dice = new Random();

int Roll1 = Dice.Next(1, 7);
int Roll2 = Dice.Next(1, 7);
int Roll3 = Dice.Next(1, 7);

Roll1 = 2;
Roll2 = 1;
Roll3 = 1;

int Total = Roll1 + Roll2 + Roll3;

Console.WriteLine($"Dice roll: {Roll1} + {Roll2} + {Roll3} = {Total}");

if ((Roll1 == Roll2 || Roll2 == Roll3 || Roll3 == Roll1))
{
    if ((Roll1 == Roll2) && (Roll2 == Roll3))
    {
        Console.WriteLine($"You rolled triples! +6 bonuns to total!");
        Total += 6;

    }
    else
    {
        Console.WriteLine($"You rolled doubles! +2 bonus to total!");
        Total += 2;
    }

    Console.WriteLine($"Your total including the bonus: {Total}");
}

if (Total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (Total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (Total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}