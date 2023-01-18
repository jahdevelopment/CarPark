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

Console.WriteLine("Please enter the number of spots for the car park:");
int totalSpaces = Int32.Parse(Console.ReadLine());

Dictionary<List<string>, List<string>> carPark = 
    new Dictionary<List<string>, List<string>>();

List<string> carSpots = new List<string>();

List<string> stateSpot = new List<string>();

char[] letters = new char[25]
    { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'X', 'Y', 'Z' };

char[] ints = new char[10] {'0','1','2','3','4','5','6','7','8','9'};

for (int i = 0; i <= totalSpaces -1; i++)
{
    if (totalSpaces < 10)
    {
        carSpots.Add($"{letters[1]}{ints[i]}");

        Console.WriteLine(carSpots[i]);
    }
    else if (totalSpaces >= 10) { }
    {
        carSpots.Add($"{letters[0]}{ints[i]}");
        carSpots.Add($"{letters[1]}{ints[i]}");
        Console.WriteLine(carSpots[i]);
    }

    
}

