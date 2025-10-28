bool x = true;
bool y = false;
bool z = false;
Console.WriteLine($"а) {!x || !y || !z}");
Console.WriteLine($"б) {(!x || !y) && (x || y)}");
Console.WriteLine($"в) {x && y || x && z || !z}");
