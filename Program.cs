//Задача 34

/*int[] Array = GetArray(10, 100, 1000);
Console.WriteLine($"[{String.Join(",", Array)}]"); 


int[] GetArray(int size, int minValue, int maxValue)  
{
int[] res = new int[size];

for (int i = 0; i < size; i++) 
{
res[i] = new Random().Next(minValue, maxValue + 1);
}
return res;
}

int Method1()
{
int count = 0;
for(int i = 0; i<Array.Length; i++)
{
    if(Array[i] % 2 ==0)
    {
        count++;
    }
}
    return count;
}

Console.WriteLine(Method1());



//Задача 36.
int[] Array = GetArray(10, 100, 1000);
Console.WriteLine($"[{String.Join(",", Array)}]"); 


int[] GetArray(int size, int minValue, int maxValue)  
{
int[] res = new int[size];

for (int i = 0; i < size; i++) 
{
res[i] = new Random().Next(minValue, maxValue + 1);
}
return res;
}


int Method2()
{
    int count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if(i % 2 != 0)
        {
            count = count + Array[i];
        }
    }
    return count;
}
Console.WriteLine(Method2());*/



//Задача 38

int[] Array = GetArray(10,-1000, 1000);
Console.WriteLine($"[{String.Join(",", Array)}]"); 


int[] GetArray(int size, int minValue, int maxValue)  
{
int[] res = new int[size];

for (int i = 0; i < size; i++) 
{
res[i] = new Random().Next(minValue, maxValue + 1);
}
return res;
}


int Maximum()
{
    int max = Array[0];
    for (int i = 0; i < Array.Length; i++)
    {
        if(Array[i]>max)
        {
            max = Array[i];
        }
    }
    return max;
}

int Minimum()
{
    int min = Array[0];
    for( int i = 0; i < Array.Length; i++)
    {
        if(Array[i] < min)
        {
            min = Array[i];
        }
    }
    return min;
}
Console.WriteLine($" Максимальное число: {Maximum()}. Минимальное число: {Minimum()}.");
Console.WriteLine($" Разность максимального и минимального чисел равна: {Maximum() - Minimum()}");


