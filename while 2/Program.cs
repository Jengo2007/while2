// See https://aka.ms/new-console-template for more information

int N=int.Parse(Console.ReadLine());
int K=int.Parse(Console.ReadLine());
double count=0;

while (N >= K)
{
    N-= K;
    count++;
}
Console.WriteLine(N);
