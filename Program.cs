using System;

Main();

void Main()
{
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();

    // moose speaking
    MooseSays("H I, I'M  E N T H U S I A S T I C !");
    MooseSays("I really am enthusiastic");

    // questions moose is asking
    CanadaQuestion();
    EnthusiasticQuestion();
    LoveCSharpQuestion();
    SecretQuestion();
}


void MooseSays(string message)
{
    Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}

void reduceClutter(bool arg, string ifYes, string ifNo)
{
    if (arg)
    {
        MooseSays(ifYes);
    }
    else
    {
        MooseSays(ifNo);
    }
}

// questions moose can ask
void CanadaQuestion()
{
    bool isTrue = MooseAsks("Is Canada real?");
    reduceClutter(isTrue, "Really? It seems very unlikely.", "I  K N E W  I T !!!");
}

void EnthusiasticQuestion()
{
    bool isEnthusiastic = MooseAsks("Are you enthusiastic?");
    reduceClutter(isEnthusiastic, "Yay!", "You should try it!");
}

void LoveCSharpQuestion()
{
    bool doesLoveCSharp = MooseAsks("Do you love C# yet?");
    reduceClutter(doesLoveCSharp, "Good job sucking up to your instructor!", "You will...oh, yes, you will...");
}

void SecretQuestion()
{
    bool wantsSecret = MooseAsks("Do you want to know a secret?");
    reduceClutter(wantsSecret, "ME TOO!!!! I love secrets...tell me one!", "Oh, no...secrets are the best, I love to share them!");
}


// how we answer the questions
bool MooseAsks(string question)
{
    Console.Write($"{question} (Y/N): ");
    string answer = Console.ReadLine().ToLower();

    while (answer != "y" && answer != "n")
    {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }

    if (answer == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}