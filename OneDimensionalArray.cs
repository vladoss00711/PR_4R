using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_4
{
    // Шаблон класса для работы с одномерным массивом
    public class OneDimensionalArray<T> where T : IComparable
    {
        private T[] array1;

        public OneDimensionalArray(T[] array)
        {
            array1 = array;
        }

        public T[] Array
        {
            get { return array1; }
            set { array1 = value; }
        }

        // Метод сортировки массива "Расческой"
        public void ShellSort()
        {
            int n = array1.Length;
            int gap = n / 2;

            while (gap > 0)
            {
                for (int i = gap; i < n; i++)
                {
                    T temp = array1[i];
                    int j = i;
                    while (j >= gap && array1[j - gap].CompareTo(temp) > 0)
                    {
                        array1[j] = array1[j - gap];
                        j -= gap;
                    }
                    array1[j] = temp;
                }
                gap /= 2;
            }
        }
        // Метод вывода массива в текстовое поле
        public string PrintArray()
        {
            return string.Join(", ", array1);
        }
    }
}
