# TestForGB

## Условие задачи
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Решение задачи
Создаю массив строк и переменные для хранения счетчика количества строк подхлдяшей длины (СК) и счетчик для заполнения (СЗ) нового массива. Далее заполняю массив и проверяю длины строк (если она нужной длины, то увеличиваю СК). Потом создаю массив длиной СК и заполняю его с уловием, что строка из исходного массива пожходящей длины (если да, то СЗ увеличиваю на 1). В конце вывожу новый массив.
