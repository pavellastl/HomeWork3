Console.Clear();
Console.WriteLine("напишите число N");
int N = int.Parse(Console.ReadLine()!);
for(int i = 1; i <= N; i++)
{
    Console.WriteLine($"{i} в кубе = {Math.Pow(i,3)}");
}

    
