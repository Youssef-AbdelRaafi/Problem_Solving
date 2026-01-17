# Pattern: Fixed Size Sliding Window

## 📝 Description
The **Fixed Sliding Window** pattern is used to perform a required operation on a specific window size of an array or string. Instead of recalculating the results for each sub-array (which takes $O(N \times K)$), we "slide" the window by adding the next element and removing the first element of the previous window, achieving a linear time complexity of **$O(N)$**.

---

## 🚀 Solved Problems

### 1. Maximum Average Subarray I
* **Source:** [LeetCode #643](https://leetcode.com/problems/maximum-average-subarray-i/)
* **Difficulty:** `Easy`
* **Concept:** Summing a window of size `k` and keeping track of the maximum sum found, then dividing by `k`.
* **Complexity:**
    * **Time Complexity:** $O(N)$ - where $N$ is the length of the array.
    * **Space Complexity:** $O(1)$ - only a few variables used.

### 2. Maximum Number of Vowels in a Substring of Given Length
* **Source:** [LeetCode #1456](https://leetcode.com/problems/maximum-number-of-vowels-in-a-substring-of-given-length/)
* **Difficulty:** `Medium`
* **Concept:** Sliding a window of size `k` and counting vowels. When the window slides, check if the outgoing character was a vowel (decrement count) and if the incoming character is a vowel (increment count).
* **Complexity:**
    * **Time Complexity:** $O(N)$ - single pass through the string.
    * **Space Complexity:** $O(1)$ - constant space used for counting.

---

## 💡 Key Takeaways
* Initialize the first window sum/count manually.
* The loop should start from index `k` to the end of the collection.
* Update the result by: `CurrentWindow = CurrentWindow - ElementMovingOut + ElementMovingIn`.
