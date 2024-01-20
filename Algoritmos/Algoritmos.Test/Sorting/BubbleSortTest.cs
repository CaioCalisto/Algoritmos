using Algoritmos.Sorting;

namespace Algoritmos.Test.Sorting;

public class BubbleSortTest
{
    [Fact]
    public void Sort()
    {
        int[] array = { 64, 34, 25, 12, 22, 11, 90 };
        int[] result = BubbleSort.Sort(array);
        
        Assert.Equal(11, result[0]);
        Assert.Equal(12, result[1]);
        Assert.Equal(22, result[2]);
        Assert.Equal(25, result[3]);
        Assert.Equal(34, result[4]);
        Assert.Equal(64, result[5]);
        Assert.Equal(90, result[6]);
    }
}