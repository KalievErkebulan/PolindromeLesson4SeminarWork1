Console.Clear();
number = int.Parse(Console.ReadLine()!);
int exampleOfFiveDigitNumber = 34593;
string strTwo = $"{exampleOfFiveDigitNumber}";
string strOne = $"{number}";
int lengthOne = strOne.Length;
int lengthTwo = strTwo.Length;
int lengthDifference =lengthOne-lengthTwo;
int degree = Convert.ToInt32(Math.Pow(10,lengthDifference));
if (lengthTwo==lengthOne)
{
    int a = number/1000;
    int b = number%100;
    int endOfNumber = a%10;
    int penultimateNumber = a/10;
    int multiple = endOfNumber*10;
    int plus = multiple+penultimateNumber;
    if (plus==b)
    {
    Console.WriteLine("да");
    }
    else
    Console.WriteLine("нет");
}
else
{
    Console.WriteLine("Вы ввели некорректное число");
}