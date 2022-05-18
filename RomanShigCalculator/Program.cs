// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("please enter two numbers and operator +  -  *  /");
int num1= Convert.ToInt16( Console.ReadLine());
int num2 = Convert.ToInt16(Console.ReadLine());
string ope = Console.ReadLine();

bool yes = true;

while (yes)
{
    switch (ope)
    {
        case "+":
            Console.WriteLine(num1+num2);
            yes = false;
            break;
        case "-":
            Console.WriteLine(num1 - num2);
            yes = false;
            break;
        case "*":
            Console.WriteLine(num1 * num2);
            yes = false;
            break;
        case "/":
            Console.WriteLine(num1 / num2);
            yes = false;
            break;
        default:
            Console.WriteLine("Wrong operator put another operator +  -  *  /");
            ope = Console.ReadLine();
            break;
    }







}