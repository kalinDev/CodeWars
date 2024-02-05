namespace KataSolution
{
    public class SolutionTest
    {
        [Fact]
        public void SampleTest()
        {
            Assert.Equal(18, Kata.СenturyFromYear(1705));
            Assert.Equal(19, Kata.СenturyFromYear(1900));
            Assert.Equal(17, Kata.СenturyFromYear(1601));
            Assert.Equal(20, Kata.СenturyFromYear(2000));
        }
    }
}