using Algoritmos.Sorting;

namespace Algoritmos.Test.Sorting;

public class HeapSortTest
{
    [Fact]
    public void Sort()
    {
        int[] array = { 12, 11, 13, 5, 6, 7 };

        int[] result = HeapSort.Sort(array);
        
        Assert.Equal(5, result[0]);
        Assert.Equal(6, result[1]);
        Assert.Equal(7, result[2]);
        Assert.Equal(11, result[3]);
        Assert.Equal(12, result[4]);
        Assert.Equal(13, result[5]);
    }
}