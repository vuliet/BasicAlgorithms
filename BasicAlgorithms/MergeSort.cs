namespace BasicAlgorithms
{
    // MergeSort:
    // Bước đầu tiên là chia mảng thành hai phần bằng cách chọn một điểm giữa (middle point). Điều này tạo ra hai mảng con.
    // Lặp lại bước chia cho đến khi mỗi mảng con chỉ chứa một phần tử.
    // Gộp (merge) hai mảng con đã sắp xếp để tạo ra một mảng mới có thứ tự.
    // Quá trình này được thực hiện bằng cách so sánh các phần tử từng cặp và đặt chúng vào đúng vị trí trong mảng kết quả.
    public static class MergeSort
    {
        private static void MergeSortHandler(int[] arr, int low, int hight)
        {
            if (low < hight)
            {
                int mid = (low + hight) / 2;

                // Chia mảng thành hai nửa và đệ quy sắp xếp từng nửa
                MergeSortHandler(arr, low, mid);
                MergeSortHandler(arr, mid + 1, hight);

                // Gộp hai nửa đã sắp xếp
                Merge(arr, low, mid, hight);
            }
        }

        private static void Merge(int[] arr, int low, int mid, int high)
        {
            int n1 = mid - low + 1;
            int n2 = high - mid;

            // Tạo mảng tạm để lưu các nửa con
            int[] left = new int[n1];
            int[] right = new int[n2];

            // Sao chép dữ liệu vào mảng tạm
            for (int index = 0; index < n1; ++index)
                left[index] = arr[low + index];

            for (int index2 = 0; index2 < n2; ++index2)
                right[index2] = arr[mid + 1 + index2];

            // Gộp các mảng tạm lại với nhau
            int i = 0, j = 0;
            int k = low;
            while (i < n1 && j < n2)
            {
                if (left[i] <= right[j])
                {
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    arr[k] = right[j];
                    j++;
                }
                k++;
            }

            // Sao chép phần tử còn lại của left[] nếu có
            while (i < n1)
            {
                arr[k] = left[i];
                i++;
                k++;
            }

            // Sao chép phần tử còn lại của right[] nếu có
            while (j < n2)
            {
                arr[k] = right[j];
                j++;
                k++;
            }
        }

        public static void MergeSortResult()
        {
            Console.WriteLine("Thuat toan MergeSort: ");

            var arrUseQuickSort = new int[] { 12, 11, 13, 5, 6, 7 };

            var low = 0;
            var hight = arrUseQuickSort.Length - 1;

            MergeSortHandler(arrUseQuickSort, low, hight);

            for (int i = 0; i < arrUseQuickSort.Length; i++)
                Console.Write($"{arrUseQuickSort[i]} ");

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
