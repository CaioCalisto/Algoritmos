using Algoritmos.Sorting;

namespace Algoritmos.Test.Sorting;

public class InsertionSortTest
{
    [Fact]
    public void Sort()
    {
        int[] inputs = { 12, 11, 13, 5, 6 };

        var result = InsertionSort.Sort(inputs);
        
        Assert.Equal(5, result[0]);
        Assert.Equal(6, result[1]);
        Assert.Equal(11, result[2]);
        Assert.Equal(12, result[3]);
        Assert.Equal(13, result[4]);
    }
}