namespace NextPermutation.Test;

using System.Reflection;
using NextPermutation;
using Xunit;

public class TestCases
{
    PermutationClass _permutationClass_obj;
    public TestCases()
    {
        _permutationClass_obj = new PermutationClass();
    }

    //Checking response consistency
    //[Theory]
    //[MemberData(nameof(GetRandoArray),parameters:100,MemberType=typeof(int[]))]
    //public void GetNextPermutation_AnsShouldHaveSameElements(int[] nums)
    //{
        // int[] numsCopy = new int[nums.Length];
        // Array.Copy(nums, numsCopy,nums.Length);
        // _permutationClass_obj.GetNextPermutation(nums);
        // Array.Sort(numsCopy);
        // Array.Sort(nums);
        // Assert.True(Enumerable.SequenceEqual(numsCopy, nums), "The answer should have the same elements");

    //}


}