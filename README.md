Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []


Решение:
Объявляется два массива: 
1. первый (array), с использованием функции AskArray(), которая запрашивает у пользователя ввод строк через пробел;
2. второй (newArray) такой же длины как первый. 
Затем используется функция CreateNewArray, которая заполняет второй (newArray) массив значениями из первого (array) массива, удовлетворяющими условию длины меньше или равно числу 3.
В цикле for для каждой строки в первом (array) массиве проверяется ее длина, и если она соответствует условию, строка добавляется во второй (newArray) массив.
С помощью функции PrintNewArray отфильтрованный второй (newArray) массив выводится на экран.