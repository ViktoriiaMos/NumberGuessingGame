// See https://aka.ms/new-console-template for more information
//для генерування рандомних чисел
Random r = new Random();

// із діапазону від 0 до 100 рандомно обирається число і присвоюється winNum
int winNum = r.Next(0, 100);

bool win = false;

do
{
    Console.WriteLine("Guess a number between 0 and 100");
    string s = Console.ReadLine();

    int i = int.Parse(s);

    if (i > winNum)
    {
        Console.WriteLine("To high! Guess lower...");

    } else if (i < winNum)
    {
        Console.WriteLine("To low! Guess higher...");

    } else if (i == winNum)
    {
        Console.WriteLine("You win!!!");
        win = true;
    }

    Console.WriteLine();

} while (win == false);

Console.WriteLine("Thank you for playing the game");