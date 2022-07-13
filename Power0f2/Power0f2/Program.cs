// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int n;

Console.WriteLine("enter the power of 2");
n= int.Parse(Console.ReadLine());
if(n>30)
{
    Console.WriteLine("\n int datatype range exceeds..\nnote: plz enter the power of 2 less than 31...  ");
    Environment.Exit(0);
}
for(int i = 1; i <= n; i++)
{
    double result = 0;
    result = Math.Pow((2),i)//finding the power of 2 its current iteration i
    Console.WriteLine("2 to the power " + i +" is = "+ result);    

}