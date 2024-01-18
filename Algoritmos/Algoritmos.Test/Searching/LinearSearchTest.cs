using Algoritmos.Searching;

namespace Algoritmos.Test.Searching;

public class LinearSearchTest
{
    [Theory]
    [InlineData(new int[]{ 4, 2, 7, 1, 9, 5, 8, 3 }, 4, 0)]
    [InlineData(new int[]{ 4, 2, 7, 1, 9, 5, 8, 3 }, 7, 2)]
    [InlineData(new int[]{ 4, 2, 7, 1, 9, 5, 8, 3 }, 1, 3)]
    [InlineData(new int[]{ 4, 2, 7, 1, 9, 5, 8, 3 }, 5, 5)]
    [InlineData(new int[]{ 4, 2, 7, 1, 9, 5, 8, 3 }, 3, 7)]
    public void Find_value(int[] inputs, int target, int expectedIndex)
    {
        int indexResult = LinearSearch.Find(inputs, target);
        
        Assert.Equal(expectedIndex, indexResult);
    }
}