namespace BasicAlgorithms
{
    // QuickSort: 
    // 1.Chọn phần tử chốt.
    // 2.Khai báo 2 biến con trỏ để trỏ để duyệt 2 phía của phần tử chốt.
    // 3.Biến bên trái trỏ đến từng phần tử mảng con bên trái của phần tử chốt.
    // 4.Biến bên phải trỏ đến từng phần tử mảng con bên phải của phần tử chốt.
    // 5.Khi biến bên trái nhỏ hơn phần tử chốt thì di chuyển sang phải.
    // 6.Khi biến bên phải nhỏ hơn phần tử chốt thì di chuyển sang trái.
    // 7.Nếu không xảy ra trưởng hợp 5 và 6 thì tráo đổi giá trị 2 biến trái và phải.
    // 8.Nếu trái lớn hơn phải thì đây là giá trị chốt mới.
    public static class QuickSort
    {
        private static void QuickSortHandler(int[] arr, int left, int right)
        {
            if (arr == null || arr.Length == 0)
                return;

            if (left >= right)
                return;

            int middle = left + (right - left) / 2;
            int pivot = arr[middle];
            int i = left, j = right;

            while (i <= j)
            {
                while (arr[i] < pivot)
                {
                    i++;
                }

                while (arr[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }
            }

            if (left < j)
                QuickSortHandler(arr, left, j);

            if (right > i)
                QuickSortHandler(arr, i, right);
        }

        public static void QuickSortResult()
        {
            Console.WriteLine("Thuat toan QuickSort: ");

            var arrUseQuickSort = new int[] { 6, 2, 3, 4, 5, 9, 1 };

            var left = 0;
            var right = arrUseQuickSort.Length - 1;

            QuickSortHandler(arrUseQuickSort, left, right);

            for (int i = 0; i < arrUseQuickSort.Length; i++)
                Console.Write($"{arrUseQuickSort[i]} ");

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
