/*
Given an array of integers, find two numbers such that 
they add up to a specific target number.

The function twoSum should return indices of the two numbers 
such that they add up to the target, where index1 must be 
less than index2.

You may assume that each input would have exactly one solution.

Input: numbers={2, 7, 11, 15}, target=9
Output: index1=0, index2=1

*/

namespace XiShuaShua
{
    #region using
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    #endregion

    [TestClass]
    public class P0001
    {
        public static Tuple<int, int> TwoSum(int[] numbers, int target)
        {
            Dictionary<int, int> map = new Dictionary<int,int>();
            for(int i = 0; i < numbers.Length; i++)
                map.Add(numbers[i], i);

            for (int i = 0; i < numbers.Length; i++)
            {
                if (map.ContainsKey(target - numbers[i]) &&
                    map[target - numbers[i]] != i)
                {
                    return new Tuple<int, int>(i, map[target - numbers[i]]);
                }
            }

            return null;
        }

        [TestMethod]
        public void P0001_TwoSum1()
        {
            int[] test = { 2, 7, 11, 15 };
            Tuple<int, int> result = TwoSum(test, 9);
            Assert.AreEqual(0, result.Item1);
            Assert.AreEqual(1, result.Item2);
        }

        [TestMethod]
        public void P0001_TwoSum2()
        {
            int[] test = { 3, 2, 4 };
            Tuple<int, int> result = TwoSum(test, 6);
            Assert.AreEqual(1, result.Item1);
            Assert.AreEqual(2, result.Item2);
        }

        [TestMethod]
        public void P0001_TwoSum3()
        {
            int[] test = { 3, 2, 4 };
            Tuple<int, int> result = TwoSum(test, 8);
            Assert.IsNull(result);
        }
    }
}