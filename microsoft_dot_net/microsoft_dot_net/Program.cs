// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter a calculation : ");

String userString = Console.ReadLine();

Console.WriteLine("here is the string : " + userString);

char[] characterToSearch = ['+', '-', '*', '/'];

char actualOperator = userString[userString.IndexOfAny(characterToSearch)];
Int16 firstNumber = Int16.Parse(userString.Substring(0, actualOperator));
Int16 secondNumber = Int16.Parse(userString.Substring(actualOperator, userString.Length));


switch (actualOperator)
{
  case   '+':
    Console.WriteLine(firstNumber + secondNumber);
    break;
    case   '-':
        Console.WriteLine(firstNumber - secondNumber);
        break;
    case   '*':
        Console.WriteLine(firstNumber * secondNumber);
        break;
    case   '/':
        Console.WriteLine(firstNumber / secondNumber);
        break;
}
