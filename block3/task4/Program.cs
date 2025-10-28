bool x = true;
bool y = true;
bool z = false;
Console.WriteLine($"а) {!x & y}");
Console.WriteLine($"б) {x | !y}");
Console.WriteLine($"в) {x | y & z}");
