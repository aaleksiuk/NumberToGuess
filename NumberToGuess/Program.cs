var numberToGuess = new Random().Next(100);
const int minValue = 0;
const int maxValue = 99;
int attemptsLeft = 5;

Console.WriteLine($"Guess number between {minValue}-{maxValue}");

while (attemptsLeft > 0)
{
    attemptsLeft--;
    int enteredNumber = GetNumberFromUser(minValue, maxValue);
    if (enteredNumber == numberToGuess)
    {
        Console.WriteLine($"You guessed it!");
        break;
    }
    if (attemptsLeft == 0)
    {
        Console.WriteLine($"Sorry you didn't guess the number, the answer was: {numberToGuess}");
        break;
    }
    PrintHint(enteredNumber > numberToGuess ? "GREATER" : "LOWER");
}

void PrintHint(string hint)
{
    Console.WriteLine($"Your number is {hint} than the one you are trying to guess. You still have {attemptsLeft} attempt(s) left! Please try again");
}

static int GetNumberFromUser(int minValue, int maxValue)
{
    int intTemp;
    while (!int.TryParse(Console.ReadLine(), out intTemp) ||
            (intTemp < minValue || intTemp > maxValue))
    {
        Console.WriteLine($"Invalid input. Please enter a valid number between {minValue}-{maxValue}.");
        Console.WriteLine("Enter your guess:");
    }
    return intTemp;
}