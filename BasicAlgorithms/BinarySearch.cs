namespace BasicAlgorithms
{
    // 1.Sắp Xếp:
    // Thuật toán này chỉ hoạt động trên dãy đã được sắp xếp.
    // Nếu dãy không được sắp xếp, bạn cần sắp xếp trước khi áp dụng tìm kiếm nhị phân.
    //
    // 2.Tìm Kiếm:
    // Bắt đầu với việc chọn một phần tử ở giữa dãy làm "phần tử giữa" (middle element).
    // 
    // 3.So Sánh:
    // So sánh phần tử giữa với phần tử cần tìm kiếm. Nếu chúng bằng nhau, bạn đã tìm thấy phần tử và thuật toán kết thúc.
    //
    // 4.Chia Dãy:
    // Nếu phần tử giữa lớn hơn phần tử cần tìm kiếm, thực hiện tìm kiếm nhị phân trên nửa đầu tiên của dãy.
    // Nếu phần tử giữa nhỏ hơn, thực hiện tìm kiếm nhị phân trên nửa thứ hai của dãy.
    // 
    // 5.Lặp Lại:
    // Lặp lại quá trình trên cho đến khi tìm thấy phần tử hoặc thu được dãy rỗng.
    public class BinarySearch
    {
        private static int BinarySearchHanlder(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                // Nếu phần tử giữa bằng với phần tử cần tìm, trả về chỉ số của phần tử đó
                if (arr[mid] == target)
                    return mid;

                // Nếu phần tử giữa lớn hơn phần tử cần tìm, thực hiện tìm kiếm nhị phân trên nửa đầu tiên của dãy
                if (arr[mid] > target)
                    right = mid - 1;
                else
                    // Nếu phần tử giữa nhỏ hơn phần tử cần tìm, thực hiện tìm kiếm nhị phân trên nửa thứ hai của dãy
                    left = mid + 1;
            }

            // Trả về -1 nếu phần tử không được tìm thấy trong dãy
            return -1;
        }

        public static void BinarySearchResult()
        {
            Console.WriteLine("Thuat toan Binary Search:");

            int[] array = { 2, 5, 8, 12, 16, 23, 38, 45, 50 };
            int target = 16;

            int result = BinarySearchHanlder(array, target);

            if (result != -1)
                Console.WriteLine($"Phan tu {target} duoc tim thay tai vi tri {result}.");
            else
                Console.WriteLine($"Phan tu {target} khong ton tai trong day.");

            Console.WriteLine();
        }
    }
}
