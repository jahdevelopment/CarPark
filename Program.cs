/*Create a "car park" program that lets us assign vehicles to parking spots using the console.

 First, the program should ask the user to initialize the spaces. It will ask how many spaces exist in the park.

 Spaces are named [Letter][Number 0 -9]

13 spaces: [A0, A1, A2 - B1, B2, B3]

 Spaces should be initialized as "empty". The console then prompts for a space to fill.

Users enter a space number. If that number is "full", the console displays a warning and asks for another space.

 If that space is empty, the user is then prompted for a six-letter license. That license will then be recorded for the requested space.

 If instead of a spot number the user enters "List", all spots are listed as well as if they are occupied, and by what license.

 */

Console.WriteLine("================= CAR PARK =================");

char[] letters = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'X', 'X', 'Y', 'Z' };

Console.WriteLine("Please enter how many spaces you want to add (maximum of 260)");

int parkSize = Int32.Parse(Console.ReadLine());

while(parkSize < 0 || parkSize > 260)
{
    Console.WriteLine("Please enter a value between 0 and 261");

    parkSize = Int32.Parse(Console.ReadLine());
}

Dictionary<string, string> carPark = new Dictionary<string, string>();

for(int i = 0;i < parkSize; i++)
{
    char letter = letters[i / 10];

    int number = i % 10;

    string parkingSpot = $"{letter}{number}";

    carPark.Add(parkingSpot, "");
}

foreach(string parkingSpot in carPark.Keys)
{
    Console.WriteLine(parkingSpot);
}
// get a parking spot

Console.WriteLine($"Enter a spot you would like to park in between {carPark.Keys.First()} and {carPark.Keys.Last()}, or LIST to see the list of spots");

string requestedInput = Console.ReadLine().ToUpper();

if (carPark.ContainsKey(requestedInput))
{
    if(requestedInput == "LIST")
    {
        foreach(KeyValuePair<string, string> pair in carPark)
        {
            string parkedCarDisplay = pair.Value;

            if (string.IsNullOrEmpty(parkedCarDisplay))
            {
                parkedCarDisplay = "EMPTY";
            }
            Console.WriteLine($"{pair.Key}: {parkedCarDisplay}");
        }
    }
    else if (string.IsNullOrEmpty(carPark[requestedInput]))
    {
        Console.WriteLine("Please enter your vehicle's license");

        string licenseInput = Console.ReadLine();

        while (licenseInput.Length < 1 || licenseInput.Length > 7)
        {
            // === INVALID LICENSE ===
            Console.WriteLine("Sorry, that is not a valid license. Please enter a valid license");
            licenseInput = Console.ReadLine();
        }

        // === SUCCESFULL ADDITION ===
        carPark[requestedInput] = licenseInput;

        Console.WriteLine($"Succesfully registered {carPark[requestedInput]} with spot {requestedInput}.");
    }
    else
    {
        // === SPOT TAKEN ===
        Console.WriteLine($"Sorry, {requestedInput} is not available.");
    }
}
else
{
    // === INVALID SPOT ===
    Console.WriteLine($"Sorry, {requestedInput} is not a valid parking spot.");
}


