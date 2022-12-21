

List<string> names = new List<string>() 
{
    "Sweater Weather", "Pure White", "Shiitake", "Pewter Green" 
};


IEnumerable<string> sortedList = names.OrderByDescending(x => x.Length);



foreach (var item in sortedList)
{
    Console.WriteLine(item);
}