//Первая группа методов. Методы первой группы очень простые и выглядят так:
// void Metod1() // ключ. слово void. Metod1 – идентификатор метода. В скобках нет никаких аргументов.
// {
//     Console.WriteLine("Автор …"); // есть тело метода, которое что-то может, например, показывать на экран. 
// }
// Metod1(); // вызов метода Metod1


// //Вторая группа методов. Назовем Metod2. 
// void Metod2(string msg) //где void ключевое слово, затем идентификатор, в скобках указаны аргументы. 
// {
//     Console.WriteLine(msg); //оператор, в скобках указан принятый аргумент. 
// }
// Metod2("Текст сообщения"); //где Metod2 - идентификатор, а в скобках указан текст, выводимый в консоли. Это методы, которые ничего не возвращают, но могут принимать какие-то аргументы. 


// //Именованные аргументы - когда у нас явно может быть указано, какому аргументу, какое значение мы хотим указать. Это часто бывает нужно, если методы принимают какое-то количество аргументов, отличное от 1. 
// void Metod21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg); //где пер. count отображает на экране определённое кол-во сообщений msg.
//         i++;
//     }
// }
// //Metod21("Текст", 4); //метод вызывает Текст, после запятой указано кол-во вызовов, в нашем случае 4. 
// Metod21(msg: "Текст", count: 4); //можно явно указать, к какому аргументу, какое значение мы хотим присвоить


// Третья группа методов.
// int Metod3() //не принимает никакие аргументы 
// {
//     return DateTime.Now.Year; // обязательное использование оператора return 
// }
// int year = Metod3(); //вызываем метод, в левой части используем ИдПер (year) и через оператор присваивания (=) кладём нужное значение 
// Console.WriteLine(year);


//Четвёртая группа методов. 
// string Metod4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty; // пер., куда будем класть результат, изначально result является пустой строкой: String.Empty
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result; // указываем результат, который ожидаем получить из метода
// }
// string res = Metod4(10, "asdf"); //чтобы вызвать метод надо создать новую переменную
// Console.WriteLine(res);


//Цикл for
// string Metod4(int count, string text)
// {
//     string result = String.Empty; // пер., куда будем класть результат, изначально result является пустой строкой: String.Empty
//     for (int i = 0; i < count; i++) // ключевое слово for, инициализация счётчика, проверка условия и инкремент (увеличение счётчика).
//     {
//         result = result + text;
//     }
//     return result; // указываем результат, который ожидаем получить из метода
// }
// string res = Metod4(10, "asdf"); //чтобы вызвать метод надо создать новую переменную, будем 10 раз склеивать текст asdf
// Console.WriteLine(res);


// Цикл в цикле
// for (int i = 2; i <= 10; i++) // i = 2 - указываем начальное значение 2, i <= 10 - пока счётчик i меньше или равен 10, надо его увеличивать. 
// {
//     for (int j = 2; j <= 10; j++) // все как в 1м цикле, только счетчик j
//     {
//         Console.WriteLine($"{i} * {j} = {i * j} "); // произведение чисел с использованием интерполяции строк.
//     }
//     Console.WriteLine(); // переход на новую строку, чтобы было разделение на части. Выполняется вывод умножения на отдельное число, потом искусственный разрыв строк и вывод умножения на новое число.
// }


//Тренировочная задача
/* Работа с текстом. Дан текст, в котором нужно все пробелы заменить чёрточками, маленькие буквы “к” заменить большими “К”, 
а большие “С” маленькими “с”.  */
// string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
// + "ежели бы вас послали вместо нашего милого Винценгероде, "
// + "вы бы взяли приступом согласие прусского короля. "
// + "Вы так красноречивы. Вы дадите мне чаю? ";

// string Replace(string text, char oldValue, char newValue) // тип string, т.к. метод Replase будет принимать строку string text и символы, которые нужно менять: старый символ oldValue и новый newValue. Это 4 вид методов.
// {
//     string result = String.Empty; // Заводим новую строку result и присваиваем ей пустую строку String.Empty
//     int length = text.Length; // получаем длину строки - text.Length
//     for (int i = 0; i < length; i++) // Идем в цикле for от 0-го символа до конца строки. Выполняем след. действие: 
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}"; // Если текущий символ ( текст i) совпал с символом, который мы хотим заменить, то в результат мы должны положить новое значение в виде строки newValue.
//         else result = result + $"{text[i]} "; // Если совпадений нет, то в result добавляем текущий символ, который был.
//     }
//     return result;
// }
// string newText = Replace(text, ' ', '|'); // Здесь указываем, что на что меняем: пробелы на |.
// Console.WriteLine(newText); // хотим увидеть newText


// Console.WriteLine(); // Для красоты разделяем каждый вывод пустой строкой.
// newText = Replace(text, 'к', 'К'); // Здесь указываем, что на что меняем: к на К.
// Console.WriteLine(newText); // 

// Console.WriteLine();
// newText = Replace(text, 'с', 'С'); // Здесь указываем, что на что меняем: с на С.
// Console.WriteLine(newText);  


// Упорядочивание данных внутри массива. Алгоритм сортировки методом выбора (алгоритм сортировки методом минимакса). 
int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 }; // Заводим массив, который будем сортировать. Не важно, если элементы повторяются
void PrintArray(int[] array) // Подзадача, отвечающая за вывод массива на экран. Метод void с именем PrintArray. В качестве аргумента будет приходить массив.
{
    int count = array.Length; // Получение кол-ва элементов array.Length.
    for (int i = 0; i < count; i++) // В цикле пробегаем по всем элементам массива
    {
        Console.Write($"{array[i]} "); //Показываем эл-ты массива на экране в строку через пробел
    }
    Console.WriteLine(); // Вывод пустой строки
}

void SelectionSort(int[] array) // Метод SelectionSort будет упорядочивать массив. Аргумент – массив.
{
    for (int i = 0; i < array.Length - 1; i++) // array.Length - 1 искусственно отнимаем 1, т.к. ниже в цикле for поиск идет от  i+1
    {
        int minPosition = i; // Определяем позицию, на которую смотрим, и запоминаем позицию рабочего эл-та

        for (int j = i + 1; j < array.Length; j++) // ищем мин.эл-т. Начальная позиция i+1, т.к. не трогаем отсортированный кусочек массива. 
        {
            if (array[j] < array[minPosition]) minPosition = j; // ищем мин.эл-т: смотрим текущий, если он меньше того, который мы предполагали минимальным, то сохраняем текущий.
        }
        int temporary = array[i]; // temporary нужна, чтобы поменять значение рабочей и минимальной позиций. Присваиваем ей рабочую i позицию.
        array[i] = array[minPosition]; // В рабочую i позицию кладем найденный минимальный элемент.
        array[minPosition] = temporary; // В позицию минимального элемента кладем рабочую i позицию
    }
}
PrintArray(arr);
SelectionSort(arr); // Вызываем метод SelectionSort для упорядочивания массива.

PrintArray(arr);

