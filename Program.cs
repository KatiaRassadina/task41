// Пользователь воодит М чисел, посчитайте сколько чисел больше 0 ввел пользователь
Console.WriteLine("input digits, devided by comma");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(","),int.Parse);
int index = 0;
for(int i=0; i<arr.Length; i++)
{
    if(arr[i]>0)
    {index++;}
}
Console.WriteLine("The number of digits > 0 is "+(index));