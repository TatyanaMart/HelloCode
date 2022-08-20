void FillArray(int[] collection) // Для заполнения массива случайными числами. Тип void указывает, что ничего не возвращает, он просто производит действия. 
{
    int length = collection.Length; // Получаем длину массива
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); // обращаемся к аргументу collection на позиции index и кладем туда новое случайное число — целое число из диапазона 1–10.
        index++; //index = index + 1;
    }
}

void PrintArray(int[] col) // Метод void, который будет печатать массив. Аргумент здесь массив с именем col, а не collection , т.к. надо называть разные аргументы разными именами.
{
    int count = col.Length; // Количество элементов
    int position = 0; // Обозначили текущую позицию не через именование пер. index, а через position. 
    while (position < count)
    {
        Console.WriteLine(col[position]); //Выводит значение текущего элемента
        position++; // Увеличивает значение текущей позиции
    }
}

int IndexOf(int[] collection, int find) // Метод IndexOf, аргумент массив collection и какой-то элемент find
{
    int count = collection.Length; // кол-во элементов
    int index = 0;
    int position = -1; // Переменная для сохранения значения индекса. Если элемента нет,  программа выдаст: -1.
    while (index < count) // цикл, чтобы проверять условие index < count
    {
        if (collection[index] == find) // Если collection[index] совпал с find, потребуется сохранить значение индекса. Чтобы её куда-то сохранить, определили переменную position
        {
            position = index; // Положить в  position значение индекса
            break; //
        }
        index++;
    }
    return position; // Выводит позицию элемента
}

int[] array = new int[10]; // new int [10] означает «создай новый массив, где будет 10 элементов». По умолчанию он будет наполнен нулями.

FillArray(array); // метод FillArray заполняет массив
PrintArray(array); // метод PrintArray печатает массив
Console.WriteLine(); // Чтобы убедиться, что не является частью вывода массива

int pos = IndexOf(array, 4); // В пер. pos кладем результат работы метода IndexOf. Аргумент – массив, будем искать число 4
Console.WriteLine(pos); // Выводит на экран pos

