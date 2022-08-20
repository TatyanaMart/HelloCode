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
    int[] array = new int[10]; // new int [10] означает «создай новый массив, где будет 10 элементов». По умолчанию он будет наполнен нулями.

    FillArray(array); // метод FillArray заполняет массив
    PrintArray(array); // метод PrintArray печатает массив
