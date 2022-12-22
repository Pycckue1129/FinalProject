string[] array = {"hello", "21", "world", ":-)", "123", "124rsdfv", "computer science", "-2"};
int lengthNewArray = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        lengthNewArray++;
    }
}

string[] newArray = new string[lengthNewArray];

int j = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        newArray[j] = array[i] ;
        j++;
    }
}

void PrintArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.WriteLine();
}

PrintArray(newArray);