// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int InPutConsole (string inputnumber){
Console.Write(inputnumber);
string input= Console.ReadLine();
int num = Convert.ToInt32(input);
return num;
}


int number = InPutConsole("Введите колличество чисел:");
int[]array = CreateArray(number);
PrintArray(array);
int countnumbers = CountNumberMoreNull(array);

Console.WriteLine($"{countnumbers}");


int[] CreateArray(int size){
    int[]arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    { arr[i]= InPut($"Введите число: {i+1}");}
    // int i = 0;
//     while (num!=0){

// arr[i] = num %10;
// // if (arr[i]<0){
    
// // }
// num/=10;
// i++;
// }


return arr;}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
 
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }

    Console.WriteLine("]");
}

int CountNumberMoreNull(int[] arr){
int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]> 0){
            count++;
        }
       
}
 return count;
}




