Random random = new Random();
int DaysUntilExpiration = random.Next(12);
DaysUntilExpiration = 0;
int DiscountPercentage = 0;


if (DaysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired");
}
else if (DaysUntilExpiration == 1)
{
    Console.WriteLine("Your susbcription expires within a day!");
    DiscountPercentage = 20;
}
else if (DaysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {DaysUntilExpiration} days.");
    DiscountPercentage = 10;
}
else if (DaysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if (DiscountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {DiscountPercentage}%");
}