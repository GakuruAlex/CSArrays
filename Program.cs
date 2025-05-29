using System.Runtime.CompilerServices;

string[] fraudulentOrderIDs = ["A123", "B456", "C789"];

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

int[] inventory = { 200, 450, 700, 175, 250 };
int total = 0;
foreach (int item in inventory)
{
    total += item;
}

Console.WriteLine($"Total: {total}");