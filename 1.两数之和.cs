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
    /// <summary>
    /// 方法1：暴力法
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    // public static int[] TwoSum(int[] nums, int target)
    // {
    //     for (int i = 0; i < nums.Length; i++)
    //     {
    //         for (int j = i+1; j < nums.Length; j++)
    //         {
    //             if (nums[i] + nums[j] == target) return new int[] { i, j };
    //         }
    //     }
    //     return new int[] { 0,0 };
    // }

    ///<summary>
    /// 方法2：两遍哈希表
    /// </summary>
    /*public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> kvs = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (kvs.ContainsKey((nums[i])))
            {
                if (nums[i] * 2 == target)
                {
                    return new int[] { i, kvs[nums[i]] };
                }
            }
            else
            {
                kvs.Add(nums[i], i);
            }
        }

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (kvs.ContainsKey(complement) && kvs[complement] != i)
            {
                return new int[] { i, kvs[complement] };
            }
        }
        return new int[] { 0, 0 };
    }*/

    ///<summary>
    /// 方法3：一遍哈希表
    /// </summary>
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

