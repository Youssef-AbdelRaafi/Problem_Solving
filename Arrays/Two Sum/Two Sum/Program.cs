int [] TwoSum(int[]num,int target)
{
    Dictionary<int, int> keyValues = new Dictionary<int, int> ();

    int n = num.Length;
    int [] arr = new int [n];
    for (int i = 0; i < n; i++) 
    {

        int result = target - num[i];

        if(keyValues.ContainsKey(result))
        {
           arr = new int[] { keyValues[result], i };
        }

        else
        {
            keyValues.Add(num[i], i);
        }
    }

    return arr;
}

int [] arr =TwoSum([2, 7, 11, 15], 9);
for (int i = 0; i < arr.Length; i++) 
{
    Console.WriteLine(arr[i]);
}
