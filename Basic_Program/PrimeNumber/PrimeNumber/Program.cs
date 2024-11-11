﻿Console.Write("Prime numbers from 1 to 100:");
for(int num = 2;num <= 100;num++)
{
    bool isPrime=true;
    for(int i = 2;i<=Math.Sqrt(num);i++)
    {
        if(num%i==0)
        {
            isPrime = false;
            break;
        }
    }
    if(isPrime)
    {
        Console.Write(num+" ");
    }
}
