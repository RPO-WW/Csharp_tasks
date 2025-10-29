bool x0 = true;
bool x1 = false;
bool y0 = true;
bool y1 = false;

Console.WriteLine($"а) {!(x0 && !y0) || x0}");
Console.WriteLine($"а) {!(x1 && !y0) || x1}");
Console.WriteLine($"а) {!(x0 && !y1) || x0}");
Console.WriteLine($"а) {!(x1 && !y1) || x1}");

Console.WriteLine($"б) {y0 && !x0 || !y0}");
Console.WriteLine($"б) {y1 && !x0 || !y1}");
Console.WriteLine($"б) {y0 && !x1 || !y0}");
Console.WriteLine($"б) {y1 && !x1 || !y1}");

Console.WriteLine($"в) {!y0 && x0 || y0}");
Console.WriteLine($"в) {!y1 && x0 || y1}");
Console.WriteLine($"в) {!y0 && x1 || y0}");
Console.WriteLine($"в) {!y1 && x1 || y1}");
