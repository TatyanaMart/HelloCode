////Стихийный подход к решению задачи. 
// int a1 = 15; // Определим и опишем 9 переменных.
// int b1 = 21;
// int c1 = 39;
// int a2 = 12;
// int b2 = 23;
// int c2 = 313;
// int a3 = 13;
// int b3 = 23;
// int c3 = 33;

// int max = a1; // Определим переменную максимум, куда положим значение первого аргумента
// if(b1 > max) max = b1; // Проверим: если значение новой переменной b1, больше max, то в max положим b1
// if(c1 > max) max = c1;// Если значение новой переменной с1, больше max, то в max положим с1 и т.д.

// if(a2 > max) max = a2;
// if(b2 > max) max = b2;
// if(c2 > max) max = c2;

// if(a3 > max) max = a3;
// if(b3 > max) max = b3;
// if(c3 > max) max = c3;
// Console.WriteLine(max);


// Процедурный подход (Воспользуемся функциями). 
int Max(int arg1, int arg2, int arg3) // Функция с именем Max типа int возьмёт 3 числа и найдёт из них максимальное. Повторим это действие несколько раз
{
    int result = arg1; // Внутренний result, где будет храниться значение max.
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result; // return возвращает result
}

int a1 = 15; // Определим и опишем 9 переменных.
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 623;
int c2 = 313;
int a3 = 13;
int b3 = 23;
int c3 = 33;

// int max1 = Max(a1, b1, c1); // в пер. max1 будет максимальное из 3 чисел: a1, b1 и c1
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3); //Финал: определяем максимальное число 
int max = Max( Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3)); // Вместо строк 45-48 внутри аргумента передаем функцию. Все работает
Console.WriteLine(max);

