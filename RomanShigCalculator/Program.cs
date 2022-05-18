// See https://aka.ms/new-console-template for more information



bool yes = true;

while (yes)
{
    Console.WriteLine("please enter two numbers and operator +  -  *  /");
    int num1 = Convert.ToInt16(Console.ReadLine());
    int num2 = Convert.ToInt16(Console.ReadLine());
    string ope = Console.ReadLine();



    switch (ope)
    {
        case "+":
            Console.WriteLine(num1.ToString() + ope + num2.ToString() + '=' + (num1 + num2).ToString());
            yes = false;
            break;
        case "-":
            Console.WriteLine(num1.ToString()+ope+num2.ToString()+'='+(num1 - num2).ToString());
            yes = false;
            break;
        case "*":
            Console.WriteLine(num1.ToString() + ope + num2.ToString() + '=' + (num1 * num2).ToString());
            yes = false;
            break;
        case "/":
            Console.WriteLine(num1.ToString() + ope + num2.ToString() + '=' + (num1 / num2).ToString());
            yes = false;
            break;
        default:
            Console.WriteLine("Wrong operator put another operator +  -  *  /");
            ope = Console.ReadLine();
            break;
    }

    Console.WriteLine("if wont another run enter y");
    if (Console.ReadLine().ToLower() == "y")
    {
        yes = true;

    }




}