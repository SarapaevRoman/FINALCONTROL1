## Решение итоговой контрольной работыю.
* На GitHube создал репозиторий `FINALCONTROL1`.
* Блок схема алгоритма 

![picture](<block diagram.jpg>)

* Описание решения задачи

```Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.```

`Console.Clear();` - Очищает консоль перед выполнением программы. При помощи `Console.WriteLine("Введите строки через пробел:");` - выводит сообщение с просьбой для ввода строк.  
`string row = Console.ReadLine();` - Считывает строку, введенную пользователем, из консоли в переменную `row`. Далее при помощи 
`string[] array = row.Split( " " );` - разбивает введенную строку на массив строк, используя пробел как разделитель. Метод `StringSplitOptions.RemoveEmptyEntries` удаляет пустые элементы после разбиения.

`string[] RowFilterinh(string[] array)` - Создаем метод, этот метод принимает массив строк и возвращает новый массив, содержащий только те строки, длина которых меньше или равна 3 символам.

`string[] arr = new string[array.Length];` - Создает новый массив для хранения отфильтрованных строк. И инициализируем `int count = 0;` - счетчик для отслеживания текущей позиции в новом массиве.

`for (int i = 0; i < array.Length; i++)` - Начинаем цикл по исходному массиву строк. 
`string input = array[i];` - Получаем текущую строку из исходного массива. 
`if (input.Length <= 3)` - Проверяем, является ли длина строки меньше или равной 3 символам. Если условие  `arr[count] = input;` выполняется, сохраняем строку в новом массиве. Далее увеличиваем счетчик `count++;` -  для следующей позиции в новом массиве.

`return arr;` - Возвращает новый массив строк с отфильтрованными значениями.

Далее создаем масcив`result` и присваиваем отфильтрованный массив из метода `RowFilterin(array);`.
Вывод отфильтрованного массива на экран осуществляется при помощи метода `PrintArray`. Метод при помощи цикла `for (int i = 0; i< result.Length; i++)` проходит по каждому элементу массива и выводит его, добавляя запятые между элементами и окружая каждый элемент двойными кавычками. 
Для того чтобы после последнего элемента не ставилась запятая, добавленно условие  `if (i < result.Length - 1)`

* Решение задачи [Решение задачи](Program.cs)

