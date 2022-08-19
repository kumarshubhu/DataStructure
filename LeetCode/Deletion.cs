using System;
namespace LeetCode
{
    public class Deletion
    {
        public int removeDuplicates(int[] nums)
        {

            // The initial length is simply the capacity.
            int length = nums.Length;

            // Assume the last element is always unique.
            // Then for each element, delete it iff it is
            // the same as the one after it. Use our deletion
            // algorithm for deleting from any index.
            for (int i = length - 2; i >= 0; i--)
            {
                if (nums[i] == nums[i + 1])
                {
                    // Delete the element at index i, using our standard
                    // deletion algorithm we learned.
                    for (int j = i + 1; j < length - 1; j++)
                    {
                        nums[j] = nums[j+1];
                    }
                    // Reduce the length by 1.
                    length--;
                }
            }
            // Return the new length.
            return length;
        }
    }
}

// jist of the logic is when we find any duplicate within the array we will move the whole array element to the left by 1 index and shorten the length varibale by 1.
