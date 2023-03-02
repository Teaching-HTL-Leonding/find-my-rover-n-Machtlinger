/*int east = 0, west = 0, south = 0, north = 0;
string eastSymbol = ">", westSymbol = "<", northSymbol = "^", southSymbol = "v";
string symbol;

int coordination = 0;

do
{
    Console.Write("Where is the rover? ");
    symbol = Console.ReadLine()!;

    if (symbol == eastSymbol) { east++; }
    else if (symbol == westSymbol) { west++; }
    else if (symbol == northSymbol) { north++; }
    else if (symbol == southSymbol) { south++; }
    else { Console.WriteLine("INVALID"); }
} while(!string.IsNullOrEmpty(symbol));

north = north - south;
east = east - west;

if (north < 0)
{
    south = south - north;
}
if (south < 0)
{
    north = north - south;
}
if (west < 0)
{
    east = east - west;
}
if (east < 0)
{
   west = west - east;
}

if (east > 0 || west > 0 || north > 0 || south > 0)
{
    if (east > 0) { Console.WriteLine($"The rover is {east}m to the East"); }
    if (west > 0) { Console.WriteLine($"The rover is {west}m to the West"); }
    if (north > 0) { Console.WriteLine($"The rover is {north}m to the North"); }
    if (south > 0) { Console.WriteLine($"The rover is {south}m to the South"); }
}
*/

int east = 0;
int west = 0;
int south = 0;
int north = 0;
char eastSymbol = '>';
char westSymbol = '<';
char northSymbol = '^';
char southSymbol = 'v';

string roverMovement = string.Empty;

do
{
    Console.Write("Where is the rover? (^, >, v, <): ");
    roverMovement = Console.ReadLine()!;
} while (!roverMovement.Contains('<') && !roverMovement.Contains('>') && !roverMovement.Contains('^') && !roverMovement.Contains('V'));

int CountMovementLogs(int count, int rover, string roverMovement)
{
    return count = roverMovement.Count(t => t == rover);
}

east = CountMovementLogs(east, eastSymbol, roverMovement);
west = CountMovementLogs(west, westSymbol, roverMovement);
north = CountMovementLogs(north, northSymbol, roverMovement);
south = CountMovementLogs(south, southSymbol, roverMovement);

west = west - east;
north = north - south;

Console.Write("The rover is ");
if (north == 0 && west == 0)
{
    Console.Write("in the base station");
}

else
{
    if (north > 0)
    {
        Console.Write($"{north}m north, ");
    }
    if (north < 0)
    {
        north *= -1;
        Console.Write($"{north}m south, ");
    }

    if (west > 0)
    {
        Console.Write($"and {west}m west");
    }
    if (west < 0)
    {
        west *= -1;
        Console.Write($"and {west}m east");
    }
}
