using Algoritmos.Searching;

namespace Algoritmos.Test.Searching;

public class BinarySearchTest
{
    [Theory]
    [InlineData(new int[] { 2, 4, 7, 10, 15, 18, 22, 27 }, 2, 0)]
    [InlineData(new int[] { 2, 4, 7, 10, 15, 18, 22, 27 }, 4, 1)]
    [InlineData(new int[] { 2, 4, 7, 10, 15, 18, 22, 27 }, 7, 2)]
    [InlineData(new int[] { 2, 4, 7, 10, 15, 18, 22, 27 }, 10, 3)]
    [InlineData(new int[] { 2, 4, 7, 10, 15, 18, 22, 27 }, 15, 4)]
    [InlineData(new int[] { 2, 4, 7, 10, 15, 18, 22, 27 }, 22, 6)]    
    [InlineData(new int[] { 2, 4, 7, 10, 15, 18, 22, 27 }, 27, 7)]

    public void Find_value(int[] inputs, int target, int expectedIndex)
    {
        int indexResult = BinarySearch.Find(inputs, target);
        
        Assert.Equal(expectedIndex, indexResult);
    }
}