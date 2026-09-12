// See https://aka.ms/new-console-template for more information
using Calculator;

char cont;
do {

    decimal num1 = -1, num2 = -1;
    char ope = 'a';

    Input input = new Input();
    BasicCalculator calculator = new BasicCalculator();

    if (input.TakeInput(ref num1, ref num2, ref ope))
    {
        Console.WriteLine($"Answer = {calculator.Calc(num1, num2, ope)}");
        Console.WriteLine("========================================================");
    }

    Console.WriteLine("If you want to continue press y/Y");
    cont = char.Parse(Console.ReadLine());
}
while (cont == 'y' || cont == 'Y');