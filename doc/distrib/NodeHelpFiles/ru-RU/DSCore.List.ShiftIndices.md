## Подробности
`List.ShiftIndices` смещает позиции элементов в списке на входное значение `amount`. Положительное входное значение в параметре `amount` приводит к смещению чисел вперед, а отрицательное — к смещению индексов назад. Элементы зацикливаются, поэтому элементы в конце списка переносятся в начало.

В примере ниже сначала создается список с помощью `Range`, а затем индексы перемещаются вперед на 3. Последние три числа из исходного списка перенесутся и станут первыми тремя номерами в новом списке.
___
## Файл примера

![List.ShiftIndices](./DSCore.List.ShiftIndices_img.jpg)
