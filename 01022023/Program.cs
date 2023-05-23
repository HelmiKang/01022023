class Program
{

    static void Main(string[] args)
    {
        string fråga = questionsFunction("Vad gillar du mest?", new string[] { "Katter", "Godis", "Blommor", });
        Console.WriteLine(fråga);
    }

    public static string questionsFunction(string question, string[] parms)
    {
        Console.WriteLine(question);
        Console.WriteLine("Svar:");
        for (int i = 1; i < parms.Length + 1; i++)
        {
            Console.WriteLine(i + " " + parms[i - 1]);
        }
        Console.WriteLine("Svara med en siffra mellan 1-3");
        bool isRunning = true;
        while (isRunning)
        {

            bool isInt = int.TryParse(Console.ReadLine(), out int siffra);
            if (!isInt)
            { Console.WriteLine("Skriv en siffra mellan 1-3"); }
            else if (siffra < 1)
            { Console.WriteLine("För lågt. Skriv en siffra mellan 1-3"); }
            else if (siffra > 3)
            { Console.WriteLine("För högt. Skriv en siffra mellan 1-3"); }
            else return parms[siffra - 1];
        }

        return "Crash";
    }
}