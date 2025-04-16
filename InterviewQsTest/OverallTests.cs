using JourneyOfLeetCodeTop150InterviewQs;

namespace InterviewQsTest;

[TestClass]
public sealed class OverallTests
{
    [TestMethod]
    public void MergeSortedArraySlnTest()
    {
        var sln = new MergeSortedArraySln();
        sln.Merge([0], 0, [1], 1);
    }
}
