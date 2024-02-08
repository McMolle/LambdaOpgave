// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<int> integers = new List<int>() { 1, 3, -10, 6, 83, 4, 17, 25, -43, 6, 9, 83, 100 };

//Find summen af alle tal over 9


//Lav en iterativ udgave
int tal = 0;
foreach (int i in integers)
{
    if (i > 9)
    {
        tal = tal + i;
    }
}
Console.WriteLine(tal);


//Lav en udgave der anvender predicate/lambda udtryk
int sum = integers.FindAll(i => i > 9).Sum();
Console.WriteLine(sum);

//Console.WriteLine($"sumAllAboveNine : {sumAllAboveNine}");

//Find summen af alle ikke lige tal

//Lav en iterativ udgave
int tal2 = 0;
foreach (int i in integers)
{
    if (i % 2 != 0) 
    {
        tal2 = tal2 + i;
    }
}
Console.WriteLine(tal2);

//Lav en udgave der anvender predicate/lambda udtryk
int sum2 = integers.FindAll(i => i % 2 != 0).Sum();
Console.WriteLine(sum2);


//Console.WriteLine($"sumAllUnEqual : {sumAllUnEqual}");


//Find gennemsnittet af alle tal der er større end 0 og mindre end 20

//Lav en iterativ udgave
double tal3 = 0;
int count = 0;
foreach (int i in integers)
{
    if (i > 0 && i < 20)
    {
        tal3= tal3 + i;
        count++;
    }
}
double average = tal3 / count;
Console.WriteLine(average);
//Lav en udgave der anvender predicate/lambda udtryk
double sum3 = integers.FindAll(i => i > 0 && i < 20).Average();
Console.WriteLine(sum3);

//Console.WriteLine($"averageAllNumbersGreaterThan0AndLessThan20 : {averageAllNumbersGreaterThan0AndLessThan20}");

//Find det højest ikke lige tal

//Lav en iterativ udgave
int highestNumber = integers[0];
foreach (int i in integers)
{
    if (i % 2 != 0)
    {
        if (i > highestNumber) 
        {
            highestNumber = i;
        }
    }
}
Console.WriteLine(highestNumber);


//Lav en udgave der anvender predicate/lambda udtryk
int sum4 = integers.FindAll(i => i % 2 != 0).Max();
Console.WriteLine(sum4);

//Console.WriteLine($"maxUnEqualNumber : {maxUnEqualNumber}");

//Udskriv alle ulige tal sorteret

Console.WriteLine("\n\n\nULIGE TAL - SORTERET:");

List<int> sum5 = integers.FindAll(i => i % 2 != 0);
sum5.Sort();
foreach (int i in sum5)
{
    Console.WriteLine(i);
}


