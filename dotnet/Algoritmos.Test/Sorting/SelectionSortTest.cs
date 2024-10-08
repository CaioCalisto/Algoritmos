using Algoritmos.Sorting;

namespace Algoritmos.Test.Sorting;

public class SelectionSortTest
{
    [Fact]
    public void Sort()
    {
        int[] array = { 64, 25, 12, 22, 11 };
        int[] result = SelectionSort.Sort(array);
        
        Assert.Equal(11, result[0]);
        Assert.Equal(12, result[1]);
        Assert.Equal(22, result[2]);
        Assert.Equal(25, result[3]);
        Assert.Equal(64, result[4]);
    }
}