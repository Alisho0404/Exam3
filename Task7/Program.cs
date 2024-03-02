 
List<int> list = new List<int>() { 1, 0, 5, -4, 5, 10, -80, 24, 0, -4, 100, 24, 45, 6, -1 };
// maxValue
int maxValue = int.MinValue;
foreach (var item in list)
{
    if (item > maxValue) maxValue = item;
}
Console.WriteLine(maxValue); 

//duplicate numbers
for (int i = 0; i < list.Count-1; i++)
{
    if (list[i] == list[i+1])
    {
        list.RemoveAt(i);
    }
}
//Sorting
list.Sort();
foreach (var item in list)
{
    Console.WriteLine(item);

}
 
//zamena na 0
for (int i = 0; i < list.Count; i++)
{
    if (list[i]<0)
    {
        list[i] = 0;
    }

}
 


//Console.WriteLine(maxValue);

 