namespace NextPermutation.Test;

using NextPermutation;
using Xunit;

public class TestCases
{
    PermutationClass _permutationClass_obj;
    public TestCases()
    {
        _permutationClass_obj = new PermutationClass();
    }

    //Checking consecutive permutation
    [Theory]
    [MemberData(nameof(Data))]
    public void GetNextPermutation_AnsShouldHaveSameElements(int[] nums1, int[] nums2)
    {
                _permutationClass_obj.GetNextPermutation(nums1);
                Assert.True(Enumerable.SequenceEqual(nums1, nums2), 
                $"The answer for {string.Join(",", nums1)} should be {string.Join(",", nums2)}");
    }
    
    public static IEnumerable<object[]> Data(){
        var dataSet = TestData.GetStaticSet;
        List<object[]> set = new List<object[]>();

        foreach (var data in dataSet) {
            
             int i = new Random().Next(0, data.Count - 2);
            
            set.Add(
                new object[]{
                    data[i],
                    data[i+1]
                });

            //Edge Case
            set.Add(
               new object[]{
                    data[data.Count - 1],
                    data[0]
                });
        }

        return set;
    }





}