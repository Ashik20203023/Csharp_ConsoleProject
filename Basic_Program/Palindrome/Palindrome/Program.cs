Console.Write("Enter a string :");
string input=Console.ReadLine();
string reverse="";
for(int i=input.Length-1;i>=0; i--)
{
    reverse += input[i];
}
if (input.Equals(reverse, StringComparison.OrdinalIgnoreCase))
    Console.Write("The string is a palindrome.");
else
    Console.Write("The string is not palindrome.");