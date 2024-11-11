Console.Write("Enter the number of elements :");
int size=int .Parse(Console.ReadLine());
int[]numbers=new int[size];
for (int i=0; i<size; i++)
{
    Console.Write("Enter element "+(i+1)+":");
    numbers[i]=int.Parse(Console.ReadLine());
}
Array.Sort(numbers);
foreach (int num in numbers)
{
    Console.Write(num+" ");
}