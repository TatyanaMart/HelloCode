int Max(int arg1, int arg2, int arg3) // Функция с именем Max типа int возьмёт 3 числа и найдёт из них максимальное. Повторим это действие несколько раз
{
    int result = arg1; // Внутренний result, где будет храниться значение max.
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result; // return возвращает result
}

int[] array = { 11, 21, 31, 41, 15, 61, 17, 18, 19 }; //тип, скобки, название массива, значения элементов массива
//array[0] = 12; //обратились к элементу с индексом 0 и присвоили значение 12
//Console.WriteLine(array[0]); //так можно обратиться к массиву и получить значение элемента с указанным индексом. Помним, индексы начинаются с нуля!
int max = Max(   //Воспользуемся уже описанным функционалом для поиска максимума из 9 чисел
Max(array[0], array[1], array[2]),
Max(array[3], array[4], array[5]),
Max(array[6], array[7], array[8])
);
Console.WriteLine(max);
