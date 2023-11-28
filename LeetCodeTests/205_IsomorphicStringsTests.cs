using LeetCode;

namespace LeetCodeTests

{
    public class IsomorphicStringsTests
    {
        [Theory]
        [InlineData("egg", "add", true)]
        [InlineData("foo", "bar", false)]
        [InlineData("paper", "title", true)]
        [InlineData("ab", "aa", false)]
        [InlineData("ab", "ca", true)]
        [InlineData("ab", "ac", true)]
        [InlineData("ab", "aa", false)]
        public void Test1(string s, string t, bool res)
        {
            Solution test = new Solution();
            Assert.Equal(res, test.IsIsomorphic(s, t));
        }
    }
}