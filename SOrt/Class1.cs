using System;

namespace SortingApp
{
    public interface ISortAlgorithm
    {
        string Name { get; }
        int[] Sort(int[] array);
    }

    public class BubbleSort : ISortAlgorithm
    {
        public string Name => "Bubble Sort";

        public int[] Sort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // Zamiana miejscami
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }
    }

    public class QuickSort : ISortAlgorithm
    {
        public string Name => "Quick Sort";

        public int[] Sort(int[] array)
        {
            QuickSortAlgorithm(array, 0, array.Length - 1);
            return array;
        }

        private void QuickSortAlgorithm(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(array, low, high);

                QuickSortAlgorithm(array, low, pi - 1);
                QuickSortAlgorithm(array, pi + 1, high);
            }
        }

        private int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = (low - 1);

            for (int j = low; j < high; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    (array[i], array[j]) = (array[j], array[i]);
                }
            }

            (array[i + 1], array[high]) = (array[high], array[i + 1]);
            return i + 1;
        }
    }

    public class MergeSort : ISortAlgorithm
    {
        public string Name => "Merge Sort";

        public int[] Sort(int[] array)
        {
            MergeSortAlgorithm(array, 0, array.Length - 1);
            return array;
        }

        private void MergeSortAlgorithm(int[] array, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;

                MergeSortAlgorithm(array, left, mid);
                MergeSortAlgorithm(array, mid + 1, right);

                Merge(array, left, mid, right);
            }
        }

        private void Merge(int[] array, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] L = new int[n1];
            int[] R = new int[n2];

            Array.Copy(array, left, L, 0, n1);
            Array.Copy(array, mid + 1, R, 0, n2);

            int i = 0, j = 0, k = left;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    array[k] = L[i];
                    i++;
                }
                else
                {
                    array[k] = R[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                array[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                array[k] = R[j];
                j++;
                k++;
            }
        }
    }

    public class CountSort : ISortAlgorithm
    {
        public string Name => "Count Sort";

        public int[] Sort(int[] array)
        {
            int max = array.Max();
            int min = array.Min();
            int range = max - min + 1;

            int[] count = new int[range];
            int[] output = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                count[array[i] - min]++;
            }

            for (int i = 1; i < count.Length; i++)
            {
                count[i] += count[i - 1];
            }

            for (int i = array.Length - 1; i >= 0; i--)
            {
                output[count[array[i] - min] - 1] = array[i];
                count[array[i] - min]--;
            }

            return output;
        }
    }
    public class ShellSort : ISortAlgorithm
    {
        public string Name => "Shell Sort";

        public int[] Sort(int[] array)
        {
            int n = array.Length;

            // Zacznij od dużego gapu i zmniejszaj
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                // Sortowanie przez wstawianie dla elementów oddalonych o gap
                for (int i = gap; i < n; i++)
                {
                    int temp = array[i];
                    int j;

                    // Przesuwanie elementów, które są większe od temp
                    for (j = i; j >= gap && array[j - gap] > temp; j -= gap)
                    {
                        array[j] = array[j - gap];
                    }

                    array[j] = temp;
                }
            }

            return array;
        }
    }
    public class HeapSort : ISortAlgorithm
    {
        public string Name => "Heap Sort";

        public int[] Sort(int[] array)
        {
            int n = array.Length;

            // Tworzenie kopca (Heapify)
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(array, n, i);

            // Wyciągaj elementy z kopca
            for (int i = n - 1; i >= 0; i--)
            {
                // Przenieś korzeń do końca
                (array[0], array[i]) = (array[i], array[0]);

                // Wywołaj heapify na zmniejszonym kopcu
                Heapify(array, i, 0);
            }

            return array;
        }

        private void Heapify(int[] array, int n, int i)
        {
            int largest = i; // Inicjalizuj largest jako root
            int left = 2 * i + 1; // lewy = 2*i + 1
            int right = 2 * i + 2; // prawy = 2*i + 2

            // Jeśli lewy jest większy niż root
            if (left < n && array[left] > array[largest])
                largest = left;

            // Jeśli prawy jest większy niż largest
            if (right < n && array[right] > array[largest])
                largest = right;

            // Jeśli largest nie jest root
            if (largest != i)
            {
                (array[i], array[largest]) = (array[largest], array[i]);

                // Rekurencyjnie heapify dla poddrzewa
                Heapify(array, n, largest);
            }
        }
    }

}
