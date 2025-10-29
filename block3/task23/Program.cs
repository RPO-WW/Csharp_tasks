bool a0 = true;
bool a1 = false;
bool b0 = true;
bool b1 = false;
bool c0 = true;
bool c1 = false;

Console.WriteLine($"а) {!(a0 || !b0 && c0) || c0}");
Console.WriteLine($"а) {!(a1 || !b0 && c0) || c0}");
Console.WriteLine($"а) {!(a0 || !b1 && c0) || c0}");
Console.WriteLine($"а) {!(a0 || !b0 && c1) || c1}");
Console.WriteLine($"а) {!(a1 || !b1 && c0) || c0}");
Console.WriteLine($"а) {!(a0 || !b1 && c1) || c1}");
Console.WriteLine($"а) {!(a1 || !b0 && c1) || c1}");
Console.WriteLine($"а) {!(a1 || !b1 && c1) || c1}");

Console.WriteLine($"б) {!(a0 && !b0 || c0) && b0}");
Console.WriteLine($"б) {!(a1 && !b0 || c0) && b0}");
Console.WriteLine($"б) {!(a0 && !b1 || c0) && b1}");
Console.WriteLine($"б) {!(a0 && !b0 || c1) && b0}");
Console.WriteLine($"б) {!(a1 && !b1 || c0) && b1}");
Console.WriteLine($"б) {!(a1 && !b0 || c1) && b0}");
Console.WriteLine($"б) {!(a0 && !b1 || c1) && b1}");
Console.WriteLine($"б) {!(a1 && !b1 || c1) && b1}");

Console.WriteLine($"в) {!(!a0 || b0 && c0) || a0}");
Console.WriteLine($"в) {!(!a1 || b0 && c0) || a1}");
Console.WriteLine($"в) {!(!a0 || b1 && c0) || a0}");
Console.WriteLine($"в) {!(!a0 || b0 && c1) || a0}");
Console.WriteLine($"в) {!(!a1 || b1 && c0) || a1}");
Console.WriteLine($"в) {!(!a0 || b1 && c1) || a0}");
Console.WriteLine($"в) {!(!a1 || b0 && c1) || a1}");
Console.WriteLine($"в) {!(!a1 || b1 && c1) || a1}");
