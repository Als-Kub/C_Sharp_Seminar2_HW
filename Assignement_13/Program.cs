// The code will find the third digit from the begining of the number
Console.Clear();
Console.WriteLine("Enter a number");
int number = int.Parse(Console.ReadLine()!);
int numberLength = (int)(Math.Floor(Math.Log10(number) + 1));
if (numberLength >= 3)
{
    int thirdNumber = (number / (int)(Math.Pow(10, numberLength - 3))) % 10;
    Console.WriteLine(thirdNumber);
}
else
{
    Console.WriteLine("There is no thrid digit in your number");
}

