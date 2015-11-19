using System;

class SequenceOfEqualArrayElements
{
static void Main()
{

int len = int.Parse(Console.ReadLine());
string[] array = new string[len];
for (int i = 0; i < len; i++)
{

array[i] = Console.ReadLine();
}
int count = 0;
int bestCount = 0;
for (int i = 1; i < len; i++)
{
if (array[i] == array[i-1])
{
count++;
if (count > bestCount)
{
bestCount = count;
}
}
else
{
count = 1;
}
}
Console.WriteLine(bestCount);
}
}
