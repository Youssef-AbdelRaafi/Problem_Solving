/*
Given a string s and an integer k, return the maximum number of vowel letters in any substring of s with length k.

Vowel letters in English are 'a', 'e', 'i', 'o', and 'u'.

 

Example 1:

Input: s = "abciiidef", k = 3
Output: 3
Explanation: The substring "iii" contains 3 vowel letters.
Example 2:

Input: s = "aeiou", k = 2
Output: 2
Explanation: Any substring of length 2 contains 2 vowels.
Example 3:

Input: s = "leetcode", k = 3
Output: 2
Explanation: "lee", "eet" and "ode" contain 2 vowels.
 

Constraints:

1 <= s.length <= 105
s consists of lowercase English letters.
1 <= k <= s.length
*/

string input = "";

Console.WriteLine("Please Enter a string?");

input = Console.ReadLine() ?? "";

int windowSize = 3;


Console.WriteLine($"Maximum Numbers Of Vowels: {(MaximumNumbersOfVowels(input, windowSize))}");

//Fixed Sliding Window

int MaximumNumbersOfVowels(string input, int windowSize)
{
    int maxNumber = 0;
    int windowSum = 0;

    for (int i = 0; i < windowSize; i++)
    {
        if (IsVowel(input[i]))
        {
            windowSum++;
        }
    }

    maxNumber = windowSum;

    for (int i = windowSize; i < input.Length; i++)
    {
        if(IsVowel(input[i-windowSize]))
        {
            windowSum--;
        }

        if (IsVowel(input[i]))
        {
            windowSum++;
        }

        maxNumber=Math.Max(maxNumber, windowSum);
    }

    return maxNumber;
}

bool IsVowel(char c)
{
    return c == 'a' || c == 'o' || c == 'u' || c == 'i' || c == 'e';
}