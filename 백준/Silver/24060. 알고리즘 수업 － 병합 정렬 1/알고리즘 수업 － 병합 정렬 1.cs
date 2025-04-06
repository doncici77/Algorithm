class BJ24060
{
    static int[] tmp;
    public static int count = 0;
    public static int ans = 0;

    public static void Main(string[] args)
    {
        string[] input1 = Console.ReadLine().Split();
        int arraySize = int.Parse(input1[0]);
        int arrayOrder = int.Parse(input1[1]);

        string[] inputArray = Console.ReadLine().Split();
        int[] arrayNum = new int[arraySize];
        for (int i = 0; i < arraySize; i++)
        {
            arrayNum[i] = int.Parse(inputArray[i]);
        }

        merge_sort(arrayNum, 0, arrayNum.Length - 1, arrayOrder);

        if (count != arrayOrder)
        {
            Console.WriteLine("-1");
        }
        else
        {
            Console.WriteLine(ans);
        }
    }

    static void merge_sort(int[] A, int left, int right, int arrayOrder)
    {
        int mid;

        if(left < right)
        {
            mid = (left + right) / 2;
            merge_sort(A, left, mid, arrayOrder);
            merge_sort(A, mid + 1, right, arrayOrder);
            merge(A, left, mid, right, arrayOrder);
        }
    }

    static void merge(int[] A, int left, int mid, int right, int arrayOrder)
    {
        if (count == arrayOrder)
        {
            return;
        }

        int i = left;
        int j = mid + 1;
        int t = 0;
        tmp = new int[right - left + 1];

        while (i <= mid && j <= right)
        {
            if (A[i] <= A[j])
            {
                tmp[t] = A[i];
                t++;
                i++;
            }
            else
            {
                tmp[t] = A[j];
                t++;
                j++;
            }
        }

        while (i <= mid) // 왼쪽 배열이 남은 경우
        {
            tmp[t] = A[i];
            t++;
            i++;
        }

        while (j <= right) // 오른쪽 배열이 남은 경우
        {
            tmp[t] = A[j];
            t++;
            j++;
        }

        // 결과를 원본 배열에 복사
        for (int k = 0; k < tmp.Length; k++)
        {
            count++;
            ans = tmp[k];
            if (count == arrayOrder)
            {
                return;
            }
            A[left + k] = tmp[k];
        }
    }
}