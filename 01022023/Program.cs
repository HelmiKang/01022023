using System.Text.Json;
using RestSharp;
using System.IO;
using _01022023;

RestClient client = new("http://ponyapi.net/v1/");

Console.WriteLine("What do you wish to search for?");
Console.WriteLine("character - episode");
string SearchType = Console.ReadLine();

if (SearchType == "character")
{
    Console.WriteLine("Which pony id?");

}
else if (SearchType == "episode")
{

    Console.WriteLine("Which episode id?");

}
else
{
    Console.WriteLine("What?");
}
string SearchId = Console.ReadLine();

RestRequest request = new($"{SearchType}/{SearchId}");

RestResponse response = client.GetAsync(request).Result;

//Console.WriteLine(response.Content);
if (response.StatusCode == System.Net.HttpStatusCode.OK)
{
    File.WriteAllText("Pony.json", response.Content);
    PonyResult pResult = JsonSerializer.Deserialize<PonyResult>(response.Content);

    Console.WriteLine("The name of your search is:");
    Console.WriteLine(pResult.data[0].Name);
    Console.WriteLine(" ");

    if (SearchType == "character")
    {
        Console.WriteLine($"What do you wish to know about the pony {pResult.data[0].Name}?");
        Console.WriteLine("1: kind 2: occupation 3: alias");
        string SearchTypeType = Console.ReadLine();

        if (SearchTypeType == "1")
        {
            Console.WriteLine($"{pResult.data[0].Name} kind is {pResult.data[0].Kind}");
        }
        if (SearchTypeType == "2")
        {
            Console.WriteLine($"{pResult.data[0].Name} occupation is {pResult.data[0].Occupation}");
        }
        if (SearchTypeType == "3")
        {
            Console.WriteLine($"{pResult.data[0].Name} alias is {pResult.data[0].Alias}");
        }


    }
    else if (SearchType == "episode")
    {
        Console.WriteLine($"What do you wish to know about the episode '{pResult.data[0].Name}'?");
        Console.WriteLine("1: season 2: episode 3: airdate");
        //funkar inte
    }   
}
else
{
    Console.WriteLine("What?");
}


Console.ReadLine();
















// class Program
// {

//     static void Main(string[] args)
//     {
//         string fråga = questionsFunction("Vad gillar du mest?", new string[] { "Katter", "Godis", "Blommor", });
//         Console.WriteLine(fråga);
//     }

//     public static string questionsFunction(string question, string[] parms)
//     {
//         Console.WriteLine(question);
//         Console.WriteLine("Svar:");
//         for (int i = 1; i < parms.Length + 1; i++)
//         {
//             Console.WriteLine(i + " " + parms[i - 1]);
//         }
//         Console.WriteLine("Svara med en siffra mellan 1-3");
//         bool isRunning = true;
//         while (isRunning)
//         {

//             bool isInt = int.TryParse(Console.ReadLine(), out int siffra);
//             if (!isInt)
//             { Console.WriteLine("Skriv en siffra mellan 1-3"); }
//             else if (siffra < 1)
//             { Console.WriteLine("För lågt. Skriv en siffra mellan 1-3"); }
//             else if (siffra > 3)
//             { Console.WriteLine("För högt. Skriv en siffra mellan 1-3"); }
//             else return parms[siffra - 1];
//         }

//         return "Crash";
//     }
// }