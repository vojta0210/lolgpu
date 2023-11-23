
bool proceed = true;
string finalSentence = "";
while (proceed)
{
    Console.WriteLine("Zadej slovo");
    string userInputA = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(userInputA))
    {
        Console.WriteLine(finalSentence);
        proceed = false;
    }
    else if (!string.IsNullOrEmpty(userInputA))
    {
        finalSentence += userInputA;

    }
}










