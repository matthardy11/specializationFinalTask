# Задача

    Написать программу которая из имеющегося массива строк формирует массив из строк длина которых меньше либо равна 3 символа

# Описание решения задачи

### 1. В главном методе программы сначала выполняется цикл который ищет колличество строк удовлетворяющих условию (длинна строки равна или меньше 3х символов). Результат записывается в переменную **counter**.
<br />

### 2. Далее создается массив с длинной равной **counter**.
<br />

### 3. После чего выполняем еще один цикл в котором записываем в новый массив строки удовлетворяющие условию (длина строки равна или меньше 3х символов). После каждой записи переменная **index** увеличивается на 1.
<br />

### 4. Выводим получившийся массив на экран с помощью метода **_PrintArray_**