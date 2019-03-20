using Xunit;

namespace XunitRepro
{
    public static class Tests
    {
        [Fact(Skip = "Skipped")]
        public static void Fact_skipped() => Assert.True(false);

        [Theory]
        [InlineData(true)]
        [InlineData(false, Skip = "Skipped")]
        public static void Theory_skipped(bool expected) => Assert.True(expected);

        [SkippedFact]
        public static void Custom_fact_skipped() => Assert.True(false);

        [SkippedTheory]
        [InlineData(false)]
        public static void Custom_theory_skipped(bool expected) => Assert.True(expected);
    }
}
