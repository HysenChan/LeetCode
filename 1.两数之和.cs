/*
 * @lc app=leetcode.cn id=1 lang=csharp
 *
 * [1] 两数之和
 */

// @lc code=start
using System;
using System.Collections.Generic;
public class Solution
{
    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> kvs = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (kvs.ContainsKey(complement) && kvs[complement] != i)
            {
                return new int[] { i, kvs[complement] };
            }

            if (!kvs.ContainsKey((nums[i])))
            {
                kvs.Add(nums[i], i);
            }
        }
        return new int[] { 0, 0 };
    }

    static void Main(string[] args)
    {
        int[] nums = new[] { 3, 2, 4, 9, 8, 3 };
        int target = 6;
        int[] pos = TwoSum(nums, target);
        Console.WriteLine(pos.Length);
        Console.WriteLine("[{0},{1}]", pos[0], pos[1]);
    }
}
// @lc code=end

