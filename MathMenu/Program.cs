// See https://aka.ms/new-console-template for more information

using System.Text;
using MathMenu;

// set output encoding
Console.OutputEncoding = Encoding.UTF8;

// see InputHelper.cs
var inputHelper = new InputHelper();

// list of available menu items
IMathActionCalculator[] menu =
{
    new SquareAreaCalculator(inputHelper),
    new RectangleAreaCalculator(inputHelper),
    new CosCalculator(inputHelper)
};

// 'special' menu item indexes
int clearScreenMenuIndex = menu.Length + 1;
int exitMenuIndex = menu.Length + 2;

do
{
    Console.Clear();

    // print all menu items
    for (int i = 0; i < menu.Length; i++)
    {
        Console.WriteLine("{0}. {1}", i + 1, menu[i].MenuLine);
    }

    // print 'special' menu items
    Console.WriteLine("{0}. Очистить консоль и вывести меню", clearScreenMenuIndex);
    Console.WriteLine("{0}. Поблагодарить пользвателя, завершить выполнение", exitMenuIndex);

    Console.Write("Выберите действия: ");

    var userInput = Console.ReadLine();

    int userChoice;

    // parsing and validating input. .
    // We expect Number that in range 1 <= N <= Menu Items Count (see menu array) + 'special' menu items 
    while (!int.TryParse(userInput, out userChoice)
           || userChoice < 1
           || !(userChoice <= menu.Length || userChoice == exitMenuIndex || userChoice == clearScreenMenuIndex))
    {
        Console.Write("Некорректный выбор, попробуйте еще: ");

        userInput = Console.ReadLine();
    }

    // check if 'special' menu item was selected
    if (userChoice == clearScreenMenuIndex)
    {
        // go to the next iteration
        continue;
    }

    if (userChoice == exitMenuIndex)
    {
        Console.WriteLine("So long and thanks for the fish!");

        // short delay before program stops
        Thread.Sleep(1000);

        // end execution
        return;
    }

    // get selected menu item from array
    var calculator = menu[userChoice - 1];

    Console.Clear();

    Console.WriteLine("{0}\n", calculator.MenuLine);

    // call the logic inside calculator
    var result = calculator.Calculate();

    // print result
    Console.WriteLine("Результат: {0}", result);

    Console.WriteLine("\nНажмите любую кнопку что бы продолжить");
    Console.ReadKey();
} while (true);