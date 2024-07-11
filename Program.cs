string[] AskArray(){
    Console.Write("Введите значения через пробел: ");
    string? input = Console.ReadLine();
    return input.Split(' ');
}

void CreateNewArray(string[] array, string[] newArray)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        newArray[count] = array[i];
        count++;
        }
    }
}

void PrintNewArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string[] array = AskArray();
string[] newArray = new string[array.Length];
CreateNewArray(array, newArray);
PrintNewArray(newArray);

