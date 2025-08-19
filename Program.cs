string[] OrderIds = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];

foreach (string orderId in OrderIds)
{
    if (orderId.StartsWith("B"))
    {
        Console.WriteLine(orderId);
    }

}