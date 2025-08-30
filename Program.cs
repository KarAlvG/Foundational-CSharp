string Permission = "Admin | Manager ";
int Level = 53;

if (Permission.Trim().ToLower().Contains("admin"))
{
    Console.WriteLine($"{(Level > 55 ? "Welcome, Super Admin user" : " Welcome, Admin user")}");
}
else if (Permission.Trim().ToLower().Contains("manager"))
{
    Console.WriteLine($"{(Level >= 20 ? "Contact an Admin for access." : "You do not have sufficient privileges.")}");
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}