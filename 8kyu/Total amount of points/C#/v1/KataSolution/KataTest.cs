namespace KataSolution;

public class KataTest
{
    [Fact]
    public void Test1() =>
        Test(new[] { "1:0", "2:0", "3:0", "4:0", "2:1", "3:1", "4:1", "3:2", "4:2", "4:3" }, 30);
        
    [Fact]
    public void Test2() =>
        Test(new[] { "1:1", "2:2", "3:3", "4:4", "2:2", "3:3", "4:4", "3:3", "4:4", "4:4" }, 10);
        
    [Fact]
    public void Test3() =>
        Test(new[] { "0:1", "0:2", "0:3", "0:4", "1:2", "1:3", "1:4", "2:3", "2:4", "3:4" }, 0);
        
    [Fact]
    public void Test4() =>
        Test(new[] { "1:0", "2:0", "3:0", "4:0", "2:1", "1:3", "1:4", "2:3", "2:4", "3:4" }, 15);
        
    [Fact]
    public void Test5() =>
        Test(new[] { "1:0", "2:0", "3:0", "4:4", "2:2", "3:3", "1:4", "2:3", "2:4", "3:4" }, 12);

    private void Test(string[] input, int expectedOutput) =>
        Assert.Equal(expectedOutput, Kata.TotalPoints(input));
}
