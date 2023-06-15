int intToGuess = new Random().Next(100);
const int minValue = 0;
const int maxValue = 99;
int maxAttempts = 5;
int attemptsLeft = maxAttempts;

Console.WriteLine($"{intToGuess}");

static int parseInput(int minValue, int maxValue)
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

Console.WriteLine($"Guess number between {minValue}-{maxValue}");

while (attemptsLeft > 0)
{
    attemptsLeft--;
    int intEntered = parseInput(minValue, maxValue);

    if (intEntered > intToGuess && attemptsLeft > 0)
        Console.WriteLine($"Your number is GREATER than the one you are trying to guess. You still have {attemptsLeft} attempt(s) left! Please try again");
    else if (intEntered < intToGuess && attemptsLeft > 0)
        Console.WriteLine($"Your number is LOWER than the one you are trying to guess. You still have {attemptsLeft} attempt(s) left! Please try again");
    else if (intEntered == intToGuess)
    {
        Console.WriteLine($"You guessed it!");
        break;
    }
    else if (attemptsLeft == 0)
    {
        Console.WriteLine($"Sorry you didn't guess the number, the answer was: {intToGuess}");
        break;
    }
}