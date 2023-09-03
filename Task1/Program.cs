// Задача 41: Пользователь вводит с клавиатуры 
// M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите несколько чисел через запятую ");
string[] numbers = Console.ReadLine().Split(", ");
int count = 0;
Console.WriteLine(String.Join(" ", numbers));
for (int i = 1; i < numbers.Length; i++){
    int a = Convert.ToInt32(numbers[i]);
    if (a > 0){
        count++;
    }
}
Console.WriteLine(count);