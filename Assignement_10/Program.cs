Console.Clear();
Console.WriteLine("Enter tree digit number");
int number = int.Parse(Console.ReadLine()!);
if ((number > 99) && (number < 1000))
    Console.WriteLine(number / 10 % 10);
else
    Console.WriteLine("Wrong number");