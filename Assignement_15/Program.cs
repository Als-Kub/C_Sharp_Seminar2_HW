Console.Clear();
Console.WriteLine("Enter a day of the week");
int number = int.Parse(Console.ReadLine()!);
if ((number < 1) ^ (number > 7))
{
    Console.WriteLine("Wrong number");
}
else if (number > 5)
{
    Console.WriteLine("Yes, it's weekend!");
    
}
else {
    Console.WriteLine("No, it's a working day");        
}