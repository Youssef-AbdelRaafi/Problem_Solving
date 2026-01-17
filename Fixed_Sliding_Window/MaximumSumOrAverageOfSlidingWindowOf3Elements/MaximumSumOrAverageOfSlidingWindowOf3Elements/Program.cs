//Find The Maximum Sum Or Avearage Of a Sliding Window Of 3 elements.

int[] numbers = { 4, 2, 7, 1, 5, 3, 6, 2, 8, 1 };
int windowSize = 3;

Console.WriteLine($"MaxSumWithBruteForce:{(MaxSumWithBruteForce(numbers, windowSize))}");
Console.WriteLine($"MaxSumWithBruteForce:{(MaxSumWithFixedSlidingWindow(numbers, windowSize))}");

int MaxSumWithFixedSlidingWindow(int[] source,int windowSize)
{
    int maxValue = 0, windowSum = 0;

    for (int i = 0; i < windowSize; i++) 
    {
        windowSum += source[i];
    }

    maxValue = windowSum;

    for (int i = windowSize; i < source.Length; i++)
    {
        windowSum += source[i] - source[i - windowSize];

        maxValue = Math.Max( maxValue, windowSum );
    }

    return maxValue;
}

int MaxSumWithBruteForce(int[] source, int windowSize)
{
    int maxValue = int.MinValue;

    for (int i = 0; i <= source.Length - windowSize; i++)
    {
        int windowSum = 0;

        for (int j = i; j < i + windowSize; j++)
        {
            windowSum += source[j];
        }

        maxValue = Math.Max(maxValue, windowSum);
    }

    return maxValue;
}