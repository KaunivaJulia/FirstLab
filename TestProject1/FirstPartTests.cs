using FirstLab;
using Newtonsoft.Json.Linq;
using System;

using System.Diagnostics;

float[] array = new float[10];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{

    array[i] = rand.NextSingle() * 20 * 1 - 10;
    Console.WriteLine(array[i]);
}

int findMinIndex(float[] array) {
    int a = 0;
    int minIndex = 0;
    while (a < array.Length)
    {
        if (array[a] < array[minIndex])
        {
            minIndex = a;
        }
        a++;
    }
    return minIndex;
}

Console.WriteLine("Индекс минимального элемента = " + findMinIndex(array));

// Тесты:
Debug.Assert(findMinIndex(new float[]{1, 2, 3, 4}) == 0); // В порядке возрастания
Debug.Assert(findMinIndex(new float[]{4, 3, 2, 1}) == 3); // В порядке убывания
Debug.Assert(findMinIndex(new float[]{2, -1, -1, 3}) == 1); // Два минимальных отрицательных

float findSumFirstSecondNegative(float[] array) {
    int b = 0;
    while (b < array.Length)
    {
        if (array[b] < 0)
        {
            break;
        }
        b++;
    }
    int c = b + 1;
    while (c < array.Length)
    {
        if (array[c] < 0)
        {
            break;
        }
        c++;
    }
    if(c == array.Length) {
        return 0;
    }
    float d = 0;
    for (int i = b + 1; i < c; i++)
    {
        d = d + array[i];
    }
    return d;
}

Console.WriteLine("Сумма от первого отрицательного до второго отрицательного (не включительно) = " + findSumFirstSecondNegative(array));

// Тесты
Debug.Assert(findSumFirstSecondNegative(new float[]{-1, 0, 7, 0, 0, -1}) == 7); // Сумма всего массива
Debug.Assert(findSumFirstSecondNegative(new float[]{-1, 5, -1, 0, 0, -1}) == 5); // Только один элемент
Debug.Assert(findSumFirstSecondNegative(new float[]{-1, -2, -1, 0, 0, -1}) == 0); // Ноль элементов
Debug.Assert(findSumFirstSecondNegative(new float[]{1, 2, 3, 4}) == 0); // Нет отрицательных элементов
Debug.Assert(findSumFirstSecondNegative(new float[]{1, -2, 3, 4}) == 0); // Только один элемент

void moveLessThanOneToEnd(float[] array) {
    int lessThanOne = 0;
    int moreThanOne = array.Length - 1;
    while (lessThanOne < moreThanOne)
    {
        if (Math.Abs(array[lessThanOne]) > 1)
        {
            float t = array[lessThanOne];
            array[lessThanOne] = array[moreThanOne];
            array[moreThanOne] = t;
            moreThanOne--;
        }
        else
        {
            lessThanOne++;
        }
    }
}

moveLessThanOneToEnd(array);
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}

// Тесты
void runMoveLessThanOneToEndTest(float[] initial) {
    moveLessThanOneToEnd(initial);
    bool isMoreThanOne = false;
    for(int i = 0; i<initial.Length; i++) {
        isMoreThanOne |= initial[i] > 1;
        Debug.Assert(initial[i] > 1 == isMoreThanOne);
    }
}
runMoveLessThanOneToEndTest(new float[]{0.5f, 0.7f, 5, 7}); // Массив не изменился
runMoveLessThanOneToEndTest(new float[]{5, 7, 0.5f, 0.7f}); // Массив полностью перемешался
runMoveLessThanOneToEndTest(new float[]{1, 0.1f, 2, 0.2f}); // Массив полностью перемешался
runMoveLessThanOneToEndTest(new float[]{0.1f, 0.2f, 0.3f}); // Только меньше 1
runMoveLessThanOneToEndTest(new float[]{1f, 2f, 3f}); // Только больше 1
runMoveLessThanOneToEndTest(new float[]{1f, -0.2f, 3f}); // Отрицательные элементы


}
    }
}
